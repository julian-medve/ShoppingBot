namespace BOTMAIN
{
    partial class captchaFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(captchaFrm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.BackgroundPanel = new System.Windows.Forms.Panel();
            this.close_btn = new Bunifu.Framework.UI.BunifuImageButton();
            this.main_panel = new System.Windows.Forms.Panel();
            this.GmailPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.passwordLBL = new System.Windows.Forms.Label();
            this.EnabledLBL = new System.Windows.Forms.Label();
            this.proxyEnabledCheck = new Bunifu.Framework.UI.BunifuCheckbox();
            this.saveGmailBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.GmailText = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label_gmail = new System.Windows.Forms.Label();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.addGmailLBL = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.BackgroundPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).BeginInit();
            this.main_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackgroundPanel
            // 
            this.BackgroundPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.BackgroundPanel.Controls.Add(this.close_btn);
            this.BackgroundPanel.Controls.Add(this.main_panel);
            this.BackgroundPanel.Controls.Add(this.bunifuSeparator1);
            this.BackgroundPanel.Controls.Add(this.addGmailLBL);
            this.BackgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackgroundPanel.Location = new System.Drawing.Point(0, 0);
            this.BackgroundPanel.Name = "BackgroundPanel";
            this.BackgroundPanel.Size = new System.Drawing.Size(400, 371);
            this.BackgroundPanel.TabIndex = 0;
            // 
            // close_btn
            // 
            this.close_btn.Image = global::BOTMAIN.Properties.Resources.cross_icon;
            this.close_btn.ImageActive = global::BOTMAIN.Properties.Resources.cross_icon;
            this.close_btn.Location = new System.Drawing.Point(375, 12);
            this.close_btn.Margin = new System.Windows.Forms.Padding(2);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(15, 16);
            this.close_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close_btn.TabIndex = 4;
            this.close_btn.TabStop = false;
            this.close_btn.Zoom = 10;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // main_panel
            // 
            this.main_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.main_panel.Controls.Add(this.GmailPassword);
            this.main_panel.Controls.Add(this.passwordLBL);
            this.main_panel.Controls.Add(this.EnabledLBL);
            this.main_panel.Controls.Add(this.proxyEnabledCheck);
            this.main_panel.Controls.Add(this.saveGmailBtn);
            this.main_panel.Controls.Add(this.GmailText);
            this.main_panel.Controls.Add(this.label_gmail);
            this.main_panel.Location = new System.Drawing.Point(8, 77);
            this.main_panel.Name = "main_panel";
            this.main_panel.Size = new System.Drawing.Size(385, 286);
            this.main_panel.TabIndex = 3;
            // 
            // GmailPassword
            // 
            this.GmailPassword.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.GmailPassword.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.GmailPassword.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.GmailPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.GmailPassword.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.GmailPassword.ForeColor = System.Drawing.Color.White;
            this.GmailPassword.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.GmailPassword.HintText = "please input Gmail Password";
            this.GmailPassword.isPassword = false;
            this.GmailPassword.LineFocusedColor = System.Drawing.Color.White;
            this.GmailPassword.LineIdleColor = System.Drawing.Color.Gray;
            this.GmailPassword.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.GmailPassword.LineThickness = 2;
            this.GmailPassword.Location = new System.Drawing.Point(19, 149);
            this.GmailPassword.Margin = new System.Windows.Forms.Padding(4);
            this.GmailPassword.MaxLength = 32767;
            this.GmailPassword.Name = "GmailPassword";
            this.GmailPassword.Size = new System.Drawing.Size(336, 33);
            this.GmailPassword.TabIndex = 9;
            this.GmailPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // passwordLBL
            // 
            this.passwordLBL.AutoSize = true;
            this.passwordLBL.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLBL.ForeColor = System.Drawing.Color.White;
            this.passwordLBL.Location = new System.Drawing.Point(25, 127);
            this.passwordLBL.Name = "passwordLBL";
            this.passwordLBL.Size = new System.Drawing.Size(136, 18);
            this.passwordLBL.TabIndex = 8;
            this.passwordLBL.Text = "Gmail Password";
            // 
            // EnabledLBL
            // 
            this.EnabledLBL.AutoSize = true;
            this.EnabledLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnabledLBL.ForeColor = System.Drawing.Color.White;
            this.EnabledLBL.Location = new System.Drawing.Point(45, 230);
            this.EnabledLBL.Name = "EnabledLBL";
            this.EnabledLBL.Size = new System.Drawing.Size(72, 16);
            this.EnabledLBL.TabIndex = 7;
            this.EnabledLBL.Text = "Is Enabled";
            // 
            // proxyEnabledCheck
            // 
            this.proxyEnabledCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.proxyEnabledCheck.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.proxyEnabledCheck.Checked = true;
            this.proxyEnabledCheck.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.proxyEnabledCheck.ForeColor = System.Drawing.Color.White;
            this.proxyEnabledCheck.Location = new System.Drawing.Point(19, 226);
            this.proxyEnabledCheck.Name = "proxyEnabledCheck";
            this.proxyEnabledCheck.Size = new System.Drawing.Size(20, 20);
            this.proxyEnabledCheck.TabIndex = 6;
            // 
            // saveGmailBtn
            // 
            this.saveGmailBtn.AllowToggling = false;
            this.saveGmailBtn.AnimationSpeed = 200;
            this.saveGmailBtn.AutoGenerateColors = false;
            this.saveGmailBtn.BackColor = System.Drawing.Color.Transparent;
            this.saveGmailBtn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.saveGmailBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("saveGmailBtn.BackgroundImage")));
            this.saveGmailBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.saveGmailBtn.ButtonText = "Save";
            this.saveGmailBtn.ButtonTextMarginLeft = 10;
            this.saveGmailBtn.ColorContrastOnClick = 45;
            this.saveGmailBtn.ColorContrastOnHover = 45;
            this.saveGmailBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.saveGmailBtn.CustomizableEdges = borderEdges3;
            this.saveGmailBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.saveGmailBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.saveGmailBtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.saveGmailBtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.saveGmailBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.saveGmailBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveGmailBtn.ForeColor = System.Drawing.Color.White;
            this.saveGmailBtn.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.saveGmailBtn.IconMarginLeft = 11;
            this.saveGmailBtn.IconPadding = 10;
            this.saveGmailBtn.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.saveGmailBtn.IdleBorderColor = System.Drawing.Color.White;
            this.saveGmailBtn.IdleBorderRadius = 30;
            this.saveGmailBtn.IdleBorderThickness = 2;
            this.saveGmailBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.saveGmailBtn.IdleIconLeftImage = global::BOTMAIN.Properties.Resources.save9;
            this.saveGmailBtn.IdleIconRightImage = null;
            this.saveGmailBtn.IndicateFocus = false;
            this.saveGmailBtn.Location = new System.Drawing.Point(235, 226);
            this.saveGmailBtn.Name = "saveGmailBtn";
            stateProperties5.BorderColor = System.Drawing.Color.White;
            stateProperties5.BorderRadius = 30;
            stateProperties5.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties5.BorderThickness = 2;
            stateProperties5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            stateProperties5.ForeColor = System.Drawing.Color.White;
            stateProperties5.IconLeftImage = null;
            stateProperties5.IconRightImage = null;
            this.saveGmailBtn.onHoverState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.White;
            stateProperties6.BorderRadius = 30;
            stateProperties6.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties6.BorderThickness = 2;
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            stateProperties6.ForeColor = System.Drawing.Color.White;
            stateProperties6.IconLeftImage = null;
            stateProperties6.IconRightImage = null;
            this.saveGmailBtn.OnPressedState = stateProperties6;
            this.saveGmailBtn.Size = new System.Drawing.Size(120, 36);
            this.saveGmailBtn.TabIndex = 5;
            this.saveGmailBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.saveGmailBtn.TextMarginLeft = 10;
            this.saveGmailBtn.UseDefaultRadiusAndThickness = true;
            this.saveGmailBtn.Click += new System.EventHandler(this.saveGmailBtn_Click);
            // 
            // GmailText
            // 
            this.GmailText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.GmailText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.GmailText.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.GmailText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.GmailText.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.GmailText.ForeColor = System.Drawing.Color.White;
            this.GmailText.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.GmailText.HintText = "please input Gmail";
            this.GmailText.isPassword = false;
            this.GmailText.LineFocusedColor = System.Drawing.Color.White;
            this.GmailText.LineIdleColor = System.Drawing.Color.Gray;
            this.GmailText.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.GmailText.LineThickness = 2;
            this.GmailText.Location = new System.Drawing.Point(19, 51);
            this.GmailText.Margin = new System.Windows.Forms.Padding(4);
            this.GmailText.MaxLength = 32767;
            this.GmailText.Name = "GmailText";
            this.GmailText.Size = new System.Drawing.Size(336, 33);
            this.GmailText.TabIndex = 2;
            this.GmailText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label_gmail
            // 
            this.label_gmail.AutoSize = true;
            this.label_gmail.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_gmail.ForeColor = System.Drawing.Color.White;
            this.label_gmail.Location = new System.Drawing.Point(25, 29);
            this.label_gmail.Name = "label_gmail";
            this.label_gmail.Size = new System.Drawing.Size(124, 18);
            this.label_gmail.TabIndex = 1;
            this.label_gmail.Text = "Gmail Address";
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(96, 63);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(200, 0);
            this.bunifuSeparator1.TabIndex = 2;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // addGmailLBL
            // 
            this.addGmailLBL.AutoEllipsis = true;
            this.addGmailLBL.AutoSize = true;
            this.addGmailLBL.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addGmailLBL.ForeColor = System.Drawing.Color.White;
            this.addGmailLBL.Location = new System.Drawing.Point(107, 36);
            this.addGmailLBL.Name = "addGmailLBL";
            this.addGmailLBL.Size = new System.Drawing.Size(182, 24);
            this.addGmailLBL.TabIndex = 0;
            this.addGmailLBL.Text = "ADD NEW GMAIL";
            this.addGmailLBL.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 20;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 10;
            this.bunifuElipse2.TargetControl = this.main_panel;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.BackgroundPanel;
            this.bunifuDragControl1.Vertical = true;
            // 
            // captchaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(400, 371);
            this.Controls.Add(this.BackgroundPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "captchaFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CaptchaFrm";
            this.Load += new System.EventHandler(this.captchaFrm_Load);
            this.BackgroundPanel.ResumeLayout(false);
            this.BackgroundPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).EndInit();
            this.main_panel.ResumeLayout(false);
            this.main_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BackgroundPanel;
        private System.Windows.Forms.Label addGmailLBL;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Label label_gmail;
        private System.Windows.Forms.Panel main_panel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox GmailText;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton saveGmailBtn;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuImageButton close_btn;
        private Bunifu.Framework.UI.BunifuCheckbox proxyEnabledCheck;
        private System.Windows.Forms.Label EnabledLBL;
        private System.Windows.Forms.Label passwordLBL;
        private Bunifu.Framework.UI.BunifuMaterialTextbox GmailPassword;
    }
}