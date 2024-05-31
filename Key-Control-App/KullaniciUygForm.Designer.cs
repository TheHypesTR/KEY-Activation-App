namespace KullaniciUygulamasi
{
    partial class KullaniciUygForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KullaniciUygForm));
            this.TopbarPanel = new System.Windows.Forms.Panel();
            this.AppNamePanel = new System.Windows.Forms.Panel();
            this.AppNameLabel = new System.Windows.Forms.Label();
            this.MinimizePanel = new System.Windows.Forms.Panel();
            this.MinimizeLabel = new System.Windows.Forms.Label();
            this.ExitPanel = new System.Windows.Forms.Panel();
            this.ExitLabel = new System.Windows.Forms.Label();
            this.AppLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.KeyTB1 = new System.Windows.Forms.TextBox();
            this.KeyLabel1 = new System.Windows.Forms.Label();
            this.KeyLabel2 = new System.Windows.Forms.Label();
            this.KeyTB2 = new System.Windows.Forms.TextBox();
            this.KeyLabel3 = new System.Windows.Forms.Label();
            this.KeyTB3 = new System.Windows.Forms.TextBox();
            this.KeyTB4 = new System.Windows.Forms.TextBox();
            this.GenerateKeyPanel = new System.Windows.Forms.Panel();
            this.GenerateKeyLabel = new System.Windows.Forms.Label();
            this.MacAddressLabel = new System.Windows.Forms.Label();
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
            this.TopbarPanel.Size = new System.Drawing.Size(546, 35);
            this.TopbarPanel.TabIndex = 1;
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
            this.AppNamePanel.Size = new System.Drawing.Size(169, 35);
            this.AppNamePanel.TabIndex = 3;
            // 
            // AppNameLabel
            // 
            this.AppNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AppNameLabel.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.AppNameLabel.Location = new System.Drawing.Point(0, 0);
            this.AppNameLabel.Name = "AppNameLabel";
            this.AppNameLabel.Size = new System.Drawing.Size(169, 35);
            this.AppNameLabel.TabIndex = 1;
            this.AppNameLabel.Text = "Kullanıcı Uygulaması";
            this.AppNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AppNameLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopbarPanel_MouseDown);
            this.AppNameLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopbarPanel_MouseMove);
            this.AppNameLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopbarPanel_MouseUp);
            // 
            // MinimizePanel
            // 
            this.MinimizePanel.Controls.Add(this.MinimizeLabel);
            this.MinimizePanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.MinimizePanel.Location = new System.Drawing.Point(476, 0);
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
            this.ExitPanel.Location = new System.Drawing.Point(511, 0);
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
            this.AppLogoPictureBox.Image = global::Key_Control_App.Resource1.Grand_Master_Key1;
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
            // KeyTB1
            // 
            this.KeyTB1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KeyTB1.Location = new System.Drawing.Point(35, 68);
            this.KeyTB1.MaxLength = 4;
            this.KeyTB1.Name = "KeyTB1";
            this.KeyTB1.Size = new System.Drawing.Size(100, 27);
            this.KeyTB1.TabIndex = 2;
            this.KeyTB1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.KeyTB1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyTB_KeyPress);
            // 
            // KeyLabel1
            // 
            this.KeyLabel1.AutoSize = true;
            this.KeyLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KeyLabel1.Location = new System.Drawing.Point(140, 69);
            this.KeyLabel1.Name = "KeyLabel1";
            this.KeyLabel1.Size = new System.Drawing.Size(16, 22);
            this.KeyLabel1.TabIndex = 3;
            this.KeyLabel1.Text = "-";
            this.KeyLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // KeyLabel2
            // 
            this.KeyLabel2.AutoSize = true;
            this.KeyLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KeyLabel2.Location = new System.Drawing.Point(267, 69);
            this.KeyLabel2.Name = "KeyLabel2";
            this.KeyLabel2.Size = new System.Drawing.Size(16, 22);
            this.KeyLabel2.TabIndex = 5;
            this.KeyLabel2.Text = "-";
            // 
            // KeyTB2
            // 
            this.KeyTB2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KeyTB2.Location = new System.Drawing.Point(161, 68);
            this.KeyTB2.MaxLength = 4;
            this.KeyTB2.Name = "KeyTB2";
            this.KeyTB2.Size = new System.Drawing.Size(100, 27);
            this.KeyTB2.TabIndex = 4;
            this.KeyTB2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.KeyTB2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyTB_KeyPress);
            // 
            // KeyLabel3
            // 
            this.KeyLabel3.AutoSize = true;
            this.KeyLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KeyLabel3.Location = new System.Drawing.Point(394, 69);
            this.KeyLabel3.Name = "KeyLabel3";
            this.KeyLabel3.Size = new System.Drawing.Size(16, 22);
            this.KeyLabel3.TabIndex = 7;
            this.KeyLabel3.Text = "-";
            // 
            // KeyTB3
            // 
            this.KeyTB3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KeyTB3.Location = new System.Drawing.Point(288, 68);
            this.KeyTB3.MaxLength = 4;
            this.KeyTB3.Name = "KeyTB3";
            this.KeyTB3.Size = new System.Drawing.Size(100, 27);
            this.KeyTB3.TabIndex = 6;
            this.KeyTB3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.KeyTB3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyTB_KeyPress);
            // 
            // KeyTB4
            // 
            this.KeyTB4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KeyTB4.Location = new System.Drawing.Point(415, 68);
            this.KeyTB4.MaxLength = 4;
            this.KeyTB4.Name = "KeyTB4";
            this.KeyTB4.Size = new System.Drawing.Size(100, 27);
            this.KeyTB4.TabIndex = 8;
            this.KeyTB4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.KeyTB4.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.KeyTB_KeyPress);
            // 
            // GenerateKeyPanel
            // 
            this.GenerateKeyPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GenerateKeyPanel.Controls.Add(this.GenerateKeyLabel);
            this.GenerateKeyPanel.Location = new System.Drawing.Point(415, 117);
            this.GenerateKeyPanel.Name = "GenerateKeyPanel";
            this.GenerateKeyPanel.Size = new System.Drawing.Size(100, 34);
            this.GenerateKeyPanel.TabIndex = 9;
            // 
            // GenerateKeyLabel
            // 
            this.GenerateKeyLabel.BackColor = System.Drawing.Color.PowderBlue;
            this.GenerateKeyLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.GenerateKeyLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GenerateKeyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GenerateKeyLabel.Location = new System.Drawing.Point(0, 0);
            this.GenerateKeyLabel.Name = "GenerateKeyLabel";
            this.GenerateKeyLabel.Size = new System.Drawing.Size(98, 32);
            this.GenerateKeyLabel.TabIndex = 0;
            this.GenerateKeyLabel.Text = "Onayla!";
            this.GenerateKeyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GenerateKeyLabel.Click += new System.EventHandler(this.ConfirmLabel_Click);
            this.GenerateKeyLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ConfirmLabel_MouseDown);
            this.GenerateKeyLabel.MouseLeave += new System.EventHandler(this.ConfirmLabel_MouseLeave);
            this.GenerateKeyLabel.MouseHover += new System.EventHandler(this.ConfirmLabel_MouseHover);
            // 
            // MacAddressLabel
            // 
            this.MacAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MacAddressLabel.Location = new System.Drawing.Point(31, 123);
            this.MacAddressLabel.Name = "MacAddressLabel";
            this.MacAddressLabel.Size = new System.Drawing.Size(379, 23);
            this.MacAddressLabel.TabIndex = 10;
            this.MacAddressLabel.Text = "MacAddressLabel";
            // 
            // KullaniciUygForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(546, 180);
            this.Controls.Add(this.MacAddressLabel);
            this.Controls.Add(this.GenerateKeyPanel);
            this.Controls.Add(this.KeyTB4);
            this.Controls.Add(this.KeyLabel3);
            this.Controls.Add(this.KeyTB3);
            this.Controls.Add(this.KeyLabel2);
            this.Controls.Add(this.KeyTB2);
            this.Controls.Add(this.KeyLabel1);
            this.Controls.Add(this.KeyTB1);
            this.Controls.Add(this.TopbarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "KullaniciUygForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.TopbarPanel.ResumeLayout(false);
            this.AppNamePanel.ResumeLayout(false);
            this.MinimizePanel.ResumeLayout(false);
            this.ExitPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AppLogoPictureBox)).EndInit();
            this.GenerateKeyPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopbarPanel;
        private System.Windows.Forms.Panel AppNamePanel;
        private System.Windows.Forms.Label AppNameLabel;
        private System.Windows.Forms.Panel MinimizePanel;
        private System.Windows.Forms.Label MinimizeLabel;
        private System.Windows.Forms.Panel ExitPanel;
        private System.Windows.Forms.Label ExitLabel;
        private System.Windows.Forms.PictureBox AppLogoPictureBox;
        private System.Windows.Forms.TextBox KeyTB1;
        private System.Windows.Forms.Label KeyLabel1;
        private System.Windows.Forms.Label KeyLabel2;
        private System.Windows.Forms.TextBox KeyTB2;
        private System.Windows.Forms.Label KeyLabel3;
        private System.Windows.Forms.TextBox KeyTB3;
        private System.Windows.Forms.TextBox KeyTB4;
        private System.Windows.Forms.Panel GenerateKeyPanel;
        private System.Windows.Forms.Label GenerateKeyLabel;
        private System.Windows.Forms.Label MacAddressLabel;
    }
}

