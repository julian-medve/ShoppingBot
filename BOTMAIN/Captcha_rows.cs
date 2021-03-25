using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BOTMAIN
{
    public partial class Captcha_rows : UserControl
    {
        IntPtr ptr = new IntPtr();
        public Captcha_rows()
        {
            InitializeComponent();
        }

        public Captcha_rows(IntPtr p)
        {
            ptr = p;
            InitializeComponent();
        }

        public int num = 0;

        private void CaptchaRows_Resize(object sender, System.EventArgs e)
        {
            int hWidth = this.Width;
            this.gmail_label.Location = new System.Drawing.Point(Convert.ToInt32(hWidth * 0.30), 13);
            //this.proxy_label.Location = new System.Drawing.Point(Convert.ToInt32(hWidth * 0.45), 13);
            this.enabled_label.Location = new System.Drawing.Point(Convert.ToInt32(hWidth * 0.68), 13);
            this.editBtn.Location = new System.Drawing.Point(Convert.ToInt32(hWidth * 0.86), 13);
            this.delBtn.Location = new System.Drawing.Point(Convert.ToInt32(hWidth * 0.86) + 26, 13);
            //this.delBtn.Location = new System.Drawing.Point(Convert.ToInt32(hWidth * 0.845) + 52, 13);
        }

        public void set_grouprow()
        {
            MainFrm mainfrm = (MainFrm)Form.FromHandle(ptr);
            this.num_label.Text = (num + 1).ToString();
            this.gmail_label.Text = mainfrm.captchaitems[num].gmail;
            //this.proxy_label.Text = mainfrm.captchaitems[num].ProxyAddress;
            if(mainfrm.captchaitems[num].enabled)
            {
                this.enabled_label.Text = "Enabled";
            }else
            {
                this.enabled_label.Text = "Not Enabled";
            }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            MainFrm mainfrm = (MainFrm)Form.FromHandle(ptr);
            mainfrm.captchaitems[num].Delete();
            mainfrm.captchaitems.Remove(mainfrm.captchaitems[num]);
            for (int i = 0; i < mainfrm.CaptchaUser.Grid_Panel.Controls.Count; i++)
            {
                if (((Captcha_rows)mainfrm.CaptchaUser.Grid_Panel.Controls[i]).num > num)
                {
                    ((Captcha_rows)mainfrm.CaptchaUser.Grid_Panel.Controls[i]).num--;
                    int name = ((Captcha_rows)mainfrm.CaptchaUser.Grid_Panel.Controls[i]).num;
                    mainfrm.CaptchaUser.Grid_Panel.Controls[i].Name = name.ToString();
                    ((Captcha_rows)mainfrm.CaptchaUser.Grid_Panel.Controls[i]).set_grouprow();
                }
            }
            mainfrm.CaptchaUser.rows_count--;
            mainfrm.CaptchaUser.Grid_Panel.Controls.Remove(this);

        }

        private void editBtn_Click(object sender, EventArgs e)
        {
            captchaFrm captchafrm = new captchaFrm(ptr);
            captchafrm.state = "EDIT";
            captchafrm.No = num;
            captchafrm.ShowDialog();
            captchafrm.Close();
            set_grouprow();
        }
    }
}
