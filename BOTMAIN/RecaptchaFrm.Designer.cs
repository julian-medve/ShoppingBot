namespace BOTMAIN
{
    partial class RecaptchaFrm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RecaptchaFrm));
            this.FrmDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.FrmElipseConrol = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.headerPanel = new System.Windows.Forms.Panel();
            this.BrowserContainer = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.headerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // FrmDragControl
            // 
            this.FrmDragControl.Fixed = true;
            this.FrmDragControl.Horizontal = true;
            this.FrmDragControl.TargetControl = this.headerPanel;
            this.FrmDragControl.Vertical = true;
            // 
            // FrmElipseConrol
            // 
            this.FrmElipseConrol.ElipseRadius = 15;
            this.FrmElipseConrol.TargetControl = this;
            // 
            // headerPanel
            // 
            this.headerPanel.Controls.Add(this.pictureBox1);
            this.headerPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.headerPanel.Location = new System.Drawing.Point(0, 0);
            this.headerPanel.Name = "headerPanel";
            this.headerPanel.Size = new System.Drawing.Size(466, 38);
            this.headerPanel.TabIndex = 0;
            // 
            // BrowserContainer
            // 
            this.BrowserContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BrowserContainer.Location = new System.Drawing.Point(0, 38);
            this.BrowserContainer.Name = "BrowserContainer";
            this.BrowserContainer.Size = new System.Drawing.Size(466, 588);
            this.BrowserContainer.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(10, 3, 3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // RecaptchaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(466, 626);
            this.Controls.Add(this.BrowserContainer);
            this.Controls.Add(this.headerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RecaptchaFrm";
            this.Text = "RecaptchaFrm";
            this.Leave += new System.EventHandler(this.RecaptchaFrm_Leave);
            this.headerPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuDragControl FrmDragControl;
        private Bunifu.Framework.UI.BunifuElipse FrmElipseConrol;
        private System.Windows.Forms.Panel BrowserContainer;
        private System.Windows.Forms.Panel headerPanel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}