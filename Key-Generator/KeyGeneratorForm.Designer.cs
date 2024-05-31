namespace AktivasyonUygulamasi
{
    partial class KeyGeneratorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KeyGeneratorForm));
            this.TopbarPanel = new System.Windows.Forms.Panel();
            this.AppNamePanel = new System.Windows.Forms.Panel();
            this.AppNameLabel = new System.Windows.Forms.Label();
            this.MinimizePanel = new System.Windows.Forms.Panel();
            this.MinimizeLabel = new System.Windows.Forms.Label();
            this.ExitPanel = new System.Windows.Forms.Panel();
            this.ExitLabel = new System.Windows.Forms.Label();
            this.AppLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.KeyLabel = new System.Windows.Forms.Label();
            this.GenerateKeyPanel = new System.Windows.Forms.Panel();
            this.GenerateKeyLabel = new System.Windows.Forms.Label();
            this.TopbarPanel.SuspendLayout();
            this.AppNamePanel.SuspendLayout();
            this.MinimizePanel.SuspendLayout();
            this.ExitPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AppLogoPictureBox)).BeginInit();
            this.GenerateKeyPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TopbarPanel
            // 
            this.TopbarPanel.BackColor = System.Drawing.Color.PowderBlue;
            this.TopbarPanel.Controls.Add(this.AppNamePanel);
            this.TopbarPanel.Controls.Add(this.MinimizePanel);
            this.TopbarPanel.Controls.Add(this.ExitPanel);
            this.TopbarPanel.Controls.Add(this.AppLogoPictureBox);
            this.TopbarPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopbarPanel.Location = new System.Drawing.Point(0, 0);
            this.TopbarPanel.Name = "TopbarPanel";
            this.TopbarPanel.Size = new System.Drawing.Size(440, 35);
            this.TopbarPanel.TabIndex = 0;
            this.TopbarPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopbarPanel_MouseDown);
            this.TopbarPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopbarPanel_MouseMove);
            this.TopbarPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopbarPanel_MouseUp);
            // 
            // AppNamePanel
            // 
            this.AppNamePanel.Controls.Add(this.AppNameLabel);
            this.AppNamePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.AppNamePanel.Location = new System.Drawing.Point(35, 0);
            this.AppNamePanel.Name = "AppNamePanel";
            this.AppNamePanel.Size = new System.Drawing.Size(120, 35);
            this.AppNamePanel.TabIndex = 3;
            // 
            // AppNameLabel
            // 
            this.AppNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AppNameLabel.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.AppNameLabel.Location = new System.Drawing.Point(0, 0);
            this.AppNameLabel.Name = "AppNameLabel";
            this.AppNameLabel.Size = new System.Drawing.Size(120, 35);
            this.AppNameLabel.TabIndex = 1;
            this.AppNameLabel.Text = "Key Generator";
            this.AppNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AppNameLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopbarPanel_MouseDown);
            this.AppNameLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopbarPanel_MouseMove);
            this.AppNameLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopbarPanel_MouseUp);
            // 
            // MinimizePanel
            // 
            this.MinimizePanel.Controls.Add(this.MinimizeLabel);
            this.MinimizePanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.MinimizePanel.Location = new System.Drawing.Point(370, 0);
            this.MinimizePanel.Name = "MinimizePanel";
            this.MinimizePanel.Size = new System.Drawing.Size(35, 35);
            this.MinimizePanel.TabIndex = 2;
            // 
            // MinimizeLabel
            // 
            this.MinimizeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MinimizeLabel.Font = new System.Drawing.Font("Calibri Light", 16.2F);
            this.MinimizeLabel.Location = new System.Drawing.Point(0, 0);
            this.MinimizeLabel.Name = "MinimizeLabel";
            this.MinimizeLabel.Size = new System.Drawing.Size(35, 35);
            this.MinimizeLabel.TabIndex = 1;
            this.MinimizeLabel.Text = "-";
            this.MinimizeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MinimizeLabel.Click += new System.EventHandler(this.MinimizeLabel_Click);
            this.MinimizeLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MinimizeLabel_MouseDown);
            this.MinimizeLabel.MouseLeave += new System.EventHandler(this.MinimizeLabel_MouseLeave);
            this.MinimizeLabel.MouseHover += new System.EventHandler(this.MinimizeLabel_MouseHover);
            // 
            // ExitPanel
            // 
            this.ExitPanel.Controls.Add(this.ExitLabel);
            this.ExitPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ExitPanel.Location = new System.Drawing.Point(405, 0);
            this.ExitPanel.Name = "ExitPanel";
            this.ExitPanel.Size = new System.Drawing.Size(35, 35);
            this.ExitPanel.TabIndex = 1;
            // 
            // ExitLabel
            // 
            this.ExitLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExitLabel.Font = new System.Drawing.Font("Calibri Light", 13.2F);
            this.ExitLabel.Location = new System.Drawing.Point(0, 0);
            this.ExitLabel.Name = "ExitLabel";
            this.ExitLabel.Size = new System.Drawing.Size(35, 35);
            this.ExitLabel.TabIndex = 0;
            this.ExitLabel.Text = "X";
            this.ExitLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ExitLabel.Click += new System.EventHandler(this.ExitLabel_Click);
            this.ExitLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ExitLabel_MouseDown);
            this.ExitLabel.MouseLeave += new System.EventHandler(this.ExitLabel_MouseLeave);
            this.ExitLabel.MouseHover += new System.EventHandler(this.ExitLabel_MouseHover);
            // 
            // AppLogoPictureBox
            // 
            this.AppLogoPictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.AppLogoPictureBox.Image = global::Key_Generator.Resource1.GearAppLogo1;
            this.AppLogoPictureBox.Location = new System.Drawing.Point(0, 0);
            this.AppLogoPictureBox.Name = "AppLogoPictureBox";
            this.AppLogoPictureBox.Size = new System.Drawing.Size(35, 35);
            this.AppLogoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AppLogoPictureBox.TabIndex = 0;
            this.AppLogoPictureBox.TabStop = false;
            this.AppLogoPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopbarPanel_MouseDown);
            this.AppLogoPictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopbarPanel_MouseMove);
            this.AppLogoPictureBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopbarPanel_MouseUp);
            // 
            // KeyLabel
            // 
            this.KeyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KeyLabel.Location = new System.Drawing.Point(0, 62);
            this.KeyLabel.Name = "KeyLabel";
            this.KeyLabel.Size = new System.Drawing.Size(440, 30);
            this.KeyLabel.TabIndex = 1;
            this.KeyLabel.Text = "Key Oluşturmak için Butona Tıklayınız!..";
            this.KeyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GenerateKeyPanel
            // 
            this.GenerateKeyPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GenerateKeyPanel.Controls.Add(this.GenerateKeyLabel);
            this.GenerateKeyPanel.Location = new System.Drawing.Point(150, 117);
            this.GenerateKeyPanel.Name = "GenerateKeyPanel";
            this.GenerateKeyPanel.Size = new System.Drawing.Size(140, 35);
            this.GenerateKeyPanel.TabIndex = 2;
            // 
            // GenerateKeyLabel
            // 
            this.GenerateKeyLabel.BackColor = System.Drawing.Color.PowderBlue;
            this.GenerateKeyLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GenerateKeyLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GenerateKeyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GenerateKeyLabel.Location = new System.Drawing.Point(0, 0);
            this.GenerateKeyLabel.Name = "GenerateKeyLabel";
            this.GenerateKeyLabel.Size = new System.Drawing.Size(138, 33);
            this.GenerateKeyLabel.TabIndex = 0;
            this.GenerateKeyLabel.Text = "Key Oluştur!";
            this.GenerateKeyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GenerateKeyLabel.Click += new System.EventHandler(this.GenerateKeyLabel_Click);
            this.GenerateKeyLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GenerateKeyLabel_MouseDown);
            this.GenerateKeyLabel.MouseLeave += new System.EventHandler(this.GenerateKeyLabel_MouseLeave);
            this.GenerateKeyLabel.MouseHover += new System.EventHandler(this.GenerateKeyLabel_MouseHover);
            // 
            // KeyGeneratorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(440, 184);
            this.Controls.Add(this.GenerateKeyPanel);
            this.Controls.Add(this.KeyLabel);
            this.Controls.Add(this.TopbarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KeyGeneratorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopbarPanel.ResumeLayout(false);
            this.AppNamePanel.ResumeLayout(false);
            this.MinimizePanel.ResumeLayout(false);
            this.ExitPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AppLogoPictureBox)).EndInit();
            this.GenerateKeyPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TopbarPanel;
        private System.Windows.Forms.PictureBox AppLogoPictureBox;
        private System.Windows.Forms.Panel AppNamePanel;
        private System.Windows.Forms.Panel MinimizePanel;
        private System.Windows.Forms.Panel ExitPanel;
        private System.Windows.Forms.Label AppNameLabel;
        private System.Windows.Forms.Label MinimizeLabel;
        private System.Windows.Forms.Label ExitLabel;
        private System.Windows.Forms.Label KeyLabel;
        private System.Windows.Forms.Panel GenerateKeyPanel;
        private System.Windows.Forms.Label GenerateKeyLabel;
    }
}

