using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BOTMAIN.EntityModels;
using BOTMAIN.Model;

namespace BOTMAIN
{
    public partial class TaskFrm : Form
    {
        IntPtr ptr = new IntPtr();
        public int No = 0;
        public string state = "ADD";
        public TaskFrm()
        {
            InitializeComponent();

        }
        public TaskFrm(IntPtr p)
        {
            ptr = p;
            InitializeComponent();
        }
        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void SiteCombo_onItemSelected(object sender, EventArgs e)
        {
            if (SiteCombo.selectedIndex == 0)
            {
                SiteCombo.ForeColor = Color.Gray;
            }
            else
            {
                SiteSep.LineColor = Color.Gray;
                SiteCombo.ForeColor = Color.White;
            }
        }

        private void LinkCombo_onItemSelected(object sender, EventArgs e)
        {
            string tmptext = LinkText.Text;
            if (LinkCombo.selectedIndex == 0)
            {
                LinkCombo.ForeColor = Color.Gray;
                LinkText.HintText = "Early Link";
                // LinkText.Validate();
                LinkText.Text = tmptext;
            }
            else
            {
                LinkSep.LineColor = Color.Gray;
                LinkCombo.ForeColor = Color.White;
                LinkText.HintText = LinkCombo.selectedValue;
                // LinkText.Validate();
                LinkText.Text = tmptext;
            }
        }

