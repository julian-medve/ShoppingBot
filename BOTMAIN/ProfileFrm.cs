using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BOTMAIN.EntityModels;
using BOTMAIN.Model;

namespace BOTMAIN
{
    public partial class ProfileFrm : Form
    {
        IntPtr ptr = new IntPtr();
        public string state = "ADD";
        public int No = 0;
        //Profile profileUser = new Profile();
        public ProfileFrm()
        {
            InitializeComponent();
        }
        public ProfileFrm(IntPtr p)
        {
            ptr = p;
            InitializeComponent();
        }
        private void close_btn_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void Add_GridRow()
        {

        }
        private void BillCountryCombo_onItemSelected(object sender, EventArgs e)
        {
            if(BillCountryCombo.selectedIndex == 0 )
            {
                BillCountryCombo.ForeColor = Color.Gray;
            }
            else
            {
                BillCountrySep.LineColor = Color.Gray;
                BillCountryCombo.ForeColor = Color.White;
            }
            if (SameCheck.Checked == false) return;
            SameShipping();
        }

        private void ShipCountryCombo_onItemSelected(object sender, EventArgs e)
        {
            if (ShipCountryCombo.selectedIndex == 0)
            {
                ShipCountryCombo.ForeColor = Color.Gray;
            }
            else
            {
                ShipCountrySep.LineColor = Color.Gray;
                ShipCountryCombo.ForeColor = Color.White;
            }
        }
        private void Component_Click(object sender, EventArgs e)
        {

        }
        private bool IsEmpty()
        {
            bool flag = false;
            for (int i = 0; i < MainPanel.Controls.Count; i++)
            {
                if (MainPanel.Controls[i].ToString() == "Bunifu.Framework.UI.BunifuMaterialTextbox")
                {
                    if (((Bunifu.Framework.UI.BunifuMaterialTextbox)MainPanel.Controls[i]).HintText != "Address2")
                    {


                        if (((Bunifu.Framework.UI.BunifuMaterialTextbox)MainPanel.Controls[i]).Text == "")
                        {
                            flag = true;
                            ((Bunifu.Framework.UI.BunifuMaterialTextbox)MainPanel.Controls[i]).LineIdleColor = Color.Red;
                            // ((Bunifu.Framework.UI.BunifuMaterialTextbox)MainPanel.Controls[i]). = true;
                        }
                    }
                }
                if (MainPanel.Controls[i].ToString() == "Bunifu.Framework.UI.BunifuDropdown")
                {
                    
                    if(BillCountryCombo.selectedIndex == 0)
                    {
                        flag = true;
                        BillCountrySep.LineColor = Color.Red;
                    }
                    if (ShipCountryCombo.selectedIndex == 0)
                    {
                        flag = true;
                        ShipCountrySep.LineColor = Color.Red;
                    }
                }
            }
            return flag;
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            MainFrm mainfrm = (MainFrm)Form.FromHandle(ptr);
            if (IsEmpty()) return;
            if (state == "ADD")
            {
                BillingModel tmpitem = new BillingModel();
                //billing
                tmpitem.BillFirstName = BillFirstNameText.Text;
                tmpitem.BillLastName = BillLastNameText.Text;
                tmpitem.BillAddress1 = BillAddr1Text.Text;
                tmpitem.BillAddress2 = BillAddr2Text.Text;
                tmpitem.BillCity = BillCityText.Text;
                tmpitem.BillStateXX = BillStateText.Text;
                tmpitem.BillZipCode = BillZipCodeText.Text;
                tmpitem.BillCountry = BillCountryCombo.selectedValue;
                //tmpitem.BillHouseNum = BillHouseNumText.Text;
                tmpitem.BillPhone = BillPhoneText.Text;
                //shipping 
                tmpitem.ShipFirstName = ShipFirstNameText.Text;
                tmpitem.ShipLastName = ShipLastName.Text;
                tmpitem.ShipAddress1 = ShipAddr1Text.Text;
                tmpitem.ShipAddress2 = ShipAddr2Text.Text;
                tmpitem.ShipCity = ShipCityText.Text;
                tmpitem.ShipStateXX = ShipStateText.Text;
                tmpitem.ShipZipCode = ShipZipCodeText.Text;
                tmpitem.ShipCountry = ShipCountryCombo.selectedValue;
                //tmpitem.ShipHouseNum = ShipHouseNumText.Text;
                tmpitem.ShipPhone = ShipPhoneText.Text;
                //card info
                tmpitem.FriendlyName = FriendlyNameText.Text;
                tmpitem.CardType = CardTypeCombo.selectedValue;
                tmpitem.CardName = CardNameText.Text;
                tmpitem.CardNumber = CardNumText.Text;
                tmpitem.ExpireMonth = Convert.ToInt16(MonthCombo.selectedValue);
                tmpitem.ExpireYear = Convert.ToInt16(YearCombo.selectedValue);
                tmpitem.SecurityCode = SecurityCodeText.Text;
                tmpitem.Email = EmailText.Text;
                tmpitem.Birthday = new DateTime();
                //tmpitem.Birthday = BirthDate.Value;
                mainfrm.billitems.Add(tmpitem);
                tmpitem.Save();

                BillingModel editMode = MainFrm.context.Billing.Where(item => item.Email == "odc.email").FirstOrDefault();
                if (editMode != null)
                {
                    editMode.Email = "kjsemail";
                    editMode.Save();
                }
                mainfrm.ProfileUser.Add_Row();
            }
            if(state=="EDIT")
            {
                BillingModel tmpitem = mainfrm.billitems[No];
                tmpitem.BillFirstName = BillFirstNameText.Text;
                tmpitem.BillLastName = BillLastNameText.Text;
                tmpitem.BillAddress1 = BillAddr1Text.Text;
                tmpitem.BillAddress2 = BillAddr2Text.Text;
                tmpitem.BillCity = BillCityText.Text;
                tmpitem.BillStateXX = BillStateText.Text;
                tmpitem.BillZipCode = BillZipCodeText.Text;
                tmpitem.BillCountry = BillCountryCombo.selectedValue;
               // tmpitem.BillHouseNum = BillHouseNumText.Text;
                tmpitem.BillPhone = BillPhoneText.Text;
                //shipping 
                tmpitem.ShipFirstName = ShipFirstNameText.Text;
                tmpitem.ShipLastName = ShipLastName.Text;
                tmpitem.ShipAddress1 = ShipAddr1Text.Text;
                tmpitem.ShipAddress2 = ShipAddr2Text.Text;
                tmpitem.ShipCity = ShipCityText.Text;
                tmpitem.ShipStateXX = ShipStateText.Text;
                tmpitem.ShipZipCode = ShipZipCodeText.Text;
                tmpitem.ShipCountry = ShipCountryCombo.selectedValue;
               // tmpitem.ShipHouseNum = ShipHouseNumText.Text;
                tmpitem.ShipPhone = ShipPhoneText.Text;
                //card info
                tmpitem.FriendlyName = FriendlyNameText.Text;
                tmpitem.CardType = CardTypeCombo.selectedValue;
                tmpitem.CardName = CardNameText.Text;
                tmpitem.CardNumber = CardNumText.Text;
                tmpitem.ExpireMonth = Convert.ToInt16(MonthCombo.selectedValue);
                tmpitem.ExpireYear = Convert.ToInt16(YearCombo.selectedValue);
                tmpitem.SecurityCode = SecurityCodeText.Text;
                tmpitem.Email = EmailText.Text;
                mainfrm.billitems[No] = tmpitem;
                tmpitem.Save();
                // tmpitem.Birthday = new DateTime();
                
            }
            Close();
        }

