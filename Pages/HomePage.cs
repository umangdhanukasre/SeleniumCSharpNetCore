using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SeleniumCSharpNetCore.Pages
{
    public class HomePage : DriverHelper
    {
        public IWebElement lnkLogin => driver.FindElement(By.LinkText("Login"));
        public IWebElement lnkLogOff => driver.FindElement(By.LinkText("Log off"));
        public void ClickLogin() => lnkLogin.Click();

        public bool IsLogOffDisplayed() => lnkLogOff.Displayed;
    }
}
