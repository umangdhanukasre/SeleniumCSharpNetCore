using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumCSharpNetCore.Pages;
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
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test1()
        {
            driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com/");
            CustomControl.SelectDropdownByText(driver.FindElement(By.Id("ContentPlaceHolder1_Add1-awed")), "Cauliflower");
            CustomControl.EnterText(driver.FindElement(By.Id("ContentPlaceHolder1_Meal")), "Tomato");
            CustomControl.ComboBox("ContentPlaceHolder1_AllMealsCombo", "Almond");
            ArrayList test= new ArrayList();
            var options = driver.FindElements(By.XPath("//div[@class = 'elabel']//a"));
            foreach (var option in options)
            {
                test.Add(option.Text);
            }
            Assert.Pass();
        }

        [Test]
        public void LoginTest()
        {
            driver.Navigate().GoToUrl("http://eaapp.somee.com/");
            HomePage homepage = new HomePage();
            homepage.ClickLogin();
            LoginPage loginPage = new LoginPage();
            loginPage.EnterUsernameAndPassword("admin", "password");
            loginPage.ClickLogin();
            Assert.That(homepage.IsLogOffDisplayed(), Is.True);
            homepage.lnkLogOff.Click();            
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
            driver.Quit();
        }
    }
}