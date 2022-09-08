using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace About_the_creator
{
    public partial class Form1 : Form
    { 

        public Form1()
        {
            InitializeComponent();
        }

        private void LunarWebsiteBTN_Click(object sender, EventArgs e)
        {
            Process.Start("http://lunarclient.com");
        }

        private void SalwyrrWebsite_Click(object sender, EventArgs e)
        {
            Process.Start("http://salwyrr.com");
        }
    }
}
