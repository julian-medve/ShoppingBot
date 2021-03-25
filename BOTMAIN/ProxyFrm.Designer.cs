namespace BOTMAIN
{
    partial class ProxyFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProxyFrm));
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.ToggleSwitch.ToggleState toggleState4 = new Bunifu.ToggleSwitch.ToggleState();
            Bunifu.ToggleSwitch.ToggleState toggleState5 = new Bunifu.ToggleSwitch.ToggleState();
            Bunifu.ToggleSwitch.ToggleState toggleState6 = new Bunifu.ToggleSwitch.ToggleState();
            this.BackgroundPanel = new System.Windows.Forms.Panel();
            this.close_btn = new Bunifu.Framework.UI.BunifuImageButton();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.ProxiesText = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.saveListBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.toggleCurrenIp = new Bunifu.ToggleSwitch.BunifuToggleSwitch();
            this.currentIpLBL = new Bunifu.UI.WinForms.BunifuLabel();
            this.TitleLBL = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.BackgroundPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).BeginInit();
            this.MainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackgroundPanel
            // 
            this.BackgroundPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.BackgroundPanel.Controls.Add(this.close_btn);
            this.BackgroundPanel.Controls.Add(this.MainPanel);
            this.BackgroundPanel.Controls.Add(this.TitleLBL);
            this.BackgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackgroundPanel.Location = new System.Drawing.Point(0, 0);
            this.BackgroundPanel.Name = "BackgroundPanel";
            this.BackgroundPanel.Size = new System.Drawing.Size(493, 410);
            this.BackgroundPanel.TabIndex = 0;
            // 
            // close_btn
            // 
            this.close_btn.BackColor = System.Drawing.Color.Transparent;
            this.close_btn.Image = global::BOTMAIN.Properties.Resources.cross;
            this.close_btn.ImageActive = null;
            this.close_btn.Location = new System.Drawing.Point(467, 11);
            this.close_btn.Margin = new System.Windows.Forms.Padding(2);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(15, 16);
            this.close_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close_btn.TabIndex = 3;
            this.close_btn.TabStop = false;
            this.close_btn.Zoom = 10;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Controls.Add(this.ProxiesText);
            this.MainPanel.Controls.Add(this.saveListBtn);
            this.MainPanel.Controls.Add(this.toggleCurrenIp);
            this.MainPanel.Controls.Add(this.currentIpLBL);
            this.MainPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainPanel.ForeColor = System.Drawing.Color.White;
            this.MainPanel.Location = new System.Drawing.Point(12, 51);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(470, 350);
            this.MainPanel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(36, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "please enter the proxies with space.";
            // 
            // ProxiesText
            // 
            this.ProxiesText.AcceptsReturn = false;
            this.ProxiesText.AcceptsTab = false;
            this.ProxiesText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ProxiesText.AnimationSpeed = 200;
            this.ProxiesText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.ProxiesText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.ProxiesText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ProxiesText.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ProxiesText.BackgroundImage")));
            this.ProxiesText.BorderColorActive = System.Drawing.Color.Gray;
            this.ProxiesText.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.ProxiesText.BorderColorHover = System.Drawing.Color.White;
            this.ProxiesText.BorderColorIdle = System.Drawing.Color.Gray;
            this.ProxiesText.BorderRadius = 3;
            this.ProxiesText.BorderThickness = 2;
            this.ProxiesText.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.ProxiesText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ProxiesText.DefaultFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProxiesText.DefaultText = "";
            this.ProxiesText.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ProxiesText.HideSelection = true;
            this.ProxiesText.IconLeft = null;
            this.ProxiesText.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.ProxiesText.IconPadding = 5;
            this.ProxiesText.IconRight = null;
            this.ProxiesText.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.ProxiesText.Lines = new string[0];
            this.ProxiesText.Location = new System.Drawing.Point(30, 93);
            this.ProxiesText.MaxLength = 32767;
            this.ProxiesText.MinimumSize = new System.Drawing.Size(100, 35);
            this.ProxiesText.Modified = false;
            this.ProxiesText.Multiline = true;
            this.ProxiesText.Name = "ProxiesText";
            stateProperties7.BorderColor = System.Drawing.Color.Gray;
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.ProxiesText.OnActiveState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Empty;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.ProxiesText.OnDisabledState = stateProperties8;
            stateProperties9.BorderColor = System.Drawing.Color.White;
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.ProxiesText.OnHoverState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.Gray;
            stateProperties10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            stateProperties10.ForeColor = System.Drawing.Color.Empty;
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.ProxiesText.OnIdleState = stateProperties10;
            this.ProxiesText.Padding = new System.Windows.Forms.Padding(3);
            this.ProxiesText.PasswordChar = '\0';
            this.ProxiesText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.ProxiesText.PlaceholderText = "Enter Proxies";
            this.ProxiesText.ReadOnly = false;
            this.ProxiesText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ProxiesText.SelectedText = "";
            this.ProxiesText.SelectionLength = 0;
            this.ProxiesText.SelectionStart = 0;
            this.ProxiesText.ShortcutsEnabled = true;
            this.ProxiesText.Size = new System.Drawing.Size(415, 168);
            this.ProxiesText.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.ProxiesText.TabIndex = 17;
            this.ProxiesText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ProxiesText.TextMarginBottom = 0;
            this.ProxiesText.TextMarginLeft = 5;
            this.ProxiesText.TextMarginTop = 0;
            this.ProxiesText.TextPlaceholder = "Enter Proxies";
            this.ProxiesText.UseSystemPasswordChar = false;
            this.ProxiesText.WordWrap = true;
            this.ProxiesText.TextChanged += new System.EventHandler(this.ProxiesText_TextChanged);
            // 
            // saveListBtn
            // 
            this.saveListBtn.AllowToggling = false;
            this.saveListBtn.AnimationSpeed = 200;
            this.saveListBtn.AutoGenerateColors = false;
            this.saveListBtn.BackColor = System.Drawing.Color.Transparent;
            this.saveListBtn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.saveListBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("saveListBtn.BackgroundImage")));
            this.saveListBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.saveListBtn.ButtonText = "Save";
            this.saveListBtn.ButtonTextMarginLeft = 5;
            this.saveListBtn.ColorContrastOnClick = 45;
            this.saveListBtn.ColorContrastOnHover = 45;
            this.saveListBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.saveListBtn.CustomizableEdges = borderEdges2;
            this.saveListBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.saveListBtn.DisabledBorderColor = System.Drawing.Color.Empty;
            this.saveListBtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.saveListBtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.saveListBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.saveListBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveListBtn.ForeColor = System.Drawing.Color.White;
            this.saveListBtn.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.saveListBtn.IconMarginLeft = 11;
            this.saveListBtn.IconPadding = 10;
            this.saveListBtn.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.saveListBtn.IdleBorderColor = System.Drawing.Color.Gray;
            this.saveListBtn.IdleBorderRadius = 30;
            this.saveListBtn.IdleBorderThickness = 2;
            this.saveListBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.saveListBtn.IdleIconLeftImage = global::BOTMAIN.Properties.Resources.save9;
            this.saveListBtn.IdleIconRightImage = null;
            this.saveListBtn.IndicateFocus = false;
            this.saveListBtn.Location = new System.Drawing.Point(325, 287);
            this.saveListBtn.Name = "saveListBtn";
            stateProperties11.BorderColor = System.Drawing.Color.White;
            stateProperties11.BorderRadius = 30;
            stateProperties11.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties11.BorderThickness = 2;
            stateProperties11.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            stateProperties11.ForeColor = System.Drawing.Color.White;
            stateProperties11.IconLeftImage = null;
            stateProperties11.IconRightImage = null;
            this.saveListBtn.onHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.White;
            stateProperties12.BorderRadius = 30;
            stateProperties12.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties12.BorderThickness = 2;
            stateProperties12.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            stateProperties12.ForeColor = System.Drawing.Color.White;
            stateProperties12.IconLeftImage = null;
            stateProperties12.IconRightImage = null;
            this.saveListBtn.OnPressedState = stateProperties12;
            this.saveListBtn.Size = new System.Drawing.Size(120, 36);
            this.saveListBtn.TabIndex = 15;
            this.saveListBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.saveListBtn.TextMarginLeft = 5;
            this.saveListBtn.UseDefaultRadiusAndThickness = true;
            this.saveListBtn.Click += new System.EventHandler(this.saveListBtn_Click);
            // 
            // toggleCurrenIp
            // 
            this.toggleCurrenIp.Animation = 5;
            this.toggleCurrenIp.BackColor = System.Drawing.Color.Transparent;
            this.toggleCurrenIp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("toggleCurrenIp.BackgroundImage")));
            this.toggleCurrenIp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toggleCurrenIp.Location = new System.Drawing.Point(30, 30);
            this.toggleCurrenIp.Name = "toggleCurrenIp";
            this.toggleCurrenIp.Size = new System.Drawing.Size(35, 20);
            this.toggleCurrenIp.TabIndex = 10;
            toggleState4.BackColor = System.Drawing.Color.Empty;
            toggleState4.BackColorInner = System.Drawing.Color.Empty;
            toggleState4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(0)))), ((int)(((byte)(140)))));
            toggleState4.BorderColorInner = System.Drawing.Color.Empty;
            toggleState4.BorderRadius = 1;
            toggleState4.BorderRadiusInner = 1;
            toggleState4.BorderThickness = 1;
            toggleState4.BorderThicknessInner = 1;
            this.toggleCurrenIp.ToggleStateDisabled = toggleState4;
            toggleState5.BackColor = System.Drawing.Color.Gray;
            toggleState5.BackColorInner = System.Drawing.Color.White;
            toggleState5.BorderColor = System.Drawing.Color.Gray;
            toggleState5.BorderColorInner = System.Drawing.Color.White;
            toggleState5.BorderRadius = 17;
            toggleState5.BorderRadiusInner = 15;
            toggleState5.BorderThickness = 1;
            toggleState5.BorderThicknessInner = 1;
            this.toggleCurrenIp.ToggleStateOff = toggleState5;
            toggleState6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            toggleState6.BackColorInner = System.Drawing.Color.White;
            toggleState6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            toggleState6.BorderColorInner = System.Drawing.Color.White;
            toggleState6.BorderRadius = 17;
            toggleState6.BorderRadiusInner = 15;
            toggleState6.BorderThickness = 1;
            toggleState6.BorderThicknessInner = 1;
            this.toggleCurrenIp.ToggleStateOn = toggleState6;
            this.toggleCurrenIp.Value = false;
            // 
            // currentIpLBL
            // 
            this.currentIpLBL.AutoEllipsis = false;
            this.currentIpLBL.CursorType = null;
            this.currentIpLBL.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentIpLBL.ForeColor = System.Drawing.Color.White;
            this.currentIpLBL.Location = new System.Drawing.Point(87, 30);
            this.currentIpLBL.Name = "currentIpLBL";
            this.currentIpLBL.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.currentIpLBL.Size = new System.Drawing.Size(143, 19);
            this.currentIpLBL.TabIndex = 8;
            this.currentIpLBL.Text = "Use current IP as Proxy";
            this.currentIpLBL.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.currentIpLBL.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // TitleLBL
            // 
            this.TitleLBL.AutoSize = true;
            this.TitleLBL.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLBL.ForeColor = System.Drawing.Color.White;
            this.TitleLBL.Location = new System.Drawing.Point(26, 24);
            this.TitleLBL.Name = "TitleLBL";
            this.TitleLBL.Size = new System.Drawing.Size(188, 24);
            this.TitleLBL.TabIndex = 0;
            this.TitleLBL.Text = "ADD NEW PROXY";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this.MainPanel;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 20;
            this.bunifuElipse2.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.BackgroundPanel;
            this.bunifuDragControl1.Vertical = true;
            // 
            // ProxyFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(493, 410);
            this.Controls.Add(this.BackgroundPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProxyFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProxyFrm";
            this.Load += new System.EventHandler(this.ProxyFrm_Load);
            this.BackgroundPanel.ResumeLayout(false);
            this.BackgroundPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BackgroundPanel;
        private System.Windows.Forms.Panel MainPanel;
        private Bunifu.ToggleSwitch.BunifuToggleSwitch toggleCurrenIp;
        private Bunifu.UI.WinForms.BunifuLabel currentIpLBL;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton saveListBtn;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuImageButton close_btn;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox ProxiesText;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCustomLabel TitleLBL;
    }
}