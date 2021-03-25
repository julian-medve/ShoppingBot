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
    public partial class Task : UserControl
    {
        IntPtr ptr = new IntPtr();

        public List<TaskHeader_Rows> taskheader = new List<TaskHeader_Rows>();
        public List<FlowLayoutPanel> taskbodypanel = new List<FlowLayoutPanel>();
        public int row_count = 0;
        public int itemChecked = 0;
        public int lastcheckNo = 0;
        public IntPtr lastptr = new IntPtr(0);

        private List<ShopifyTask> shopifyTasks = new List<ShopifyTask>();
        private MainFrm mainFrm = null;
        public Task()
        {
            InitializeComponent();
            mainFrm = (MainFrm)Form.FromHandle(ptr);
        }
        public Task(IntPtr p)
        {
            ptr = p;
            InitializeComponent();
            mainFrm = (MainFrm)Form.FromHandle(ptr);
        }

        private void Panel1_Resize(object sender, System.EventArgs e)
        {
            Int32 hWidth = this.header_panel.Width;
            this.lblAction.Location = new System.Drawing.Point(Convert.ToInt32(hWidth * 0.89), 7);
            this.lblStatus.Location = new System.Drawing.Point(Convert.ToInt32(hWidth * 0.78), 7);
            this.lblProxy.Location = new System.Drawing.Point(Convert.ToInt32(hWidth * 0.65), 7);
            this.lblProfile.Location = new System.Drawing.Point(Convert.ToInt32(hWidth * 0.54), 7);
            this.lblSize.Location = new System.Drawing.Point(Convert.ToInt32(hWidth * 0.45), 7);
            this.lblProduct.Location = new System.Drawing.Point(Convert.ToInt32(hWidth * 0.27), 7);
            this.lblStore.Location = new System.Drawing.Point(Convert.ToInt32(hWidth * 0.13), 7);

            this.StartBtn.Location = new System.Drawing.Point(Convert.ToInt32(hWidth * 0.08), 20);
            this.StopBtn.Location = new System.Drawing.Point(Convert.ToInt32(hWidth * 0.23), 20);
            this.CreateBtn.Location = new System.Drawing.Point(Convert.ToInt32(hWidth * 0.38), 20);
            this.MassEditBtn.Location = new System.Drawing.Point(Convert.ToInt32(hWidth * 0.53), 20);
            this.CaptchaBtn.Location = new System.Drawing.Point(Convert.ToInt32(hWidth * 0.68), 20);
            this.DeleteBtn.Location = new System.Drawing.Point(Convert.ToInt32(hWidth * 0.85), 20);

            for (int i = 0; i < taskbodypanel.Count; i++)
            {
                if (Grid_Panel.VerticalScroll.Visible == true)
                {
                    taskheader[i].Width = this.Grid_Panel.Width - 20;
                    taskbodypanel[i].Width = this.Grid_Panel.Width - 20;
                    for (int j = 0; j < taskbodypanel[i].Controls.Count; j++)
                    {
                        taskbodypanel[i].Controls[j].Width = this.Grid_Panel.Width - 20;
                    }
                } else
                {
                    taskheader[i].Width = this.Grid_Panel.Width - 2;
                    taskbodypanel[i].Width = this.Grid_Panel.Width - 2;
                    for (int j = 0; j < taskbodypanel[i].Controls.Count; j++)
                    {
                        taskbodypanel[i].Controls[j].Width = this.Grid_Panel.Width - 2;
                    }
                }                
            }
        }

        public void MenuItem_Click(object sender, EventArgs e)
        {
            mainFrm = (MainFrm)Form.FromHandle(ptr);
            MenuItem mi = sender as MenuItem;
            if (mi != null)
            {
                if(mi.Text== "Start Selected Items")
                {
                    for(int i = 0; i < mainFrm.newTaskItems.Count; i ++)
                    {
                        var taskItem = mainFrm.newTaskItems[i];
                        if(taskItem.taskRow.down == 1)
                        {
                            taskItem.start();
                        }
                    }
                }
                if (mi.Text == "Stop Selected Items")
                {

                }
                if (mi.Text == "Delete Selected Items")
                {

                }
                if (mi.Text == "Mass Edit URL")
                {
                    MassEditBtn_Click(sender, e);
                }
            }
        }
        public void Grid_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if(Control.ModifierKeys!=Keys.Control)
                {
                    if (Control.ModifierKeys != Keys.Shift)
                    {
                        for (int i = 0; i < taskbodypanel.Count; i++)
                        {
                            for (int j = 0; j < taskbodypanel[i].Controls.Count; j++)
                            {
                                if (((Task_Rows)taskbodypanel[i].Controls[j]).down == 1)
                                {
                                    ((Task_Rows)taskbodypanel[i].Controls[j]).down = 0;
                                    ((Task_Rows)taskbodypanel[i].Controls[j]).BackColor = Color.FromArgb(42, 42, 42);
                                }
                            }
                        }
                    }
                }
                ((Task_Rows)sender).down = 1;
                ((Task_Rows)sender).BackColor = Color.FromArgb(0, 0, 0);
                itemChecked++;
                MassEditBtn.Enabled = true;
            }
            if(e.Button==MouseButtons.Right)
            {
               
            }
        }
        public void Grid_MouseDown1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (Control.ModifierKeys != Keys.Control)
                {
                    for (int i = 0; i < taskbodypanel.Count; i++)
                    {
                        for (int j = 0; j < taskbodypanel[i].Controls.Count; j++)
                        {
                            if (((Task_Rows)taskbodypanel[i].Controls[j]).down == 1)
                            {
                                ((Task_Rows)taskbodypanel[i].Controls[j]).down = 0;
                                ((Task_Rows)taskbodypanel[i].Controls[j]).BackColor = Color.FromArgb(42, 42, 42);
                            }
                        }
                    }
                }
                if (((Task_Rows)((Label)sender).Parent).down == 0)
                {
                    ((Task_Rows)((Label)sender).Parent).down = 1;
                    ((Task_Rows)((Label)sender).Parent).BackColor = Color.FromArgb(0, 0, 0);
                    itemChecked++;
                    MassEditBtn.Enabled = true;
                }
                else
                {
                    ((Task_Rows)((Label)sender).Parent).down = 0;
                    ((Task_Rows)((Label)sender).Parent).BackColor = Color.FromArgb(42, 42, 42);
                }
            }
        }
        public void AddTitleHeader(int count = 0)
        {
            MainFrm mainfrm = (MainFrm)Form.FromHandle(ptr);
            int pos = 0;
            row_count = count == 0 ? mainfrm.newTaskItems.Count : count;
            if (row_count == 0) return;
            for(pos=0;pos<taskheader.Count;pos++)
            {
                if(taskheader[pos].TitleLBL.Text==mainfrm.newTaskItems[row_count-1].Site.SiteName)
                {
                    break;
                }
            }
            //if Taskheader do not exist
            if(pos==taskheader.Count)
            {
                Task_Rows taskrow = new Task_Rows(ptr);
                //taskrow.Name = row_count.ToString();
                taskrow.num = row_count - 1;
                taskrow.No = 1;
                taskrow.Setname();
                taskrow.MouseDown += new MouseEventHandler(this.Grid_MouseDown);
                taskrow.num_label.MouseDown += new MouseEventHandler(this.Grid_MouseDown1);
                taskrow.Store_label.MouseDown += new MouseEventHandler(this.Grid_MouseDown1);
                taskrow.Prod_label.MouseDown += new MouseEventHandler(this.Grid_MouseDown1);
                taskrow.Size_label.MouseDown += new MouseEventHandler(this.Grid_MouseDown1);
                taskrow.Prof_label.MouseDown += new MouseEventHandler(this.Grid_MouseDown1);
                taskrow.Proxy_label.MouseDown += new MouseEventHandler(this.Grid_MouseDown1);
                taskrow.Status_label.MouseDown += new MouseEventHandler(this.Grid_MouseDown1);
                TaskHeader_Rows tmpheaderrow = new TaskHeader_Rows(ptr);

                tmpheaderrow.No = taskheader.Count;
                tmpheaderrow.TitleLBL.Text = mainfrm.newTaskItems[row_count - 1].Site.SiteName;
                taskheader.Add(tmpheaderrow);
                FlowLayoutPanel tmppanel = new FlowLayoutPanel();

                tmppanel.Margin = new Padding(0, 0, 0, 0);
                tmppanel.Padding = new Padding(0, 0, 0, 0);
                //Grid_Panel.AutoScrollPosition=new Point(100);
                Grid_Panel.SetAutoScrollMargin(100, 100);
                Grid_Panel.HorizontalScroll.Visible = false;
                tmppanel.BackColor = Color.FromArgb(42, 42, 42);
                
                tmppanel.Controls.Add(taskrow);
                MenuItem[] mi = new MenuItem[4];
                mi[0] = new MenuItem("Start Selected Items", MenuItem_Click);
                mi[1] = new MenuItem("Stop Selected Items", MenuItem_Click);
                mi[2] = new MenuItem("Delete Selected Items", MenuItem_Click);
                mi[3] = new MenuItem("Mass Edit URL", MenuItem_Click);
                ContextMenu cm = new ContextMenu(mi);
                
                tmppanel.ContextMenu = cm;
                //tmppanel.Name = taskbodypanel.Count.ToString();
                taskbodypanel.Add(tmppanel);
                Grid_Panel.Controls.Add(taskheader[taskheader.Count - 1]);
                Grid_Panel.Controls.Add(taskbodypanel[taskbodypanel.Count - 1]);
            }
            else
            {
                Task_Rows taskrow1 = new Task_Rows(ptr);
                //taskrow1.Name = row_count.ToString();
                taskrow1.num = row_count - 1;
                taskrow1.No = taskbodypanel[pos].Controls.Count+1;
                taskrow1.Setname();
                taskbodypanel[pos].Height = 30 * (taskbodypanel[pos].Controls.Count+1);
                taskrow1.MouseDown += new MouseEventHandler(this.Grid_MouseDown);
                taskrow1.num_label.MouseDown += new MouseEventHandler(this.Grid_MouseDown1);
                taskrow1.Store_label.MouseDown += new MouseEventHandler(this.Grid_MouseDown1);
                taskrow1.Prod_label.MouseDown += new MouseEventHandler(this.Grid_MouseDown1);
                taskrow1.Size_label.MouseDown += new MouseEventHandler(this.Grid_MouseDown1);
                taskrow1.Prof_label.MouseDown += new MouseEventHandler(this.Grid_MouseDown1);
                taskrow1.Proxy_label.MouseDown += new MouseEventHandler(this.Grid_MouseDown1);
                taskrow1.Status_label.MouseDown += new MouseEventHandler(this.Grid_MouseDown1);
                taskbodypanel[pos].Controls.Add(taskrow1);
            }
            for (int k = 0; k < taskbodypanel.Count; k++)
            {
                if (Grid_Panel.VerticalScroll.Visible == true)
                {
                    taskheader[k].Width = this.Grid_Panel.Width-20;
                    taskbodypanel[k].Width = this.Grid_Panel.Width - 20;
                }
                else
                {
                    taskheader[k].Width = this.Grid_Panel.Width-2;
                    taskbodypanel[k].Width = this.Grid_Panel.Width-2;
                }
            }
        }
        private void CreateBtn_Click(object sender, EventArgs e)
        {
            if (MainFrm.shared.task_counter != 0)
            {
                return;
            }
            //MessageBox.Show(((MainFrm)Form.FromHandle(ptr)).taskitems.Count.ToString());
            TaskFrm taskfrm = new TaskFrm(ptr);
            taskfrm.ShowDialog();
            taskfrm.Close();
        }

        private void header_panel_Click(object sender, EventArgs e)
        {
          /*  for (int i = 0; i < taskbodypanel.Count; i++)
            {
                for (int j = 0; j < taskbodypanel[i].Controls.Count; j++)
                {
                    if (((Task_Rows)taskbodypanel[i].Controls[j]).down == 1)
                    {
                        int kk = ((Task_Rows)taskbodypanel[i].Controls[j]).num;
                        MessageBox.Show(kk.ToString());
                    }
                }
            }*/
        }

        private void MassEditBtn_Click(object sender, EventArgs e)
        {
            if (MainFrm.shared.task_counter != 0)
            {
                return;
            }
            MainFrm mainfrm = (MainFrm)Form.FromHandle(ptr);
            MassEditFrm massfrm = new MassEditFrm();
            if(massfrm.ShowDialog()==DialogResult.OK)
            {
                //MessageBox.Show(massfrm.MassURL);
                for (int i = 0; i < taskbodypanel.Count; i++)
                {
                    for(int j=0;j<taskbodypanel[i].Controls.Count;j++)
                    {
                        if(((Task_Rows)taskbodypanel[i].Controls[j]).down==1)
                        {
                            TaskModel tmpitem = mainfrm.newTaskItems[((Task_Rows)taskbodypanel[i].Controls[j]).num];
                            tmpitem.LinkType = "Early Link";
                            tmpitem.LinkURL = massfrm.MassURL;
                            mainfrm.newTaskItems[((Task_Rows)taskbodypanel[i].Controls[j]).num] = tmpitem;
                            ((Task_Rows)taskbodypanel[i].Controls[j]).Setname();

                        }
                    }
                }
            }
            
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            MainFrm mainfrm = (MainFrm)Form.FromHandle(ptr);
            for(int i = 0; i < mainFrm.newTaskItems.Count; i ++)
            {
                var taskItem = mainFrm.newTaskItems[i];
                taskItem.start();
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            if (MainFrm.shared.task_counter != 0)
            {
                return;
            }
        }

        private void CaptchaBtn_Click(object sender, EventArgs e)
        {
            if (MainFrm.shared.task_counter != 0)
            {
                return;
            }
        }

        public void SetDisplayOfButtons(bool IsDisplay)
        {

            DeleteBtn.Invoke((MethodInvoker)delegate ()
            {
                DeleteBtn.Enabled = IsDisplay;
            });
            CaptchaBtn.Invoke((MethodInvoker)delegate ()
            {
                CaptchaBtn.Enabled = IsDisplay;
            });
            CreateBtn.Invoke((MethodInvoker)delegate ()
            {
                CreateBtn.Enabled = IsDisplay;
            });
            MassEditBtn.Invoke((MethodInvoker)delegate ()
            {
                MassEditBtn.Enabled = IsDisplay;
            });
        }
    }
}
