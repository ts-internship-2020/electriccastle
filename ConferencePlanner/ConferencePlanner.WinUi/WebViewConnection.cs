using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ConferencePlanner.WinUi
{
    public partial class WebViewConnection : Form
    {
        public WebViewConnection()
        {
            InitializeComponent();
        }

        private void WebViewConnection_Load(object sender, EventArgs e)
        {
            webView1.Navigate(new Uri("http://www.google.com"));
        }
    }
}
