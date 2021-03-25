using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using BOTMAIN.EntityModels;
using HtmlAgilityPack;

namespace BOTMAIN.Model
{
    class GoogleLogin
    {
        public CookieContainer cookieContainer
        {
            get
            {
                return cookieJar;
            }
        }
        private CookieContainer cookieJar { get; set; }
        private CaptchaInfo captchaInfo { get; set; }
        private Dictionary<string, string> requestParams { get; set; }

        public GoogleLogin(CaptchaInfo captchaInfo)
        {
            this.captchaInfo = captchaInfo;
        }

        public void Login()
        {
            requestParams = new Dictionary<string, string>();
            requestParams["URL"] = @"https://accounts.google.com/signin/v2/identifier?service=oz&flowName=GlifWebSignIn&flowEntry=ServiceLogin";
            requestParams["RequestName"] = "LoginPage";

            var webRequest = GetRequest(requestParams["URL"]);
            webRequest.UserAgent = captchaInfo.browserInfo.useragent;

            cookieJar = new CookieContainer();
            webRequest.CookieContainer = cookieJar;

            string html = string.Empty;

            try
            {
                using (WebResponse response = webRequest.GetResponse())
                {
                    using (var streamReader = new StreamReader(response.GetResponseStream()))
                    {
                        html = streamReader.ReadToEnd();
                        ParseLoginRequest(html, response);
                    }
                }
            }
            catch (WebException e)
            {
                using (WebResponse response = e.Response)
                {
                    HttpWebResponse httpResponse = (HttpWebResponse)response;
                    Console.WriteLine("Error code: {0}", httpResponse.StatusCode);
                    using (var streamReader = new StreamReader(response.GetResponseStream()))
                        Console.WriteLine(html = streamReader.ReadToEnd());
                }
            }
        }

        private void ParseLoginRequest(string html, WebResponse response)
        {
            Console.WriteLine(html);
            HtmlNode.ElementsFlags.Remove("form");

            HtmlDocument doc = new HtmlDocument();
            doc.LoadHtml(html);
            HtmlNode form = doc.DocumentNode.ChildNodes.FindFirst("form");

            requestParams["URL"] = form.GetAttributeValue("action", string.Empty);
            requestParams["ReqeustName"] = "LoginPost";

            var inputs = form.Descendants("input");

            foreach (var element in inputs)
            {
                string name = element.GetAttributeValue("name", "undefined");
                string value = element.GetAttributeValue("value", "");
                if (!name.Equals("undefined"))
                {
                    if (name.ToLower().Equals("identifier"))
                    {
                        value = captchaInfo.username;
                    } else if (name.ToLower().Equals("passwd"))
                    {
                        value = captchaInfo.password;
                    }
                    requestParams[name] = value;
                }
            }

            
            var webRequest = GetRequest(requestParams["URL"]);
            webRequest.UserAgent = captchaInfo.browserInfo.useragent;
            webRequest.Method = "POST";
            webRequest.ContentType = "application/x-www-form-urlencoded";
            webRequest.CookieContainer = cookieJar;

            var parameters = new StringBuilder();

            foreach (var key in requestParams.Keys)
            {
                parameters.AppendFormat("{0}={1}&", HttpUtility.UrlEncode(key.ToString()),
                    HttpUtility.UrlEncode(requestParams[key.ToString()]));
            }

            parameters.Length -= 1;

            using (var writer = new StreamWriter(webRequest.GetRequestStream()))
            {
                writer.Write(parameters.ToString());
            }

            html = string.Empty;

            using (response = webRequest.GetResponse())
            {
                using (var streamReader = new StreamReader(response.GetResponseStream()))
                {
                    html = streamReader.ReadToEnd();

                }
            }

        }

        private HttpWebRequest GetRequest(string url)
        {
            var webRequest = (HttpWebRequest)HttpWebRequest.Create(url);
            SetProxy(webRequest);
            return webRequest;
        }
        private void SetProxy(HttpWebRequest request)
        {
            if (captchaInfo.proxy != null)
            {
                if (captchaInfo.proxy == null || captchaInfo.proxy.Host == null) return;

                var proxy = new WebProxy();
                Uri uri = new Uri($"http://{captchaInfo.proxy.Host}:{captchaInfo.proxy.Port}");
                proxy.Address = uri;

                if (captchaInfo.proxy.Username != null && captchaInfo.proxy.Password != null)
                {
                    proxy.Credentials = new NetworkCredential(captchaInfo.proxy.Username, captchaInfo.proxy.Password);
                }
                else
                {
                    proxy.Credentials = new NetworkCredential();
                }

                request.Proxy = proxy;
            }
        }
    }
}
