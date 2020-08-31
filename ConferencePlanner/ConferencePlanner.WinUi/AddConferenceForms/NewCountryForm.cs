using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ConferencePlanner.Abstraction.ElectricCastleModel;
using ConferencePlanner.Abstraction.ElectricCastleRepository;
using ConferencePlanner.Abstraction.Helpers;
using ConferencePlanner.Repository.Ado.ElectricCastleRepository;

namespace ConferencePlanner.WinUi
{
    public partial class NewCountryForm : Form
    {

        private readonly IAddConferenceCountryRepository _getCountry;

        public NewCountryForm(IAddConferenceCountryRepository getCountry)
        {
            this._getCountry = getCountry;
            InitializeComponent();
        }

        private void colorButton1_Click(object sender, EventArgs e)
        {

        }

        private void NewCountryForm_Load(object sender, EventArgs e)
        {

        }

        private void AddCountryFromButton_Click(object sender, EventArgs e)
        {
            System.Text.RegularExpressions.Regex name = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z]+$");

            if (!name.IsMatch(CoutryNameTb.Text))
            {
                errorProviderCountryName.SetError(CoutryNameTb, "The name should contain only letters");
            }

            if (!name.IsMatch(CountryCodTb.Text))
            {
                errorProviderCountryCod.SetError(CountryCodTb, "The code should contain only letters");
            }

            if (CoutryNameTb.TextLength == 0) errorProviderCountryName.SetError(CoutryNameTb, "You have to introduce the name");
            if (CountryCodTb.TextLength == 0) errorProviderCountryCod.SetError(CountryCodTb, "You have to introduce the code");

            if (CoutryNameTb.TextLength <= 3) errorProviderCountryName.SetError(CoutryNameTb, "Such country does not exist");
            if (CountryCodTb.TextLength == 1) errorProviderCountryCod.SetError(CountryCodTb, "This code is not explicit");

            _getCountry.InsertConferenceCountry( CountryCodTb.Text, CoutryNameTb.Text);
        }
    }
}
