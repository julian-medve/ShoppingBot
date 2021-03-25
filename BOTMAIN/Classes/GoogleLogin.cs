using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace BOTMAIN.Classes
{
    class GoogleLogin
    {
        [TestClass]
        public class FillFormIntegrationTest
        {
            public static string BaseUrl = "http://www.gmail.com";
            public const int TimeOut = 30;

            [TestMethod]
            public void Login()
            {
                var driver = new FirefoxDriver();

                driver.Navigate().GoToUrl(BaseUrl);

                var loginBox = driver.FindElement(By.Id("Email"));
                loginBox.SendKeys("gloweve1220@gmail.com");

                var pwBox = driver.FindElement(By.Id("Passwd"));
                pwBox.SendKeys("!SuperSecretpassw0rd");

                var signinBtn = driver.FindElement(By.Id("login"));
                signinBtn.Click();

                driver.Quit();

            }
        }
    }
}
