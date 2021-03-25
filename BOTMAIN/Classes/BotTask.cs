using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Windows.Forms;
using System.Threading;

namespace BOTMAIN.Classes
{
    class BotTask
    {
        public string link = "";
        public BotTask()
        {

        }
        public string run(string url, string refer, string host)
        {
            Console.WriteLine($"https://kith.com/collections/kith-spring-and-classics/products/kith-x-converse-chuck-taylor-all-star-1970-classics-black: {url}");
            var responseText = GetProductPage(url, refer, host);
            return responseText;
        }
        public string GetProductPage(string url, string refer, string host)
        {
            try
            {
                var request = GetWebRequest(url);

                var sp = request.ServicePoint;
                var prop = sp.GetType().GetProperty("HttpBehaviour",
                                        System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
                prop.SetValue(sp, (byte)0, null);

                CookieContainer cookieJar = new CookieContainer();
                request.CookieContainer = cookieJar;
                request.UserAgent = @"Mozilla/5.0 (Macintosh; Intel Mac OS X 10_11_5) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/52.0.2743.116 Safari/537.36";
                request.Referer = refer;
                request.Host = host;

                request.Headers.Add("Accept-Language", "en-US,en;q=0.9");
                request.Accept = @"*/*";
                request.Method = "GET";
                request.KeepAlive = true;
                request.AllowAutoRedirect = false;

                var response = (HttpWebResponse)request.GetResponse();

                string html = "";
                using (var reader = new StreamReader(response.GetResponseStream()))
                {
                    html = reader.ReadToEnd();
                }
                return html;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return "";
            }
        }
        public HttpWebRequest GetWebRequest(string url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            return request;
        }
    }
}
