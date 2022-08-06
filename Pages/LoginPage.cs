using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace SeleniumCSharpNetCore.Pages
{
    public class LoginPage : DriverHelper
    {
        IWebElement usernameInput = driver.FindElement(By.CssSelector("input[id = 'UserName']"));
        IWebElement userpasswordInput = driver.FindElement(By.CssSelector("input[id = 'Password']"));
        IWebElement loginButton = driver.FindElement(By.CssSelector("input[class = 'btn btn-default']"));
        
        public void EnterText(IWebElement element, string text) => element.SendKeys(text);
        public void ClickLogin() => loginButton.Click();

        public void EnterUsernameAndPassword(string userName, string password)
        {
            usernameInput.SendKeys(userName);
            userpasswordInput.SendKeys(password);
        }
    }
}
