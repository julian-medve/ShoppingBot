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
    public partial class Proxy : UserControl
    {
        IntPtr ptr = new IntPtr();
        public int rows_count = 0;
        public Proxy()
        {
            InitializeComponent();
        }
        public Proxy(IntPtr form)
        {
            ptr = form;
            InitializeComponent();
        }
        private void Proxy_Resize(object sender, System.EventArgs e)
        {
            Int32 hWidth = this.header_panel.Width;
            this.lblProxy.Location = new System.Drawing.Point(Convert.ToInt32(hWidth * 0.26), 5);
            this.lblStatus.Location = new System.Drawing.Point(Convert.ToInt32(hWidth * 0.66), 5);
            this.lblAction.Location = new System.Drawing.Point(Convert.ToInt32(hWidth * 0.85), 5);

            this.testProxyBtn.Location = new System.Drawing.Point(hWidth - 529, 24);
            this.addProxyBtn.Location = new System.Drawing.Point(hWidth - 344, 24);
            this.delProxyBtn.Location = new System.Drawing.Point(hWidth - 172, 24);

            for (int i = 0; i < this.Grid_panel.Controls.Count; i++)
            {
                this.Grid_panel.Controls[i].Width = Grid_panel.Width;
            }
        }

        public void Add_Row()
        {
            Proxy_rows rows = new Proxy_rows(ptr);
            rows_count++;
            rows.num = rows_count - 1;
            rows.Name = (rows_count - 1).ToString();
            rows.set_grouprow();
            Grid_panel.Controls.Add(rows);
        }

        private void addProxyBtn_Click(object sender, EventArgs e)
        {
            ProxyFrm proxyfrm = new ProxyFrm(ptr);
            proxyfrm.ShowDialog();
            proxyfrm.Close();
        }

        private void deleteProxyBtn_Click(object sender, EventArgs e)
        {
            MainFrm mainfrm = (MainFrm)Form.FromHandle(ptr);
            Grid_panel.Controls.Clear();
            rows_count = 0;
            mainfrm.proxiesitems.Clear();
            ProxyModel.DeleteAll();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            ProxyTestFrm proxytestfrm = new ProxyTestFrm(ptr);
            proxytestfrm.ShowDialog();
            proxytestfrm.Close();
        }
    }
}
