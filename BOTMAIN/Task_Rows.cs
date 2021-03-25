using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BOTMAIN.Model;
using BOTMAIN.EntityModels;

namespace BOTMAIN
{
    public partial class Task_Rows : UserControl
    {
        public int num { get; set; }
        public int No { get; set; }
        public int down { get; set; }
        IntPtr ptr = new IntPtr();
        public TaskModel task { get; set; }
        public bool IsStarted { get; set; }
        public Task_Rows(IntPtr p)
        {
            num = No = down = 0;
            ptr = p;
            IsStarted = false;
            InitializeComponent();
        }

        private void TaskRows_Resize(object sender, System.EventArgs e)
        {
            int hWidth = this.Width;
            this.Store_label.Location = new System.Drawing.Point(Convert.ToInt32(hWidth * 0.13), 7);
            this.Prod_label.Location = new System.Drawing.Point(Convert.ToInt32(hWidth * 0.23), 8);
            this.Size_label.Location = new System.Drawing.Point(Convert.ToInt32(hWidth * 0.46), 7);
            this.Prof_label.Location = new System.Drawing.Point(Convert.ToInt32(hWidth * 0.54), 7);
            this.Proxy_label.Location = new System.Drawing.Point(Convert.ToInt32(hWidth * 0.65), 7);
            this.Status_label.Location = new System.Drawing.Point(Convert.ToInt32(hWidth * 0.73), 7);
            this.StartBtn.Location = new System.Drawing.Point(Convert.ToInt32(hWidth * 0.9), 7);
            this.EditBtn.Location = new System.Drawing.Point(Convert.ToInt32(hWidth * 0.9) + 21, 7);
            this.RemoveBtn.Location = new System.Drawing.Point(Convert.ToInt32(hWidth * 0.9) + 42, 7);

        }
        public void Setname()
        {
            var task = MainFrm.shared.newTaskItems[num];
            task.taskRow = this;
            this.task = task;
            Store_label.Text = task.Site.SiteName;
            Prod_label.Text = task.LinkURL;
            Size_label.Text = task.Size;
            num_label.Text = Convert.ToString(num + 1);
            Status_label.Text = "Ready";
            Console.WriteLine(task.BillingId);
            Console.WriteLine(MainFrm.shared.billitems);
            if (task.BillingId >= 0)
            {
                this.Prof_label.Text = MainFrm.shared.billitems[task.BillingId].FriendlyName;
                if (MainFrm.shared.siteproxyItems.Count != 0)
                {
                    this.Proxy_label.Text = "Set";
                }
            }
        }


        delegate void setStatusCallback(string text);
        public void setStatus(string status)
        {
            if (this.Status_label.InvokeRequired)
            {
                var d = new setStatusCallback(setStatus);
                this.Invoke(d, new object[] { status });
            } else
            {
                this.Status_label.Text = status;
            }
        }

        delegate void setStartButtonCallback();
        public void setStartButton()
        {
            if (this.StartBtn.InvokeRequired)
            {
                var d = new setStartButtonCallback(setStartButton);
                this.Invoke(d, new object[] { });
            }
            else
            {
                if (IsStarted)
                {
                    this.StartBtn.Image = global::BOTMAIN.Properties.Resources.play_icon;
                    this.EditBtn.Enabled = true;
                    this.RemoveBtn.Enabled = true;
                } else
                {
                    this.StartBtn.Image = global::BOTMAIN.Properties.Resources.stop_icon;
                    this.EditBtn.Enabled = false;
                    this.RemoveBtn.Enabled = false;
                }
                IsStarted = !IsStarted;
            }
        }

