using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Web.Script.Serialization;
using System.Text.RegularExpressions;
using System.Xml;
using Newtonsoft.Json.Linq;
using System.Threading;
using BOTMAIN.EntityModels;
using BOTMAIN.Classes;

namespace BOTMAIN.Model
{
    public class ShopifyTask: Object
    {
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

        public string Link { get; set; }
        public string pkeyword, nkeyword;
        public string VLink { get; set; }
        public string SiteHost { get; set; }
        public HttpWebResponse response { get; set; }
        public HttpWebRequest request { get; set; }
        public CookieCollection addcart = new CookieCollection(), checkout = new CookieCollection();
        public string checkouturl = "", card_info = "", shipping_rates = "";

        public bool threadStart = true;
        public string resultURL = "";
        public int[] stepF = new int[6];
        public string htmltxt { get; set; }
        public string productID { get; set; }
        public BillingModel Billinfo { get; set; }
        public TaskModel taskitem { get; set; }
        public string g_recaptcha_response = "";
        public bool captchaCheck = false;

        // Proxy Setting Attributes
        private ProxyModel proxy { get; set; }
        private BrowserInfo browserInfo { get; set; }

        private Thread taskThread { get; set; }


        //public ShopifyTask()
        //{
        //    Link = "";
        //    pkeyword = "";
        //    nkeyword = "";
        //    VLink = "";
        //    SiteName = "";
        //}
        public ShopifyTask(TaskModel task)
        {
            Billinfo = task.Billing;
            taskitem = task;
            SiteHost = task.Site.SiteHost;
            captchaCheck = false;
        }
        
        //public ShopifyTask(string url, bool type, string sitename)
        //{
        //    SiteName = sitename;

        //    if (type)
        //    {
        //        Link = url;
        //    }
        //    else
        //    {
        //        VLink = url;
        //    }
        //}

