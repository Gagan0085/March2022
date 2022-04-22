using Gagan.Pages;
using Gagan.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace March2022.Tests
{
    [TestFixture]
    internal class TM_Tests : CommonDriver
    {

        [OneTimeSetUp]
        public void LoginFunction()
        {
            // open brower
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            // Login page object initialization and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginSteps(driver);

            // Home page object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTMPage(driver);

        }

        [Test]
        public void CreateTM_Test()
        {
            // TM page object initialization and definition
            TMPage tMPageObj = new TMPage();
            tMPageObj.CreateTM(driver);

        }

        [Test]
        public void EditTM_Test()
        {
            // Edit TM
            TMPage tMPageObj = new TMPage();
            tMPageObj.EditTM(driver);
        }

        [Test]
        public void DeleteTM_Test()
        {
            // Delete TM
            TMPage tMPageObj = new TMPage();
            tMPageObj.DeleteTM(driver);

        }

        [TearDown]
        public void CloseTestRun()
        {

        }
    }
  
}

   