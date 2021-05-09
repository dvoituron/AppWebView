using Microsoft.Web.WebView2.WinForms;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace AppWebView
{
    public partial class MainForm : Form
    {
        private Configuration _configuration = new Configuration();
        private WebView2 _webViewContent = new WebView2();

        public MainForm()
        {
            InitializeComponent();
            ConfigureWebView2();

            // Add WebView2 into this Window
            _webViewContent.Location = new Point(36, 0);
            _webViewContent.Margin = new Padding(0);
            _webViewContent.Size = new Size(this.ClientSize.Width - 36, this.ClientSize.Height);
            _webViewContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.Controls.Add(_webViewContent);

            this.Load += MainForm_Load;
            this.FormClosed += MainForm_FormClosed;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            _configuration.Load();

            if (File.Exists(_configuration.IconFilename))
            {
                using (var stream = File.OpenRead(_configuration.IconFilename))
                {
                    this.Icon = new Icon(stream);
                }
            }

            ControlBoxMenu.InsertMenu(this.Handle, 1001, "Configuration...");

            _webViewContent.Source = new Uri(_configuration.LaunchUrl, UriKind.Absolute);
            this.Location = _configuration.Location;
            this.Size = _configuration.Size;

            if (File.Exists(_configuration.IconFilename))
            {
                this.Icon = new Icon(_configuration.IconFilename);
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            _configuration.Location = this.Location;
            _configuration.Size = this.Size;
            _configuration.Save();
        }

        protected override void WndProc(ref Message msg)
        {
            if (msg.Msg == ControlBoxMenu.WM_SYSCOMMAND)
            {
                switch (msg.WParam.ToInt32())
                {
                    case 1001:
                        var configForm = new ConfigurationForm(_configuration);
                        configForm.Owner = this;
                        configForm.ShowDialog();
                        return;
                    default:
                        break;
                }
            }
            base.WndProc(ref msg);
        }

        private void ConfigureWebView2()
        {
            string userData = Configuration.BrowserUserData.FullName;
            _webViewContent.CreationProperties = new CoreWebView2CreationProperties();
            _webViewContent.CreationProperties.UserDataFolder = userData;
            _webViewContent.EnsureCoreWebView2Async();
        }
    }
}
