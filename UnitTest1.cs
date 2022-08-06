using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Collections;
using System.IO;

namespace SeleniumCSharpNetCore
{
    public class Tests : DriverHelper
    {

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver(Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.Parent.FullName, "drivers"));
        }

        [Test]
        public void Test1()
        {
            driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com/");
            driver.FindElement(By.Id("ContentPlaceHolder1_Meal")).SendKeys("Pota");
            CustomControl.ComboBox("ContentPlaceHolder1_AllMealsCombo", "Almond");
            ArrayList test= new ArrayList();
            var options = driver.FindElements(By.XPath("//div[@class = 'elabel']//a"));
            foreach (var option in options)
            {
                test.Add(option.Text);
            }
            Assert.Pass();
        }
    }
}