namespace BOTMAIN
{
    partial class MassEditFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MassEditFrm));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.BackgroundPanel = new System.Windows.Forms.Panel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.SaveBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.close_btn = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.MassText = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.TitleLBL = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.BackgroundPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // BackgroundPanel
            // 
            this.BackgroundPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.BackgroundPanel.Controls.Add(this.TitleLBL);
            this.BackgroundPanel.Controls.Add(this.close_btn);
            this.BackgroundPanel.Controls.Add(this.MainPanel);
            this.BackgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackgroundPanel.Location = new System.Drawing.Point(0, 0);
            this.BackgroundPanel.Margin = new System.Windows.Forms.Padding(0);
            this.BackgroundPanel.Name = "BackgroundPanel";
            this.BackgroundPanel.Size = new System.Drawing.Size(389, 185);
            this.BackgroundPanel.TabIndex = 0;
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.MainPanel.Controls.Add(this.MassText);
            this.MainPanel.Controls.Add(this.SaveBtn);
            this.MainPanel.Location = new System.Drawing.Point(8, 47);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(374, 128);
            this.MainPanel.TabIndex = 0;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 10;
            this.bunifuElipse2.TargetControl = this.MainPanel;
            // 
            // SaveBtn
            // 
            this.SaveBtn.ActiveBorderThickness = 2;
            this.SaveBtn.ActiveCornerRadius = 20;
            this.SaveBtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.SaveBtn.ActiveForecolor = System.Drawing.Color.White;
            this.SaveBtn.ActiveLineColor = System.Drawing.Color.White;
            this.SaveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.SaveBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SaveBtn.BackgroundImage")));
            this.SaveBtn.ButtonText = "Save";
            this.SaveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.SaveBtn.IdleBorderThickness = 2;
            this.SaveBtn.IdleCornerRadius = 25;
            this.SaveBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.SaveBtn.IdleForecolor = System.Drawing.Color.White;
            this.SaveBtn.IdleLineColor = System.Drawing.Color.Gray;
            this.SaveBtn.Location = new System.Drawing.Point(258, 85);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(100, 40);
            this.SaveBtn.TabIndex = 12;
            this.SaveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // close_btn
            // 
            this.close_btn.BackColor = System.Drawing.Color.Transparent;
            this.close_btn.Image = global::BOTMAIN.Properties.Resources.cross;
            this.close_btn.ImageActive = null;
            this.close_btn.Location = new System.Drawing.Point(366, 8);
            this.close_btn.Margin = new System.Windows.Forms.Padding(2);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(15, 16);
            this.close_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close_btn.TabIndex = 17;
            this.close_btn.TabStop = false;
            this.close_btn.Zoom = 10;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.BackgroundPanel;
            this.bunifuDragControl1.Vertical = true;
            // 
            // MassText
            // 
            this.MassText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.MassText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MassText.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.MassText.ForeColor = System.Drawing.Color.White;
            this.MassText.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.MassText.HintText = "Mass URL";
            this.MassText.isPassword = false;
            this.MassText.LineFocusedColor = System.Drawing.Color.White;
            this.MassText.LineIdleColor = System.Drawing.Color.Gray;
            this.MassText.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.MassText.LineThickness = 2;
            this.MassText.Location = new System.Drawing.Point(19, 42);
            this.MassText.Margin = new System.Windows.Forms.Padding(4);
            this.MassText.Name = "MassText";
            this.MassText.Size = new System.Drawing.Size(339, 33);
            this.MassText.TabIndex = 13;
            this.MassText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.MassText.OnValueChanged += new System.EventHandler(this.MassText_OnValueChanged);
            // 
            // TitleLBL
            // 
            this.TitleLBL.AutoSize = true;
            this.TitleLBL.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLBL.ForeColor = System.Drawing.Color.White;
            this.TitleLBL.Location = new System.Drawing.Point(12, 18);
            this.TitleLBL.Name = "TitleLBL";
            this.TitleLBL.Size = new System.Drawing.Size(123, 24);
            this.TitleLBL.TabIndex = 18;
            this.TitleLBL.Text = "MASS EDIT";
            // 
            // MassEditFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(389, 185);
            this.Controls.Add(this.BackgroundPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MassEditFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MASS EDIT";
            this.BackgroundPanel.ResumeLayout(false);
            this.BackgroundPanel.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel BackgroundPanel;
        private System.Windows.Forms.Panel MainPanel;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuThinButton2 SaveBtn;
        private Bunifu.Framework.UI.BunifuImageButton close_btn;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox MassText;
        public Bunifu.Framework.UI.BunifuCustomLabel TitleLBL;
    }
}