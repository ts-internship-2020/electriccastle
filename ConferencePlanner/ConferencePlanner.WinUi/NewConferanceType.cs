using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ConferencePlanner.WinUi
{
    public partial class NewConferanceType : Form
    {
        public NewConferanceType()
        {
            InitializeComponent();
        }

        private void btSaveType_Click(object sender, EventArgs e)
        {
            if(txtCodeType.Text==string.Empty || txtNameType.Text==string.Empty)
            {
                txtCodeType.Focus();
                errorProviderCode.SetError(txtCodeType, "Can't be empty");
                errorProviderCode.SetError(txtNameType, "Can't be empty");

            }
            else
            {
                Testare testare = new Testare();
                testare.ShowDialog();
            }

        }
    }
}
