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

namespace BOTMAIN
{
    public partial class ProxyEditFrm : Form
    {
        IntPtr ptr = new IntPtr();
        public int No = 0;
        public ProxyEditFrm()
        {
            InitializeComponent();
        }
        public ProxyEditFrm(IntPtr p)
        {
            ptr = p;
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ProxyEditFrm_Load(object sender, EventArgs e)
        {
            MainFrm mainfrm = (MainFrm)Form.FromHandle(ptr);
            this.proxyIPText.Text = mainfrm.proxiesitems[No].ProxyIP.ToString();
        }

        private void saveEditProxyBtn_Click(object sender, EventArgs e)
        {
            MainFrm mainfrm = (MainFrm)Form.FromHandle(ptr);
            ProxyModel tmpitem = mainfrm.proxiesitems[No];
            tmpitem.ProxyIP = proxyIPText.Text;
            mainfrm.proxiesitems[No] = tmpitem;
            tmpitem.Save();
            Close();
        }
    }
}
