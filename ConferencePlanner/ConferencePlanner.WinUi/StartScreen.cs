﻿using ConferencePlanner.Abstraction.ElectricCastleRepository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using System.Threading;
using static ConferencePlanner.WinUi.Program;


namespace ConferencePlanner.WinUi
{
    public partial class StartScreen : Form
    {
       
        public StartScreen()
        {
            //Timer Clock = new Timer();
            //Clock.Interval = 3000;
            //StartLogo();
            //Clock.Start();
            //Clock.Tick += new EventHandler(Timer_Tick);

            //StartScreen.CenterToScreen();
            Thread t = new Thread(new ThreadStart(StartLogo));
             t.Start();
            t.Join();
            
            //t.Abort();
            InitializeComponent();
           
           // InitializeComponent();
            this.ActiveControl = txtButton;
            txtButton.Focus();
            //StartScreen.CenterToScreen();


        }

        public void StartLogo()
        {
            Logo l = new Logo();
            l.Show();
            Thread.Sleep(3000);
            l.Hide();
            
        }



        private void submitButton_Click(object sender, EventArgs e)
        {
            EmailParticipants = txtButton.Text.ToString();
          

            MainScreen ms = Program.ServiceProvider.GetService<MainScreen>();

            ms.ShowDialog();

            Visible = false;
            
        }

        private void txtButton_Validating(object sender, CancelEventArgs e)
        {
            System.Text.RegularExpressions.Regex rEmail = new System.Text.RegularExpressions.Regex(@"^[\w!#$%&'*+\-/=?\^_`{|}~]+(\.[\w!#$%&'*+\-/=?\^_`{|}~]+)*"
                                                                                                    + "@"
                                                                                                    + @"((([\-\w]+\.)+[a-zA-Z]{2,4})|(([0-9]{1,3}\.){3}[0-9]{1,3}))$");
            if (txtButton.Text.Length > 0)
            {
                if (!rEmail.IsMatch(txtButton.Text))
                {
                    errorProviderEmailText.SetError(txtButton, "Invalid email address");
                    txtButton.SelectAll();
                    e.Cancel = true;
                }
            }
            else
            {

                errorProviderEmailText.SetError(txtButton, "Insert an email");
                txtButton.SelectAll();
                e.Cancel = true;

            }
        }

        private void txtButton_KeyDown(object sender, KeyEventArgs e)
        {
            if ( e.KeyCode == Keys.Enter)
            {
                submitButton.PerformClick();
            }
        }

        private void txtButton_TextChanged(object sender, EventArgs e)
        {

        }

        private void StartScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }
    }
}