        private void ShippingLBL_Click(object sender, EventArgs e)
        {
            
            SameCheck.Checked = !SameCheck.Checked;
            SameShippingMain();
        }
        private void SameShipping()
        {
            ShipFirstNameText.Text = BillFirstNameText.Text;
            ShipLastName.Text = BillLastNameText.Text;
            ShipAddr1Text.Text = BillAddr1Text.Text;
            ShipAddr2Text.Text = BillAddr2Text.Text;
            ShipCityText.Text = BillCityText.Text;
            ShipZipCodeText.Text = BillZipCodeText.Text;
            ShipStateText.Text = BillStateText.Text;
            if (BillCountryCombo.selectedIndex >= 0)
            {
                ShipCountryCombo.selectedIndex = BillCountryCombo.selectedIndex;
            }
            //ShipHouseNumText.Text = BillHouseNumText.Text;
            ShipPhoneText.Text = BillPhoneText.Text;
        }
        private void SameShippingMain()
        {
            ShipFirstNameText.Enabled = !SameCheck.Checked;
            ShipLastName.Enabled = !SameCheck.Checked;
            ShipAddr1Text.Enabled = !SameCheck.Checked;
            ShipAddr2Text.Enabled = !SameCheck.Checked;
            ShipCityText.Enabled = !SameCheck.Checked;
            ShipStateText.Enabled = !SameCheck.Checked;
            ShipZipCodeText.Enabled = !SameCheck.Checked;
            ShipCountryCombo.Enabled = !SameCheck.Checked;
            //ShipHouseNumText.Enabled = !SameCheck.Checked;
            ShipPhoneText.Enabled = !SameCheck.Checked;
            if (SameCheck.Checked == true) SameShipping();
        }

        private void SameCheck_OnChange(object sender, EventArgs e)
        {
            SameShippingMain();
        }

