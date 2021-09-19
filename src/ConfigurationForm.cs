using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppWebView
{
    public partial class ConfigurationForm : Form
    {
        private Configuration _configuration;

        public ConfigurationForm(Configuration configuration)
        {
            _configuration = configuration;

            InitializeComponent();

            txtLaunchUrl.Text = _configuration.LaunchUrl;
            txtIcon.Text = _configuration.IconFilename;
            txtEdgeFolder.Text = _configuration.BrowserFixedVersionFolder;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            _configuration.LaunchUrl = txtLaunchUrl.Text;
            _configuration.IconFilename = txtIcon.Text;
            _configuration.BrowserFixedVersionFolder = txtEdgeFolder.Text;

            MessageBox.Show("Please, restart the software to apply these changes.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lnkEdgeFolder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var process = new System.Diagnostics.ProcessStartInfo();
            process.UseShellExecute = true;
            process.FileName = "https://developer.microsoft.com/microsoft-edge/webview2";
            System.Diagnostics.Process.Start(process);
        }
    }
}