        //public ShopifyTask(string pkey, string nkey, string sitename)
        //{
        //    SiteName = sitename;
        //    pkeyword = pkey;
        //    nkeyword = nkey;
        //}
        private bool MakeKeyword(string handle)
        {
            string tmp1 = taskitem.LinkURL;
            int startpos = -1;

            while (true)
            {
                startpos = tmp1.IndexOf("&");
                if (startpos > -1)
                {
                    //myobj.title.indexOf('YEEZY') >= 0
                    if (handle.IndexOf(tmp1.Substring(0, startpos)) == -1) return false;
                    tmp1 = tmp1.Substring(startpos + 1);
                }
                else
                {
                    if (handle.IndexOf(tmp1) == -1) return false;
                    break;
                }
            }
            return true;
        }
        public string GetProductID(string html)
        {
            string patternstr = "";
            if (SiteHost.IndexOf("yeezy") > -1)
            {
                patternstr = @"<script class=""js-product-json"" type=""application/json"">([^>]*)</script>";
            }
            if (SiteHost.IndexOf("kith") > -1)
            {
                patternstr = @"<script type=""application/json"" data-product-json>([^>]*)</script>";
            }
            if (SiteHost.IndexOf("deadstock") > -1)
            {
                patternstr = @"<script type=""application/json"" id=""ProductJson-product-template"">([^>]*)</script>";
            }
            Match match = Regex.Match(html, patternstr,
                        RegexOptions.IgnoreCase);
            JObject pro = new JObject();
            int findF = 0;
            while (match.Success)
            {
                // Finally, we get the Group value and display it.
                string key = match.Groups[1].Value;
                pro = (JObject)Newtonsoft.Json.JsonConvert.DeserializeObject(key);
                string tmpstr = pro["handle"].ToString();
                if (taskitem.LinkType == "Early Link")
                {
                    findF = 1;
                    break;
                }
                if (MakeKeyword(tmpstr))
                {
                    findF = 1;
                    break;
                }
                match = match.NextMatch();
            }
            if (findF == 0) return "";
            for (int i = 0; i < pro["variants"].Count(); i++)
            {
                string tmpstr = pro["variants"][i]["option1"].ToString();
                if (tmpstr.IndexOf("10") > -1)
                {
                    return pro["variants"][i]["id"].ToString();
                }
            }
            return pro["variants"][0]["id"].ToString();
        }
        public void run(string proxyAddress = null, string username = null, string password = null)
        {
            proxy = taskitem.Site.ProxyList.next();
            browserInfo = new BrowserInfo();

            if (taskThread != null) return;
            addcart = new CookieCollection(); checkout = new CookieCollection();
            response = null;
            JavaScriptSerializer JsonSerializer = new JavaScriptSerializer();

            taskThread = new Thread(() =>
            {
                try
                {
                    if (taskitem.LinkType == "Early Link")
                    {
                        setStatus("Getting Product");

                        htmltxt = GetProductPage(taskitem.LinkURL, @"https://" + SiteHost + @"/", SiteHost);
                    }
                    else if (taskitem.LinkType == "Keyword")
                    {
                        setStatus("Getting Product");
                        htmltxt = GetProductPage(@"https://" + SiteHost + @"/", @"http://" + SiteHost + @"/", SiteHost);
                    }
                    productID = GetProductID(htmltxt);
                    if (productID == "")
                    {
                        throw new Exception("Empty product");
                    }

                    setStatus("Get Checkout url");
                    checkouturl = GetCheckoutURL(GetLinks(@"https://" + SiteHost + @"//checkout.js", @"http://" + SiteHost + @"/", SiteHost));
                    if (checkouturl.IndexOf("checkpoint") > -1)
                    {
                        setStatus("waiting a captcha for checkpoint");
                        openRecaptcha();
                        while (g_recaptcha_response == "") { }
                        checkouturl = GetCheckoutURL(Checkpointprocessing(checkouturl, @"https://kith.com/checkpoint?return_to=https%3A%2F%2Fkith.com%2Fcart", SiteHost));
                    }
                    if (checkouturl.IndexOf("queue") > -1)
                    {
                        setStatus("waiting Queue");
                        var resultString = "";
                        while (true)
                        {
                            System.Threading.Thread.Sleep(5000);
                            resultString = ThrottleQueue(@"https://" + SiteHost + @"/checkout/poll?js_poll=1", @"http://" + SiteHost + @"/", SiteHost);
                            if (resultString != "{}") break;
                        }
                        setStatus("Get Checkout url");
                        checkouturl = GetCheckoutURL(resultString);
                    }
                    resultURL = checkouturl;


                    setStatus("Adding Checkout");
                    AddCheckout(checkouturl, @"http://" + SiteHost + @"/", SiteHost);
                    resultURL = response.ResponseUri.ToString();


                    setStatus("Get Cart Links");
                    GetLinks(@"https://" + SiteHost + @"/cart/add.js?id=" + productID + @"&quantity=1", @"http://" + SiteHost + @"/", SiteHost);


                    setStatus("Passing checkout");
                    checkouts(checkouturl + @"?previous_step=shipping_method&step=payment_method", @"http://" + SiteHost + @"/", SiteHost);
                    resultURL = response.ResponseUri.ToString();


                    setStatus("Getting card info");
                    card_info = GetCardInfo(@"https://elb.deposit.shopifycs.com/sessions", @"https://checkout.shopifycs.com", @"elb.deposit.shopifycs.com");


                    setStatus("Getting shipping rate");
                    shipping_rates = GetShippingRate(@"http://" + SiteHost + @"/cart/shipping_rates.json", @"http://" + SiteHost + @"/", SiteHost);


                    setStatus("Going to payment");
                    GotoPayment(checkouturl + @"?previous_step=shipping_method&step=payment_method", @"http://" + SiteHost + @"/", SiteHost);


                    setStatus("Waiting a captcha");
                    openRecaptcha();
                    while (captchaCheck == true && g_recaptcha_response == "") {}


                    setStatus("Processing payment(1)");
                    PaymentProcessing(checkouturl, @"http://" + SiteHost + @"/", SiteHost, 0);


                    setStatus("Processing payment(2)");
                    PaymentProcessing(checkouturl, @"http://" + SiteHost + @"/", SiteHost, 1);


                    setStatus("Processing...");
                    while (true)
                    {
                        string str = ProcessingStatus(checkouturl + @"/processing", @"http://" + SiteHost + @"/", SiteHost);
                        if (str != "No")
                        {
                            setStatus(str);
                            setStartButton();
                            break;
                        }
                    }
                }
                catch (Exception ex)
                {
                    if (ex.Message != "Thread was being aborted.")
                    {
                        setStatus(ex.Message);
                        setStartButton();
                    }
                }
                finally {
                    taskThread = null;
                }
            });

            taskThread.Start();
        }
        
