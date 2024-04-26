// LoginTests.cs
using NUnit.Framework;
using YourProject.Pages;

namespace YourProject.Tests
{
    public class LoginTests : BaseTest
    {
        [Test]
        public void ValidLoginTest()
        {
            var loginPage = new LoginPage(Driver);
            loginPage.Login("username", "password");
            
            var homePage = new HomePage(Driver);
            Assert.IsTrue(homePage.IsAt(), "Not on the home page after login.");
        }
        
        // Add more tests as needed
    }
}
