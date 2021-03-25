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
    public partial class Proxy_rows : UserControl
    {
        IntPtr ptr = new IntPtr();

        public Proxy_rows()
        {
            InitializeComponent();
        }
        public Proxy_rows(IntPtr p)
        {
            ptr = p;
            InitializeComponent();
        }
        public int num = 0;
        private void ProxyRows_Resize(object sender, System.EventArgs e)
        {
            int hWidth = this.Width;
            this.proxy_label.Location = new System.Drawing.Point(Convert.ToInt32(hWidth * 0.22), 13);
            this.status_label.Location = new System.Drawing.Point(Convert.ToInt32(hWidth * 0.66), 13);
            this.EditBtn.Location = new System.Drawing.Point(Convert.ToInt32(hWidth * 0.86), 13);
            this.DelBtn.Location = new System.Drawing.Point(Convert.ToInt32(hWidth * 0.86) + 21, 13);
        }

        public void set_grouprow()
        {
            string enabled;
            MainFrm mainfrm = (MainFrm)Form.FromHandle(ptr);
            if (mainfrm.proxiesitems[num].Status)
            {
                enabled = "working";
            }
            else
            {
                enabled = "not working";
            }
            this.num_label.Text = (num + 1).ToString();
            this.proxy_label.Text = mainfrm.proxiesitems[num].ProxyIP.ToString();
            this.status_label.Text = enabled;
        }
        

        private void EditBtn_Click(object sender, EventArgs e)
        {
            ProxyEditFrm proxyEditFrm = new ProxyEditFrm(ptr);
            proxyEditFrm.No = num;
            proxyEditFrm.ShowDialog();
            proxyEditFrm.Close();
            set_grouprow();
        }

        private void DelBtn_Click(object sender, EventArgs e)
        {
            MainFrm mainfrm = (MainFrm)Form.FromHandle(ptr);
            //delete from db
            mainfrm.proxiesitems[num].Delete();
            //delete from rows
            mainfrm.proxiesitems.Remove(mainfrm.proxiesitems[num]);
            for (int i = 0; i < mainfrm.ProxyUser.Grid_panel.Controls.Count; i++)
            {
                if (((Proxy_rows)mainfrm.ProxyUser.Grid_panel.Controls[i]).num > num)
                {
                    ((Proxy_rows)mainfrm.ProxyUser.Grid_panel.Controls[i]).num--;
                    int name = ((Proxy_rows)mainfrm.ProxyUser.Grid_panel.Controls[i]).num;
                    mainfrm.ProxyUser.Grid_panel.Controls[i].Name = name.ToString();
                    ((Proxy_rows)mainfrm.ProxyUser.Grid_panel.Controls[i]).set_grouprow();
                }
            }
            mainfrm.ProxyUser.rows_count--;
            mainfrm.ProxyUser.Grid_panel.Controls.Remove(this);
        }
    }
}
