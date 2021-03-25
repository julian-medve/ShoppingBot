namespace BOTMAIN
{
    partial class Captcha_rows
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
            this.num_label = new System.Windows.Forms.Label();
            this.gmail_label = new System.Windows.Forms.Label();
            this.editBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.delBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.enabled_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.editBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // num_label
            // 
            this.num_label.AutoSize = true;
            this.num_label.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_label.ForeColor = System.Drawing.Color.White;
            this.num_label.Location = new System.Drawing.Point(32, 12);
            this.num_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.num_label.Name = "num_label";
            this.num_label.Size = new System.Drawing.Size(15, 16);
            this.num_label.TabIndex = 0;
            this.num_label.Text = "#";
            // 
            // gmail_label
            // 
            this.gmail_label.AutoSize = true;
            this.gmail_label.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gmail_label.ForeColor = System.Drawing.Color.White;
            this.gmail_label.Location = new System.Drawing.Point(286, 12);
            this.gmail_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gmail_label.Name = "gmail_label";
            this.gmail_label.Size = new System.Drawing.Size(97, 16);
            this.gmail_label.TabIndex = 1;
            this.gmail_label.Text = "Gmail_Address";
            // 
            // editBtn
            // 
            this.editBtn.Image = global::BOTMAIN.Properties.Resources.edit_icon;
            this.editBtn.ImageActive = global::BOTMAIN.Properties.Resources.edit_icon;
            this.editBtn.Location = new System.Drawing.Point(810, 12);
            this.editBtn.Margin = new System.Windows.Forms.Padding(2);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(13, 13);
            this.editBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.editBtn.TabIndex = 4;
            this.editBtn.TabStop = false;
            this.editBtn.Zoom = 30;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // delBtn
            // 
            this.delBtn.Image = global::BOTMAIN.Properties.Resources.del_icon;
            this.delBtn.ImageActive = global::BOTMAIN.Properties.Resources.del_icon;
            this.delBtn.Location = new System.Drawing.Point(836, 12);
            this.delBtn.Margin = new System.Windows.Forms.Padding(2);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(13, 13);
            this.delBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.delBtn.TabIndex = 5;
            this.delBtn.TabStop = false;
            this.delBtn.Zoom = 30;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // enabled_label
            // 
            this.enabled_label.AutoSize = true;
            this.enabled_label.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enabled_label.ForeColor = System.Drawing.Color.White;
            this.enabled_label.Location = new System.Drawing.Point(644, 13);
            this.enabled_label.Name = "enabled_label";
            this.enabled_label.Size = new System.Drawing.Size(55, 16);
            this.enabled_label.TabIndex = 6;
            this.enabled_label.Text = "Enabled";
            // 
            // Captcha_rows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.Controls.Add(this.enabled_label);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.gmail_label);
            this.Controls.Add(this.num_label);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Captcha_rows";
            this.Size = new System.Drawing.Size(940, 41);
            this.Resize += new System.EventHandler(this.CaptchaRows_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.editBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delBtn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label num_label;
        private System.Windows.Forms.Label gmail_label;
        private Bunifu.Framework.UI.BunifuImageButton editBtn;
        private Bunifu.Framework.UI.BunifuImageButton delBtn;
        private System.Windows.Forms.Label enabled_label;
    }
}
