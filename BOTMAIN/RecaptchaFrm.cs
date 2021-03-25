using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CefSharp;
using CefSharp.WinForms;
using BOTMAIN.Model;
using System.Net;
using System.IO;
using HtmlAgilityPack;

namespace BOTMAIN
{
    public partial class RecaptchaFrm : Form
    {
        private ChromiumWebBrowser browser { get; set; }
        private CookieContainer cookieJar { get; set; }
        private CaptchaInfo captchaInfo { get; set; }
        private HttpWebRequest webRequest { get; set; }
        private Dictionary<string, string> rparams = new Dictionary<string, string>();


        public RecaptchaFrm(CaptchaInfo captchaInfo)
        {
            this.captchaInfo = captchaInfo;

            InitializeComponent();
            CenterToScreen();

            var proxy = captchaInfo.proxy;
            if (captchaInfo.proxy != null)
            {
                ProxyOptions proxyOptions = new ProxyOptions(proxy.Host, Convert.ToString(proxy.Port), proxy.Username, proxy.Password, "localhost,checkout.shopify.com");
                CefSharpSettings.Proxy = proxyOptions;
            }

            CreateNewBrower();
        }

        public void CreateNewBrower()
        {
            var requestContext = new RequestContext();

            browser = new ChromiumWebBrowser($"https://checkout.shopify.com?id={captchaInfo.taskId}", requestContext);
            browser.RequestHandler = new RecaptchaHandler(captchaInfo.browserInfo);

            BrowserContainer.Controls.Add(browser);
            browser.Dock = DockStyle.Fill;
        }
        private void RecaptchaFrm_Leave(object sender, EventArgs e)
        {
            browser.Dispose();
        }
    }
}