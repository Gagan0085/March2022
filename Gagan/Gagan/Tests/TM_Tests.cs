using Gagan.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace March2022.Tests
{
    internal class TM_Tests
    {
        private static object descriptionTextbox;

        public static object typeCodeDropdown { get; private set; }

        static void Main(string[] args)
        {
            // open brower
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            // Login page object initialization and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginSteps(driver);

            // Home page object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTMPage(driver);

            // TM page object initialization and definition
            TMPage tMPageObj = new TMPage();
            tMPageObj.CreateTM(driver);

            // Edit TM
            tMPageObj.EditTM(driver);

            // Delete TM
            tMPageObj.DeleteTM(driver);

        }
    }

}
   