        private void BillingCombo_onItemSelected(object sender, EventArgs e)
        {
            if (BillingCombo.selectedIndex == 0)
            {
                BillingCombo.ForeColor = Color.Gray;
            }
            else
            {
                BillingSep.LineColor = Color.Gray;
                BillingCombo.ForeColor = Color.White;
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            MainFrm mainfrm = (MainFrm)Form.FromHandle(ptr);
            bool flag = false;
            if (SiteCombo.selectedIndex == 0)
            {
                SiteSep.LineColor = Color.Red;
                flag = true;
            }
            if (EmailText.Text == "")
            {
                EmailText.LineIdleColor = Color.Red;
                flag = true;
            }
            if (PassText.Text == "")
            {
                PassText.LineIdleColor = Color.Red;
                flag = true;
            }
            if (LinkCombo.selectedIndex == 0)
            {
                LinkSep.LineColor = Color.Red;
                flag = true;
            }
            if (SizeText.Text == "")
            {
                SizeText.LineIdleColor = Color.Red;
                flag = true;
            }
            if (LinkText.Text == "")
            {
                LinkText.LineIdleColor = Color.Red;
                flag = true;
            }

            if (flag == true) return;
            if (state == "ADD")
            {
                TaskModel tmpitem = new TaskModel();

                tmpitem.Captcha = !CaptchaCheck.Checked;
                tmpitem.SetSiteName(SiteCombo.selectedValue);
                tmpitem.Email = EmailText.Text;
                tmpitem.Password = PassText.Text;
                tmpitem.LinkType = LinkCombo.selectedValue;
                tmpitem.Size = SizeText.Text;
                tmpitem.LinkURL = LinkText.Text;
                tmpitem.MaxPrice = Convert.ToInt32(MaxPriceText.Text);
                tmpitem.MinPrice = Convert.ToInt32(MinPriceText.Text);
                tmpitem.ShippingRate = Convert.ToInt32(ShippingText.Text);
                tmpitem.BillingId = BillingCombo.selectedIndex - 1;
                tmpitem.Guest = GuestCheck.Checked;
                tmpitem.Mode = ModeCombo.selectedValue;

                tmpitem.Save();
                mainfrm.newTaskItems.Add(tmpitem);
                mainfrm.TaskUser.AddTitleHeader();
            }
            if(state=="EDIT")
            {
                TaskModel tmpitem = mainfrm.newTaskItems[No];
                tmpitem.Captcha = !CaptchaCheck.Checked;

                tmpitem.SetSiteName(SiteCombo.selectedValue);
                tmpitem.Email = EmailText.Text;
                tmpitem.Password = PassText.Text;
                tmpitem.LinkType = LinkCombo.selectedValue;
                tmpitem.Size = SizeText.Text;
                tmpitem.LinkURL = LinkText.Text;
                tmpitem.MaxPrice = Convert.ToInt32(MaxPriceText.Text);
                tmpitem.MinPrice = Convert.ToInt32(MinPriceText.Text);
                tmpitem.ShippingRate = Convert.ToInt32(ShippingText.Text);
                tmpitem.BillingId = BillingCombo.selectedIndex - 1;
                tmpitem.Guest = GuestCheck.Checked;
                tmpitem.Mode = ModeCombo.selectedValue;
                /*RequestContext rc1 = new RequestContext();
                //tmpitem.browser = new ChromiumWebBrowser("",null,rc1);
                tmpitem.browser = new CefSharp.WinForms.ChromiumWebBrowser(LinkText.Text, rc1)
                {
                    Dock = DockStyle.Fill,
                    Size = new Size(600, 600),
                    Location = new Point(200, 200),
                };*/

                //tmpitem.browser = new ChromiumWebBrowser();
                mainfrm.newTaskItems[No] = tmpitem;
                tmpitem.Save();
                //mainfrm.TaskUser.AddTitleHeader();
                
            }
            Close();
        }

        private void CaptchaLBL_Click(object sender, EventArgs e)
        {
            CaptchaCheck.Checked = !CaptchaCheck.Checked;

        }

        private void GuestLBL_Click(object sender, EventArgs e)
        {
            GuestCheck.Checked = !GuestCheck.Checked;
            //GuestChange();
        }

        private void TaskFrm_Load(object sender, EventArgs e)
        {
            MainFrm mainfrm = (MainFrm)Form.FromHandle(ptr);
            BillingCombo.Clear();
            BillingCombo.AddItem("Select a Billing");
            for (int i = 0; i < mainfrm.billitems.Count; i++)
            {
                BillingCombo.AddItem(mainfrm.billitems[i].FriendlyName);
            }
            BillingCombo.selectedIndex = 0;

            // add site items
            foreach (SiteModel item in MainFrm.context.Site.ToList())
            {
                this.SiteCombo.AddItem(item.SiteName);
            }
            if (state=="EDIT")
            {
                TitleLBL.Text = "Edit Task";
                BillingCombo.selectedIndex = mainfrm.newTaskItems[No].BillingId + 1;
                int ii = 0;
                while(mainfrm.newTaskItems[No].Site.SiteName != SiteCombo.Items[ii].ToString())
                {
                    ii++;
                }
                SiteCombo.selectedIndex = ii;
                ii = 0;
                while (mainfrm.newTaskItems[No].LinkType != LinkCombo.Items[ii].ToString())
                {
                    ii++;
                }
                LinkCombo.selectedIndex = ii;
                ii = 0;
                while (mainfrm.newTaskItems[No].Mode != ModeCombo.Items[ii].ToString())
                {
                    ii++;
                }
                CaptchaCheck.Checked = !mainfrm.newTaskItems[No].Captcha;
                GuestCheck.Checked = mainfrm.newTaskItems[No].Guest;
                EmailText.Text = mainfrm.newTaskItems[No].Email;
                PassText.Text = mainfrm.newTaskItems[No].Password;
                SizeText.Text = mainfrm.newTaskItems[No].Size;
                LinkText.Text = mainfrm.newTaskItems[No].LinkURL;
                MinPriceText.Text = Convert.ToString(mainfrm.newTaskItems[No].MinPrice);
                MaxPriceText.Text = Convert.ToString(mainfrm.newTaskItems[No].MaxPrice);
                ShippingText.Text = Convert.ToString(mainfrm.newTaskItems[No].ShippingRate);
            }
        }
        private void Text_OnValueChanged(object sender, EventArgs e)
        {
            ((Bunifu.Framework.UI.BunifuMaterialTextbox)sender).LineIdleColor = Color.Gray;
        }
        private void GuestCheck_OnChange(object sender, EventArgs e)
        {
            //GuestChange();
        }
        void GuestChange()
        {
            EmailText.Enabled = !GuestCheck.Checked;
            PassText.Enabled = !GuestCheck.Checked;
        }
    }
}
