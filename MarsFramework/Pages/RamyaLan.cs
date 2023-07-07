using MarsFramework.Global;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using System.Net.NetworkInformation;

namespace MarsFramework.Pages
{
    internal class RamyaLan
    {
        public RamyaLan()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }



        //Click Language tab
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Languages')]")]
        private IWebElement ClickLanguagetab { get; set; }


        //Finding the AddNewButton 
        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'Add New')]")]
        private IWebElement AddNewButton { get; set; }


        //Finding the AddLanguage 
        [FindsBy(How = How.XPath, Using = "//input[@name='name']")]
        private IWebElement AddLanguage { get; set; }


        //Finding the LanguageLevel 
        [FindsBy(How = How.XPath, Using = "//select/option[contains(text(),'Basic')]")]
        private IWebElement LanguageLevel { get; set; }

        //Finding the AddButton 
        [FindsBy(How = How.XPath, Using = "//option[@value='Basic']/parent::select/parent::div/following-sibling::div/input[@value='Add']")]
        private IWebElement AddButton { get; set; }



        internal void AddNewLanguage()
        {
            Global.GlobalDefinitions.wait(60000);

            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Profile");

            //Click on Add New button
            ClickLanguagetab.Click();

            AddNewButton.Click();

            //Add Language


            //Enter the Language
            AddLanguage.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Language"));


            //Choose the language level
            // IWebElement Lang = GlobalDefinitions.driver.FindElement(By.XPath("//select/option[contains(text(),'Basic')]"));
            //LanguageLevel.Click();

            SelectElement SkillLevel = new SelectElement(Global.GlobalDefinitions.driver.FindElement(By.XPath("//option[@value='Basic']/parent::select[@name='level']")));
            SkillLevel.SelectByText(Global.GlobalDefinitions.ExcelLib.ReadData(2, "LangLevel"));



            //Click on Add button
            AddButton.Click();


            Base.test.Log(LogStatus.Info, "Added Language successfully");
        }
    }
}
