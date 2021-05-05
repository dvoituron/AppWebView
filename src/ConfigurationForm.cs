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
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            _configuration.LaunchUrl = txtLaunchUrl.Text;
            _configuration.IconFilename = txtIcon.Text;

            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
