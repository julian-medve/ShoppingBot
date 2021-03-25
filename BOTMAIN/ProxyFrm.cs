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
using BOTMAIN.Classes;
using BOTMAIN.EntityModels;

namespace BOTMAIN
{
    public partial class ProxyFrm : Form
    {
        IntPtr ptr = new IntPtr();
        public int No = 0;
        public string state = "ADD";
        public ProxyFrm()
        {
            InitializeComponent();
        }
        public ProxyFrm(IntPtr p)
        {
            ptr = p;
            InitializeComponent();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ProxiesText_TextChanged(object sender, EventArgs e)
        {
            if(ProxiesText.Text != "")
            {
                ProxiesText.BorderThickness = 2;
            }
        }
        public bool IsEmpty()
        {
            bool flag = false;

            if (!toggleCurrenIp.Value)
            {
                if(ProxiesText.Text == "")
                {
                    flag = true;
                    ProxiesText.BorderThickness = 4;
                }
            }
            return flag;
        }

        private void saveListBtn_Click(object sender, EventArgs e)
        {
            MainFrm mainfrm = (MainFrm)Form.FromHandle(ptr);
            if (IsEmpty()) return;
            if (state == "ADD")
            {
                //ProxyListItem tmpitem = new ProxyListItem();
                

                // get list proxyaddresses from proxy string.
                string str = ProxiesText.Text;
                string[] strlist = SupplyUI.GetAddressList(str);

                foreach (string s in strlist)
                {
                    ProxyModel proxy = new ProxyModel();
                    proxy.ProxyIP = s;
                    proxy.Save();
                    mainfrm.proxiesitems.Add(proxy);
                    mainfrm.ProxyUser.Add_Row();
                }

                if (toggleCurrenIp.Value == true)
                {
                    ProxyModel proxy = new ProxyModel();
                    proxy.ProxyIP = SupplyUI.GetLocalIPAddress();
                    proxy.Save();
                    mainfrm.proxiesitems.Add(proxy);
                    mainfrm.ProxyUser.Add_Row();
                }
            }
            if (state == "EDIT")
            {
                //ProxyModel tmpitem = mainfrm.proxiesitems[No];
                //string[] strlist = SupplyUI.GetAddressList(str);
                //tmpitem.ProxyIP = 
                //// get list proxyaddresses from proxy string.
                //string str = ProxiesText.Text;
                //string[] strlist = SupplyUI.GetAddressList(str);

                //tmpitem.proxyaddresses.Clear();
                //foreach (string s in strlist)
                //{
                //    var proxyString = Model.Proxy.validate(s);
                //    if (proxyString != null)
                //        tmpitem.proxyaddresses.Add(s);
                //}

                //if (toggleCurrenIp.Value == true)
                //{
                //    tmpitem.proxyaddresses.Add(SupplyUI.GetLocalIPAddress());
                //}

                //tmpitem.useCurrentIP = toggleCurrenIp.Value;
                //mainfrm.proxiesitems[No] = tmpitem;
                //tmpitem.update(No);
                
            }
            this.Close();
        }

        private void ProxyFrm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
