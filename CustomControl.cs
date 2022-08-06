using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumCSharpNetCore
{
    public class CustomControl : DriverHelper
    {
        public static void ComboBox(string controlName, string value)
        {
            IWebElement comboControl = driver.FindElement(By.XPath($"//input[@id = '{controlName}-awed']"));
            comboControl.Clear();
            comboControl.SendKeys(value);
            driver.FindElement(By.XPath($"//div[@id = '{controlName}-dropmenu']//li[text()= '{value}']")).Click();
        }
    }
}
