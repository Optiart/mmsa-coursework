using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
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
            pnlConnections.Enabled = false;
        }

        private void btnAddCity_Click(object sender, EventArgs e)
        {
            var frmAddCity = new frmAddCity(_cities);
            frmAddCity.ShowDialog();
            RefreshList(lstCity, _cities.Select(c => c.Name).ToArray());
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
            RefreshList(lstCityConnections, selectedCity.Connections.ToArray());
        }

        private void RefreshAllConnections()
        {
            lstAllConnections.Items.Clear();
            foreach (var city in _cities)
            {
                foreach (var connection in city.Connections)
                {
                    lstAllConnections.Items.Add($"{city.Name} - {connection.CityName} ({connection.DistanceKm} км)");
                }
            }
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
            var currentCityName = lstCity.SelectedItem as string;

            if (currentCityName == null)
            {
                return null;
            }

            return _cities.SingleOrDefault(c => c.Name == currentCityName);
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
                RefreshList(lstCity, _cities.Select(c => c.Name).ToArray());
            };

            RemoveFromList(lstCity, btnRemoveCity, action);
        }

        private void RefreshCities() => RefreshList(lstCity, _cities.Select(c => c.Name).ToArray());

        private void btnRemoveConnection_Click(object sender, EventArgs e)
        {
            Action<Connection> action = selectedItem =>
            {
                var selectedCity = GetSelectedCity();

                if (selectedCity == null)
                {
                    return;
                }

                selectedCity.Connections.RemoveAll(c => c.CityId == selectedItem.CityId);
                RefreshList(lstCityConnections, selectedCity.Connections);
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
        }

        private void btnGenerateCities_Click(object sender, EventArgs e)
        {
            _cities = new List<City>
            {
                new City(0, "Київ"),
                new City(1, "Житомир"),
                new City(2, "Львів"),
                new City(3, "Хмельницький"),
                new City(4, "Вінниця")
            };

            _cities[0].Connections.Add(new Connection(1, "Житомир", 140));
            _cities[0].Connections.Add(new Connection(4, "Вінниця", 267));
            _cities[1].Connections.Add(new Connection(2, "Львів", 402));
            _cities[1].Connections.Add(new Connection(4, "Вінниця", 129));
            _cities[1].Connections.Add(new Connection(3, "Хмельницький", 183));
            _cities[3].Connections.Add(new Connection(2, "Львів", 240));
            _cities[4].Connections.Add(new Connection(2, "Хмельницький", 119));

            RefreshCities();
            RefreshAllConnections();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            var graph = new List<List<int>>();
        }
    }

    public class City
    {
        public int Id { get; }

        public string Name { get; }

        public List<Connection> Connections { get; } = new List<Connection>();

        public City(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }

    public class Connection
    {
        public int CityId { get; }

        public string CityName { get; }

        public int DistanceKm { get; }

        public Connection(int cityId, string cityName, int distanceKm)
        {
            CityId = cityId;
            CityName = cityName;
            DistanceKm = distanceKm;
        }

        public override string ToString() => $"{CityName} - {DistanceKm} км";
    }
}
