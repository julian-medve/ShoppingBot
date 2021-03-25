namespace BOTMAIN
{
    partial class TaskHeader_Rows
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TitleLBL = new System.Windows.Forms.Label();
            this.UpDownBtn = new Bunifu.Framework.UI.BunifuImageButton();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // TitleLBL
            // 
            this.TitleLBL.AutoSize = true;
            this.TitleLBL.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLBL.ForeColor = System.Drawing.Color.Aqua;
            this.TitleLBL.Location = new System.Drawing.Point(24, 4);
            this.TitleLBL.Name = "TitleLBL";
            this.TitleLBL.Size = new System.Drawing.Size(109, 18);
            this.TitleLBL.TabIndex = 1;
            this.TitleLBL.Text = "YeezySupply";
            // 
            // UpDownBtn
            // 
            this.UpDownBtn.BackColor = System.Drawing.Color.Transparent;
            this.UpDownBtn.Image = global::BOTMAIN.Properties.Resources.up1;
            this.UpDownBtn.ImageActive = null;
            this.UpDownBtn.Location = new System.Drawing.Point(7, 7);
            this.UpDownBtn.Name = "UpDownBtn";
            this.UpDownBtn.Size = new System.Drawing.Size(12, 12);
            this.UpDownBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UpDownBtn.TabIndex = 0;
            this.UpDownBtn.TabStop = false;
            this.UpDownBtn.Zoom = 20;
            this.UpDownBtn.Click += new System.EventHandler(this.UpDownBtn_Click);
            // 
            // TaskHeader_Rows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.TitleLBL);
            this.Controls.Add(this.UpDownBtn);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "TaskHeader_Rows";
            this.Size = new System.Drawing.Size(1090, 25);
            this.Load += new System.EventHandler(this.TaskHeader_Rows_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UpDownBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton UpDownBtn;
        public System.Windows.Forms.Label TitleLBL;
    }
}
