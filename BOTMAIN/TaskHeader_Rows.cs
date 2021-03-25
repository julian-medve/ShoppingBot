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
    public partial class TaskHeader_Rows : UserControl
    {
        IntPtr ptr = new IntPtr();
        bool flag = true;
        public int No = 0;
        public TaskHeader_Rows()
        {
            InitializeComponent();
        }
        public TaskHeader_Rows(IntPtr p)
        {
            ptr = p;
            InitializeComponent();
        }
        private void TaskHeader_Rows_Load(object sender, EventArgs e)
        {

        }

        private void UpDownBtn_Click(object sender, EventArgs e)
        {
            MainFrm mainfrm = (MainFrm)Form.FromHandle(ptr);
            if(flag)
            {
                mainfrm.TaskUser.taskbodypanel[No].Visible = false;
                UpDownBtn.Image = BOTMAIN.Properties.Resources.down1;
            }
            else
            {
                mainfrm.TaskUser.taskbodypanel[No].Visible = true;
                UpDownBtn.Image = BOTMAIN.Properties.Resources.up1;
            }
            flag = !flag;
            for (int k = 0; k < mainfrm.TaskUser.taskbodypanel.Count; k++)
            {
                if (mainfrm.TaskUser.Grid_Panel.VerticalScroll.Visible == true)
                {
                    mainfrm.TaskUser.taskheader[k].Width = 1072;
                    mainfrm.TaskUser.taskbodypanel[k].Width = 1072;
                }
                else
                {
                    mainfrm.TaskUser.taskheader[k].Width = 1090;
                    mainfrm.TaskUser.taskbodypanel[k].Width = 1090;
                }
            }
        }
    }
}
