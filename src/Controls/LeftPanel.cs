using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppWebView.Controls
{
    public partial class LeftPanel : UserControl
    {
        public LeftPanel()
        {
            InitializeComponent();

            for (int i = 0; i < 20; i++)
            {
                var picture = CreatePicture();
                picture.Location = new Point(2, 4 + i * 34);
                this.Controls.Add(picture);
            }
        }

        private PictureBox CreatePicture()
        {
            var picture = new PictureBox();

            picture.Size = new Size(32, 32);
            picture.Image = Image.FromFile("c:\\_temp\\Outlook.png");

            return picture;
        }
    }
}
