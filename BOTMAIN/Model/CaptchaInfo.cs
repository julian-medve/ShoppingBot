using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BOTMAIN.EntityModels;

namespace BOTMAIN.Model
{

    public class CaptchaInfo
    {
        public string taskId { get; set; }
        public ProxyModel proxy { get; set; }
        public BrowserInfo browserInfo { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    }
}
