using MarsFramework.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Threading;

namespace MarsFramework
{
    internal class Profile
    {
        //Profile changes
        //Manage Listings
        public Profile()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        #region  Initialize Web Elements 
        //Click on Availability Time Edit button
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),' Time')]//i[@class='right floated outline small write icon']")]
        private IWebElement AvailabilityTimeEdit { get; set; }

        //Click on Availability Time dropdown
        [FindsBy(How = How.Name, Using = "availabiltyType")]
        private IWebElement AvailabilityTime { get; set; }

        //AvailabilityHoursEdit
        //Click on Availability Edit button
        [FindsBy(How = How.XPath, Using = "//span[contains(text(),'week')]//i[@class='right floated outline small write icon']")]
        private IWebElement AvailabilityHoursEdit { get; set; }

        //Click on Availability Time option
        [FindsBy(How = How.XPath, Using = "//option[@value='0']")]
        private IWebElement AvailabilityTimeOpt { get; set; }

        //Click on Availability Hour dropdown
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[1]/div/div[3]/div")]
        private IWebElement AvailabilityHours { get; set; }

        //Click on salary
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[1]/div/div[4]/div")]
        private IWebElement Salary { get; set; }

        //Click on Location
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[2]/div/div[2]/div")]
        private IWebElement Location { get; set; }

        //Choose Location
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[2]/div/div[2]/div/div[2]")]
        private IWebElement LocationOpt { get; set; }

        //Click on City
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[2]/div/div[3]/div")]
        private IWebElement City { get; set; }

        //Choose City
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[2]/div/div[3]/div/div[2]")]
        private IWebElement CityOpt { get; set; }

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

        //Click Skill tab
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Skills')]")]
        private IWebElement ClickSkillstab { get; set; }


        //Click on Add new to add new skill
        [FindsBy(How = How.XPath, Using = "//thead/tr[1]/th[contains(text(),'Skill')]/following-sibling::th[2]/div")]
        private IWebElement AddNewSkillBtn { get; set; }

        //Enter the Skill on text box
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Add Skill']")]
        private IWebElement AddSkillText { get; set; }

        //Click on skill level dropdown
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[4]/div/div[2]/div/div/div[2]/select")]
        private IWebElement ChooseSkill { get; set; }

        //Choose the skill level option
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[4]/div/div[2]/div/div/div[2]/select/option[3]")]
        private IWebElement ChooseSkilllevel { get; set; }

        //Add Skill
        [FindsBy(How = How.XPath, Using = "//input[@value='Add']")]
        private IWebElement AddSkill { get; set; }

        //Click Education tab
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Languages')]/parent::div/child::a[contains(text(),'Education')]")]
        private IWebElement ClickEducationtab { get; set; }


        //Click on Add new to Educaiton
        [FindsBy(How = How.XPath, Using = "//th[contains(text(),'Country')]/following-sibling::th/div[contains(text(),'Add New')]")]
        private IWebElement ClickAddNewEducation { get; set; }

        //Enter university in the text box
        [FindsBy(How = How.XPath, Using = "//input[@name='instituteName']")]
        private IWebElement EnterUniversity { get; set; }

        //Choose the country
        [FindsBy(How = How.XPath, Using = "//select[@name='country']")]
        private IWebElement ChooseCountry { get; set; }

        //Choose the skill level option
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[1]/div[2]/select/option[6]")]
        private IWebElement ChooseCountryOpt { get; set; }

        //Click on Title dropdown
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[2]/div[1]/select")]
        private IWebElement ChooseTitle { get; set; }

        //Choose title
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[2]/div[1]/select/option[5]")]
        private IWebElement ChooseTitleOpt { get; set; }

        //Degree
        [FindsBy(How = How.XPath, Using = "//input[@name='degree']")]
        private IWebElement Degree { get; set; }

        //Year of graduation
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[2]/div[3]/select")]
        private IWebElement YearOfGraduation { get; set; }

        //Choose Year
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[2]/div[3]/select/option[4]")]
        private IWebElement DegreeYearOpt { get; set; }

        //Click on Add
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[5]/div/div[2]/div/div/div[3]/div/input[1]")]
        private IWebElement AddEdu { get; set; }

        //Click Certificate tab
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Certifications')]")]
        private IWebElement ClickCertificatetab { get; set; }


        //Add new Certificate
        [FindsBy(How = How.XPath, Using = "//th[contains(text(),'Certificate')]/parent::tr/child::th/div[contains(text(),'Add New')]")]
        private IWebElement AddNewCertificationsBtn { get; set; }

        //Enter Certification Name
        [FindsBy(How = How.XPath, Using = "//input[@name='certificationName']")]
        private IWebElement Certificate { get; set; }

        //Certified from
        [FindsBy(How = How.XPath, Using = "//input[@name='certificationFrom']")]
        private IWebElement CertificateFrom { get; set; }

        //Year
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[6]/div/div[2]/div/div/div[2]/div[2]/select")]
        private IWebElement CertiYear { get; set; }

       
        //Add Ceritification
        [FindsBy(How = How.XPath, Using = "//input[@name='certificationFrom']/parent::div/parent::div/following-sibling::div/input[@value='Add']")]
        private IWebElement CertificateAddButton { get; set; }

        //Add Desctiption
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[8]/div/div[2]/div[1]/textarea")]
        private IWebElement Description { get; set; }

        //Click on Save Button
        [FindsBy(How = How.XPath, Using = "//*[@id='account-profileEdit-section']/div/section[2]/div/div/div/form/div[8]/div/div[4]/span/button[1]")]
        private IWebElement Save { get; set; }

        #endregion

        internal void EditProfile()
        {


            Global.GlobalDefinitions.wait(60000);
            //Populate the Excel Sheet
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Profile");


             //Click on Edit button
             AvailabilityTimeEdit.Click();
             AvailabilityTime.Click();
             //AvailabilityTimeOpt.Click();


             // Actions action = new Actions(GlobalDefinitions.driver);
             // action.MoveToElement(AvailabilityTime).Build().Perform();
             Thread.Sleep(1000);
             //IList<IWebElement> AvailableTime = AvailabilityTimeOpt.FindElements(By.TagName("div"));
             IList<IWebElement> AvailableTime = GlobalDefinitions.driver.FindElements(By.XPath("//select[@name='availabiltyType']/option"));
             int count = AvailableTime.Count;
             for (int i = 0; i < count; i++)
             {
                 if (AvailableTime[i].Text == GlobalDefinitions.ExcelLib.ReadData(2, "AvailableTime"))
                 {
                     AvailableTime[i].Click();
                     Base.test.Log(LogStatus.Info, "Select the available time");
                     //Console.WriteLine(AvailableTime[i].Text);
                     //Console.WriteLine(count);

                 }
             }                              

            //Availability Hours Edit
                      AvailabilityHoursEdit.Click();
            //Availability Hours option
            //AvailabilityHoursDropDown.Click();
            AvailabilityHours.Click();

            //Salary 
            // SalaryEdit.Click();
            //Choose the option from salary dropdown
            //SalaryDropdown.Click();

            //SalaryOpt.Click();

        }


        internal void AddNewLanguage()
        {

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
        
        internal void AddNewSkills() {
                

            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Profile");

            Thread.Sleep(2000);
            //Click on Skill tab
            ClickSkillstab.Click();

            //Click on Add New Skill Button
            AddNewSkillBtn.Click();

            //Enter the skill 
            AddSkillText.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Skill"));

            //Click the skill dropdown
         


            //SelectElement SkillLevel = new SelectElement(GlobalDefinitions.driver.FindElement(By.XPath("//select[@name='level']/option[contains(text()',"+ skillLevel+ "')]")));
            SelectElement SkillLevel = new SelectElement(Global.GlobalDefinitions.driver.FindElement(By.XPath("//input[@placeholder='Add Skill']/parent::div/following-sibling::div/select[@name='level']")));
            SkillLevel.SelectByText(Global.GlobalDefinitions.ExcelLib.ReadData(2, "SkillLevel"));

            AddSkill.Click();


            Base.test.Log(LogStatus.Info, "Added Skills successfully");
        }

        internal void AddNewEducation() {

            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Profile");


            //Click on Education Tab
            ClickEducationtab.Click();

            //Add Education
            ClickAddNewEducation.Click();

            //Enter the University
            EnterUniversity.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "University"));

            //Choose Country
            //ChooseCountry.Click();
            SelectElement Country = new SelectElement(Global.GlobalDefinitions.driver.FindElement(By.XPath("//select[@name='country']")));
            Country.SelectByText(Global.GlobalDefinitions.ExcelLib.ReadData(2, "Country"));

            //Choose Title
            //ChooseTitle.Click();

            SelectElement Title = new SelectElement(Global.GlobalDefinitions.driver.FindElement(By.XPath("//select[@name='title']")));
            Title.SelectByText(Global.GlobalDefinitions.ExcelLib.ReadData(2, "Title"));

            //Enter Degree
            Degree.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Degree"));

            //Year of Graduation
            SelectElement YearOfGraduation = new SelectElement(Global.GlobalDefinitions.driver.FindElement(By.XPath("//select[@name='yearOfGraduation']")));
            YearOfGraduation.SelectByText(Global.GlobalDefinitions.ExcelLib.ReadData(2, "Year"));
            

            Base.test.Log(LogStatus.Info, "Added Education successfully");
        }

        internal void AddNewCertification() {

            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Profile");

            //Click on Certificates Tab
            ClickCertificatetab.Click();

            //Add new Certificate
            AddNewCertificationsBtn.Click();

            //Enter Certificate Name
            Certificate.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Certificate"));

            //Enter Certified from
            CertificateFrom.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "CertifiedFrom"));

            //Enter the Year
            SelectElement YearOfGraduation = new SelectElement(Global.GlobalDefinitions.driver.FindElement(By.XPath("//select[@name='certificationYear']")));
            YearOfGraduation.SelectByText(Global.GlobalDefinitions.ExcelLib.ReadData(2, "CertificationYear"));


            CertificateAddButton.Click();

                Base.test.Log(LogStatus.Info, "Added Certificate successfully");

                



            }


        }
    }
