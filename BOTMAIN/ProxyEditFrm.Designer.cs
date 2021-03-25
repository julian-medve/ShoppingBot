namespace BOTMAIN
{
    partial class ProxyEditFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProxyEditFrm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.proxyIPText = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.saveEditProxyBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // proxyIPText
            // 
            this.proxyIPText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.proxyIPText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.proxyIPText.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.proxyIPText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.proxyIPText.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.proxyIPText.ForeColor = System.Drawing.Color.White;
            this.proxyIPText.HintForeColor = System.Drawing.Color.White;
            this.proxyIPText.HintText = "";
            this.proxyIPText.isPassword = false;
            this.proxyIPText.LineFocusedColor = System.Drawing.Color.White;
            this.proxyIPText.LineIdleColor = System.Drawing.Color.Gray;
            this.proxyIPText.LineMouseHoverColor = System.Drawing.Color.Lavender;
            this.proxyIPText.LineThickness = 2;
            this.proxyIPText.Location = new System.Drawing.Point(13, 35);
            this.proxyIPText.Margin = new System.Windows.Forms.Padding(4);
            this.proxyIPText.MaxLength = 32767;
            this.proxyIPText.Name = "proxyIPText";
            this.proxyIPText.Size = new System.Drawing.Size(379, 33);
            this.proxyIPText.TabIndex = 0;
            this.proxyIPText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // saveEditProxyBtn
            // 
            this.saveEditProxyBtn.AllowToggling = false;
            this.saveEditProxyBtn.AnimationSpeed = 200;
            this.saveEditProxyBtn.AutoGenerateColors = false;
            this.saveEditProxyBtn.BackColor = System.Drawing.Color.Transparent;
            this.saveEditProxyBtn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.saveEditProxyBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("saveEditProxyBtn.BackgroundImage")));
            this.saveEditProxyBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.saveEditProxyBtn.ButtonText = "Save";
            this.saveEditProxyBtn.ButtonTextMarginLeft = 5;
            this.saveEditProxyBtn.ColorContrastOnClick = 45;
            this.saveEditProxyBtn.ColorContrastOnHover = 45;
            this.saveEditProxyBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.saveEditProxyBtn.CustomizableEdges = borderEdges1;
            this.saveEditProxyBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.saveEditProxyBtn.DisabledBorderColor = System.Drawing.Color.Empty;
            this.saveEditProxyBtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.saveEditProxyBtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.saveEditProxyBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.saveEditProxyBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveEditProxyBtn.ForeColor = System.Drawing.Color.White;
            this.saveEditProxyBtn.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.saveEditProxyBtn.IconMarginLeft = 11;
            this.saveEditProxyBtn.IconPadding = 10;
            this.saveEditProxyBtn.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.saveEditProxyBtn.IdleBorderColor = System.Drawing.Color.Gray;
            this.saveEditProxyBtn.IdleBorderRadius = 30;
            this.saveEditProxyBtn.IdleBorderThickness = 2;
            this.saveEditProxyBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.saveEditProxyBtn.IdleIconLeftImage = global::BOTMAIN.Properties.Resources.save9;
            this.saveEditProxyBtn.IdleIconRightImage = null;
            this.saveEditProxyBtn.IndicateFocus = false;
            this.saveEditProxyBtn.Location = new System.Drawing.Point(272, 90);
            this.saveEditProxyBtn.Name = "saveEditProxyBtn";
            stateProperties1.BorderColor = System.Drawing.Color.White;
            stateProperties1.BorderRadius = 30;
            stateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties1.BorderThickness = 2;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            stateProperties1.ForeColor = System.Drawing.Color.White;
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.saveEditProxyBtn.onHoverState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.White;
            stateProperties2.BorderRadius = 30;
            stateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties2.BorderThickness = 2;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            stateProperties2.ForeColor = System.Drawing.Color.White;
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.saveEditProxyBtn.OnPressedState = stateProperties2;
            this.saveEditProxyBtn.Size = new System.Drawing.Size(120, 36);
            this.saveEditProxyBtn.TabIndex = 1;
            this.saveEditProxyBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.saveEditProxyBtn.TextMarginLeft = 5;
            this.saveEditProxyBtn.UseDefaultRadiusAndThickness = true;
            this.saveEditProxyBtn.Click += new System.EventHandler(this.saveEditProxyBtn_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.Image = global::BOTMAIN.Properties.Resources.cross_icon;
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(379, 12);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(15, 16);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 2;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this;
            this.bunifuDragControl1.Vertical = true;
            // 
            // ProxyEditFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ClientSize = new System.Drawing.Size(406, 138);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.saveEditProxyBtn);
            this.Controls.Add(this.proxyIPText);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProxyEditFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProxyEditFrm";
            this.Load += new System.EventHandler(this.ProxyEditFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox proxyIPText;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton saveEditProxyBtn;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
    }
}