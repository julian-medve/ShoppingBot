using System.Windows.Forms;

namespace BOTMAIN
{
    partial class ProxyTestFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProxyTestFrm));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BackgroundPanel = new System.Windows.Forms.Panel();
            this.closeBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.saveProxyStatus = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.testResultText = new Bunifu.UI.WinForms.BunifuLabel();
            this.startBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.resultDataGridView = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.ProxyAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pingTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.countryName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chk = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.TestFrmLBL = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuDragControl1 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.bunifuDragControl2 = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.BackgroundPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).BeginInit();
            this.MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BackgroundPanel
            // 
            this.BackgroundPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BackgroundPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.BackgroundPanel.Controls.Add(this.closeBtn);
            this.BackgroundPanel.Controls.Add(this.MainPanel);
            this.BackgroundPanel.Controls.Add(this.TestFrmLBL);
            this.BackgroundPanel.Location = new System.Drawing.Point(0, 0);
            this.BackgroundPanel.Name = "BackgroundPanel";
            this.BackgroundPanel.Size = new System.Drawing.Size(1006, 594);
            this.BackgroundPanel.TabIndex = 0;
            // 
            // closeBtn
            // 
            this.closeBtn.Image = global::BOTMAIN.Properties.Resources.cross;
            this.closeBtn.ImageActive = null;
            this.closeBtn.Location = new System.Drawing.Point(979, 12);
            this.closeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(15, 16);
            this.closeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeBtn.TabIndex = 2;
            this.closeBtn.TabStop = false;
            this.closeBtn.Zoom = 10;
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.MainPanel.Controls.Add(this.saveProxyStatus);
            this.MainPanel.Controls.Add(this.testResultText);
            this.MainPanel.Controls.Add(this.startBtn);
            this.MainPanel.Controls.Add(this.resultDataGridView);
            this.MainPanel.Location = new System.Drawing.Point(12, 63);
            this.MainPanel.MinimumSize = new System.Drawing.Size(100, 35);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(982, 519);
            this.MainPanel.TabIndex = 1;
            // 
            // saveProxyStatus
            // 
            this.saveProxyStatus.AllowToggling = false;
            this.saveProxyStatus.AnimationSpeed = 200;
            this.saveProxyStatus.AutoGenerateColors = false;
            this.saveProxyStatus.BackColor = System.Drawing.Color.Transparent;
            this.saveProxyStatus.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.saveProxyStatus.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("saveProxyStatus.BackgroundImage")));
            this.saveProxyStatus.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.saveProxyStatus.ButtonText = "Save";
            this.saveProxyStatus.ButtonTextMarginLeft = 5;
            this.saveProxyStatus.ColorContrastOnClick = 45;
            this.saveProxyStatus.ColorContrastOnHover = 45;
            this.saveProxyStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.saveProxyStatus.CustomizableEdges = borderEdges1;
            this.saveProxyStatus.DialogResult = System.Windows.Forms.DialogResult.None;
            this.saveProxyStatus.DisabledBorderColor = System.Drawing.Color.Empty;
            this.saveProxyStatus.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.saveProxyStatus.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.saveProxyStatus.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.saveProxyStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveProxyStatus.ForeColor = System.Drawing.Color.White;
            this.saveProxyStatus.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.saveProxyStatus.IconMarginLeft = 11;
            this.saveProxyStatus.IconPadding = 10;
            this.saveProxyStatus.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.saveProxyStatus.IdleBorderColor = System.Drawing.Color.Gray;
            this.saveProxyStatus.IdleBorderRadius = 30;
            this.saveProxyStatus.IdleBorderThickness = 2;
            this.saveProxyStatus.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.saveProxyStatus.IdleIconLeftImage = global::BOTMAIN.Properties.Resources.save9;
            this.saveProxyStatus.IdleIconRightImage = null;
            this.saveProxyStatus.IndicateFocus = false;
            this.saveProxyStatus.Location = new System.Drawing.Point(845, 451);
            this.saveProxyStatus.Name = "saveProxyStatus";
            stateProperties1.BorderColor = System.Drawing.Color.White;
            stateProperties1.BorderRadius = 30;
            stateProperties1.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties1.BorderThickness = 2;
            stateProperties1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            stateProperties1.ForeColor = System.Drawing.Color.White;
            stateProperties1.IconLeftImage = null;
            stateProperties1.IconRightImage = null;
            this.saveProxyStatus.onHoverState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.White;
            stateProperties2.BorderRadius = 30;
            stateProperties2.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties2.BorderThickness = 2;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            stateProperties2.ForeColor = System.Drawing.Color.White;
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.saveProxyStatus.OnPressedState = stateProperties2;
            this.saveProxyStatus.Size = new System.Drawing.Size(120, 36);
            this.saveProxyStatus.TabIndex = 6;
            this.saveProxyStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.saveProxyStatus.TextMarginLeft = 5;
            this.saveProxyStatus.UseDefaultRadiusAndThickness = true;
            this.saveProxyStatus.Click += new System.EventHandler(this.saveProxyStatus_Click);
            // 
            // testResultText
            // 
            this.testResultText.AutoEllipsis = false;
            this.testResultText.CursorType = null;
            this.testResultText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.testResultText.Location = new System.Drawing.Point(289, 427);
            this.testResultText.Name = "testResultText";
            this.testResultText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.testResultText.Size = new System.Drawing.Size(0, 0);
            this.testResultText.TabIndex = 5;
            this.testResultText.Text = null;
            this.testResultText.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.testResultText.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // startBtn
            // 
            this.startBtn.AllowToggling = false;
            this.startBtn.AnimationSpeed = 200;
            this.startBtn.AutoGenerateColors = false;
            this.startBtn.BackColor = System.Drawing.Color.Transparent;
            this.startBtn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.startBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("startBtn.BackgroundImage")));
            this.startBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.startBtn.ButtonText = "Start";
            this.startBtn.ButtonTextMarginLeft = 5;
            this.startBtn.ColorContrastOnClick = 45;
            this.startBtn.ColorContrastOnHover = 45;
            this.startBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.startBtn.CustomizableEdges = borderEdges2;
            this.startBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.startBtn.DisabledBorderColor = System.Drawing.Color.Empty;
            this.startBtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.startBtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.startBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.startBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startBtn.ForeColor = System.Drawing.Color.White;
            this.startBtn.IconLeftCursor = System.Windows.Forms.Cursors.Hand;
            this.startBtn.IconMarginLeft = 11;
            this.startBtn.IconPadding = 10;
            this.startBtn.IconRightCursor = System.Windows.Forms.Cursors.Hand;
            this.startBtn.IdleBorderColor = System.Drawing.Color.Gray;
            this.startBtn.IdleBorderRadius = 30;
            this.startBtn.IdleBorderThickness = 2;
            this.startBtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.startBtn.IdleIconLeftImage = global::BOTMAIN.Properties.Resources.play_icon;
            this.startBtn.IdleIconRightImage = null;
            this.startBtn.IndicateFocus = false;
            this.startBtn.Location = new System.Drawing.Point(703, 451);
            this.startBtn.Name = "startBtn";
            stateProperties3.BorderColor = System.Drawing.Color.White;
            stateProperties3.BorderRadius = 30;
            stateProperties3.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties3.BorderThickness = 2;
            stateProperties3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            stateProperties3.ForeColor = System.Drawing.Color.White;
            stateProperties3.IconLeftImage = null;
            stateProperties3.IconRightImage = null;
            this.startBtn.onHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.White;
            stateProperties4.BorderRadius = 30;
            stateProperties4.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            stateProperties4.BorderThickness = 2;
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            stateProperties4.ForeColor = System.Drawing.Color.White;
            stateProperties4.IconLeftImage = null;
            stateProperties4.IconRightImage = null;
            this.startBtn.OnPressedState = stateProperties4;
            this.startBtn.Size = new System.Drawing.Size(120, 36);
            this.startBtn.TabIndex = 4;
            this.startBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.startBtn.TextMarginLeft = 5;
            this.startBtn.UseDefaultRadiusAndThickness = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // resultDataGridView
            // 
            this.resultDataGridView.AllowCustomTheming = false;
            this.resultDataGridView.AllowUserToAddRows = false;
            this.resultDataGridView.AllowUserToDeleteRows = false;
            this.resultDataGridView.AllowUserToOrderColumns = true;
            this.resultDataGridView.AllowUserToResizeColumns = false;
            this.resultDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            this.resultDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.resultDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.resultDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.resultDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.resultDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.resultDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.resultDataGridView.ColumnHeadersHeight = 40;
            this.resultDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProxyAddress,
            this.pingTime,
            this.status,
            this.countryName,
            this.chk});
            this.resultDataGridView.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(48)))), ((int)(((byte)(52)))));
            this.resultDataGridView.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.resultDataGridView.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.White;
            this.resultDataGridView.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.resultDataGridView.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.resultDataGridView.CurrentTheme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.resultDataGridView.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.resultDataGridView.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.resultDataGridView.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.resultDataGridView.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.resultDataGridView.CurrentTheme.Name = null;
            this.resultDataGridView.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            this.resultDataGridView.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.resultDataGridView.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.White;
            this.resultDataGridView.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            this.resultDataGridView.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(41)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(117)))), ((int)(((byte)(119)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.resultDataGridView.DefaultCellStyle = dataGridViewCellStyle4;
            this.resultDataGridView.EnableHeadersVisualStyles = false;
            this.resultDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(56)))), ((int)(((byte)(62)))));
            this.resultDataGridView.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.resultDataGridView.HeaderBgColor = System.Drawing.Color.Empty;
            this.resultDataGridView.HeaderForeColor = System.Drawing.Color.White;
            this.resultDataGridView.Location = new System.Drawing.Point(16, 49);
            this.resultDataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.resultDataGridView.Name = "resultDataGridView";
            this.resultDataGridView.RowHeadersVisible = false;
            this.resultDataGridView.RowHeadersWidth = 25;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.resultDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.resultDataGridView.RowTemplate.Height = 40;
            this.resultDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.resultDataGridView.Size = new System.Drawing.Size(949, 366);
            this.resultDataGridView.TabIndex = 2;
            this.resultDataGridView.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Dark;
            this.resultDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.resultDataGridView_CellContentClick);
            // 
            // ProxyAddress
            // 
            this.ProxyAddress.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 10);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProxyAddress.DefaultCellStyle = dataGridViewCellStyle3;
            this.ProxyAddress.FillWeight = 120.5228F;
            this.ProxyAddress.HeaderText = "ProxyAddress";
            this.ProxyAddress.Name = "ProxyAddress";
            this.ProxyAddress.ReadOnly = true;
            // 
            // pingTime
            // 
            this.pingTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.pingTime.FillWeight = 120.4924F;
            this.pingTime.HeaderText = "ResponseTime(ms)";
            this.pingTime.Name = "pingTime";
            this.pingTime.ReadOnly = true;
            // 
            // status
            // 
            this.status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.status.FillWeight = 120.4924F;
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            // 
            // countryName
            // 
            this.countryName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.countryName.FillWeight = 120.4924F;
            this.countryName.HeaderText = "Country";
            this.countryName.Name = "countryName";
            this.countryName.ReadOnly = true;
            // 
            // chk
            // 
            this.chk.HeaderText = "Use";
            this.chk.Name = "chk";
            // 
            // TestFrmLBL
            // 
            this.TestFrmLBL.AutoSize = true;
            this.TestFrmLBL.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TestFrmLBL.ForeColor = System.Drawing.Color.White;
            this.TestFrmLBL.Location = new System.Drawing.Point(24, 36);
            this.TestFrmLBL.Name = "TestFrmLBL";
            this.TestFrmLBL.Size = new System.Drawing.Size(181, 24);
            this.TestFrmLBL.TabIndex = 0;
            this.TestFrmLBL.Text = "ProxyTester(kith)";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 15;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 10;
            this.bunifuElipse2.TargetControl = this.MainPanel;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.BackgroundPanel;
            this.bunifuDragControl1.Vertical = true;
            // 
            // bunifuDragControl2
            // 
            this.bunifuDragControl2.Fixed = true;
            this.bunifuDragControl2.Horizontal = true;
            this.bunifuDragControl2.TargetControl = this.TestFrmLBL;
            this.bunifuDragControl2.Vertical = true;
            // 
            // ProxyTestFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.ClientSize = new System.Drawing.Size(1006, 594);
            this.Controls.Add(this.BackgroundPanel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProxyTestFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProxyTestFrm";
            this.Load += new System.EventHandler(this.ProxyTestFrm_Load);
            this.BackgroundPanel.ResumeLayout(false);
            this.BackgroundPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeBtn)).EndInit();
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resultDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BackgroundPanel;
        private System.Windows.Forms.Label TestFrmLBL;
        private System.Windows.Forms.Panel MainPanel;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl1;
        private Bunifu.Framework.UI.BunifuDragControl bunifuDragControl2;
        private Bunifu.UI.WinForms.BunifuDataGridView resultDataGridView;
        private Bunifu.Framework.UI.BunifuImageButton closeBtn;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton startBtn;
        private Bunifu.UI.WinForms.BunifuLabel testResultText;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProxyAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn pingTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
        private System.Windows.Forms.DataGridViewTextBoxColumn countryName;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton saveProxyStatus;
        private DataGridViewCheckBoxColumn chk;
    }
}