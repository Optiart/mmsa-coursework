using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace DjikstaAndFloydWarshall
{
    public partial class frmAddCity : Form
    {
        private readonly List<City> _cities;
        private readonly ErrorLabelWrapper _errorLabel;

        public frmAddCity(List<City> cities)
        {
            InitializeComponent();
            _errorLabel = new ErrorLabelWrapper(lblError);
            _cities = cities;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCityName.Text))
            {
                _errorLabel.Write("Заповніть, будь ласка, поле");
                return;
            }

            if (_cities.Any(c => c.Name == txtCityName.Text))
            {
                _errorLabel.Write("Таке місто вже існує");
                return;
            }

            _cities.Add(new City(_cities.Count, txtCityName.Text));
            this.Close();
        }
    }
}
