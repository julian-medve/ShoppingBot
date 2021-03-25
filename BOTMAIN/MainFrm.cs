using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Data.SQLite;
using CefSharp;
using CefSharp.WinForms;
using System.Threading;

using BOTMAIN.RecaptchaServer;
using BOTMAIN.Classes;
using BOTMAIN.Model;
using System.Diagnostics;
using BOTMAIN.EntityModels;

namespace BOTMAIN
{
    public partial class MainFrm : Form
    {

        //for json class
        public static MainFrm shared = null;
        public static int port = 9999;

        public static DatabaseContext context { get; set; }

        private void MainFrm_Resize(object sender, System.EventArgs e)
        {
            //Console.WriteLine(this.HeaderPanel.Width);
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);
                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }
            base.WndProc(ref m);
        }

        public class AllProduct_List
        {
            public List<Product_list> products { get; set; }
        }
        public class Product_list
        {
            public long id { get; set; }
            public string title { get; set; }
            public string handle { get; set; }
            public string body_html { get; set; }
            public string published_at { get; set; }
            public string created_at { get; set; }
            public string updated_at { get; set; }
            public string vendor { get; set; }
            public string product_type { get; set; }
            public string[] tags { get; set; }
            public List<Variant> variants { get; set; }
            public List<product_images> images { get; set; }
            public List<product_options> options { get; set; }
        }


        public class Variant
        {
            public long id { get; set; }
            public string title { get; set; }
            public string option1 { get; set; }
            public string option2 { get; set; }
            public string option3 { get; set; }
            public string sku { get; set; }
            public bool requires_shpping { get; set; }
            public bool taxable { get; set; }
            public string featured_image { get; set; }
            public bool available { get; set; }
            public string price { get; set; }
            public long grams { get; set; }
            public string compare_at_price { get; set; }
            public int position { get; set; }
            public long product_id { get; set; }
            public string created_at { get; set; }
            public string updated_at { get; set; }

        }
        public class product_images
        {
            public long id { get; set; }
            public string created_at { get; set; }
            public int position { get; set; }
            public string updated_at { get; set; }
            public long product_id { get; set; }
            public List<long> variant_ids { get; set; }
            public string src { get; set; }
            public int width { get; set; }
            public int height { get; set; }
        }
        public class product_options
        {
            public string name { get; set; }
            public int position { get; set; }
            public List<string> values { get; set; }
        }


        //public List<TaskItem> taskitems { get; set; }
        public List<TaskModel> newTaskItems { get; set; }

        public List<ProxyModel> proxiesitems = new List<ProxyModel>();
        public List<BillingModel> billitems = new List<BillingModel>();
        public List<CaptchaModel> captchaitems = new List<CaptchaModel>();
        public List<SiteProxyModel> siteproxyItems = new List<SiteProxyModel>();

        public Task TaskUser;
        public Profile ProfileUser;
        public Proxy ProxyUser;
        public Captcha CaptchaUser;
        public SQLiteConnection myconn;

        public int task_counter = 0;

        private Queue<CaptchaInfo> captchaInfoList = new Queue<CaptchaInfo>();
        private RecaptchaFrm recaptchaFrm = null;
        private Thread recaptchaThread = null;
        private SimpleHTTPServer myServer = null;

        private const int cGrip = 16;      // Grip size
        private const int cCaption = 32;   // Caption bar height;

        public MainFrm()
        {
            context = new DatabaseContext();

            Configure();

            InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);

            shared = this;
            CenterToScreen();


            string myFolder = Application.StartupPath + "\\htdocs";
            myServer = new SimpleHTTPServer(myFolder, port);
        }


        public void SetDisplayOfButtons(bool isStart)
        {
            if (isStart) task_counter++;
            else task_counter--;
            TaskUser.SetDisplayOfButtons(task_counter == 0);
        }


        public void createRecaptchaFrm(string task_id, ProxyModel proxy, BrowserInfo browserInfo)
        {
            captchaInfoList.Enqueue(new CaptchaInfo {
                taskId = task_id,
                proxy = proxy,
                browserInfo = browserInfo
            });
            runRecaptcha();
        }

        public void Configure()
        {
            CefSettings cefSettings = new CefSettings();
            Cef.Initialize(cefSettings);
        }
        public void runRecaptcha()
        {
            if (recaptchaThread != null) return;
            recaptchaThread = new Thread(() =>
            {
                try
                {
                    while (captchaInfoList.Count > 0)
                    {
                        var captchaInfo = captchaInfoList.Dequeue();

                        Invoke((MethodInvoker)delegate ()
                        {
                            recaptchaFrm = new RecaptchaFrm(captchaInfo);
                            recaptchaFrm.ShowDialog();
                        });
                    }
                }
                catch (Exception e)
                {
                }
                finally
                {
                    recaptchaThread = null;
                }
            });
            recaptchaThread.Start();
        }

        public void closeRecaptchaFrm(string task_id)
        {
            Invoke((MethodInvoker)delegate ()
            {
                if (recaptchaFrm == null) return;
                recaptchaFrm.Close();
                recaptchaFrm.Dispose();
                recaptchaFrm = null;
            });
        }

        private void task_btn_Click(object sender, EventArgs e)
        {
            task_btn.Normalcolor = Color.FromArgb(25, 25, 25);
            prof_btn.Normalcolor = Color.FromArgb(42, 42, 42);
            prox_btn.Normalcolor = Color.FromArgb(42, 42, 42);
            cap_btn.Normalcolor = Color.FromArgb(42, 42, 42);
            setting_btn.Normalcolor = Color.FromArgb(42, 42, 42);
            TaskUser.Show();
            ProfileUser.Hide();
            ProxyUser.Hide();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            Close();

        }

        internal void openMessageBox(string message)
        {
            MessageBox.Show(message, "Recaptcha Server Error");
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            readSiteProxies();

            ProfileUser = new Profile(this.Handle);
            ProfileUser.Dock = DockStyle.Fill;
            Main_Panel.Controls.Add(ProfileUser);
            ProfileUser.Hide();
            readProfile(); 

            TaskUser = new Task(this.Handle);
            TaskUser.Dock = DockStyle.Fill;
            Main_Panel.Controls.Add(TaskUser);
            readTask();

            ProxyUser = new Proxy(this.Handle);
            ProxyUser.Dock = DockStyle.Fill;
            Main_Panel.Controls.Add(ProxyUser);
            ProxyUser.Hide();
            readProxy();

            CaptchaUser = new Captcha(this.Handle);
            CaptchaUser.Dock = DockStyle.Fill;
            Main_Panel.Controls.Add(CaptchaUser);
            CaptchaUser.Hide();
            readCaptcha();

            task_btn.Normalcolor = Color.FromArgb(25, 25, 25);

        }

        public void readSiteProxies()
        {
            foreach (SiteProxyModel item in context.SiteProxy.ToList())
            {
                siteproxyItems.Add(item);
            }
        }



        public void readTask()
        {
            newTaskItems = context.ShippingTask.ToList();
            for (int i = 1; i <= newTaskItems.Count; i++)
            {
                TaskUser.AddTitleHeader(i);
            }
        }

        public void readProfile()
        {
            foreach (BillingModel item in context.Billing.ToList())
            {
                billitems.Add(item);
                ProfileUser.Add_Row();
            }
        }
        public void deleteAllProxyList()
        {
            MySQLite.DB.deleteAllProxyItems();
        }

        public void readProxy()
        {
            foreach (ProxyModel item in MainFrm.context.Proxy.ToList())
            {
                proxiesitems.Add(item);
                ProxyUser.Add_Row();
            }
        }

        //public void UpdateCaptcha(int id)
        //{
        //    MySQLite.DB.updateCaptchaItems(id, captchaitems[id]);
        //}
        private void cap_btn_Click(object sender, EventArgs e)
        {
            if (task_counter != 0)
            {
                return;
            }
            cap_btn.Normalcolor = Color.FromArgb(25, 25, 25);
            task_btn.Normalcolor = Color.FromArgb(42, 42, 42);
            prox_btn.Normalcolor = Color.FromArgb(42, 42, 42);
            prof_btn.Normalcolor = Color.FromArgb(42, 42, 42);
            setting_btn.Normalcolor = Color.FromArgb(42, 42, 42);
            CaptchaUser.Show();
            TaskUser.Hide();
            ProxyUser.Hide();
            ProfileUser.Hide();
        }

        public void readCaptcha()
        {
            foreach (CaptchaModel item in context.Captcha.ToList())
            {
                captchaitems.Add(item);
                CaptchaUser.Add_Row();
            }
        }

        private void prof_btn_Click(object sender, EventArgs e)
        {
            if (task_counter != 0)
            {
                return;
            }
            prof_btn.Normalcolor = Color.FromArgb(25, 25, 25);
            task_btn.Normalcolor = Color.FromArgb(42, 42, 42);
            prox_btn.Normalcolor = Color.FromArgb(42, 42, 42);
            cap_btn.Normalcolor = Color.FromArgb(42, 42, 42);
            setting_btn.Normalcolor = Color.FromArgb(42, 42, 42);
            ProfileUser.Show();
            TaskUser.Hide();
            ProxyUser.Hide();
            CaptchaUser.Hide();
        }

        private void mini_btn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void prox_btn_Click(object sender, EventArgs e)
        {
            if (task_counter != 0)
            {
                return;
            }
            prox_btn.Normalcolor = Color.FromArgb(25, 25, 25);
            task_btn.Normalcolor = Color.FromArgb(42, 42, 42);
            prof_btn.Normalcolor = Color.FromArgb(42, 42, 42);
            cap_btn.Normalcolor = Color.FromArgb(42, 42, 42);
            setting_btn.Normalcolor = Color.FromArgb(42, 42, 42);
            ProxyUser.Show();
            TaskUser.Hide();
            ProfileUser.Hide();
            CaptchaUser.Hide();
        }

        public void SetRecaptchaResponse(RecaptchaResponse response)
        {
            if (TaskModel.All.Keys.Contains(response.id))
            {
                var item = TaskModel.All[response.id];
                item.task.g_recaptcha_response = response.token;
                closeRecaptchaFrm(response.id);
            }
        }

        private void MainFrm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (recaptchaFrm != null)
            {
                recaptchaFrm.Close();
                recaptchaFrm.Dispose();
            }
            Cef.Shutdown();
            Service.RemoveDomainToHost();
            myServer.Stop();
            Process.GetCurrentProcess().Kill();
        }

        private void setting_btn_Click(object sender, EventArgs e)
        {
            if (task_counter != 0)
            {
                return;
            }
        }
    }

    public class RecaptchaResponse
    {
        public string id { get; set; }
        public string token { get; set; }
    }

}
