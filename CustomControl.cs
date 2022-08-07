using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
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
            EnterText(comboControl, value);
            driver.FindElement(By.XPath($"//div[@id = '{controlName}-dropmenu']//li[text()= '{value}']")).Click();
        }

        public static void EnterText(IWebElement element, string value) => element.SendKeys(value);
        
        public static void Click(IWebElement element) => element.Click();

        public static void SelectDropdownByText(IWebElement element, string text)
        {
            Thread.Sleep(5000);
            SelectElement selectElement = new SelectElement(element); 
            Thread.Sleep(3000);
            selectElement.SelectByText(text);
        }
        
    }
}