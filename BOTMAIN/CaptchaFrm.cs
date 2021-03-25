using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BOTMAIN.Model;
using BOTMAIN.EntityModels;

namespace BOTMAIN
{
    public partial class captchaFrm : Form
    {
        IntPtr ptr = new IntPtr();
        public int No = 0;
        public string state = "ADD";
        public captchaFrm()
        {
            InitializeComponent();
        }

        public captchaFrm(IntPtr p)
        {
            ptr = p;
            InitializeComponent();
        }
        private void captchaFrm_Load(object sender, EventArgs e)
        {
            MainFrm mainfrm = (MainFrm)Form.FromHandle(ptr);
            if (state == "EDIT")
            {
                addGmailLBL.Text = "Edit Captcha";
                GmailText.Text = mainfrm.captchaitems[No].gmail;
                GmailPassword.Text = mainfrm.captchaitems[No].password;
                //ProxyText.Text = mainfrm.captchaitems[No].ProxyAddress;
                proxyEnabledCheck.Checked = mainfrm.captchaitems[No].enabled;
            }
        }
        
        private void close_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveGmailBtn_Click(object sender, EventArgs e)
        {
            MainFrm mainfrm = (MainFrm)Form.FromHandle(ptr);
            bool flag = false;
            if (GmailText.Text == "")
            {
                GmailText.LineIdleColor = Color.Red;
                flag = true;
                
            }
            if (GmailPassword.Text == "")
            {
                GmailPassword.LineIdleColor = Color.Red;
                flag = true;

            }

            if(flag) return;

            if(state == "ADD")
            {
                CaptchaModel tmpCaptcha = new CaptchaModel();
                tmpCaptcha.gmail= GmailText.Text;
                tmpCaptcha.password = GmailPassword.Text;
                tmpCaptcha.enabled= proxyEnabledCheck.Checked;
                // save to db
                tmpCaptcha.Save();
                // add row
                mainfrm.captchaitems.Add(tmpCaptcha);
                mainfrm.CaptchaUser.Add_Row();
            }
            if(state == "EDIT")
            {
                CaptchaModel tmpitem = mainfrm.captchaitems[No];
                tmpitem.gmail = GmailText.Text;
                tmpitem.password = GmailPassword.Text;
                tmpitem.enabled = proxyEnabledCheck.Checked;
                
                mainfrm.captchaitems[No] = tmpitem;
                tmpitem.Save();
                //mainfrm.UpdateCaptcha(No);
            }
            Close();
        }
    }
}
