using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ConferencePlanner.WinUi
{
    public partial class AddSpeakerForm : Form
    {
        public AddSpeakerForm()
        {
            InitializeComponent();
        }

        private void newSpeakerName_Click(object sender, EventArgs e)
        {

        }

        private void NewSpeaker_Load(object sender, EventArgs e)
        {
            newSpeakerPictureBox.LoadAsync("https://images.unsplash.com/photo-1544502062-f82887f03d1c?ixlib=rb-1.2.1&ixid=eyJhcHBfaWQiOjEyMDd9&auto=format&fit=crop&w=827&q=80");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
