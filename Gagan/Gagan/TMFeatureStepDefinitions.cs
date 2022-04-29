using Gagan.Pages;
using Gagan.Utilities;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Gagan
{
    [Binding]
    public class TMFeatureStepDefinitions : CommonDriver
    {
        [Given(@"I logged into the TurnUp portal successfully")]
        public void GivenILoggedIntoTheTurnUpPortalSuccessfully()
        {
            //open chrome browser
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            // Login page object initialization and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginSteps(driver);

        }

        [When(@"I navigate to Time and Material page")]
        public void WhenINavigateToTimeAndMaterialPage()
        {
            // Home page object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTMPage(driver);

        }

        [When(@"I create a new file")]
        public void WhenICreateANewFile()
        {
            // TM page object initialization and definition
            TMPage tMPageObj = new TMPage();
            tMPageObj.CreateTM(driver);
        }

        [Then(@"the record should be created successfully")]
        public void ThenTheRecordShouldBeCreatedSuccessfully()
        {
            TMPage tMPageObj = new TMPage();

            string newCode = tMPageObj.GetCode(driver);
            string newTypeCode = tMPageObj.GetTypeCode(driver);
            string newDescription = tMPageObj.GetDescription(driver);
            string newPrice = tMPageObj.GetPrice(driver);

            Assert.That(newCode == "March2022", "Actual code and the expected code do not match.");
            Assert.That(newTypeCode == "M", "Actual typecode and the expected typecode do not match.");
            Assert.That(newDescription == "March2022", "Actual description and the expected description do not match.");
            Assert.That(newPrice == "$12.00", "Actual price and the expected price do not match.");

        }

        [When(@"I update '([^']*)' on a existing time and material record")]
        public void WhenIUpdateOnAExistingTimeAndMaterialRecord(string description)
        {
            throw new PendingStepException();
        }

        [Then(@"the record should have the updated '([^']*)'")]
        public void ThenTheRecordShouldHaveTheUpdated(string description)
        {
            throw new PendingStepException();
        }

       

    }
}
