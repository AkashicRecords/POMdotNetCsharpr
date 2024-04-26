// BaseTest.cs
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace YourProject.Tests
{
    public class BaseTest
    {
        protected IWebDriver Driver;
        
        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver();
            Driver.Manage().Window.Maximize();
        }
        
        [TearDown]
        public void Cleanup()
        {
            Driver.Quit();
        }
    }
}