        private void BillFirstNameText_OnValueChanged(object sender, EventArgs e)
        {
            ((Bunifu.Framework.UI.BunifuMaterialTextbox)sender).LineIdleColor = Color.Gray;
            if (SameCheck.Checked == false) return;
            SameShipping();
        }
        private void Text_OnValueChanged(object sender, EventArgs e)
        {
            ((Bunifu.Framework.UI.BunifuMaterialTextbox)sender).LineIdleColor = Color.Gray;
        }
        private void ProfileFrm_Load(object sender, EventArgs e)
        {
            MainFrm mainfrm = (MainFrm)Form.FromHandle(ptr);
            Dictionary<string, string> objDic = new Dictionary<string, string>();
            int billno = 0, shipno = 0,ii=-1;
            foreach (CultureInfo ObjCultureInfo in CultureInfo.GetCultures(CultureTypes.SpecificCultures))
            {
                RegionInfo objRegionInfo = new RegionInfo(ObjCultureInfo.Name);
                if (!objDic.ContainsKey(objRegionInfo.EnglishName))
                {
                    objDic.Add(objRegionInfo.EnglishName, objRegionInfo.TwoLetterISORegionName.ToLower());
                }
            }
            SortedList<string, string> sortedList = new SortedList<string, string>(objDic);
            BillCountryCombo.Clear();
            BillCountryCombo.AddItem("Select a Country");
            ShipCountryCombo.Clear();
            ShipCountryCombo.AddItem("Select a Country");

            foreach (KeyValuePair<string, string> val in sortedList)
            {
                ii++;
                if(state=="EDIT")
                {
                    if(val.Key==mainfrm.billitems[No].BillCountry)
                    {
                        billno = ii;
                    }
                    if (val.Key == mainfrm.billitems[No].ShipCountry)
                    {
                        shipno = ii;
                    }
                }
                BillCountryCombo.AddItem(val.Key);
                ShipCountryCombo.AddItem(val.Key);
            }
            BillCountryCombo.selectedIndex = 0;
            ShipCountryCombo.selectedIndex = 0;
            MonthCombo.Clear();
            for (int i = 0; i < 12; i++)
            {
                MonthCombo.AddItem((i + 1).ToString());
            }
            YearCombo.Clear();
            for (int i = 2000; i < 2999; i++)
            {
                YearCombo.AddItem(i.ToString());
            }
            DateTime da = new DateTime();
            da = DateTime.Now;
            MonthCombo.selectedIndex = da.Month - 1;
            YearCombo.selectedIndex = da.Year - 2000;
            if(state=="EDIT")
            {
                TitleLBL.Text = "Edit Profile";
                BillFirstNameText.Text = mainfrm.billitems[No].BillFirstName;
                BillLastNameText.Text = mainfrm.billitems[No].BillLastName;
                BillAddr1Text.Text = mainfrm.billitems[No].BillAddress1;
                BillAddr2Text.Text = mainfrm.billitems[No].BillAddress2;
                BillCityText.Text = mainfrm.billitems[No].BillCity;
                BillStateText.Text = mainfrm.billitems[No].BillStateXX;
                BillZipCodeText.Text = mainfrm.billitems[No].BillZipCode;
               /* while(BillCountryCombo.Items[ii]!=mainfrm.billitems[No].BillCountry)
                {
                    ii++;
                }*/
                BillCountryCombo.selectedIndex = billno;
                //BillHouseNumText.Text = mainfrm.billitems[No].BillHouseNum;
                BillPhoneText.Text = mainfrm.billitems[No].BillPhone;

                ShipFirstNameText.Text = mainfrm.billitems[No].ShipFirstName;
                ShipLastName.Text = mainfrm.billitems[No].ShipLastName;
                ShipAddr1Text.Text = mainfrm.billitems[No].ShipAddress1;
                ShipAddr2Text.Text = mainfrm.billitems[No].ShipAddress2;
                ShipCityText.Text = mainfrm.billitems[No].ShipCity;
                ShipStateText.Text = mainfrm.billitems[No].ShipStateXX;
                ShipZipCodeText.Text = mainfrm.billitems[No].ShipZipCode;
                ii=0;
               /* while(ShipCountryCombo.Items[ii]!=mainfrm.billitems[No].ShipCountry)
                {
                    ii++;
                }*/
                ShipCountryCombo.selectedIndex = shipno;
                //ShipHouseNumText.Text = mainfrm.billitems[No].ShipHouseNum;
                ShipPhoneText.Text = mainfrm.billitems[No].ShipPhone;

                FriendlyNameText.Text = mainfrm.billitems[No].FriendlyName;
                ii = 0;
                while (CardTypeCombo.items[ii] != mainfrm.billitems[No].CardType.ToString())
                {
                    ii++;
                }
                CardTypeCombo.selectedIndex = ii;
                CardNameText.Text = mainfrm.billitems[No].CardName;
                CardNumText.Text = mainfrm.billitems[No].CardNumber;
                MonthCombo.selectedIndex = mainfrm.billitems[No].ExpireMonth - 1;
                YearCombo.selectedIndex = mainfrm.billitems[No].ExpireYear - 2000;
                SecurityCodeText.Text = mainfrm.billitems[No].SecurityCode;
                EmailText.Text = mainfrm.billitems[No].Email;
            }
            
        }

        private void BillCountryCombo_Validated(object sender, EventArgs e)
        {

        }
        int fx,fy;
        private void BackgroundPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(this.Location.X + e.X - fx, this.Location.Y + e.Y - fy);
            }
        }

        private void CardTypeCombo_onItemSelected(object sender, EventArgs e)
        {

        }

        private void BackgroundPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                fx = e.X;
                fy = e.Y;
            }
        }
        
    }
}
