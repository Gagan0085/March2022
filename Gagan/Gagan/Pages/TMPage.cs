using Gagan.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Gagan.Pages
{
    internal class TMPage
    {
        public void CreateTM(IWebDriver driver)
        {
            // Click on Create New Button
            IWebElement CreateNewButton = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            CreateNewButton.Click();

            // Select Material from TypeCode Dropdown
            IWebElement typeCodeDdropdown = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[2]/span"));
            typeCodeDdropdown.Click();

            IWebElement materialOption = driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[1]"));
            materialOption.Click();

            // Identify the code textbox and input a code
            IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
            codeTextbox.SendKeys("March2022");

            // Identify the description textbox and input a description
            IWebElement desciptionTextbox = driver.FindElement(By.Id("Description"));
            desciptionTextbox.SendKeys("March2022");

            // Identfy the price textbox and input a price
            IWebElement priceTag = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            priceTag.Click();

            IWebElement priceTextbox = driver.FindElement(By.Id("Price"));
            priceTextbox.SendKeys("12");

            // Click on save button
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();
            Wait.WaitToBeVisible(driver, "XPath", "//*[@id='tmsGrid']/div[3]/table/tbody/tr[1]/td[1]", 2);

            // click on last page button
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            goToLastPageButton.Click();
            Thread.Sleep(1000);

            // Check if record create is present in the table and expected value
            IWebElement actualCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[3]/td[5]/a[1]"));
            
            // Option1
            Assert.That(actualCode.Text == "March2022", "Actual code and excepted Code do not match");

            // Option2
            //if (actualCode.Text == "March2022")
            //{
               // Assert.Pass("Material record created successfully, test passed.");
            //}
            //else
            //{
                // Assert.Fail("Test failed.");
            //}
        }

        public void EditTM(IWebDriver driver)
        { 
        
        }

        public void DeleteTM(IWebDriver driver)
        { 
        
        }
    
    }
}
