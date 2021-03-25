namespace BOTMAIN
{
    partial class ProfileFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileFrm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.BackgroundPanel = new System.Windows.Forms.Panel();
            this.TitleLBL = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.CreateBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuSeparator4 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator3 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.ShipCountrySep = new Bunifu.Framework.UI.BunifuSeparator();
            this.BillCountrySep = new Bunifu.Framework.UI.BunifuSeparator();
            this.ShippingLBL = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SameCheck = new Bunifu.Framework.UI.BunifuCheckbox();
            this.ShipPhoneText = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.BillPhoneText = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.EmailText = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ShipCountryCombo = new Bunifu.Framework.UI.BunifuDropdown();
            this.BillCountryCombo = new Bunifu.Framework.UI.BunifuDropdown();
            this.SecurityCodeText = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ShipZipCodeText = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.BillZipCodeText = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel6 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.YearCombo = new Bunifu.Framework.UI.BunifuDropdown();
            this.ShipStateText = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.BillStateText = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.MonthCombo = new Bunifu.Framework.UI.BunifuDropdown();
            this.ShipCityText = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.BillCityText = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.CardNumText = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ShipAddr2Text = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.BillAddr2Text = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.CardNameText = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ShipAddr1Text = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.BillAddr1Text = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.CardTypeCombo = new Bunifu.Framework.UI.BunifuDropdown();
            this.ShipLastName = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.BillLastNameText = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.FriendlyNameText = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ShipFirstNameText = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.BillFirstNameText = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.close_btn = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.dragCon = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
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
            this.BackgroundPanel.Controls.Add(this.MainPanel);
            this.BackgroundPanel.Controls.Add(this.close_btn);
            this.BackgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackgroundPanel.Location = new System.Drawing.Point(0, 0);
            this.BackgroundPanel.Name = "BackgroundPanel";
            this.BackgroundPanel.Size = new System.Drawing.Size(800, 556);
            this.BackgroundPanel.TabIndex = 0;
            this.BackgroundPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BackgroundPanel_MouseDown);
            this.BackgroundPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BackgroundPanel_MouseMove);
            // 
            // TitleLBL
            // 
            this.TitleLBL.AutoSize = true;
            this.TitleLBL.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLBL.ForeColor = System.Drawing.Color.White;
            this.TitleLBL.Location = new System.Drawing.Point(28, 23);
            this.TitleLBL.Name = "TitleLBL";
            this.TitleLBL.Size = new System.Drawing.Size(206, 24);
            this.TitleLBL.TabIndex = 19;
            this.TitleLBL.Text = "ADD NEW PROFILE";
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.MainPanel.Controls.Add(this.CreateBtn);
            this.MainPanel.Controls.Add(this.bunifuSeparator4);
            this.MainPanel.Controls.Add(this.bunifuSeparator3);
            this.MainPanel.Controls.Add(this.bunifuSeparator2);
            this.MainPanel.Controls.Add(this.ShipCountrySep);
            this.MainPanel.Controls.Add(this.BillCountrySep);
            this.MainPanel.Controls.Add(this.ShippingLBL);
            this.MainPanel.Controls.Add(this.SameCheck);
            this.MainPanel.Controls.Add(this.ShipPhoneText);
            this.MainPanel.Controls.Add(this.BillPhoneText);
            this.MainPanel.Controls.Add(this.EmailText);
            this.MainPanel.Controls.Add(this.ShipCountryCombo);
            this.MainPanel.Controls.Add(this.BillCountryCombo);
            this.MainPanel.Controls.Add(this.SecurityCodeText);
            this.MainPanel.Controls.Add(this.ShipZipCodeText);
            this.MainPanel.Controls.Add(this.BillZipCodeText);
            this.MainPanel.Controls.Add(this.bunifuCustomLabel6);
            this.MainPanel.Controls.Add(this.YearCombo);
            this.MainPanel.Controls.Add(this.ShipStateText);
            this.MainPanel.Controls.Add(this.BillStateText);
            this.MainPanel.Controls.Add(this.bunifuCustomLabel5);
            this.MainPanel.Controls.Add(this.MonthCombo);
            this.MainPanel.Controls.Add(this.ShipCityText);
            this.MainPanel.Controls.Add(this.BillCityText);
            this.MainPanel.Controls.Add(this.CardNumText);
            this.MainPanel.Controls.Add(this.ShipAddr2Text);
            this.MainPanel.Controls.Add(this.BillAddr2Text);
            this.MainPanel.Controls.Add(this.CardNameText);
            this.MainPanel.Controls.Add(this.ShipAddr1Text);
            this.MainPanel.Controls.Add(this.BillAddr1Text);
            this.MainPanel.Controls.Add(this.CardTypeCombo);
            this.MainPanel.Controls.Add(this.ShipLastName);
            this.MainPanel.Controls.Add(this.BillLastNameText);
            this.MainPanel.Controls.Add(this.FriendlyNameText);
            this.MainPanel.Controls.Add(this.ShipFirstNameText);
            this.MainPanel.Controls.Add(this.BillFirstNameText);
            this.MainPanel.Controls.Add(this.bunifuSeparator1);
            this.MainPanel.Controls.Add(this.bunifuCustomLabel4);
            this.MainPanel.Controls.Add(this.bunifuCustomLabel3);
            this.MainPanel.Controls.Add(this.bunifuCustomLabel2);
            this.MainPanel.Location = new System.Drawing.Point(12, 51);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(777, 493);
            this.MainPanel.TabIndex = 18;
            // 
            // CreateBtn
            // 
            this.CreateBtn.AllowToggling = false;
            this.CreateBtn.AnimationSpeed = 200;
            this.CreateBtn.AutoGenerateColors = false;
            this.CreateBtn.BackColor = System.Drawing.Color.Transparent;
            this.CreateBtn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.CreateBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CreateBtn.BackgroundImage")));
            this.CreateBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.CreateBtn.ButtonText = "Save";
            this.CreateBtn.ButtonTextMarginLeft = 5;
            this.CreateBtn.ColorContrastOnClick = 45;
            this.CreateBtn.ColorContrastOnHover = 45;
            this.CreateBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.CreateBtn.CustomizableEdges = borderEdges2;
            this.CreateBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.CreateBtn.DisabledBorderColor = System.Drawing.Color.Empty;
            this.CreateBtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.CreateBtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.CreateBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.CreateBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateBtn.ForeColor = System.Drawing.Color.White;
            this.CreateBtn.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.CreateBtn.IconMarginLeft = 11;
            this.CreateBtn.IconPadding = 10;
            this.CreateBtn.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.CreateBtn.IdleBorderColor = System.Drawing.Color.Gray;
            this.CreateBtn.IdleBorderRadius = 30;
            this.CreateBtn.IdleBorderThickness = 2;
            this.CreateBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.CreateBtn.IdleIconLeftImage = global::BOTMAIN.Properties.Resources.save9;
            this.CreateBtn.IdleIconRightImage = null;
            this.CreateBtn.IndicateFocus = false;
            this.CreateBtn.Location = new System.Drawing.Point(619, 440);
            this.CreateBtn.Name = "CreateBtn";
            stateProperties3.BorderColor = System.Drawing.Color.White;
            stateProperties3.BorderRadius = 30;
            stateProperties3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties3.BorderThickness = 2;
            stateProperties3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            stateProperties3.ForeColor = System.Drawing.Color.White;
            stateProperties3.IconLeftImage = null;
            stateProperties3.IconRightImage = null;
            this.CreateBtn.onHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.White;
            stateProperties4.BorderRadius = 30;
            stateProperties4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties4.BorderThickness = 2;
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            stateProperties4.ForeColor = System.Drawing.Color.White;
            stateProperties4.IconLeftImage = null;
            stateProperties4.IconRightImage = null;
            this.CreateBtn.OnPressedState = stateProperties4;
            this.CreateBtn.Size = new System.Drawing.Size(120, 36);
            this.CreateBtn.TabIndex = 62;
            this.CreateBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CreateBtn.TextMarginLeft = 5;
            this.CreateBtn.UseDefaultRadiusAndThickness = true;
            this.CreateBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // bunifuSeparator4
            // 
            this.bunifuSeparator4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator4.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bunifuSeparator4.LineThickness = 1;
            this.bunifuSeparator4.Location = new System.Drawing.Point(638, 299);
            this.bunifuSeparator4.Name = "bunifuSeparator4";
            this.bunifuSeparator4.Size = new System.Drawing.Size(101, 2);
            this.bunifuSeparator4.TabIndex = 61;
            this.bunifuSeparator4.Transparency = 255;
            this.bunifuSeparator4.Vertical = false;
            // 
            // bunifuSeparator3
            // 
            this.bunifuSeparator3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator3.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bunifuSeparator3.LineThickness = 1;
            this.bunifuSeparator3.Location = new System.Drawing.Point(638, 258);
            this.bunifuSeparator3.Name = "bunifuSeparator3";
            this.bunifuSeparator3.Size = new System.Drawing.Size(101, 2);
            this.bunifuSeparator3.TabIndex = 60;
            this.bunifuSeparator3.Transparency = 255;
            this.bunifuSeparator3.Vertical = false;
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(526, 136);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(212, 2);
            this.bunifuSeparator2.TabIndex = 59;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = false;
            // 
            // ShipCountrySep
            // 
            this.ShipCountrySep.BackColor = System.Drawing.Color.Transparent;
            this.ShipCountrySep.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ShipCountrySep.LineThickness = 1;
            this.ShipCountrySep.Location = new System.Drawing.Point(279, 379);
            this.ShipCountrySep.Name = "ShipCountrySep";
            this.ShipCountrySep.Size = new System.Drawing.Size(212, 2);
            this.ShipCountrySep.TabIndex = 58;
            this.ShipCountrySep.Transparency = 255;
            this.ShipCountrySep.Vertical = false;
            // 
            // BillCountrySep
            // 
            this.BillCountrySep.BackColor = System.Drawing.Color.Transparent;
            this.BillCountrySep.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BillCountrySep.LineThickness = 1;
            this.BillCountrySep.Location = new System.Drawing.Point(32, 379);
            this.BillCountrySep.Name = "BillCountrySep";
            this.BillCountrySep.Size = new System.Drawing.Size(212, 2);
            this.BillCountrySep.TabIndex = 57;
            this.BillCountrySep.Transparency = 255;
            this.BillCountrySep.Vertical = false;
            // 
            // ShippingLBL
            // 
            this.ShippingLBL.AutoSize = true;
            this.ShippingLBL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ShippingLBL.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShippingLBL.ForeColor = System.Drawing.Color.White;
            this.ShippingLBL.Location = new System.Drawing.Point(430, 451);
            this.ShippingLBL.Name = "ShippingLBL";
            this.ShippingLBL.Size = new System.Drawing.Size(169, 17);
            this.ShippingLBL.TabIndex = 56;
            this.ShippingLBL.Text = "Shipping Same As Billing";
            this.ShippingLBL.Click += new System.EventHandler(this.ShippingLBL_Click);
            // 
            // SameCheck
            // 
            this.SameCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.SameCheck.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.SameCheck.Checked = false;
            this.SameCheck.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.SameCheck.ForeColor = System.Drawing.Color.White;
            this.SameCheck.Location = new System.Drawing.Point(406, 449);
            this.SameCheck.Name = "SameCheck";
            this.SameCheck.Size = new System.Drawing.Size(20, 20);
            this.SameCheck.TabIndex = 55;
            this.SameCheck.OnChange += new System.EventHandler(this.SameCheck_OnChange);
            // 
            // ShipPhoneText
            // 
            this.ShipPhoneText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.ShipPhoneText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.ShipPhoneText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ShipPhoneText.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.ShipPhoneText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ShipPhoneText.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ShipPhoneText.ForeColor = System.Drawing.Color.White;
            this.ShipPhoneText.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.ShipPhoneText.HintText = "Phone Number";
            this.ShipPhoneText.isPassword = false;
            this.ShipPhoneText.LineFocusedColor = System.Drawing.Color.White;
            this.ShipPhoneText.LineIdleColor = System.Drawing.Color.Gray;
            this.ShipPhoneText.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.ShipPhoneText.LineThickness = 2;
            this.ShipPhoneText.Location = new System.Drawing.Point(279, 390);
            this.ShipPhoneText.Margin = new System.Windows.Forms.Padding(4);
            this.ShipPhoneText.MaxLength = 32767;
            this.ShipPhoneText.Name = "ShipPhoneText";
            this.ShipPhoneText.Size = new System.Drawing.Size(214, 33);
            this.ShipPhoneText.TabIndex = 53;
            this.ShipPhoneText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ShipPhoneText.OnValueChanged += new System.EventHandler(this.Text_OnValueChanged);
            // 
            // BillPhoneText
            // 
            this.BillPhoneText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.BillPhoneText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.BillPhoneText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.BillPhoneText.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.BillPhoneText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BillPhoneText.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BillPhoneText.ForeColor = System.Drawing.Color.White;
            this.BillPhoneText.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.BillPhoneText.HintText = "Phone Number";
            this.BillPhoneText.isPassword = false;
            this.BillPhoneText.LineFocusedColor = System.Drawing.Color.White;
            this.BillPhoneText.LineIdleColor = System.Drawing.Color.Gray;
            this.BillPhoneText.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.BillPhoneText.LineThickness = 2;
            this.BillPhoneText.Location = new System.Drawing.Point(32, 390);
            this.BillPhoneText.Margin = new System.Windows.Forms.Padding(4);
            this.BillPhoneText.MaxLength = 32767;
            this.BillPhoneText.Name = "BillPhoneText";
            this.BillPhoneText.Size = new System.Drawing.Size(214, 33);
            this.BillPhoneText.TabIndex = 52;
            this.BillPhoneText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BillPhoneText.OnValueChanged += new System.EventHandler(this.BillFirstNameText_OnValueChanged);
            // 
            // EmailText
            // 
            this.EmailText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.EmailText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.EmailText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.EmailText.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.EmailText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.EmailText.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.EmailText.ForeColor = System.Drawing.Color.White;
            this.EmailText.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.EmailText.HintText = "Email";
            this.EmailText.isPassword = false;
            this.EmailText.LineFocusedColor = System.Drawing.Color.White;
            this.EmailText.LineIdleColor = System.Drawing.Color.Gray;
            this.EmailText.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.EmailText.LineThickness = 2;
            this.EmailText.Location = new System.Drawing.Point(525, 349);
            this.EmailText.Margin = new System.Windows.Forms.Padding(4);
            this.EmailText.MaxLength = 32767;
            this.EmailText.Name = "EmailText";
            this.EmailText.Size = new System.Drawing.Size(214, 33);
            this.EmailText.TabIndex = 49;
            this.EmailText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.EmailText.OnValueChanged += new System.EventHandler(this.Text_OnValueChanged);
            // 
            // ShipCountryCombo
            // 
            this.ShipCountryCombo.BackColor = System.Drawing.Color.Transparent;
            this.ShipCountryCombo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ShipCountryCombo.BorderRadius = 7;
            this.ShipCountryCombo.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ShipCountryCombo.ForeColor = System.Drawing.Color.Gray;
            this.ShipCountryCombo.items = new string[0];
            this.ShipCountryCombo.Location = new System.Drawing.Point(278, 354);
            this.ShipCountryCombo.Margin = new System.Windows.Forms.Padding(4);
            this.ShipCountryCombo.Name = "ShipCountryCombo";
            this.ShipCountryCombo.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ShipCountryCombo.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ShipCountryCombo.selectedIndex = -1;
            this.ShipCountryCombo.Size = new System.Drawing.Size(214, 28);
            this.ShipCountryCombo.TabIndex = 48;
            this.ShipCountryCombo.onItemSelected += new System.EventHandler(this.ShipCountryCombo_onItemSelected);
            // 
            // BillCountryCombo
            // 
            this.BillCountryCombo.BackColor = System.Drawing.Color.Transparent;
            this.BillCountryCombo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BillCountryCombo.BorderRadius = 7;
            this.BillCountryCombo.DisabledColor = System.Drawing.Color.Gray;
            this.BillCountryCombo.ForeColor = System.Drawing.Color.Gray;
            this.BillCountryCombo.items = new string[0];
            this.BillCountryCombo.Location = new System.Drawing.Point(31, 354);
            this.BillCountryCombo.Margin = new System.Windows.Forms.Padding(4);
            this.BillCountryCombo.Name = "BillCountryCombo";
            this.BillCountryCombo.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BillCountryCombo.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.BillCountryCombo.selectedIndex = -1;
            this.BillCountryCombo.Size = new System.Drawing.Size(214, 28);
            this.BillCountryCombo.TabIndex = 47;
            this.BillCountryCombo.onItemSelected += new System.EventHandler(this.BillCountryCombo_onItemSelected);
            this.BillCountryCombo.Validated += new System.EventHandler(this.BillCountryCombo_Validated);
            // 
            // SecurityCodeText
            // 
            this.SecurityCodeText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.SecurityCodeText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.SecurityCodeText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.SecurityCodeText.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.SecurityCodeText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SecurityCodeText.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.SecurityCodeText.ForeColor = System.Drawing.Color.White;
            this.SecurityCodeText.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.SecurityCodeText.HintText = "Security Code";
            this.SecurityCodeText.isPassword = false;
            this.SecurityCodeText.LineFocusedColor = System.Drawing.Color.White;
            this.SecurityCodeText.LineIdleColor = System.Drawing.Color.Gray;
            this.SecurityCodeText.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.SecurityCodeText.LineThickness = 2;
            this.SecurityCodeText.Location = new System.Drawing.Point(525, 308);
            this.SecurityCodeText.Margin = new System.Windows.Forms.Padding(4);
            this.SecurityCodeText.MaxLength = 32767;
            this.SecurityCodeText.Name = "SecurityCodeText";
            this.SecurityCodeText.Size = new System.Drawing.Size(214, 33);
            this.SecurityCodeText.TabIndex = 46;
            this.SecurityCodeText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SecurityCodeText.OnValueChanged += new System.EventHandler(this.Text_OnValueChanged);
            // 
            // ShipZipCodeText
            // 
            this.ShipZipCodeText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.ShipZipCodeText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.ShipZipCodeText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ShipZipCodeText.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.ShipZipCodeText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ShipZipCodeText.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ShipZipCodeText.ForeColor = System.Drawing.Color.White;
            this.ShipZipCodeText.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.ShipZipCodeText.HintText = "Zip Code";
            this.ShipZipCodeText.isPassword = false;
            this.ShipZipCodeText.LineFocusedColor = System.Drawing.Color.White;
            this.ShipZipCodeText.LineIdleColor = System.Drawing.Color.Gray;
            this.ShipZipCodeText.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.ShipZipCodeText.LineThickness = 2;
            this.ShipZipCodeText.Location = new System.Drawing.Point(278, 308);
            this.ShipZipCodeText.Margin = new System.Windows.Forms.Padding(4);
            this.ShipZipCodeText.MaxLength = 32767;
            this.ShipZipCodeText.Name = "ShipZipCodeText";
            this.ShipZipCodeText.Size = new System.Drawing.Size(214, 33);
            this.ShipZipCodeText.TabIndex = 45;
            this.ShipZipCodeText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ShipZipCodeText.OnValueChanged += new System.EventHandler(this.Text_OnValueChanged);
            // 
            // BillZipCodeText
            // 
            this.BillZipCodeText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.BillZipCodeText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.BillZipCodeText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.BillZipCodeText.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.BillZipCodeText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BillZipCodeText.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BillZipCodeText.ForeColor = System.Drawing.Color.White;
            this.BillZipCodeText.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.BillZipCodeText.HintText = "Zip Code";
            this.BillZipCodeText.isPassword = false;
            this.BillZipCodeText.LineFocusedColor = System.Drawing.Color.White;
            this.BillZipCodeText.LineIdleColor = System.Drawing.Color.Gray;
            this.BillZipCodeText.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.BillZipCodeText.LineThickness = 2;
            this.BillZipCodeText.Location = new System.Drawing.Point(31, 308);
            this.BillZipCodeText.Margin = new System.Windows.Forms.Padding(4);
            this.BillZipCodeText.MaxLength = 32767;
            this.BillZipCodeText.Name = "BillZipCodeText";
            this.BillZipCodeText.Size = new System.Drawing.Size(214, 33);
            this.BillZipCodeText.TabIndex = 44;
            this.BillZipCodeText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BillZipCodeText.OnValueChanged += new System.EventHandler(this.BillFirstNameText_OnValueChanged);
            // 
            // bunifuCustomLabel6
            // 
            this.bunifuCustomLabel6.AutoSize = true;
            this.bunifuCustomLabel6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel6.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel6.Location = new System.Drawing.Point(529, 276);
            this.bunifuCustomLabel6.Name = "bunifuCustomLabel6";
            this.bunifuCustomLabel6.Size = new System.Drawing.Size(86, 20);
            this.bunifuCustomLabel6.TabIndex = 43;
            this.bunifuCustomLabel6.Text = "Expiry Year";
            // 
            // YearCombo
            // 
            this.YearCombo.BackColor = System.Drawing.Color.Transparent;
            this.YearCombo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.YearCombo.BorderRadius = 7;
            this.YearCombo.DisabledColor = System.Drawing.Color.Gray;
            this.YearCombo.ForeColor = System.Drawing.Color.White;
            this.YearCombo.items = new string[0];
            this.YearCombo.Location = new System.Drawing.Point(638, 272);
            this.YearCombo.Margin = new System.Windows.Forms.Padding(4);
            this.YearCombo.Name = "YearCombo";
            this.YearCombo.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.YearCombo.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.YearCombo.selectedIndex = -1;
            this.YearCombo.Size = new System.Drawing.Size(101, 28);
            this.YearCombo.TabIndex = 42;
            // 
            // ShipStateText
            // 
            this.ShipStateText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.ShipStateText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.ShipStateText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ShipStateText.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.ShipStateText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ShipStateText.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ShipStateText.ForeColor = System.Drawing.Color.White;
            this.ShipStateText.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.ShipStateText.HintText = "State(XX)";
            this.ShipStateText.isPassword = false;
            this.ShipStateText.LineFocusedColor = System.Drawing.Color.White;
            this.ShipStateText.LineIdleColor = System.Drawing.Color.Gray;
            this.ShipStateText.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.ShipStateText.LineThickness = 2;
            this.ShipStateText.Location = new System.Drawing.Point(278, 267);
            this.ShipStateText.Margin = new System.Windows.Forms.Padding(4);
            this.ShipStateText.MaxLength = 32767;
            this.ShipStateText.Name = "ShipStateText";
            this.ShipStateText.Size = new System.Drawing.Size(214, 33);
            this.ShipStateText.TabIndex = 41;
            this.ShipStateText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ShipStateText.OnValueChanged += new System.EventHandler(this.Text_OnValueChanged);
            // 
            // BillStateText
            // 
            this.BillStateText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.BillStateText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.BillStateText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.BillStateText.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.BillStateText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BillStateText.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BillStateText.ForeColor = System.Drawing.Color.White;
            this.BillStateText.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.BillStateText.HintText = "State(XX)";
            this.BillStateText.isPassword = false;
            this.BillStateText.LineFocusedColor = System.Drawing.Color.White;
            this.BillStateText.LineIdleColor = System.Drawing.Color.Gray;
            this.BillStateText.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.BillStateText.LineThickness = 2;
            this.BillStateText.Location = new System.Drawing.Point(31, 267);
            this.BillStateText.Margin = new System.Windows.Forms.Padding(4);
            this.BillStateText.MaxLength = 32767;
            this.BillStateText.Name = "BillStateText";
            this.BillStateText.Size = new System.Drawing.Size(214, 33);
            this.BillStateText.TabIndex = 40;
            this.BillStateText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BillStateText.OnValueChanged += new System.EventHandler(this.BillFirstNameText_OnValueChanged);
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(529, 236);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(102, 20);
            this.bunifuCustomLabel5.TabIndex = 39;
            this.bunifuCustomLabel5.Text = "Expiry Month";
            // 
            // MonthCombo
            // 
            this.MonthCombo.BackColor = System.Drawing.Color.Transparent;
            this.MonthCombo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MonthCombo.BorderRadius = 7;
            this.MonthCombo.DisabledColor = System.Drawing.Color.Gray;
            this.MonthCombo.ForeColor = System.Drawing.Color.White;
            this.MonthCombo.items = new string[0];
            this.MonthCombo.Location = new System.Drawing.Point(638, 232);
            this.MonthCombo.Margin = new System.Windows.Forms.Padding(4);
            this.MonthCombo.Name = "MonthCombo";
            this.MonthCombo.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.MonthCombo.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.MonthCombo.selectedIndex = -1;
            this.MonthCombo.Size = new System.Drawing.Size(101, 28);
            this.MonthCombo.TabIndex = 38;
            // 
            // ShipCityText
            // 
            this.ShipCityText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.ShipCityText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.ShipCityText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ShipCityText.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.ShipCityText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ShipCityText.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ShipCityText.ForeColor = System.Drawing.Color.White;
            this.ShipCityText.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.ShipCityText.HintText = "City";
            this.ShipCityText.isPassword = false;
            this.ShipCityText.LineFocusedColor = System.Drawing.Color.White;
            this.ShipCityText.LineIdleColor = System.Drawing.Color.Gray;
            this.ShipCityText.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.ShipCityText.LineThickness = 2;
            this.ShipCityText.Location = new System.Drawing.Point(278, 226);
            this.ShipCityText.Margin = new System.Windows.Forms.Padding(4);
            this.ShipCityText.MaxLength = 32767;
            this.ShipCityText.Name = "ShipCityText";
            this.ShipCityText.Size = new System.Drawing.Size(214, 33);
            this.ShipCityText.TabIndex = 37;
            this.ShipCityText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ShipCityText.OnValueChanged += new System.EventHandler(this.Text_OnValueChanged);
            // 
            // BillCityText
            // 
            this.BillCityText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.BillCityText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.BillCityText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.BillCityText.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.BillCityText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BillCityText.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BillCityText.ForeColor = System.Drawing.Color.White;
            this.BillCityText.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.BillCityText.HintText = "City";
            this.BillCityText.isPassword = false;
            this.BillCityText.LineFocusedColor = System.Drawing.Color.White;
            this.BillCityText.LineIdleColor = System.Drawing.Color.Gray;
            this.BillCityText.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.BillCityText.LineThickness = 2;
            this.BillCityText.Location = new System.Drawing.Point(31, 226);
            this.BillCityText.Margin = new System.Windows.Forms.Padding(4);
            this.BillCityText.MaxLength = 32767;
            this.BillCityText.Name = "BillCityText";
            this.BillCityText.Size = new System.Drawing.Size(214, 33);
            this.BillCityText.TabIndex = 36;
            this.BillCityText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BillCityText.OnValueChanged += new System.EventHandler(this.BillFirstNameText_OnValueChanged);
            // 
            // CardNumText
            // 
            this.CardNumText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.CardNumText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.CardNumText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.CardNumText.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.CardNumText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CardNumText.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.CardNumText.ForeColor = System.Drawing.Color.White;
            this.CardNumText.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.CardNumText.HintText = "Card Number";
            this.CardNumText.isPassword = false;
            this.CardNumText.LineFocusedColor = System.Drawing.Color.White;
            this.CardNumText.LineIdleColor = System.Drawing.Color.Gray;
            this.CardNumText.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.CardNumText.LineThickness = 2;
            this.CardNumText.Location = new System.Drawing.Point(525, 185);
            this.CardNumText.Margin = new System.Windows.Forms.Padding(4);
            this.CardNumText.MaxLength = 32767;
            this.CardNumText.Name = "CardNumText";
            this.CardNumText.Size = new System.Drawing.Size(214, 33);
            this.CardNumText.TabIndex = 35;
            this.CardNumText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CardNumText.OnValueChanged += new System.EventHandler(this.Text_OnValueChanged);
            // 
            // ShipAddr2Text
            // 
            this.ShipAddr2Text.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.ShipAddr2Text.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.ShipAddr2Text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ShipAddr2Text.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.ShipAddr2Text.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ShipAddr2Text.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ShipAddr2Text.ForeColor = System.Drawing.Color.White;
            this.ShipAddr2Text.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.ShipAddr2Text.HintText = "Address2";
            this.ShipAddr2Text.isPassword = false;
            this.ShipAddr2Text.LineFocusedColor = System.Drawing.Color.White;
            this.ShipAddr2Text.LineIdleColor = System.Drawing.Color.Gray;
            this.ShipAddr2Text.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.ShipAddr2Text.LineThickness = 2;
            this.ShipAddr2Text.Location = new System.Drawing.Point(278, 185);
            this.ShipAddr2Text.Margin = new System.Windows.Forms.Padding(4);
            this.ShipAddr2Text.MaxLength = 32767;
            this.ShipAddr2Text.Name = "ShipAddr2Text";
            this.ShipAddr2Text.Size = new System.Drawing.Size(214, 33);
            this.ShipAddr2Text.TabIndex = 34;
            this.ShipAddr2Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ShipAddr2Text.OnValueChanged += new System.EventHandler(this.Text_OnValueChanged);
            // 
            // BillAddr2Text
            // 
            this.BillAddr2Text.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.BillAddr2Text.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.BillAddr2Text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.BillAddr2Text.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.BillAddr2Text.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BillAddr2Text.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BillAddr2Text.ForeColor = System.Drawing.Color.White;
            this.BillAddr2Text.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.BillAddr2Text.HintText = "Address2";
            this.BillAddr2Text.isPassword = false;
            this.BillAddr2Text.LineFocusedColor = System.Drawing.Color.White;
            this.BillAddr2Text.LineIdleColor = System.Drawing.Color.Gray;
            this.BillAddr2Text.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.BillAddr2Text.LineThickness = 2;
            this.BillAddr2Text.Location = new System.Drawing.Point(31, 185);
            this.BillAddr2Text.Margin = new System.Windows.Forms.Padding(4);
            this.BillAddr2Text.MaxLength = 32767;
            this.BillAddr2Text.Name = "BillAddr2Text";
            this.BillAddr2Text.Size = new System.Drawing.Size(214, 33);
            this.BillAddr2Text.TabIndex = 33;
            this.BillAddr2Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BillAddr2Text.OnValueChanged += new System.EventHandler(this.BillFirstNameText_OnValueChanged);
            // 
            // CardNameText
            // 
            this.CardNameText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.CardNameText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.CardNameText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.CardNameText.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.CardNameText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.CardNameText.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.CardNameText.ForeColor = System.Drawing.Color.White;
            this.CardNameText.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.CardNameText.HintText = "Name On Card";
            this.CardNameText.isPassword = false;
            this.CardNameText.LineFocusedColor = System.Drawing.Color.White;
            this.CardNameText.LineIdleColor = System.Drawing.Color.Gray;
            this.CardNameText.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.CardNameText.LineThickness = 2;
            this.CardNameText.Location = new System.Drawing.Point(525, 144);
            this.CardNameText.Margin = new System.Windows.Forms.Padding(4);
            this.CardNameText.MaxLength = 32767;
            this.CardNameText.Name = "CardNameText";
            this.CardNameText.Size = new System.Drawing.Size(214, 33);
            this.CardNameText.TabIndex = 32;
            this.CardNameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CardNameText.OnValueChanged += new System.EventHandler(this.Text_OnValueChanged);
            // 
            // ShipAddr1Text
            // 
            this.ShipAddr1Text.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.ShipAddr1Text.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.ShipAddr1Text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ShipAddr1Text.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.ShipAddr1Text.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ShipAddr1Text.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ShipAddr1Text.ForeColor = System.Drawing.Color.White;
            this.ShipAddr1Text.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.ShipAddr1Text.HintText = "Address1";
            this.ShipAddr1Text.isPassword = false;
            this.ShipAddr1Text.LineFocusedColor = System.Drawing.Color.White;
            this.ShipAddr1Text.LineIdleColor = System.Drawing.Color.Gray;
            this.ShipAddr1Text.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.ShipAddr1Text.LineThickness = 2;
            this.ShipAddr1Text.Location = new System.Drawing.Point(278, 144);
            this.ShipAddr1Text.Margin = new System.Windows.Forms.Padding(4);
            this.ShipAddr1Text.MaxLength = 32767;
            this.ShipAddr1Text.Name = "ShipAddr1Text";
            this.ShipAddr1Text.Size = new System.Drawing.Size(214, 33);
            this.ShipAddr1Text.TabIndex = 31;
            this.ShipAddr1Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ShipAddr1Text.OnValueChanged += new System.EventHandler(this.Text_OnValueChanged);
            // 
            // BillAddr1Text
            // 
            this.BillAddr1Text.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.BillAddr1Text.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.BillAddr1Text.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.BillAddr1Text.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.BillAddr1Text.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BillAddr1Text.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BillAddr1Text.ForeColor = System.Drawing.Color.White;
            this.BillAddr1Text.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.BillAddr1Text.HintText = "Address1";
            this.BillAddr1Text.isPassword = false;
            this.BillAddr1Text.LineFocusedColor = System.Drawing.Color.White;
            this.BillAddr1Text.LineIdleColor = System.Drawing.Color.Gray;
            this.BillAddr1Text.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.BillAddr1Text.LineThickness = 2;
            this.BillAddr1Text.Location = new System.Drawing.Point(31, 144);
            this.BillAddr1Text.Margin = new System.Windows.Forms.Padding(4);
            this.BillAddr1Text.MaxLength = 32767;
            this.BillAddr1Text.Name = "BillAddr1Text";
            this.BillAddr1Text.Size = new System.Drawing.Size(214, 33);
            this.BillAddr1Text.TabIndex = 30;
            this.BillAddr1Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BillAddr1Text.OnValueChanged += new System.EventHandler(this.BillFirstNameText_OnValueChanged);
            // 
            // CardTypeCombo
            // 
            this.CardTypeCombo.BackColor = System.Drawing.Color.Transparent;
            this.CardTypeCombo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CardTypeCombo.BorderRadius = 7;
            this.CardTypeCombo.DisabledColor = System.Drawing.Color.Gray;
            this.CardTypeCombo.ForeColor = System.Drawing.Color.White;
            this.CardTypeCombo.items = new string[] {
        "VISA",
        "AMEX",
        "COD",
        "DISCOVER",
        "MASTERCARD"};
            this.CardTypeCombo.Location = new System.Drawing.Point(525, 110);
            this.CardTypeCombo.Margin = new System.Windows.Forms.Padding(4);
            this.CardTypeCombo.Name = "CardTypeCombo";
            this.CardTypeCombo.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.CardTypeCombo.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.CardTypeCombo.selectedIndex = 0;
            this.CardTypeCombo.Size = new System.Drawing.Size(214, 28);
            this.CardTypeCombo.TabIndex = 29;
            this.CardTypeCombo.onItemSelected += new System.EventHandler(this.CardTypeCombo_onItemSelected);
            // 
            // ShipLastName
            // 
            this.ShipLastName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.ShipLastName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.ShipLastName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ShipLastName.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.ShipLastName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ShipLastName.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ShipLastName.ForeColor = System.Drawing.Color.White;
            this.ShipLastName.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.ShipLastName.HintText = "Last Name";
            this.ShipLastName.isPassword = false;
            this.ShipLastName.LineFocusedColor = System.Drawing.Color.White;
            this.ShipLastName.LineIdleColor = System.Drawing.Color.Gray;
            this.ShipLastName.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.ShipLastName.LineThickness = 2;
            this.ShipLastName.Location = new System.Drawing.Point(278, 103);
            this.ShipLastName.Margin = new System.Windows.Forms.Padding(4);
            this.ShipLastName.MaxLength = 32767;
            this.ShipLastName.Name = "ShipLastName";
            this.ShipLastName.Size = new System.Drawing.Size(214, 33);
            this.ShipLastName.TabIndex = 28;
            this.ShipLastName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ShipLastName.OnValueChanged += new System.EventHandler(this.Text_OnValueChanged);
            // 
            // BillLastNameText
            // 
            this.BillLastNameText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.BillLastNameText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.BillLastNameText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.BillLastNameText.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.BillLastNameText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BillLastNameText.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BillLastNameText.ForeColor = System.Drawing.Color.White;
            this.BillLastNameText.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.BillLastNameText.HintText = "Last Name";
            this.BillLastNameText.isPassword = false;
            this.BillLastNameText.LineFocusedColor = System.Drawing.Color.White;
            this.BillLastNameText.LineIdleColor = System.Drawing.Color.Gray;
            this.BillLastNameText.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.BillLastNameText.LineThickness = 2;
            this.BillLastNameText.Location = new System.Drawing.Point(31, 103);
            this.BillLastNameText.Margin = new System.Windows.Forms.Padding(4);
            this.BillLastNameText.MaxLength = 32767;
            this.BillLastNameText.Name = "BillLastNameText";
            this.BillLastNameText.Size = new System.Drawing.Size(214, 33);
            this.BillLastNameText.TabIndex = 27;
            this.BillLastNameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BillLastNameText.OnValueChanged += new System.EventHandler(this.BillFirstNameText_OnValueChanged);
            // 
            // FriendlyNameText
            // 
            this.FriendlyNameText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.FriendlyNameText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.FriendlyNameText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.FriendlyNameText.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.FriendlyNameText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FriendlyNameText.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.FriendlyNameText.ForeColor = System.Drawing.Color.White;
            this.FriendlyNameText.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.FriendlyNameText.HintText = "Friendly Name";
            this.FriendlyNameText.isPassword = false;
            this.FriendlyNameText.LineFocusedColor = System.Drawing.Color.White;
            this.FriendlyNameText.LineIdleColor = System.Drawing.Color.Gray;
            this.FriendlyNameText.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.FriendlyNameText.LineThickness = 2;
            this.FriendlyNameText.Location = new System.Drawing.Point(525, 62);
            this.FriendlyNameText.Margin = new System.Windows.Forms.Padding(4);
            this.FriendlyNameText.MaxLength = 32767;
            this.FriendlyNameText.Name = "FriendlyNameText";
            this.FriendlyNameText.Size = new System.Drawing.Size(214, 33);
            this.FriendlyNameText.TabIndex = 26;
            this.FriendlyNameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.FriendlyNameText.OnValueChanged += new System.EventHandler(this.Text_OnValueChanged);
            // 
            // ShipFirstNameText
            // 
            this.ShipFirstNameText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.ShipFirstNameText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.ShipFirstNameText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ShipFirstNameText.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.ShipFirstNameText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ShipFirstNameText.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ShipFirstNameText.ForeColor = System.Drawing.Color.White;
            this.ShipFirstNameText.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.ShipFirstNameText.HintText = "First Name";
            this.ShipFirstNameText.isPassword = false;
            this.ShipFirstNameText.LineFocusedColor = System.Drawing.Color.White;
            this.ShipFirstNameText.LineIdleColor = System.Drawing.Color.Gray;
            this.ShipFirstNameText.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.ShipFirstNameText.LineThickness = 2;
            this.ShipFirstNameText.Location = new System.Drawing.Point(278, 62);
            this.ShipFirstNameText.Margin = new System.Windows.Forms.Padding(4);
            this.ShipFirstNameText.MaxLength = 32767;
            this.ShipFirstNameText.Name = "ShipFirstNameText";
            this.ShipFirstNameText.Size = new System.Drawing.Size(214, 33);
            this.ShipFirstNameText.TabIndex = 25;
            this.ShipFirstNameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.ShipFirstNameText.OnValueChanged += new System.EventHandler(this.Text_OnValueChanged);
            // 
            // BillFirstNameText
            // 
            this.BillFirstNameText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.BillFirstNameText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.BillFirstNameText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.BillFirstNameText.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.BillFirstNameText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BillFirstNameText.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.BillFirstNameText.ForeColor = System.Drawing.Color.White;
            this.BillFirstNameText.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.BillFirstNameText.HintText = "First Name";
            this.BillFirstNameText.isPassword = false;
            this.BillFirstNameText.LineFocusedColor = System.Drawing.Color.White;
            this.BillFirstNameText.LineIdleColor = System.Drawing.Color.Gray;
            this.BillFirstNameText.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.BillFirstNameText.LineThickness = 2;
            this.BillFirstNameText.Location = new System.Drawing.Point(31, 62);
            this.BillFirstNameText.Margin = new System.Windows.Forms.Padding(4);
            this.BillFirstNameText.MaxLength = 32767;
            this.BillFirstNameText.Name = "BillFirstNameText";
            this.BillFirstNameText.Size = new System.Drawing.Size(214, 33);
            this.BillFirstNameText.TabIndex = 24;
            this.BillFirstNameText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BillFirstNameText.OnValueChanged += new System.EventHandler(this.BillFirstNameText_OnValueChanged);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(72)))), ((int)(((byte)(72)))), ((int)(((byte)(72)))));
            this.bunifuSeparator1.LineThickness = 2;
            this.bunifuSeparator1.Location = new System.Drawing.Point(31, 47);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(708, 14);
            this.bunifuSeparator1.TabIndex = 23;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(550, 24);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(164, 22);
            this.bunifuCustomLabel4.TabIndex = 22;
            this.bunifuCustomLabel4.Text = "Card Information";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(289, 24);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(192, 22);
            this.bunifuCustomLabel3.TabIndex = 21;
            this.bunifuCustomLabel3.Text = "Shipping Infomation";
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(50, 24);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(176, 22);
            this.bunifuCustomLabel2.TabIndex = 20;
            this.bunifuCustomLabel2.Text = "Billing Information";
            // 
            // close_btn
            // 
            this.close_btn.BackColor = System.Drawing.Color.Transparent;
            this.close_btn.Image = global::BOTMAIN.Properties.Resources.cross;
            this.close_btn.ImageActive = null;
            this.close_btn.Location = new System.Drawing.Point(774, 11);
            this.close_btn.Margin = new System.Windows.Forms.Padding(2);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(15, 16);
            this.close_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close_btn.TabIndex = 17;
            this.close_btn.TabStop = false;
            this.close_btn.Zoom = 10;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 10;
            this.bunifuElipse2.TargetControl = this.MainPanel;
            // 
            // dragCon
            // 
            this.dragCon.Fixed = true;
            this.dragCon.Horizontal = true;
            this.dragCon.TargetControl = this.BackgroundPanel;
            this.dragCon.Vertical = true;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.TitleLBL;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.MainPanel;
            this.bunifuDragControl2.Vertical = true;
            // 
            // ProfileFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(800, 556);
            this.Controls.Add(this.BackgroundPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProfileFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADD PROFILE";
            this.Load += new System.EventHandler(this.ProfileFrm_Load);
            this.BackgroundPanel.ResumeLayout(false);
            this.BackgroundPanel.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel BackgroundPanel;
        private System.Windows.Forms.Panel MainPanel;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuCustomLabel TitleLBL;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox FriendlyNameText;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ShipFirstNameText;
        private Bunifu.Framework.UI.BunifuMaterialTextbox BillFirstNameText;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ShipLastName;
        private Bunifu.Framework.UI.BunifuMaterialTextbox BillLastNameText;
        private Bunifu.Framework.UI.BunifuDropdown CardTypeCombo;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.Framework.UI.BunifuDropdown MonthCombo;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ShipCityText;
        private Bunifu.Framework.UI.BunifuMaterialTextbox BillCityText;
        private Bunifu.Framework.UI.BunifuMaterialTextbox CardNumText;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ShipAddr2Text;
        private Bunifu.Framework.UI.BunifuMaterialTextbox BillAddr2Text;
        private Bunifu.Framework.UI.BunifuMaterialTextbox CardNameText;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ShipAddr1Text;
        private Bunifu.Framework.UI.BunifuMaterialTextbox BillAddr1Text;
        private Bunifu.Framework.UI.BunifuDropdown BillCountryCombo;
        private Bunifu.Framework.UI.BunifuMaterialTextbox SecurityCodeText;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ShipZipCodeText;
        private Bunifu.Framework.UI.BunifuMaterialTextbox BillZipCodeText;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel6;
        private Bunifu.Framework.UI.BunifuDropdown YearCombo;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ShipStateText;
        private Bunifu.Framework.UI.BunifuMaterialTextbox BillStateText;
        private Bunifu.Framework.UI.BunifuDropdown ShipCountryCombo;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ShipPhoneText;
        private Bunifu.Framework.UI.BunifuMaterialTextbox BillPhoneText;
        private Bunifu.Framework.UI.BunifuMaterialTextbox EmailText;
        private Bunifu.Framework.UI.BunifuCustomLabel ShippingLBL;
        private Bunifu.Framework.UI.BunifuCheckbox SameCheck;
        private Bunifu.Framework.UI.BunifuDragControl dragCon;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.Framework.UI.BunifuSeparator BillCountrySep;
        private Bunifu.Framework.UI.BunifuSeparator ShipCountrySep;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator4;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator3;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuImageButton close_btn;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton CreateBtn;
    }
}