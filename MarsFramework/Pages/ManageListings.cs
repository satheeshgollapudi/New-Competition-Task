using MarsFramework.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using static MarsFramework.Global.GlobalDefinitions;

namespace MarsFramework.Pages
{
    internal class ManageListings
    {
        public ManageListings()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        //Click on Manage Listings Link
        [FindsBy(How = How.LinkText, Using = "Manage Listings")]
        private IWebElement manageListingsLink { get; set; }

        //View the listing
        [FindsBy(How = How.XPath, Using = "(//i[@class='eye icon'])[1]")]
        private IWebElement view { get; set; }

        //Delete the listing
        [FindsBy(How = How.XPath, Using = "//table[1]/tbody[1]")]
        private IWebElement delete { get; set; }

        //Edit the listing
        [FindsBy(How = How.XPath, Using = "(//i[@class='outline write icon'])[1]")]
        private IWebElement edit { get; set; }

        //Click on Yes or No
        [FindsBy(How = How.XPath, Using = "//div[@class='actions']")]
        private IWebElement clickActionsButton { get; set; }

        internal void Listings()
        {
            //Populate the Excel Sheet
            //GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ManageListings");



            //Click on Manage Listings

            manageListingsLink.Click();


            //Click on view the listing
           // view.Click();

            //GlobalDefinitions.driver.Navigate().Back();

            //Click on edit the listing
            edit.Click();

            ShareSkill obj = new ShareSkill();
            obj.EnterShareSkill1();


            //Click on delete the listing

            // Actions action = new Actions(GlobalDefinitions.driver);
            // action.MoveToElement(delete).Build().Perform();

            // IList<IWebElement> listings = delete.FindElements(By.XPath("//table[@class='ui striped table']/tbody/tr"));
            IList<IWebElement> listings = GlobalDefinitions.driver.FindElements(By.XPath("//table[@class='ui striped table']/tbody/tr"));
            int listingCount = listings.Count;
            Console.WriteLine("Number of Listings : " + listingCount);
            //GlobalDefinitions.driver.FindElement(By.XPath("//table[@class='ui striped table']/tbody/tr[2]/td[8]/div/button[3]/i")).Click();
            for (int i = 1; i <= listingCount; i++)
            {
                // int j = i + 1;
                var Name = GlobalDefinitions.driver.FindElement(By.XPath("//table[@class='ui striped table']/tbody/tr[" + i + "]/td[3]")).Text;
                Console.WriteLine("Name is : " + Name);
                if (Name.Equals(ExcelLib.ReadData(2, "Title")))
                   
                {
                    GlobalDefinitions.driver.FindElement(By.XPath("//table[@class='ui striped table']/tbody/tr[" + i + "]/td[8]/div/button[3]/i")).Click();
                    Base.test.Log(LogStatus.Pass, "Clicking on delete icon has been successfully performed");

                }
                break;
            }

            // To click on yes or no in the alert message for deleting

            // action.MoveToElement(clickActionsButton).Build().Perform();

            IList<IWebElement> clickAction = clickActionsButton.FindElements(By.TagName("button"));
            //Indicating the number of buttons present
            int clickActionCount = clickAction.Count;
            Console.WriteLine("Number of Actions for Deleting : " + clickActionCount);
            for (int i = 1; i <= clickActionCount; i++)
            {
                if (clickAction[i].Text == GlobalDefinitions.ExcelLib.ReadData(2, "Deleteaction"))
                {
                    clickAction[i].Click();
                    Base.test.Log(LogStatus.Info, "Action has been performed successfully");

                    break;
                }

            }

        }



    }
}

