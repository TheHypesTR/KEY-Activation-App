namespace KullaniciUygulamasi
{
    partial class AnasayfaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnasayfaForm));
            this.TopbarPanel = new System.Windows.Forms.Panel();
            this.AppNamePanel = new System.Windows.Forms.Panel();
            this.AppNameLabel = new System.Windows.Forms.Label();
            this.MinimizePanel = new System.Windows.Forms.Panel();
            this.MinimizeLabel = new System.Windows.Forms.Label();
            this.ExitPanel = new System.Windows.Forms.Panel();
            this.ExitLabel = new System.Windows.Forms.Label();
            this.AppLogoPictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TopbarPanel.SuspendLayout();
            this.AppNamePanel.SuspendLayout();
            this.MinimizePanel.SuspendLayout();
            this.ExitPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AppLogoPictureBox)).BeginInit();
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
            this.TopbarPanel.Size = new System.Drawing.Size(472, 35);
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
            this.AppNamePanel.Size = new System.Drawing.Size(85, 35);
            this.AppNamePanel.TabIndex = 3;
            // 
            // AppNameLabel
            // 
            this.AppNameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AppNameLabel.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.AppNameLabel.Location = new System.Drawing.Point(0, 0);
            this.AppNameLabel.Name = "AppNameLabel";
            this.AppNameLabel.Size = new System.Drawing.Size(85, 35);
            this.AppNameLabel.TabIndex = 1;
            this.AppNameLabel.Text = "Ana Sayfa";
            this.AppNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AppNameLabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopbarPanel_MouseDown);
            this.AppNameLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopbarPanel_MouseMove);
            this.AppNameLabel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.TopbarPanel_MouseUp);
            // 
            // MinimizePanel
            // 
            this.MinimizePanel.Controls.Add(this.MinimizeLabel);
            this.MinimizePanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.MinimizePanel.Location = new System.Drawing.Point(402, 0);
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
            this.ExitPanel.Location = new System.Drawing.Point(437, 0);
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
            this.AppLogoPictureBox.Image = global::Key_Control_App.Resource1.Home_Page1;
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
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(0, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Etkinleştirme Başarılı!";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AnasayfaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 122);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TopbarPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AnasayfaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnasayfaForm";
            this.TopbarPanel.ResumeLayout(false);
            this.AppNamePanel.ResumeLayout(false);
            this.MinimizePanel.ResumeLayout(false);
            this.ExitPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AppLogoPictureBox)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Label label1;
    }
}