using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using cas31.PageObject;


namespace cas31
{
    class TestClass
    {
        private IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new FirefoxDriver();
            driver.Manage().Window.Maximize();

        }
        [Test]
        public void TestGoogleSearch()
        {
            HomePage naslovna = new HomePage(driver);
            ResultsPages rezultati;

            naslovna.GoToPage();
            rezultati = naslovna.SearchFor("Csharp Selenium PageObject Model");
        
                Assert.Greater(rezultati.NumberOfResults, 0);
                }
        [Test]
        public void TestClickOnPrivacy()
        {
            HomePage naslovna = new HomePage(driver);
            naslovna.GoToPage();
            naslovna.ClickOnPrivacy();
            System.Threading.Thread.Sleep(5000);
        }

        [TearDown]
        public void TearDown()
        {
            driver.Close();
        }
    }
}
