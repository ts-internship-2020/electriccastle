using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ConferencePlanner.WinUi
{
    public partial class NewCityForm : Form
    {
        public NewCityForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void butonCircular1_Click(object sender, EventArgs e)
        {
            System.Text.RegularExpressions.Regex name = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z]+$");

            if (CityNameTb.TextLength == 0) errorProviderCityName.SetError(CityNameTb, "You have to introduce the name");
            if (CityCodTb.TextLength == 0) errorProviderCityCod.SetError(CityCodTb, "You have to introduce the code");

            if (!name.IsMatch(CityNameTb.Text))
            {
                errorProviderCityName.SetError(CityNameTb, "The name should contain only letters");
            }

            if(!name.IsMatch(CityCodTb.Text))
            {
                errorProviderCityCod.SetError(CityCodTb, "The code should contain only letters");
            }

            if (CityNameTb.TextLength <= 3) errorProviderCityName.SetError(CityNameTb, "Such city does not exist");
            if (CityCodTb.TextLength == 1) errorProviderCityCod.SetError(CityCodTb, "This code is not explicit");
        }
    }
}
