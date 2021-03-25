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
    public partial class Profile : UserControl
    {
        IntPtr ptr=new IntPtr();
        public int rows_count = 0;
        public Profile()
        {
            InitializeComponent();
        }
        public Profile(IntPtr frm)
        {
            ptr = frm;
            InitializeComponent();
        }
        private void Profile_Resize(object sender, System.EventArgs e)
        {
            Int32 hWidth = this.header_panel.Width;
            this.lblCardName.Location = new System.Drawing.Point(Convert.ToInt32(hWidth * 0.168), 5);
            this.lblCountry.Location = new System.Drawing.Point(Convert.ToInt32(hWidth * 0.384), 5);
            this.lblCardType.Location = new System.Drawing.Point(Convert.ToInt32(hWidth * 0.608), 5);
            this.lblAction.Location = new System.Drawing.Point(Convert.ToInt32(hWidth * 0.836), 5);

            this.CreateBtn.Location = new System.Drawing.Point(hWidth - 373, 24);
            this.DeleteBtn.Location = new System.Drawing.Point(hWidth - 185, 24);

            for (int i = 0; i < this.Grid_panel.Controls.Count; i++)
            {
                this.Grid_panel.Controls[i].Width = Grid_panel.Width;
            }
        }
        public void Add_Row()
        {
            Profile_rows rows = new Profile_rows(ptr);
            rows_count++;
            rows.num = rows_count-1;
            rows.Name = (rows_count-1).ToString();
            rows.set_grouprow();
            Grid_panel.Controls.Add(rows);
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            ProfileFrm profilefrm = new ProfileFrm(ptr);
            profilefrm.ShowDialog();
            profilefrm.Close();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            MainFrm mainfrm = (MainFrm)Form.FromHandle(ptr);
            Grid_panel.Controls.Clear();
            rows_count = 0;
            mainfrm.billitems.Clear();
            BillingModel.DeleteAll();
        }

        private void Grid_panel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
