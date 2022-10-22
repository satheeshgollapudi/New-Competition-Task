using MarsFramework.Global;
using NUnit.Framework;
using RelevantCodes.ExtentReports;
using System;

namespace MarsFramework
{
    public class Program
    {
        [TestFixture]
        [Category("Sprint1")]
        class User : Global.Base
        {

            [Test]
            
           
                public void UserAccount()
                {
                    try
                    {
                        // Creates a toggle for the given test, adds all log events under it    
                        test = extent.StartTest(" Profile");

                        // Create an class and object to call the method
                        Profile obj = new Profile();
                    // obj.EditProfile();
                    obj.AddNewLanguage();
                    //obj.AddNewSkills();
                    //obj.AddNewEducation();
                   // obj.AddNewCertification();
                        test.Log(LogStatus.Pass, "Test Passed");
                        Console.WriteLine("Test Passed");
                    }
                    catch (Exception e)
                    {
                        test.Log(LogStatus.Fail, "Test Failed", e.Message);
                        Console.WriteLine("Test Failed");
                    }

                }



            [Test]
            public void AddNewLanguageTest()
            {

                GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Profile");
                try
                {
                    // Creates a toggle for the given test, adds all log events under it    
                    test = extent.StartTest("Add New Language");

                    // Create an class and object to call the method
                    Profile profile = new Profile();

                    // obj1.EnterShareSkill();
                    profile.AddNewLanguage();

                    string ExpectedValue = GlobalDefinitions.ExcelLib.ReadData(2, "Language");
                    Console.WriteLine(ExpectedValue);
                    string ActualValue = "ListingManagement";




                    if (ExpectedValue == ActualValue)
                    {
                        test.Log(LogStatus.Pass, "Test Passed, Added a Skill Successfully");
                        Console.WriteLine("Test Passed Added a Skill Successfully");

                    }

                    else
                    {

                        test.Log(LogStatus.Fail, "Test Failed Expected not equal");
                        Console.WriteLine("Test Failed not equal");

                    }
                }
                catch (Exception e)
                {
                    test.Log(LogStatus.Fail, "Test Failed", e.StackTrace);
                    Console.WriteLine("Test Failed");
                }

            }

        }



        }
    }
