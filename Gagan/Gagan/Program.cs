using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace March2022
{
    internal class Program
    {
        private static object descriptionTextbox;

        public static object typeCodeDropdown { get; private set; }

        static void Main(string[] args)
        {
            // open brower
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            // Launch turnup portal
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

            // identify username textbox and enter valid username
            IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
            usernameTextbox.SendKeys("hari");

            // identify password textbox and enter valid password
            IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
            passwordTextbox.SendKeys("123123");

            // click on login button
            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
            loginButton.Click();

            // check if user is logged in successfully
            IWebElement helloHari = driver.FindElement(By.XPath("//*[@id='logoutForm']/ul/li/a"));

            if (helloHari.Text == "Hello hari!")
            {
                Console.WriteLine("Logged in successfully, test passed");
            }
            else
            {
                Console.WriteLine("Login failed, test failed");
            }
            // Create Time and Material record

            // Go.To TM page
            IWebElement administrationDropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administrationDropdown.Click();

            IWebElement tmoption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            tmoption.Click();

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
            Thread.Sleep(1000);

            // click on last page button
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            goToLastPageButton.Click();
            Thread.Sleep(1000);

            // Check if record create is present in the table and expected value
            IWebElement actualCode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[3]/td[5]/a[1]"));

            if (actualCode.Text == "March2022")
            {
                Console.WriteLine("Material record created successfully, test passed.");
            }
            else
            {
                Console.WriteLine("Test failed.");
            }
            // Check if user is able to edit in previous time and material item
            IWebElement editButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[4]/td[5]/a[1]"));
            editButton.Click();
            IWebElement codeEditTextbox = driver.FindElement(By.Id("Code"));
            codeEditTextbox.Click();
            codeEditTextbox.Clear();
            codeEditTextbox.Click();
            codeEditTextbox.SendKeys("may2022");

            IWebElement descriptionEditTextbox = driver.FindElement(By.Id("Description"));
            descriptionEditTextbox.Click();
            descriptionEditTextbox.Clear();
            descriptionEditTextbox.SendKeys("2022");

            IWebElement priceEditTextbox = driver.FindElement(By.Id("Price"));
            //priceEditTextbox.Click();
            //priceEditTextbox.Clear();


            //priceEditTextbox.SendKeys("20");


            // click the Save it button
            IWebElement saveitButton = driver.FindElement(By.Id("SaveButton"));
            saveitButton.Click();
            Thread.Sleep(3000);


            // click on last page
            IWebElement lastPageButton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            lastPageButton.Click();

            {
                Console.WriteLine("testing pass");
            }

            {
                Console.WriteLine("test failed");
            }

        }
    }

}
   