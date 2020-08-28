using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ConferencePlanner.WinUi
{
    public partial class NewDistrictForm : Form
    {
        public NewDistrictForm()
        {
            InitializeComponent();
        }

        private void butonCircular1_Click(object sender, EventArgs e)
        {
            System.Text.RegularExpressions.Regex name = new System.Text.RegularExpressions.Regex(@"^[a-zA-Z]+$");

            if (!name.IsMatch(DistrictNameTb.Text))
            {
                errorProviderDistrictName.SetError(DistrictNameTb, "The name should contain only letters");
            }

            if (!name.IsMatch(DistrictCodTb.Text))
            {
                errorProviderDistrictCod.SetError(DistrictCodTb, "The code should contain only letters");
            }

            if (DistrictNameTb.TextLength == 0) errorProviderDistrictName.SetError(DistrictNameTb, "You have to introduce the name");
            if (DistrictCodTb.TextLength == 0) errorProviderDistrictCod.SetError(DistrictCodTb, "You have to introduce the code");

            if (DistrictNameTb.TextLength <= 3) errorProviderDistrictName.SetError(DistrictNameTb, "Such country does not exist");
            if (DistrictCodTb.TextLength == 1) errorProviderDistrictCod.SetError(DistrictCodTb, "This code is not explicit");
        }
    }
}