        public void stop()
        {
            try
            {
                taskThread.Abort();
            }
            catch (Exception e) {
                Console.WriteLine(e);
            }
        }
        public void setStatus(string result_string)
        {
            var thread = new System.Threading.Thread(() =>
            {
                taskitem.taskRow.setStatus(result_string);
            });
            thread.Start();
        }
        public void setStartButton()
        {
            var thread = new System.Threading.Thread(() =>
            {
                taskitem.taskRow.setStartButton();
            });
            thread.Start();
        }
        public void openRecaptcha()
        {
            g_recaptcha_response = "";
            if (!captchaCheck) return;
            MainFrm.shared.createRecaptchaFrm(Convert.ToString(taskitem.ID), proxy, browserInfo);
        }
        public string GetCheckoutURL(string source)
        {
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();
            doc.LoadHtml(source);
            var link = doc.DocumentNode.Descendants("a").ToList()[0].GetAttributeValue("href", null);
            return link;
        }
        public string GetLinks(string Url, string refer, string hostname)
        {

            CookieContainer cookieJar = new CookieContainer();
            //request.KeepAlive = true;

            request = GetWebRequest(Url);
            //request.Headers.Add("Connection", "keep-alive");
            var sp = request.ServicePoint;
            var prop = sp.GetType().GetProperty("HttpBehaviour",
                                    System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
            prop.SetValue(sp, (byte)0, null);
            request.KeepAlive = true;

            request.CookieContainer = cookieJar;
            if (response != null) request.CookieContainer.Add(addcart);
            request.Accept = @"*/*";
            request.Referer = refer;
            request.Headers.Add("Accept-Language", "en-US,en;q=0.9");
            request.Headers.Add("Accept-Encoding", "gzip,deflate,sdch");
            //request.UserAgent = @"Mozilla/5.0 (Macintosh; Intel Mac OS X 10_11_5) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/52.0.2743.116 Safari/537.36";
            request.UserAgent = browserInfo.useragent;
            request.ContentType = "multipart/form-data; boundary=--------------------------";
            request.Host = hostname;
            request.Method = "POST";
            request.AllowAutoRedirect = false;

            response = (HttpWebResponse)request.GetResponse();
            String htmlString;
            using (var reader = new StreamReader(response.GetResponseStream()))
            {
                htmlString = reader.ReadToEnd();
                Uri uri = new Uri(@"https://" + SiteHost + @"/");
                //request.CookieContainer.GetCookies(uri);
                addcart.Add(request.CookieContainer.GetCookies(uri));
                if (checkouturl != "") addcart.Add(request.CookieContainer.GetCookies(new Uri(checkouturl)));
                addcart.Add(response.Cookies);
                return htmlString;
            }
        }
        public string GetProductPage(string Url, string refer, string hostname)
        {

            request = GetWebRequest(Url);
            //request.Headers.Add("Connection", "keep-alive");
            var sp = request.ServicePoint;
            var prop = sp.GetType().GetProperty("HttpBehaviour",
                                    System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
            prop.SetValue(sp, (byte)0, null);


            CookieContainer cookieJar = new CookieContainer();
            request.CookieContainer = cookieJar;
            request.UserAgent = browserInfo.useragent;
            request.Referer = refer;
            request.Host = hostname;
            //request.Headers.Add("Accept-Encoding", "gzip,deflate,sdch");
            //request.UserAgent = @"Mozilla/5.0 (Macintosh; Intel Mac OS X 10_11_5) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/52.0.2743.116 Safari/537.36";

            request.Headers.Add("Accept-Language", "en-US,en;q=0.9");
            request.Accept = @"*/*"; 
            request.Method = "GET";
            request.KeepAlive = true;
            request.AllowAutoRedirect = false;
            //request.ContentType = "multipart/form-data; boundary=--------------------------";

            response = (HttpWebResponse)request.GetResponse();
            string htmlString;
            using (var reader = new StreamReader(response.GetResponseStream()))
            {
                htmlString = reader.ReadToEnd();
                return htmlString;
            }
        }
        public string AddCheckout(string Url, string refer, string hostname)
        {

            CookieContainer cookieJar = new CookieContainer();
            request = GetWebRequest(Url);
            var sp = request.ServicePoint;
            var prop = sp.GetType().GetProperty("HttpBehaviour",
                                    System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
            prop.SetValue(sp, (byte)0, null);
            request.KeepAlive = true;

            request.CookieContainer = cookieJar;
            if (response != null) request.CookieContainer.Add(addcart);
            request.Referer = refer;
            request.Headers.Add("Accept-Language", "en-US,en;q=0.9");
            request.Headers.Add("Accept-Language", "gzip,deflate,sdch");
            //request.UserAgent = @"Mozilla/5.0 (Macintosh; Intel Mac OS X 10_11_5) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/52.0.2743.116 Safari/537.36";
            request.UserAgent = browserInfo.useragent;
            request.ContentType = "application/x-www-form-urlencoded";
            request.Accept = @"text/html, application/xhtml+xml, */*";
            request.Host = hostname;
            var payload_ship_info = @"utf8=%25e2%259c%2593&_method=patch&authenticity_token=&";
            payload_ship_info += @"previous_step=contact_information&step=shipping_method&";
            payload_ship_info += @"checkout%5bemail%5d=" + Billinfo.Email.Replace("@", "%40") + @"&checkout%5bbuyer_accepts_marketing%5d=0&";
            payload_ship_info += @"checkout%5bshipping_address%5d%5bfirst_name%5d=" + Billinfo.BillFirstName + @"&checkout%5bshipping_address%5d%5blast_name%5d=" + Billinfo.BillLastName;
            payload_ship_info += @"&checkout%5bshipping_address%5d%5bcompany%5d=&checkout%5bshipping_address%5d%5baddress1%5d=" + Billinfo.BillAddress1.Replace(" ", "+");
            payload_ship_info += @"&checkout%5bshipping_address%5d%5baddress2%5d=" + Billinfo.BillAddress2.Replace(" ", "+") + @"&checkout%5bshipping_address%5d%5bcity%5d=" + Billinfo.BillCity.Replace(" ", "+");
            payload_ship_info += @"&checkout%5bshipping_address%5d%5bcountry%5d=" + Billinfo.BillCountry.Replace(" ", "+") + @"&checkout%5bshipping_address%5d%5bprovince%5d=" + Billinfo.BillStateXX.Replace(" ", "+");
            payload_ship_info += @"&checkout%5bshipping_address%5d%5bzip%5d=" + Billinfo.BillZipCode + @"&checkout%5bshipping_address%5d%5bphone%5d=" + Billinfo.BillPhone + @"&checkout%5bremember_me%5d=0&checkout%5bclient_details%5d%5bbrowser_width%5d=1710&checkout%5bclient_details%5d%5bbrowser_height%5d=1289&checkout%5bclient_details%5d%5bjavascript_enabled%5d=1";

            request.Method = "POST";
            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                streamWriter.Write(payload_ship_info);
            }
            request.AllowAutoRedirect = false;
            response = (HttpWebResponse)request.GetResponse();
            String htmlString;
            using (var reader = new StreamReader(response.GetResponseStream()))
            {
                htmlString = reader.ReadToEnd();
                Uri uri = new Uri(@"https://" + SiteHost + @"/");
                addcart.Add(request.CookieContainer.GetCookies(uri));
                if (checkouturl != "") addcart.Add(request.CookieContainer.GetCookies(new Uri(checkouturl)));
                addcart.Add(response.Cookies);
                return htmlString;
            }
        }
        public string checkouts(string Url, string refer, string hostname)
        {
            //string Url = "https://kith.com/products.json";
            CookieContainer cookieJar = new CookieContainer();
            request = GetWebRequest(Url);

            var sp = request.ServicePoint;
            var prop = sp.GetType().GetProperty("HttpBehaviour",
                                    System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
            prop.SetValue(sp, (byte)0, null);
            request.KeepAlive = true;

            request.CookieContainer = cookieJar;
            request.CookieContainer.Add(addcart);
            request.Accept = @"text/html, application/xhtml+xml, */*";
            request.Referer = refer;
            request.Headers.Add("Accept-Language", "en-GB");
            //request.UserAgent = @"Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 6.2; Trident/6.0)";
            request.UserAgent = browserInfo.useragent;
            request.Host = hostname;
            request.AllowAutoRedirect = false;

            response = (HttpWebResponse)request.GetResponse();
            string htmlString;
            using (var reader = new StreamReader(response.GetResponseStream()))
            {
                Uri uri = new Uri(@"https://" + SiteHost + @"/");
                request.CookieContainer.GetCookies(uri);
                addcart.Add(request.CookieContainer.GetCookies(uri));
                if (checkouturl != "") addcart.Add(request.CookieContainer.GetCookies(new Uri(checkouturl)));
                addcart.Add(response.Cookies);
                htmlString = reader.ReadToEnd();
                return htmlString;
            }
        }
        public string ThrottleQueue(string Url, string refer, string hostname)
        {
            //string Url = "https://kith.com/products.json";
            CookieContainer cookieJar = new CookieContainer();
            request = GetWebRequest(Url);

            var sp = request.ServicePoint;
            var prop = sp.GetType().GetProperty("HttpBehaviour",
                                    System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
            prop.SetValue(sp, (byte)0, null);
            request.KeepAlive = false;

            request.CookieContainer = cookieJar;
            request.CookieContainer.Add(addcart);
            request.Accept = @"text/html, application/xhtml+xml, */*";
            request.Referer = refer;
            request.Headers.Add("Accept-Language", "en-GB");
            //request.UserAgent = @"Mozilla/5.0 (compatible; MSIE 10.0; Windows NT 6.2; Trident/6.0)";
            request.UserAgent = browserInfo.useragent;
            request.Host = hostname;
            request.AllowAutoRedirect = true;

            response = (HttpWebResponse)request.GetResponse();

            string htmlString;
            using (var reader = new StreamReader(response.GetResponseStream()))
            {
                Uri uri = new Uri(@"https://" + SiteHost + @"/");
                request.CookieContainer.GetCookies(uri);
                addcart.Add(request.CookieContainer.GetCookies(uri));
                if (checkouturl != "") addcart.Add(request.CookieContainer.GetCookies(new Uri(checkouturl)));
                addcart.Add(response.Cookies);
                htmlString = reader.ReadToEnd();
                return htmlString;
            }
        }
        public string GetCardInfo(string Url, string refer, string hostname)
        {
            //string Url = "https://kith.com/products.json";
            CookieContainer cookieJar = new CookieContainer();
            request = GetWebRequest(Url);

            var sp = request.ServicePoint;
            var prop = sp.GetType().GetProperty("HttpBehaviour",
                                    System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
            prop.SetValue(sp, (byte)0, null);
            request.KeepAlive = true;

            request.CookieContainer = cookieJar;
            request.Accept = @"application/json";
            request.Headers.Add("Origin", "https://checkout.shopifycs.com,https://checkout.shopifycs.com");
            // request.Headers.Add("Accept-Encoding", "gzip, deflate, br,UTF-8");
            request.Headers.Add("Accept-Language", "en-US,en;q=0.9");
            //request.UserAgent = @"Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) coc_coc_browser/56.3.120 Chrome/50.3.2661.120 Safari/537.36";
            request.UserAgent = browserInfo.useragent;
            request.Host = hostname;
            request.ContentType = @"application/json";
            request.AllowAutoRedirect = false;
            var payload_ship_info = @"{""credit_card"":{""number"":""" + Billinfo.CardNumber + @""",""name"":""" + Billinfo.CardName + @""",""month"":" + Billinfo.ExpireMonth.ToString() + @",""year"":" + Billinfo.ExpireYear.ToString() + @",""verification_value"":""" + Billinfo.SecurityCode + @"""}}";
            request.Method = "POST";

            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                streamWriter.Write(payload_ship_info);
            }
            response = (HttpWebResponse)request.GetResponse();
            string htmlString;
            using (var reader = new StreamReader(response.GetResponseStream()))
            {
                htmlString = reader.ReadToEnd();
                var json = new JavaScriptSerializer();
                var data = json.Deserialize<Dictionary<string, string>>(htmlString);
                return (data["id"]);
            }
        }
        public string PaymentProcessing(string Url, string refer, string hostname, int tokenf)
        {
            //string Url = "https://kith.com/products.json";
            CookieContainer cookieJar = new CookieContainer();
            request = GetWebRequest(Url);

            var sp = request.ServicePoint;
            var prop = sp.GetType().GetProperty("HttpBehaviour",
                                    System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
            prop.SetValue(sp, (byte)0, null);
            request.KeepAlive = true;


            request.CookieContainer = cookieJar;
            request.CookieContainer.Add(addcart);
            request.Accept = @"*/*";
            request.Headers.Add("Accept-Language", "en-US,en;q=0.9");
            //request.UserAgent = @"Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) coc_coc_browser/56.3.120 Chrome/50.3.2661.120 Safari/537.36";
            request.UserAgent = browserInfo.useragent;
            request.Host = hostname;
            request.ContentType = @"application/x-www-form-urlencoded";
            request.AllowAutoRedirect = true;
            var payload_ship_info = "";
            if (tokenf == 0)
            {
                payload_ship_info = @"_method=patch&authenticity_token=&previous_step=payment_method&";
                payload_ship_info += @"step=&checkout%5bcredit_card%5d%5bvault%5d=false&checkout%5bdifferent_billing_address%5d=false&";
                payload_ship_info += @"checkout%5btotal_price%5d=&complete=1&checkout%5bclient_details%5d%5bbrowser_width%5d=1920&checkout%5bclient_details%5d%5bbrowser_height%5d=960&";
                payload_ship_info += @"checkout%5bclient_details%5d%5bjavascript_enabled%5d=1&button=&utf8=%25e2%259c%2593&";
                payload_ship_info += @"checkout%5bshipping_rate%5d%5bid%5d=" + shipping_rates + @"&s=" + card_info;// +@"&checkout%5bpayment_gateway%5d=117647559";
                if (g_recaptcha_response != "") payload_ship_info += @"&g-recaptcha-response=" + g_recaptcha_response;
            }
            else
            {
                payload_ship_info = @"_method=patch&authenticity_token=&previous_step=payment_method&checkout%5btotal_price%5d=&";
                payload_ship_info += @"complete=1&checkout%5bclient_details%5d%5bbrowser_width%5d=2016&";
                payload_ship_info += @"checkout%5bclient_details%5d%5bbrowser_height%5d=481&checkout%5bclient_details%5d%5bjavascript_enabled%5d=1&button=&utf8=%25e2%259c%2593";
                //payload_ship_info += @"checkout%5bclient_details%5d%5bjavascript_enabled%5d=1&button=&utf8=%25e2%259c%2593&";
                //payload_ship_info += @"checkout%5bshipping_rate%5d%5bid%5d=" + shipping_rates;// + @"&s=" + card_info+@"&checkout%5bpayment_gateway%5d=117647559";
            }


            request.Method = "POST";

            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                streamWriter.Write(payload_ship_info);
            }

            response = (HttpWebResponse)request.GetResponse();
            //MessageBox.Show(request.)
            string htmlString;
            using (var reader = new StreamReader(response.GetResponseStream()))
            {
                htmlString = reader.ReadToEnd();
                Uri uri = new Uri(@"https://" + SiteHost + @"/");
                request.CookieContainer.GetCookies(uri);
                addcart.Add(request.CookieContainer.GetCookies(uri));
                if (checkouturl != "") addcart.Add(request.CookieContainer.GetCookies(new Uri(checkouturl)));
                addcart.Add(response.Cookies);
                return htmlString;
            }
        }

        public string Checkpointprocessing(string Url, string refer, string hostname)
        {
            //string Url = "https://kith.com/products.json";
            CookieContainer cookieJar = new CookieContainer();
            request = GetWebRequest(Url);

            var sp = request.ServicePoint;
            var prop = sp.GetType().GetProperty("HttpBehaviour",
                                    System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
            prop.SetValue(sp, (byte)0, null);
            request.KeepAlive = true;


            request.CookieContainer = cookieJar;
            request.CookieContainer.Add(addcart);
            request.Accept = @"text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
            request.Headers.Add("Accept-Language", "en-US,en;q=0.5");
            //request.UserAgent = @"Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) coc_coc_browser/56.3.120 Chrome/50.3.2661.120 Safari/537.36";
            request.UserAgent = browserInfo.useragent;
            request.Host = hostname;
            request.ContentType = @"application/x-www-form-urlencoded";
            request.Referer = refer;
            request.AllowAutoRedirect = true;

            var payload_ship_info = "";
            payload_ship_info = @"g-recaptcha-response=" + g_recaptcha_response;

            request.Method = "POST";
            g_recaptcha_response = "";
            using (var streamWriter = new StreamWriter(request.GetRequestStream()))
            {
                streamWriter.Write(payload_ship_info);
            }

            response = (HttpWebResponse)request.GetResponse();
            //MessageBox.Show(request.)
            string htmlString;
            using (var reader = new StreamReader(response.GetResponseStream()))
            {
                htmlString = reader.ReadToEnd();
                Uri uri = new Uri(@"https://" + SiteHost + @"/");
                request.CookieContainer.GetCookies(uri);
                addcart.Add(request.CookieContainer.GetCookies(uri));
                if (checkouturl != "") addcart.Add(request.CookieContainer.GetCookies(new Uri(checkouturl)));
                addcart.Add(response.Cookies);
                return htmlString;
            }
        }
        public string ProcessingStatus(string Url, string refer, string hostname)
        {
            //string Url = "https://kith.com/products.json";
            CookieContainer cookieJar = new CookieContainer();
            request = GetWebRequest(Url);

            var sp = request.ServicePoint;
            var prop = sp.GetType().GetProperty("HttpBehaviour",
                                    System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
            prop.SetValue(sp, (byte)0, null);
            request.KeepAlive = true;

            request.CookieContainer = cookieJar;
            request.CookieContainer.Add(addcart);
            request.Accept = @"*/*";
            request.Headers.Add("Accept-Language", "en-US,en;q=0.9");
            //request.UserAgent = @"Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) coc_coc_browser/56.3.120 Chrome/50.3.2661.120 Safari/537.36";
            request.UserAgent = browserInfo.useragent;
            request.Host = hostname;
            request.ContentType = @"application/x-www-form-urlencoded";
            request.AllowAutoRedirect = true;
            request.Method = "GET";

            response = (HttpWebResponse)request.GetResponse();
            string htmlString;
            using (var reader = new StreamReader(response.GetResponseStream()))
            {
                htmlString = reader.ReadToEnd();
                Match match = Regex.Match(htmlString, @"<p class=""notice__text"">([A-Za-z0-9\- .,""]+)\</p>",
                    RegexOptions.IgnoreCase);
                if (match.Success)
                {
                    // Finally, we get the Group value and display it.
                    string key = match.Groups[1].Value;
                    return key;
                }
                else
                {
                    return "No";
                }

            }
        }
        public string GetShippingRate(string Url, string refer, string hostname)
        {
            //string Url = "https://kith.com/products.json";
            CookieContainer cookieJar = new CookieContainer();
            var payload_ship_info = @"?shipping_address[zip]=" + Billinfo.BillZipCode + @"&shipping_address[country]=" + Billinfo.BillCountry.Replace(" ", "%20") + @"&shipping_address[province]=" + Billinfo.BillStateXX;
            request = (HttpWebRequest)WebRequest.Create(Url + payload_ship_info);

            var sp = request.ServicePoint;
            var prop = sp.GetType().GetProperty("HttpBehaviour",
                                    System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
            prop.SetValue(sp, (byte)0, null);
            request.KeepAlive = true;

            request.CookieContainer = cookieJar;
            request.CookieContainer.Add(addcart);
            request.Accept = @"application/json";
            //request.Referer = refer;
            //request.Headers.Add("Origin", "https://checkout.shopifycs.com,https://checkout.shopifycs.com");
            // request.Headers.Add("Accept-Encoding", "gzip, deflate, br,UTF-8");
            request.Headers.Add("Accept-Language", "en-US,en;q=0.9");
            //request.UserAgent = @"Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) coc_coc_browser/56.3.120 Chrome/50.3.2661.120 Safari/537.36";
            request.UserAgent = browserInfo.useragent;
            request.Host = hostname;
            request.ContentType = @"application/json";
            request.AllowAutoRedirect = true;
            request.Method = "GET";

            response = (HttpWebResponse)request.GetResponse();
            string htmlString;
            using (var reader = new StreamReader(response.GetResponseStream()))
            {
                htmlString = reader.ReadToEnd();
                XmlDocument stuff1 = Newtonsoft.Json.JsonConvert.DeserializeXmlNode(htmlString);
                htmlString = "shopify-" + stuff1.ChildNodes[0].ChildNodes[0].InnerText + "-" + stuff1.ChildNodes[0].ChildNodes[3].InnerText;
                htmlString = htmlString.Replace(" ", @"%2520");
                // var json = new JavaScriptSerializer();
                // var data = json.Deserialize<Dictionary<string, string>>(htmlString);
                return (htmlString);
            }
        }
        public string GotoPayment(string Url, string refer, string hostname)
        {
            //string Url = "https://kith.com/products.json";
            CookieContainer cookieJar = new CookieContainer();
            request = GetWebRequest(Url);

            var sp = request.ServicePoint;
            var prop = sp.GetType().GetProperty("HttpBehaviour",
                                    System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic);
            prop.SetValue(sp, (byte)0, null);
            request.KeepAlive = true;

            request.CookieContainer = cookieJar;
            request.CookieContainer.Add(addcart);
            request.Accept = @"*/*";
            request.Headers.Add("Accept-Language", "en-US,en;q=0.9");
            //request.UserAgent = @"Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) coc_coc_browser/56.3.120 Chrome/50.3.2661.120 Safari/537.36";
            request.UserAgent = browserInfo.useragent;
            request.Host = hostname;
            request.ContentType = @"application/x-www-form-urlencoded";
            request.AllowAutoRedirect = true;
            request.Method = "GET";

            response = (HttpWebResponse)request.GetResponse();
            string htmlString;
            using (var reader = new StreamReader(response.GetResponseStream()))
            {
                htmlString = reader.ReadToEnd();

                Match match = Regex.Match(htmlString, @"g-recaptcha-response",
                    RegexOptions.IgnoreCase);
                captchaCheck = match.Success;

                Uri uri = new Uri(@"https://" + SiteHost + @"/");
                request.CookieContainer.GetCookies(uri);
                addcart.Add(request.CookieContainer.GetCookies(uri));
                if (checkouturl != "") addcart.Add(request.CookieContainer.GetCookies(new Uri(checkouturl)));
                addcart.Add(response.Cookies);
                return htmlString;
            }
        }
        public HttpWebRequest GetWebRequest(string Url)
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(Url);
            
            SetProxy(request);

            return request;
        }

        public void SetProxy(HttpWebRequest request)
        {
            if (this.proxy == null || this.proxy.Host == null) return;

            var proxy = new WebProxy();
            Uri uri = new Uri($"http://{this.proxy.Host}:{this.proxy.Port}");
            proxy.Address = uri;

            if (this.proxy.Username != null && this.proxy.Password != null)
            {
                proxy.Credentials = new NetworkCredential(this.proxy.Username, this.proxy.Password);
            }
            else
            {
                proxy.Credentials = new NetworkCredential();
            }

            request.Proxy = proxy;
        }
    }
}
