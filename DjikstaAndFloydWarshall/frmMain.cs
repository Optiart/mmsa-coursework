using Microsoft.Msagl.Drawing;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DjikstaAndFloydWarshall
{
    public partial class frmMain : Form
    {
        private List<City> _cities = new List<City>();

        public frmMain()
        {
            InitializeComponent();
            lstCity.Items.Clear();
            lstCityConnections.Items.Clear();
            lstAllConnections.Items.Clear();
            lblCityCount.Text = string.Empty;
            lblConnectionCount.Text = string.Empty;
            lblAllConnectionsCount.Text = string.Empty;
            lblGraphError.Text = string.Empty;
            lblDijkstraResult.Text = string.Empty;
            lblFloydWarshal.Text = string.Empty;
            pnlConnections.Enabled = false;
            lblDijkstraShortestDistance.Text = string.Empty;
            lblFloydWarshalShortestDistance.Text = string.Empty;
        }

        private void btnAddCity_Click(object sender, EventArgs e)
        {
            var frmAddCity = new frmAddCity(_cities);
            frmAddCity.ShowDialog();
            RefreshCities();
        }

        private void btnAddConnection_Click(object sender, EventArgs e)
        {
            var selectedCity = GetSelectedCity();

            if (selectedCity == null)
            {
                return;
            }

            var frmAddConnection = new frmAddConnection(_cities, selectedCity);
            frmAddConnection.ShowDialog();

            RefreshAllConnections();
            RefreshConnections(selectedCity.Connections);
        }

        private void RefreshAllConnections()
        {
            lstAllConnections.Items.Clear();
            lblAllConnectionsCount.Text = string.Empty;
            foreach (var city in _cities)
            {
                foreach (var connection in city.Connections)
                {
                    lstAllConnections.Items.Add($"{city.Name} - {connection.City.Name} ({connection.DistanceKm} км)");
                }
            }
            lblAllConnectionsCount.Text = $"{lstAllConnections.Items.Count}";
        }

        private void lstCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstCityConnections.Items.Clear();
            if (lstCity.SelectedItem != null)
            {
                var selectedCity = GetSelectedCity();
                pnlConnections.Enabled = true;
                lstCityConnections.Items.AddRange(selectedCity.Connections.ToArray());
                btnRemoveCity.Enabled = true;
            }
            else
            {
                pnlConnections.Enabled = false;
            }
        }

        private City GetSelectedCity()
        {
            var currentCity = lstCity.SelectedItem as City;
            return currentCity ?? _cities.SingleOrDefault(c => c.Name == currentCity.Name);
        }

        private void lstCityConnections_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstCityConnections.SelectedItem != null)
            {
                btnRemoveConnection.Enabled = true;
            }
        }

        private void btnRemoveCity_Click(object sender, EventArgs e)
        {
            Action<string> action = selectedItem =>
            {
                _cities.RemoveAll(c => c.Name == selectedItem);
                RefreshList(lstCity, _cities.ToArray());
            };

            RemoveFromList(lstCity, btnRemoveCity, action);
        }

        private void btnRemoveConnection_Click(object sender, EventArgs e)
        {
            Action<Connection> action = selectedItem =>
            {
                var selectedCity = GetSelectedCity();

                if (selectedCity == null)
                {
                    return;
                }

                selectedCity.Connections.RemoveAll(c => c.City.Id == selectedItem.City.Id);
                RefreshConnections(selectedCity.Connections);
            };

            RemoveFromList(lstCityConnections, btnRemoveConnection, action);
        }

        private void RemoveFromList<T>(ListBox listBox, Button deleteButton, Action<T> action)
        {
            var selectedItem = (T)Convert.ChangeType(listBox.SelectedItem, typeof(T));
            if (selectedItem == null)
            {
                deleteButton.Enabled = false;
                return;
            }

            var dialogResult = MessageBox.Show($"Видалити {selectedItem}?", "Підтвердження", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                action(selectedItem);
                deleteButton.Enabled = false;
                RefreshAllConnections();
            }
        }

        private void RefreshList(ListBox listBox, IEnumerable<object> values)
        {
            listBox.Items.Clear();
            listBox.Items.AddRange(values.ToArray());
            RefreshGraphView();
        }

        private void RefreshGraphView()
        {
            if (_cities.Count > 100 || _cities.SelectMany(c => c.Connections).Count() > 1000)
            {
                lblGraphError.Text = "Граф не буде відображений - занадто багато зв'язків";
                gViewer.Graph = null;
                gViewer.Refresh();
                return;
            }
            else
            {
                lblGraphError.Text = string.Empty;
            }

            var graph = new Graph("Shortest path");

            foreach (var city in _cities)
            {
                graph.AddNode(new Node(city.Name));
            }

            foreach (var city in _cities)
            {
                foreach (var connection in city.Connections)
                {
                    graph.AddEdge(city.Name, $"{connection.DistanceKm}", connection.City.Name);
                }
            }

            gViewer.Graph = graph;
        }

        private async void btnCalculate_Click(object sender, EventArgs e)
        {
            var cityFrom = cmbCityFrom.SelectedItem as City;
            if (cityFrom == null)
            {
                MessageBox.Show("Оберіть місто, звідки починати пошук", "Увага", MessageBoxButtons.OK);
                return;
            }

            var cityTo = cmbCityTo.SelectedItem as City;
            if (cityTo == null)
            {
                MessageBox.Show("Оберіть місто призначення", "Увага", MessageBoxButtons.OK);
                return;
            }

            var graph = new int[_cities.Count, _cities.Count];
            var indexToIdMapping = new Dictionary<int, int>();

            for (int i = 0; i < _cities.Count; i++)
            {
                indexToIdMapping.Add(i, _cities[i].Id);
            }

            for (int i = 0; i < _cities.Count; i++)
            {
                if (_cities[i].Connections == null)
                {
                    MessageBox.Show($"Місто {_cities[i].Name} не має зв'язків", "Помилка", MessageBoxButtons.OK);
                    return;
                }

                var connections = _cities[i].Connections;

                for (int j = 0; j < _cities.Count; j++)
                {
                    var connectionCity = connections.SingleOrDefault(c => c.City.Id == indexToIdMapping[j]);
                    graph[i, j] = connectionCity == null ? -1 : connectionCity.DistanceKm;
                }
            }

            btnCalculate.Enabled = false;
            this.Cursor = Cursors.WaitCursor;

            var results = await Task.Run(() =>
            {
                var dijkstra = new DijkstraRouteFinder();
                var floydWarshal = new FloydWarshallRouteFinder();

                var dijkstraResult = RunAndMeasure(() =>
                    dijkstra.Find(graph, indexToIdMapping[cityFrom.Id], indexToIdMapping[cityTo.Id]));

                var floydWarshalResult = RunAndMeasure(() =>
                    floydWarshal.Find(graph, indexToIdMapping[cityFrom.Id], indexToIdMapping[cityTo.Id]));

                return (dijkstraResult, floydWarshalResult);
            });

            lblDijkstraResult.Text = $"{results.dijkstraResult.elapsedMs} мс";
            lblFloydWarshal.Text = $"{results.floydWarshalResult.elapsedMs} мс";

            ReconstructRoute(results.dijkstraResult.result, indexToIdMapping, txtDijkstraShortestPath, lblDijkstraShortestDistance, shouldHighlightPath: true);
            ReconstructRoute(results.floydWarshalResult.result, indexToIdMapping, txtFloydWarshalShortestPath, lblFloydWarshalShortestDistance, shouldHighlightPath: false);

            btnCalculate.Enabled = true;
            this.Cursor = Cursors.Hand;
        }

        private (Result result, long elapsedMs) RunAndMeasure(Func<Result> algorithm)
        {
            var stopWatch = new Stopwatch();
            stopWatch.Start();
            var result = algorithm();
            stopWatch.Stop();
            return (result, stopWatch.ElapsedMilliseconds);
        }

        private void ReconstructRoute(Result result, Dictionary<int, int> indexToIdMapping, TextBox txtShortestPath, System.Windows.Forms.Label lblResultTime, bool shouldHighlightPath)
        {
            var routeCityIds = result.Route.Select(r => indexToIdMapping[r]).ToArray();
            var cityNames = new string[routeCityIds.Length];
            for (int i = 0; i < routeCityIds.Length; i++)
            {
                cityNames[i] = _cities.Single(c => c.Id == routeCityIds[i]).Name;
            }

            txtShortestPath.Text = string.Join("->", cityNames);
            if (gViewer.Graph != null && shouldHighlightPath)
            {
                HighlightShortestPath(cityNames);
            }

            lblResultTime.Text = $"({result.Distance} км)";
        }

        private void HighlightShortestPath(string[] cityNames)
        {
            foreach (var edge in gViewer.Graph.Edges)
            {
                if (cityNames.Contains(edge.SourceNode.Id) && cityNames.Contains(edge.TargetNode.Id))
                {
                    edge.Attr.Color = Color.Green;
                    edge.Attr.LineWidth = 3;
                }
                else
                {
                    edge.Attr.LineWidth = 1;
                    edge.Attr.Color = Color.Black;
                }

                gViewer.Refresh();
            }
        }

        private void cmbCityFrom_Click(object sender, EventArgs e)
        {
            cmbCityFrom.Items.Clear();
            cmbCityFrom.Items.AddRange(_cities.ToArray());
        }

        private void cmbCityTo_Click(object sender, EventArgs e)
        {
            cmbCityTo.Items.Clear();
            cmbCityTo.Items.AddRange(_cities.ToArray());
        }

        private void btnGenerateCities_Click(object sender, EventArgs e)
        {
            if (_cities.Any() &&
                MessageBox.Show("Введені дані будуть перезаписані. Продовжити?", "Підтвердження", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            AutoGenerate(() => AutoGenerator.GenerateCitiesForDemo());
        }


        private void btnGenerateCitiesLoad_Click(object sender, EventArgs e)
        {
            if (_cities.Any() &&
                MessageBox.Show("Введені дані будуть перезаписані. Продовжити?", "Підтвердження", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            AutoGenerate(() => AutoGenerator.GenerateCitiesAndConnectionsForLoad(cityCount: 800, maxConnections: 10, maxDistance: 300));
        }


        private void AutoGenerate(Func<List<City>> generateCities)
        {
            cmbCityFrom.Items.Clear();
            cmbCityTo.Items.Clear();

            _cities = generateCities();

            RefreshCities();
            RefreshAllConnections();
        }

        private void RefreshCities()
        {
            RefreshList(lstCity, _cities.ToArray());
            lblCityCount.Text = $"{lstCity.Items.Count}";
        }

        private void RefreshConnections(List<Connection> connections)
        {
            RefreshList(lstCityConnections, connections.ToArray());
            lblConnectionCount.Text = $"{lstCityConnections.Items.Count}";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (!_cities.Any())
            {
                return;
            }

            if (MessageBox.Show("Стерти всі дані?", "Підтвердження", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                return;
            }

            _cities = new List<City>();
            RefreshCities();
            RefreshAllConnections();
            RefreshGraphView();
            cmbCityFrom.Items.Clear();
            cmbCityTo.Items.Clear();

            txtDijkstraShortestPath.Text = string.Empty;
            txtFloydWarshalShortestPath.Text = string.Empty;
            lblDijkstraResult.Text = string.Empty;
            lblFloydWarshal.Text = string.Empty;
        }
    }
}
