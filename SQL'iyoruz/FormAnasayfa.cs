using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace SQL_iyoruz
{
    public partial class FormAnasayfa : Form
    {
        public FormAnasayfa()
        {
            InitializeComponent();

        }

        private void FormAnasayfa_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;

        }

        private void GitHubBox_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/burakarslan0110");
        }

        private void LinkedInBox_Click(object sender, EventArgs e)
        {
            Process.Start("www.linkedin.com/in/burakarslann0110");

        }
    }
}
