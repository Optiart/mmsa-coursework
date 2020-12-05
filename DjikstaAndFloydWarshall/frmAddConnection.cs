using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DjikstaAndFloydWarshall
{
    public partial class frmAddConnection : Form
    {
        private readonly List<City> _cities;
        private readonly ErrorLabelWrapper _errorLabel;
        private readonly City _currentCity;

        public frmAddConnection(List<City> cities, City currentCity)
        {
            InitializeComponent();
            _errorLabel = new ErrorLabelWrapper(lblError);

            _cities = cities;
            _currentCity = currentCity;

            var possibleCitiesToConnect = _cities.Where(c => !currentCity.Connections.Any(connection => connection.City.Name == c.Name) && c.Name != currentCity.Name);
            cmbConnectionTo.Items.AddRange(possibleCitiesToConnect.Select(c => c.Name).ToArray());

            if (cmbConnectionTo.Items.Count > 0)
            {
                cmbConnectionTo.SelectedIndex = 0;
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtDistance.Text))
            {
                _errorLabel.Write("Заповніть, будь ласка, дистанцію");
                return;
            }

            var selectedCityToConnect = cmbConnectionTo.SelectedItem.ToString();
            if (_currentCity.Connections.Any(c => c.City.Name == selectedCityToConnect))
            {
                _errorLabel.Write("Такий зв'язок вже існує");
                return;
            }

            if (!int.TryParse(txtDistance.Text, out var distanceKm))
            {
                _errorLabel.Write("Дистанція має бути цілим числом");
                return;
            }

            var cityToConnect = _cities.SingleOrDefault(c => c.Name == selectedCityToConnect);
            _currentCity.Connections.Add(new Connection(cityToConnect.Id, cityToConnect.Name, distanceKm));
            this.Close();
        }
    }
}
