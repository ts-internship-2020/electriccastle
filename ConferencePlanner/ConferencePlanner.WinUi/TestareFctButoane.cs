using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ConferencePlanner.Abstraction.ElectricCastleRepository;

using ConferencePlanner.Repository.Ado.ElectricCastleRepository;
using System.Linq;

namespace ConferencePlanner.WinUi
{
    public partial class TestareFctButoane : Form
    {
        private readonly IDictionaryParticipantState _getdictionaryParticipantState;

        public TestareFctButoane(IDictionaryParticipantState getdictionaryParticipantState)
        {
            _getdictionaryParticipantState = getdictionaryParticipantState;

            InitializeComponent();
        }

        private void TestareFctButoane_Load(object sender, EventArgs e)
        {

        }

        private void join_Click(object sender, EventArgs e)
        {
           
            var x = _getdictionaryParticipantState.GetDictionaryParticipantStates("Joined");
            withdraw.Hide();
            label1.Text = x.FirstOrDefault().State;
            join.Hide();
            withdraw.Show();
            Form f= new WebViewConnection();
            f.Show();
            

        }

        private void attend_Click(object sender, EventArgs e)
        {
            
            var y = _getdictionaryParticipantState.GetDictionaryParticipantStates("Attended");
            join.Hide();
            label1.Text = y.ElementAt(2).State;
            withdraw.Show();
           
        }

        private void withdraw_Click(object sender, EventArgs e)
        {
            
            var z = _getdictionaryParticipantState.GetDictionaryParticipantStates("Withdrawn");

            label1.Text = z.ElementAt(1).State;
            withdraw.Hide();
            join.Show();
            
            //listBox1.DataSource = z;
            //listBox1.DisplayMember = "State";
        }
    }
}
