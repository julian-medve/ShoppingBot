using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BOTMAIN.EntityModels;

namespace BOTMAIN
{
    public partial class Captcha : UserControl
    {
        IntPtr ptr = new IntPtr();
        public int rows_count = 0;
        public Captcha()
        {
            InitializeComponent();
        }
        public Captcha(IntPtr frm)
        {
            ptr = frm;
            InitializeComponent();
        }
        private void Captcha_Resize(object sender, System.EventArgs e)
        {
            Int32 hWidth = this.header_panel.Width;
            this.lblMail.Location = new System.Drawing.Point(Convert.ToInt32(hWidth * 0.35), 5);
            //this.lblProxy.Location = new System.Drawing.Point(Convert.ToInt32(hWidth * 0.47), 5);
            this.lblEnabled.Location = new System.Drawing.Point(Convert.ToInt32(hWidth * 0.675), 5);
            this.lblAction.Location = new System.Drawing.Point(Convert.ToInt32(hWidth * 0.845), 5);

            this.addBtn.Location = new System.Drawing.Point(hWidth - 373, 24);
            this.deleteAllBtn.Location = new System.Drawing.Point(hWidth - 185, 24);

            for (int i = 0; i < this.Grid_Panel.Controls.Count; i++)
            {
                this.Grid_Panel.Controls[i].Width = Grid_Panel.Width;
            }
        }

        public void Add_Row()
        {
            Captcha_rows rows= new Captcha_rows(ptr);
            rows_count++;
            rows.num = rows_count - 1;
            rows.set_grouprow();
            Grid_Panel.Controls.Add(rows);
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            captchaFrm captchafrm = new captchaFrm(ptr);
            captchafrm.ShowDialog();
        }

        private void deleteAllBtn_Click(object sender, EventArgs e)
        {
            MainFrm mainfrm = (MainFrm)Form.FromHandle(ptr);
            Grid_Panel.Controls.Clear();
            rows_count = 0;
            mainfrm.captchaitems.Clear();
            CaptchaModel.DeleteAll();
        }
    }
}
