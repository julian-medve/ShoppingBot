using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CefSharp;
using CefSharp.WinForms;

namespace BOTMAIN.Model
{
    public class RecaptchaHandler : CefSharp.Handler.RequestHandler
    {
        protected BrowserInfo browserInfo { get; set; }
        public RecaptchaHandler(BrowserInfo browserInfo)
        {
            this.browserInfo = browserInfo;
        }
        protected override IResourceRequestHandler GetResourceRequestHandler(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, IRequest request, bool isNavigation, bool isDownload, string requestInitiator, ref bool disableDefaultHandling)
        {
            return new CustomResourceRequestHandler(browserInfo);
        }
    }
    public class CustomResourceRequestHandler : CefSharp.Handler.ResourceRequestHandler
    {
        protected BrowserInfo browserInfo { get; set; }
        public CustomResourceRequestHandler(BrowserInfo browserInfo)
        {
            this.browserInfo = browserInfo;
        }
        protected override CefReturnValue OnBeforeResourceLoad(IWebBrowser chromiumWebBrowser, IBrowser browser, IFrame frame, IRequest request, IRequestCallback callback)
        {
            //Set the header by name, override the existing value
            request.SetHeaderByName("user-agent", browserInfo.useragent, true);

            return CefReturnValue.Continue;
        }
    }
}
