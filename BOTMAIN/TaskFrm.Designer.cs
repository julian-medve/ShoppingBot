namespace BOTMAIN
{
    partial class TaskFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskFrm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.BackgroundPanel = new System.Windows.Forms.Panel();
            this.Main_Panel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.SaveBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.BillingSep = new Bunifu.Framework.UI.BunifuSeparator();
            this.ModeSep = new Bunifu.Framework.UI.BunifuSeparator();
            this.LinkSep = new Bunifu.Framework.UI.BunifuSeparator();
            this.SiteSep = new Bunifu.Framework.UI.BunifuSeparator();
            this.GuestLBL = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.GuestCheck = new Bunifu.Framework.UI.BunifuCheckbox();
            this.CaptchaLBL = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.CaptchaCheck = new Bunifu.Framework.UI.BunifuCheckbox();
            this.BillingCombo = new Bunifu.Framework.UI.BunifuDropdown();
            this.ShippingText = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.MaxPriceText = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.MinPriceText = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.LinkText = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.SizeText = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.ModeCombo = new Bunifu.Framework.UI.BunifuDropdown();
            this.LinkCombo = new Bunifu.Framework.UI.BunifuDropdown();
            this.PassText = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.EmailText = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.SiteCombo = new Bunifu.Framework.UI.BunifuDropdown();
            this.TitleLBL = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.close_btn = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.BackgroundPanel.SuspendLayout();
            this.Main_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).BeginInit();
            this.SuspendLayout();
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
            this.bunifuDragControl1.TargetControl = this.BackgroundPanel;
            this.bunifuDragControl1.Vertical = true;
            // 
            // BackgroundPanel
            // 
            this.BackgroundPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.BackgroundPanel.Controls.Add(this.Main_Panel);
            this.BackgroundPanel.Controls.Add(this.TitleLBL);
            this.BackgroundPanel.Controls.Add(this.close_btn);
            this.BackgroundPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackgroundPanel.Location = new System.Drawing.Point(0, 0);
            this.BackgroundPanel.Name = "BackgroundPanel";
            this.BackgroundPanel.Size = new System.Drawing.Size(800, 450);
            this.BackgroundPanel.TabIndex = 0;
            // 
            // Main_Panel
            // 
            this.Main_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Main_Panel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Main_Panel.BackgroundImage")));
            this.Main_Panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Main_Panel.Controls.Add(this.SaveBtn);
            this.Main_Panel.Controls.Add(this.BillingSep);
            this.Main_Panel.Controls.Add(this.ModeSep);
            this.Main_Panel.Controls.Add(this.LinkSep);
            this.Main_Panel.Controls.Add(this.SiteSep);
            this.Main_Panel.Controls.Add(this.GuestLBL);
            this.Main_Panel.Controls.Add(this.GuestCheck);
            this.Main_Panel.Controls.Add(this.CaptchaLBL);
            this.Main_Panel.Controls.Add(this.CaptchaCheck);
            this.Main_Panel.Controls.Add(this.BillingCombo);
            this.Main_Panel.Controls.Add(this.ShippingText);
            this.Main_Panel.Controls.Add(this.MaxPriceText);
            this.Main_Panel.Controls.Add(this.MinPriceText);
            this.Main_Panel.Controls.Add(this.LinkText);
            this.Main_Panel.Controls.Add(this.SizeText);
            this.Main_Panel.Controls.Add(this.ModeCombo);
            this.Main_Panel.Controls.Add(this.LinkCombo);
            this.Main_Panel.Controls.Add(this.PassText);
            this.Main_Panel.Controls.Add(this.EmailText);
            this.Main_Panel.Controls.Add(this.SiteCombo);
            this.Main_Panel.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.Main_Panel.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.Main_Panel.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.Main_Panel.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.Main_Panel.Location = new System.Drawing.Point(11, 53);
            this.Main_Panel.Name = "Main_Panel";
            this.Main_Panel.Quality = 10;
            this.Main_Panel.Size = new System.Drawing.Size(776, 387);
            this.Main_Panel.TabIndex = 18;
            // 
            // SaveBtn
            // 
            this.SaveBtn.AllowToggling = false;
            this.SaveBtn.AnimationSpeed = 200;
            this.SaveBtn.AutoGenerateColors = false;
            this.SaveBtn.BackColor = System.Drawing.Color.Transparent;
            this.SaveBtn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.SaveBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SaveBtn.BackgroundImage")));
            this.SaveBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SaveBtn.ButtonText = "Save";
            this.SaveBtn.ButtonTextMarginLeft = 5;
            this.SaveBtn.ColorContrastOnClick = 45;
            this.SaveBtn.ColorContrastOnHover = 45;
            this.SaveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.SaveBtn.CustomizableEdges = borderEdges3;
            this.SaveBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.SaveBtn.DisabledBorderColor = System.Drawing.Color.Empty;
            this.SaveBtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.SaveBtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.SaveBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.SaveBtn.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.ForeColor = System.Drawing.Color.White;
            this.SaveBtn.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.SaveBtn.IconMarginLeft = 11;
            this.SaveBtn.IconPadding = 10;
            this.SaveBtn.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.SaveBtn.IdleBorderColor = System.Drawing.Color.Gray;
            this.SaveBtn.IdleBorderRadius = 30;
            this.SaveBtn.IdleBorderThickness = 2;
            this.SaveBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.SaveBtn.IdleIconLeftImage = global::BOTMAIN.Properties.Resources.save9;
            this.SaveBtn.IdleIconRightImage = null;
            this.SaveBtn.IndicateFocus = false;
            this.SaveBtn.Location = new System.Drawing.Point(638, 330);
            this.SaveBtn.Name = "SaveBtn";
            stateProperties5.BorderColor = System.Drawing.Color.White;
            stateProperties5.BorderRadius = 30;
            stateProperties5.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties5.BorderThickness = 2;
            stateProperties5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            stateProperties5.ForeColor = System.Drawing.Color.White;
            stateProperties5.IconLeftImage = null;
            stateProperties5.IconRightImage = null;
            this.SaveBtn.onHoverState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.White;
            stateProperties6.BorderRadius = 30;
            stateProperties6.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties6.BorderThickness = 2;
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            stateProperties6.ForeColor = System.Drawing.Color.White;
            stateProperties6.IconLeftImage = null;
            stateProperties6.IconRightImage = null;
            this.SaveBtn.OnPressedState = stateProperties6;
            this.SaveBtn.Size = new System.Drawing.Size(120, 36);
            this.SaveBtn.TabIndex = 63;
            this.SaveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SaveBtn.TextMarginLeft = 5;
            this.SaveBtn.UseDefaultRadiusAndThickness = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // BillingSep
            // 
            this.BillingSep.BackColor = System.Drawing.Color.Transparent;
            this.BillingSep.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BillingSep.LineThickness = 1;
            this.BillingSep.Location = new System.Drawing.Point(24, 341);
            this.BillingSep.Name = "BillingSep";
            this.BillingSep.Size = new System.Drawing.Size(208, 2);
            this.BillingSep.TabIndex = 61;
            this.BillingSep.Transparency = 255;
            this.BillingSep.Vertical = false;
            // 
            // ModeSep
            // 
            this.ModeSep.BackColor = System.Drawing.Color.Transparent;
            this.ModeSep.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ModeSep.LineThickness = 1;
            this.ModeSep.Location = new System.Drawing.Point(287, 173);
            this.ModeSep.Name = "ModeSep";
            this.ModeSep.Size = new System.Drawing.Size(208, 2);
            this.ModeSep.TabIndex = 60;
            this.ModeSep.Transparency = 255;
            this.ModeSep.Vertical = false;
            // 
            // LinkSep
            // 
            this.LinkSep.BackColor = System.Drawing.Color.Transparent;
            this.LinkSep.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.LinkSep.LineThickness = 1;
            this.LinkSep.Location = new System.Drawing.Point(24, 173);
            this.LinkSep.Name = "LinkSep";
            this.LinkSep.Size = new System.Drawing.Size(208, 2);
            this.LinkSep.TabIndex = 59;
            this.LinkSep.Transparency = 255;
            this.LinkSep.Vertical = false;
            // 
            // SiteSep
            // 
            this.SiteSep.BackColor = System.Drawing.Color.Transparent;
            this.SiteSep.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.SiteSep.LineThickness = 1;
            this.SiteSep.Location = new System.Drawing.Point(24, 57);
            this.SiteSep.Name = "SiteSep";
            this.SiteSep.Size = new System.Drawing.Size(208, 2);
            this.SiteSep.TabIndex = 58;
            this.SiteSep.Transparency = 255;
            this.SiteSep.Vertical = false;
            // 
            // GuestLBL
            // 
            this.GuestLBL.AutoSize = true;
            this.GuestLBL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.GuestLBL.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GuestLBL.ForeColor = System.Drawing.Color.White;
            this.GuestLBL.Location = new System.Drawing.Point(504, 41);
            this.GuestLBL.Name = "GuestLBL";
            this.GuestLBL.Size = new System.Drawing.Size(47, 17);
            this.GuestLBL.TabIndex = 15;
            this.GuestLBL.Text = "Guest";
            this.GuestLBL.Click += new System.EventHandler(this.GuestLBL_Click);
            // 
            // GuestCheck
            // 
            this.GuestCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.GuestCheck.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.GuestCheck.Checked = true;
            this.GuestCheck.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.GuestCheck.ForeColor = System.Drawing.Color.White;
            this.GuestCheck.Location = new System.Drawing.Point(480, 39);
            this.GuestCheck.Name = "GuestCheck";
            this.GuestCheck.Size = new System.Drawing.Size(20, 20);
            this.GuestCheck.TabIndex = 14;
            this.GuestCheck.OnChange += new System.EventHandler(this.GuestCheck_OnChange);
            // 
            // CaptchaLBL
            // 
            this.CaptchaLBL.AutoSize = true;
            this.CaptchaLBL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.CaptchaLBL.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptchaLBL.ForeColor = System.Drawing.Color.White;
            this.CaptchaLBL.Location = new System.Drawing.Point(294, 41);
            this.CaptchaLBL.Name = "CaptchaLBL";
            this.CaptchaLBL.Size = new System.Drawing.Size(147, 17);
            this.CaptchaLBL.TabIndex = 13;
            this.CaptchaLBL.Text = "Task without Captcha";
            this.CaptchaLBL.Click += new System.EventHandler(this.CaptchaLBL_Click);
            // 
            // CaptchaCheck
            // 
            this.CaptchaCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.CaptchaCheck.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.CaptchaCheck.Checked = false;
            this.CaptchaCheck.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.CaptchaCheck.ForeColor = System.Drawing.Color.White;
            this.CaptchaCheck.Location = new System.Drawing.Point(268, 38);
            this.CaptchaCheck.Name = "CaptchaCheck";
            this.CaptchaCheck.Size = new System.Drawing.Size(20, 20);
            this.CaptchaCheck.TabIndex = 12;
            // 
            // BillingCombo
            // 
            this.BillingCombo.BackColor = System.Drawing.Color.Transparent;
            this.BillingCombo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BillingCombo.BorderRadius = 7;
            this.BillingCombo.DisabledColor = System.Drawing.Color.Gray;
            this.BillingCombo.ForeColor = System.Drawing.Color.Gray;
            this.BillingCombo.items = new string[] {
        "Select a Billing"};
            this.BillingCombo.Location = new System.Drawing.Point(24, 315);
            this.BillingCombo.Margin = new System.Windows.Forms.Padding(4);
            this.BillingCombo.Name = "BillingCombo";
            this.BillingCombo.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.BillingCombo.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.BillingCombo.selectedIndex = 0;
            this.BillingCombo.Size = new System.Drawing.Size(208, 28);
            this.BillingCombo.TabIndex = 10;
            this.BillingCombo.onItemSelected += new System.EventHandler(this.BillingCombo_onItemSelected);
            // 
            // ShippingText
            // 
            this.ShippingText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.ShippingText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.ShippingText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ShippingText.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.ShippingText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ShippingText.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.ShippingText.ForeColor = System.Drawing.Color.White;
            this.ShippingText.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.ShippingText.HintText = "Shipping Rate";
            this.ShippingText.isPassword = false;
            this.ShippingText.LineFocusedColor = System.Drawing.Color.White;
            this.ShippingText.LineIdleColor = System.Drawing.Color.Gray;
            this.ShippingText.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.ShippingText.LineThickness = 2;
            this.ShippingText.Location = new System.Drawing.Point(550, 256);
            this.ShippingText.Margin = new System.Windows.Forms.Padding(4);
            this.ShippingText.MaxLength = 32767;
            this.ShippingText.Name = "ShippingText";
            this.ShippingText.Size = new System.Drawing.Size(208, 33);
            this.ShippingText.TabIndex = 9;
            this.ShippingText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // MaxPriceText
            // 
            this.MaxPriceText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.MaxPriceText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.MaxPriceText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.MaxPriceText.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.MaxPriceText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MaxPriceText.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.MaxPriceText.ForeColor = System.Drawing.Color.White;
            this.MaxPriceText.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.MaxPriceText.HintText = "Max Price";
            this.MaxPriceText.isPassword = false;
            this.MaxPriceText.LineFocusedColor = System.Drawing.Color.White;
            this.MaxPriceText.LineIdleColor = System.Drawing.Color.Gray;
            this.MaxPriceText.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.MaxPriceText.LineThickness = 2;
            this.MaxPriceText.Location = new System.Drawing.Point(287, 256);
            this.MaxPriceText.Margin = new System.Windows.Forms.Padding(4);
            this.MaxPriceText.MaxLength = 32767;
            this.MaxPriceText.Name = "MaxPriceText";
            this.MaxPriceText.Size = new System.Drawing.Size(208, 33);
            this.MaxPriceText.TabIndex = 8;
            this.MaxPriceText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // MinPriceText
            // 
            this.MinPriceText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.MinPriceText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.MinPriceText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.MinPriceText.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.MinPriceText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.MinPriceText.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.MinPriceText.ForeColor = System.Drawing.Color.White;
            this.MinPriceText.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.MinPriceText.HintText = "Min Price";
            this.MinPriceText.isPassword = false;
            this.MinPriceText.LineFocusedColor = System.Drawing.Color.White;
            this.MinPriceText.LineIdleColor = System.Drawing.Color.Gray;
            this.MinPriceText.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.MinPriceText.LineThickness = 2;
            this.MinPriceText.Location = new System.Drawing.Point(24, 256);
            this.MinPriceText.Margin = new System.Windows.Forms.Padding(4);
            this.MinPriceText.MaxLength = 32767;
            this.MinPriceText.Name = "MinPriceText";
            this.MinPriceText.Size = new System.Drawing.Size(208, 33);
            this.MinPriceText.TabIndex = 7;
            this.MinPriceText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // LinkText
            // 
            this.LinkText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.LinkText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.LinkText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.LinkText.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.LinkText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.LinkText.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.LinkText.ForeColor = System.Drawing.Color.White;
            this.LinkText.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.LinkText.HintText = "Early Link";
            this.LinkText.isPassword = false;
            this.LinkText.LineFocusedColor = System.Drawing.Color.White;
            this.LinkText.LineIdleColor = System.Drawing.Color.Gray;
            this.LinkText.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.LinkText.LineThickness = 2;
            this.LinkText.Location = new System.Drawing.Point(24, 197);
            this.LinkText.Margin = new System.Windows.Forms.Padding(4);
            this.LinkText.MaxLength = 32767;
            this.LinkText.Name = "LinkText";
            this.LinkText.Size = new System.Drawing.Size(735, 33);
            this.LinkText.TabIndex = 6;
            this.LinkText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.LinkText.OnValueChanged += new System.EventHandler(this.Text_OnValueChanged);
            // 
            // SizeText
            // 
            this.SizeText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.SizeText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.SizeText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.SizeText.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.SizeText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SizeText.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.SizeText.ForeColor = System.Drawing.Color.White;
            this.SizeText.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.SizeText.HintText = "Size";
            this.SizeText.isPassword = false;
            this.SizeText.LineFocusedColor = System.Drawing.Color.White;
            this.SizeText.LineIdleColor = System.Drawing.Color.Gray;
            this.SizeText.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.SizeText.LineThickness = 2;
            this.SizeText.Location = new System.Drawing.Point(550, 142);
            this.SizeText.Margin = new System.Windows.Forms.Padding(4);
            this.SizeText.MaxLength = 32767;
            this.SizeText.Name = "SizeText";
            this.SizeText.Size = new System.Drawing.Size(208, 33);
            this.SizeText.TabIndex = 5;
            this.SizeText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SizeText.OnValueChanged += new System.EventHandler(this.Text_OnValueChanged);
            // 
            // ModeCombo
            // 
            this.ModeCombo.BackColor = System.Drawing.Color.Transparent;
            this.ModeCombo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ModeCombo.BorderRadius = 7;
            this.ModeCombo.DisabledColor = System.Drawing.Color.Gray;
            this.ModeCombo.ForeColor = System.Drawing.Color.White;
            this.ModeCombo.items = new string[] {
        "Fast Mode",
        "CEF Mode"};
            this.ModeCombo.Location = new System.Drawing.Point(287, 147);
            this.ModeCombo.Margin = new System.Windows.Forms.Padding(4);
            this.ModeCombo.Name = "ModeCombo";
            this.ModeCombo.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ModeCombo.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.ModeCombo.selectedIndex = 0;
            this.ModeCombo.Size = new System.Drawing.Size(208, 28);
            this.ModeCombo.TabIndex = 4;
            // 
            // LinkCombo
            // 
            this.LinkCombo.BackColor = System.Drawing.Color.Transparent;
            this.LinkCombo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LinkCombo.BorderRadius = 7;
            this.LinkCombo.DisabledColor = System.Drawing.Color.Gray;
            this.LinkCombo.ForeColor = System.Drawing.Color.Gray;
            this.LinkCombo.items = new string[] {
        "Select Input Type",
        "Early Link",
        "Keyword",
        "Variant"};
            this.LinkCombo.Location = new System.Drawing.Point(24, 147);
            this.LinkCombo.Margin = new System.Windows.Forms.Padding(4);
            this.LinkCombo.Name = "LinkCombo";
            this.LinkCombo.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.LinkCombo.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.LinkCombo.selectedIndex = 0;
            this.LinkCombo.Size = new System.Drawing.Size(208, 28);
            this.LinkCombo.TabIndex = 3;
            this.LinkCombo.onItemSelected += new System.EventHandler(this.LinkCombo_onItemSelected);
            // 
            // PassText
            // 
            this.PassText.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.PassText.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.PassText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.PassText.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.PassText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PassText.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.PassText.ForeColor = System.Drawing.Color.White;
            this.PassText.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.PassText.HintText = "Password";
            this.PassText.isPassword = false;
            this.PassText.LineFocusedColor = System.Drawing.Color.White;
            this.PassText.LineIdleColor = System.Drawing.Color.Gray;
            this.PassText.LineMouseHoverColor = System.Drawing.Color.Gray;
            this.PassText.LineThickness = 2;
            this.PassText.Location = new System.Drawing.Point(425, 84);
            this.PassText.Margin = new System.Windows.Forms.Padding(4);
            this.PassText.MaxLength = 32767;
            this.PassText.Name = "PassText";
            this.PassText.Size = new System.Drawing.Size(334, 33);
            this.PassText.TabIndex = 2;
            this.PassText.Text = "Guest";
            this.PassText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PassText.OnValueChanged += new System.EventHandler(this.Text_OnValueChanged);
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
            this.EmailText.Location = new System.Drawing.Point(24, 84);
            this.EmailText.Margin = new System.Windows.Forms.Padding(4);
            this.EmailText.MaxLength = 32767;
            this.EmailText.Name = "EmailText";
            this.EmailText.Size = new System.Drawing.Size(334, 33);
            this.EmailText.TabIndex = 1;
            this.EmailText.Text = "Guest.958686";
            this.EmailText.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.EmailText.OnValueChanged += new System.EventHandler(this.Text_OnValueChanged);
            // 
            // SiteCombo
            // 
            this.SiteCombo.BackColor = System.Drawing.Color.Transparent;
            this.SiteCombo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SiteCombo.BorderRadius = 7;
            this.SiteCombo.DisabledColor = System.Drawing.Color.Gray;
            this.SiteCombo.ForeColor = System.Drawing.Color.Gray;
            this.SiteCombo.items = new string[] {"Select Site Name"};
            this.SiteCombo.Location = new System.Drawing.Point(24, 30);
            this.SiteCombo.Margin = new System.Windows.Forms.Padding(4);
            this.SiteCombo.Name = "SiteCombo";
            this.SiteCombo.NomalColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.SiteCombo.onHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.SiteCombo.selectedIndex = 0;
            this.SiteCombo.Size = new System.Drawing.Size(208, 28);
            this.SiteCombo.TabIndex = 0;
            this.SiteCombo.onItemSelected += new System.EventHandler(this.SiteCombo_onItemSelected);
            // 
            // TitleLBL
            // 
            this.TitleLBL.AutoSize = true;
            this.TitleLBL.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLBL.ForeColor = System.Drawing.Color.White;
            this.TitleLBL.Location = new System.Drawing.Point(31, 26);
            this.TitleLBL.Name = "TitleLBL";
            this.TitleLBL.Size = new System.Drawing.Size(116, 24);
            this.TitleLBL.TabIndex = 17;
            this.TitleLBL.Text = "ADD TASK";
            // 
            // close_btn
            // 
            this.close_btn.BackColor = System.Drawing.Color.Transparent;
            this.close_btn.Image = global::BOTMAIN.Properties.Resources.cross;
            this.close_btn.ImageActive = null;
            this.close_btn.Location = new System.Drawing.Point(775, 11);
            this.close_btn.Margin = new System.Windows.Forms.Padding(2);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(15, 16);
            this.close_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.close_btn.TabIndex = 16;
            this.close_btn.TabStop = false;
            this.close_btn.Zoom = 10;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 10;
            this.bunifuElipse2.TargetControl = this.Main_Panel;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 20;
            this.bunifuElipse3.TargetControl = this;
            // 
            // TaskFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BackgroundPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Location = new System.Drawing.Point(250, 0);
            this.Name = "TaskFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ADD TASK";
            this.Load += new System.EventHandler(this.TaskFrm_Load);
            this.BackgroundPanel.ResumeLayout(false);
            this.BackgroundPanel.PerformLayout();
            this.Main_Panel.ResumeLayout(false);
            this.Main_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.close_btn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private System.Windows.Forms.Panel BackgroundPanel;
        private Bunifu.Framework.UI.BunifuGradientPanel Main_Panel;
        private Bunifu.Framework.UI.BunifuDropdown BillingCombo;
        private Bunifu.Framework.UI.BunifuMaterialTextbox ShippingText;
        private Bunifu.Framework.UI.BunifuMaterialTextbox MaxPriceText;
        private Bunifu.Framework.UI.BunifuMaterialTextbox MinPriceText;
        private Bunifu.Framework.UI.BunifuMaterialTextbox LinkText;
        private Bunifu.Framework.UI.BunifuMaterialTextbox SizeText;
        private Bunifu.Framework.UI.BunifuDropdown ModeCombo;
        private Bunifu.Framework.UI.BunifuDropdown LinkCombo;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PassText;
        private Bunifu.Framework.UI.BunifuMaterialTextbox EmailText;
        private Bunifu.Framework.UI.BunifuDropdown SiteCombo;
        private Bunifu.Framework.UI.BunifuImageButton close_btn;
        private Bunifu.Framework.UI.BunifuCheckbox CaptchaCheck;
        private Bunifu.Framework.UI.BunifuCustomLabel CaptchaLBL;
        private Bunifu.Framework.UI.BunifuCustomLabel GuestLBL;
        private Bunifu.Framework.UI.BunifuCheckbox GuestCheck;
        private Bunifu.Framework.UI.BunifuSeparator BillingSep;
        private Bunifu.Framework.UI.BunifuSeparator ModeSep;
        private Bunifu.Framework.UI.BunifuSeparator LinkSep;
        private Bunifu.Framework.UI.BunifuSeparator SiteSep;
        public Bunifu.Framework.UI.BunifuCustomLabel TitleLBL;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton SaveBtn;
    }
}