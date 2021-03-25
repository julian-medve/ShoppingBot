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
    public partial class Profile_rows : UserControl
    {
        IntPtr ptr = new IntPtr();
        public Profile_rows()
        {
            InitializeComponent();
        }
        public Profile_rows(IntPtr p)
        {
            ptr = p;
            InitializeComponent();
        }
        public int num = 0;
        private void ProfileRows_Resize(object sender, System.EventArgs e)
        {
            int hWidth = this.Width;
            this.Name_label.Location = new System.Drawing.Point(Convert.ToInt32(hWidth * 0.16), 13);
            this.Country_label.Location = new System.Drawing.Point(Convert.ToInt32(hWidth * 0.39), 13);
            this.Card_label.Location = new System.Drawing.Point(Convert.ToInt32(hWidth * 0.63), 13);
            this.EditBtn.Location = new System.Drawing.Point(Convert.ToInt32(hWidth * 0.85), 13);
            this.RemoveBtn.Location = new System.Drawing.Point(Convert.ToInt32(hWidth * 0.85) + 21, 13);
        }

        public void set_grouprow()
        {
            MainFrm mainfrm = (MainFrm)Form.FromHandle(ptr);
            this.num_label.Text = (num+1).ToString();
            this.Name_label.Text = mainfrm.billitems[num].FriendlyName;
            this.Country_label.Text = mainfrm.billitems[num].BillCountry;
            this.Card_label.Text = mainfrm.billitems[num].CardType;
        }
        private void EditBtn_Click(object sender, EventArgs e)
        {
            ProfileFrm profrm = new ProfileFrm(ptr);
            profrm.state = "EDIT";
            
            profrm.No = num;
            profrm.ShowDialog();
            set_grouprow();
        }
        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            MainFrm mainfrm = (MainFrm)Form.FromHandle(ptr);

            //delete from db
            mainfrm.billitems[num].Delete();
            //delete from rows
            mainfrm.billitems.Remove(mainfrm.billitems[num]);
            for (int i = 0; i < mainfrm.ProfileUser.Grid_panel.Controls.Count; i++)
            {
                if (((Profile_rows)mainfrm.ProfileUser.Grid_panel.Controls[i]).num>num)
                {
                    ((Profile_rows)mainfrm.ProfileUser.Grid_panel.Controls[i]).num--;
                    int name = ((Profile_rows)mainfrm.ProfileUser.Grid_panel.Controls[i]).num;
                    mainfrm.ProfileUser.Grid_panel.Controls[i].Name = name.ToString();
                    ((Profile_rows)mainfrm.ProfileUser.Grid_panel.Controls[i]).set_grouprow();
                }
            }
            mainfrm.ProfileUser.rows_count--;
            mainfrm.ProfileUser.Grid_panel.Controls.Remove(this);
        }
    }
}
