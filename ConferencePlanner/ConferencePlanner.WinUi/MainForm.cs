using ConferencePlanner.Abstraction.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConferencePlanner.WinUi
{
    public partial class MainForm : Form
    {
        private readonly IGetDemoRepository _getDemoRepository;

        public MainForm(IGetDemoRepository getDemoRepository)
        {
            _getDemoRepository = getDemoRepository;

            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var x = _getDemoRepository.GetDemo("hello");

            label1.Text = x.FirstOrDefault().Name;
            listBox1.DataSource = x;
            listBox1.DisplayMember = "Name";
        }
    }
}
