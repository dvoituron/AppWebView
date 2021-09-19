
namespace AppWebView
{
    partial class ConfigurationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblLaunchUrl = new System.Windows.Forms.Label();
            this.txtLaunchUrl = new System.Windows.Forms.TextBox();
            this.txtIcon = new System.Windows.Forms.TextBox();
            this.lblIcon = new System.Windows.Forms.Label();
            this.txtEdgeFolder = new System.Windows.Forms.TextBox();
            this.lblEdgeFolder = new System.Windows.Forms.Label();
            this.lnkEdgeFolder = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Location = new System.Drawing.Point(303, 132);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(82, 22);
            this.btnOK.TabIndex = 0;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(390, 132);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(82, 22);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblLaunchUrl
            // 
            this.lblLaunchUrl.AutoSize = true;
            this.lblLaunchUrl.Location = new System.Drawing.Point(10, 14);
            this.lblLaunchUrl.Name = "lblLaunchUrl";
            this.lblLaunchUrl.Size = new System.Drawing.Size(67, 15);
            this.lblLaunchUrl.TabIndex = 2;
            this.lblLaunchUrl.Text = "Launch Url:";
            // 
            // txtLaunchUrl
            // 
            this.txtLaunchUrl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLaunchUrl.Location = new System.Drawing.Point(102, 9);
            this.txtLaunchUrl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLaunchUrl.Name = "txtLaunchUrl";
            this.txtLaunchUrl.PlaceholderText = "(Required) https://teams.microsoft.com";
            this.txtLaunchUrl.Size = new System.Drawing.Size(371, 23);
            this.txtLaunchUrl.TabIndex = 3;
            // 
            // txtIcon
            // 
            this.txtIcon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIcon.Location = new System.Drawing.Point(102, 41);
            this.txtIcon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIcon.Name = "txtIcon";
            this.txtIcon.PlaceholderText = "(Optional) C:\\MyApp\\Teams.ico";
            this.txtIcon.Size = new System.Drawing.Size(371, 23);
            this.txtIcon.TabIndex = 5;
            // 
            // lblIcon
            // 
            this.lblIcon.AutoSize = true;
            this.lblIcon.Location = new System.Drawing.Point(10, 46);
            this.lblIcon.Name = "lblIcon";
            this.lblIcon.Size = new System.Drawing.Size(82, 15);
            this.lblIcon.TabIndex = 4;
            this.lblIcon.Text = "Icon filename:";
            // 
            // txtEdgeFolder
            // 
            this.txtEdgeFolder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEdgeFolder.Location = new System.Drawing.Point(102, 73);
            this.txtEdgeFolder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEdgeFolder.Name = "txtEdgeFolder";
            this.txtEdgeFolder.PlaceholderText = "(Optional) C:\\MyApp\\Edge93";
            this.txtEdgeFolder.Size = new System.Drawing.Size(371, 23);
            this.txtEdgeFolder.TabIndex = 6;
            // 
            // lblEdgeFolder
            // 
            this.lblEdgeFolder.AutoSize = true;
            this.lblEdgeFolder.Location = new System.Drawing.Point(10, 78);
            this.lblEdgeFolder.Name = "lblEdgeFolder";
            this.lblEdgeFolder.Size = new System.Drawing.Size(75, 15);
            this.lblEdgeFolder.TabIndex = 7;
            this.lblEdgeFolder.Text = "Edge Folder :";
            // 
            // lnkEdgeFolder
            // 
            this.lnkEdgeFolder.AutoSize = true;
            this.lnkEdgeFolder.Location = new System.Drawing.Point(102, 102);
            this.lnkEdgeFolder.Name = "lnkEdgeFolder";
            this.lnkEdgeFolder.Size = new System.Drawing.Size(188, 15);
            this.lnkEdgeFolder.TabIndex = 8;
            this.lnkEdgeFolder.TabStop = true;
            this.lnkEdgeFolder.Text = "Download a Fixed Version of Edge.";
            this.lnkEdgeFolder.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkEdgeFolder_LinkClicked);
            // 
            // ConfigurationForm
            // 
            this.AcceptButton = this.btnOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(483, 162);
            this.Controls.Add(this.lnkEdgeFolder);
            this.Controls.Add(this.lblEdgeFolder);
            this.Controls.Add(this.txtEdgeFolder);
            this.Controls.Add(this.txtIcon);
            this.Controls.Add(this.lblIcon);
            this.Controls.Add(this.txtLaunchUrl);
            this.Controls.Add(this.lblLaunchUrl);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfigurationForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Configuration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblLaunchUrl;
        private System.Windows.Forms.TextBox txtLaunchUrl;
        private System.Windows.Forms.TextBox txtIcon;
        private System.Windows.Forms.Label lblIcon;
        private System.Windows.Forms.TextBox txtEdgeFolder;
        private System.Windows.Forms.Label lblEdgeFolder;
        private System.Windows.Forms.LinkLabel lnkEdgeFolder;
    }
}