        private void EditBtn_Click(object sender, EventArgs e)
        {
            MainFrm mainfrm = (MainFrm)Form.FromHandle(ptr);
            string sitename = mainfrm.newTaskItems[num].Site.SiteName;
            TaskFrm taskfrm = new TaskFrm(ptr);
            taskfrm.No = num;
            taskfrm.state = "EDIT";
            taskfrm.ShowDialog();
            if (mainfrm.newTaskItems[num].Site.SiteName != sitename)
            {
                int pos = 0,pos1=0,poss;
                for (pos = 0; pos < mainfrm.TaskUser.taskheader.Count; pos++)
                {
                    if (mainfrm.TaskUser.taskheader[pos].TitleLBL.Text == mainfrm.newTaskItems[num].Site.SiteName)
                    {
                        break;
                    }
                }
                for (poss = 0; poss < mainfrm.TaskUser.taskheader.Count; poss++)
                {
                    if (mainfrm.TaskUser.taskheader[poss].TitleLBL.Text == sitename)
                    {
                        pos1 = poss;
                    }
                }
                for (int i=0;i<mainfrm.TaskUser.taskbodypanel[pos1].Controls.Count;i++)
                {
                    if(((Task_Rows)mainfrm.TaskUser.taskbodypanel[pos1].Controls[i]).No>No)
                    {
                        ((Task_Rows)mainfrm.TaskUser.taskbodypanel[pos1].Controls[i]).No--;
                        ((Task_Rows)mainfrm.TaskUser.taskbodypanel[pos1].Controls[i]).Setname();
                    }
                }
                if (pos==mainfrm.TaskUser.taskheader.Count)
                {
                    No = 1;
                    TaskHeader_Rows tmpheaderrow = new TaskHeader_Rows(ptr);
                    tmpheaderrow.No = mainfrm.TaskUser.taskheader.Count;
                    tmpheaderrow.TitleLBL.Text = mainfrm.newTaskItems[num].Site.SiteName;
                    mainfrm.TaskUser.taskheader.Add(tmpheaderrow);
                    FlowLayoutPanel tmppanel = new FlowLayoutPanel();
                    tmppanel.BackColor = Color.FromArgb(42, 42, 42);
                    tmppanel.Margin = new Padding(0, 0, 0, 0);
                    tmppanel.Padding = new Padding(0, 0, 0, 0);
                    tmppanel.Width = 1090;
                    tmppanel.Height = 30;
                    tmppanel.Controls.Add(this);
                    MenuItem[] mi = new MenuItem[4];
                    mi[0] = new MenuItem("Start Selected Items",mainfrm.TaskUser.MenuItem_Click);
                    mi[1] = new MenuItem("Stop Selected Items", mainfrm.TaskUser.MenuItem_Click);
                    mi[2] = new MenuItem("Delete Selected Items", mainfrm.TaskUser.MenuItem_Click);
                    mi[3] = new MenuItem("Mass Edit URL", mainfrm.TaskUser.MenuItem_Click);
                    ContextMenu cm = new ContextMenu(mi);
                    tmppanel.ContextMenu = cm;
                    //tmppanel.Name = taskbodypanel.Count.ToString();
                    mainfrm.TaskUser.taskbodypanel.Add(tmppanel);
                    mainfrm.TaskUser.Grid_Panel.Controls.Add(mainfrm.TaskUser.taskheader[mainfrm.TaskUser.taskheader.Count - 1]);
                    mainfrm.TaskUser.Grid_Panel.Controls.Add(mainfrm.TaskUser.taskbodypanel[mainfrm.TaskUser.taskbodypanel.Count - 1]);
                    
                }
                else
                {
                    this.No =mainfrm.TaskUser.taskbodypanel[pos].Controls.Count + 1;
                    mainfrm.TaskUser.taskbodypanel[pos].Height = 30 * (mainfrm.TaskUser.taskbodypanel[pos].Controls.Count + 1);
                    mainfrm.TaskUser.taskbodypanel[pos].Controls.Add(this);
                }
                Setname();
                mainfrm.TaskUser.taskbodypanel[pos1].Controls.Remove(this);
                if (mainfrm.TaskUser.taskbodypanel[pos1].Controls.Count == 0)
                {
                    mainfrm.TaskUser.Grid_Panel.Controls.Remove(mainfrm.TaskUser.taskbodypanel[pos1]);
                    mainfrm.TaskUser.Grid_Panel.Controls.Remove(mainfrm.TaskUser.taskheader[pos1]);
                    mainfrm.TaskUser.taskbodypanel.Remove(mainfrm.TaskUser.taskbodypanel[pos1]);
                    mainfrm.TaskUser.taskheader.Remove(mainfrm.TaskUser.taskheader[pos1]);
                    for(int i=0;i<mainfrm.TaskUser.taskheader.Count;i++)
                    {
                        if (mainfrm.TaskUser.taskheader[i].No > pos1) mainfrm.TaskUser.taskheader[i].No--;
                    }
                }
                else
                {
                    mainfrm.TaskUser.taskbodypanel[pos1].Height = 30 * mainfrm.TaskUser.taskbodypanel[pos1].Controls.Count;
                }
            }
            else
            {
                Setname();
            }
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

        public void RemoveBtn_Click(object sender, EventArgs e)
        {
            int pos;
            MainFrm mainfrm = (MainFrm)Form.FromHandle(ptr);
            for (pos = 0; pos < mainfrm.TaskUser.taskheader.Count; pos++)
            {
                if (mainfrm.TaskUser.taskheader[pos].TitleLBL.Text == mainfrm.newTaskItems[num].Site.SiteName)
                {
                    break;
                }
            }
            for(int i=0;i<mainfrm.TaskUser.taskheader.Count;i++)
            {
                for(int j=0;j<mainfrm.TaskUser.taskbodypanel[i].Controls.Count;j++)
                {
                    if(((Task_Rows)mainfrm.TaskUser.taskbodypanel[i].Controls[j]).num>num)
                    {
                        ((Task_Rows)mainfrm.TaskUser.taskbodypanel[i].Controls[j]).num--;
                    }
                    if ((((Task_Rows)mainfrm.TaskUser.taskbodypanel[i].Controls[j]).No > No) && i==pos)
                    {
                        ((Task_Rows)mainfrm.TaskUser.taskbodypanel[i].Controls[j]).No--;
                        ((Task_Rows)mainfrm.TaskUser.taskbodypanel[i].Controls[j]).Setname();
                    }
                }
            }
            mainfrm.newTaskItems[num].Delete();
            mainfrm.newTaskItems.Remove(mainfrm.newTaskItems[num]);
            mainfrm.TaskUser.taskbodypanel[pos].Controls.Remove(this);
            if (mainfrm.TaskUser.taskbodypanel[pos].Controls.Count == 0)
            {
                mainfrm.TaskUser.Grid_Panel.Controls.Remove(mainfrm.TaskUser.taskbodypanel[pos]);
                mainfrm.TaskUser.Grid_Panel.Controls.Remove(mainfrm.TaskUser.taskheader[pos]);
                mainfrm.TaskUser.taskbodypanel.Remove(mainfrm.TaskUser.taskbodypanel[pos]);
                mainfrm.TaskUser.taskheader.Remove(mainfrm.TaskUser.taskheader[pos]);
                for (int i = 0; i < mainfrm.TaskUser.taskheader.Count; i++)
                {
                    if (mainfrm.TaskUser.taskheader[i].No > pos) mainfrm.TaskUser.taskheader[i].No--;
                }
            }
            else
            {
                mainfrm.TaskUser.taskbodypanel[pos].Height = 30 * mainfrm.TaskUser.taskbodypanel[pos].Controls.Count;
            }
            
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

        private void StartBtn_Click(object sender, EventArgs e)
        {
            if (!IsStarted) task.start();
            else task.Stop();

            MainFrm.shared.SetDisplayOfButtons(IsStarted);
            setStartButton();
        }
    }
}
