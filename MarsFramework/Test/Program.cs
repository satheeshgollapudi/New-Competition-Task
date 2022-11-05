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

           
            public void AddNewProfileTest()
            {

                GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Profile");
                try
                {
                    // Creates a toggle for the given test, adds all log events under it    
                    test = extent.StartTest("Add New Profile");

                    // Create an class and object to call the method
                    Profile profile = new Profile();


                    profile.EditProfile();

                    string ExpectedValue = GlobalDefinitions.ExcelLib.ReadData(2, "AvailableTime");
                    Console.WriteLine(ExpectedValue);

                    profile.AvailabilityTimeEdit.Click();
                    string ActualValue = profile.GetText(GlobalDefinitions.ExcelLib.ReadData(2, "AvailableTime"));




                    if (ExpectedValue == ActualValue)
                    {
                        test.Log(LogStatus.Pass, "Test Passed, Added a Profile Successfully");
                        Console.WriteLine("Test Passed Added a Profile Successfully");

                    }

                    else
                    {

                        test.Log(LogStatus.Fail, "Test Failed Expected not equal");
                        Console.WriteLine("Test Failed Expected not equal");

                    }
                }
                catch (Exception e)
                {
                    test.Log(LogStatus.Fail, "Test Failed", e.StackTrace);
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

                   
                    profile.AddNewLanguage();

                    string ExpectedValue = GlobalDefinitions.ExcelLib.ReadData(2, "Language");
                    Console.WriteLine(ExpectedValue);
                    string ActualValue = profile.GetText(GlobalDefinitions.ExcelLib.ReadData(2, "Language"));




                    if (ExpectedValue == ActualValue)
                    {
                        test.Log(LogStatus.Pass, "Test Passed, Added a Language Successfully");
                        Console.WriteLine("Test Passed Added a Language Successfully");

                    }

                    else
                    {

                        test.Log(LogStatus.Fail, "Test Failed Expected not equal");
                        Console.WriteLine("Test Failed Expected not equal");

                    }
                }
                catch (Exception e)
                {
                    test.Log(LogStatus.Fail, "Test Failed", e.StackTrace);
                    Console.WriteLine("Test Failed");
                }

            }

            [Test]
            public void AddNewSkillTest()
            {

                GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Profile");
                try
                {
                    // Creates a toggle for the given test, adds all log events under it    
                    test = extent.StartTest("Add New Skill");

                    // Create an class and object to call the method
                    Profile profile = new Profile();


                    profile.AddNewSkills();

                    
                   string ExpectedValue = GlobalDefinitions.ExcelLib.ReadData(2, "Skill");
                    Console.WriteLine(ExpectedValue);
                    string ActualValue = profile.GetText(GlobalDefinitions.ExcelLib.ReadData(2, "Skill"));




                    if (ExpectedValue == ActualValue)
                    {
                        test.Log(LogStatus.Pass, "Test Passed, Added a Skill Successfully");
                        Console.WriteLine("Test Passed Added a Skill Successfully");


                    }

                    else
                    {

                        test.Log(LogStatus.Fail, "Test Failed Expected not equal");
                        Console.WriteLine("Test Failed Expected not equal");
                        Assert.That(ActualValue, Is.EqualTo(ExpectedValue));


                    }
                }
                catch (Exception e)
                {
                    test.Log(LogStatus.Fail, "Test Failed", e.StackTrace);
                    Console.WriteLine("Test Failed");
                }

            }

            [Test]
            public void AddNewEducationTest()
            {

                GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Profile");
                try
                {
                    // Creates a toggle for the given test, adds all log events under it    
                    test = extent.StartTest("Add New Education");

                    // Create an class and object to call the method
                    Profile profile = new Profile();


                    profile.AddNewEducation();

                    
                    string ExpectedValue = GlobalDefinitions.ExcelLib.ReadData(2, "University");
                    Console.WriteLine(ExpectedValue);
                    string ActualValue = profile.GetText(GlobalDefinitions.ExcelLib.ReadData(2, "University"));




                    if (ExpectedValue == ActualValue)
                    {
                        test.Log(LogStatus.Pass, "Test Passed, Added a Education Successfully");
                        Console.WriteLine("Test Passed Added a Education Successfully");
                       

                    }

                    else
                    {

                        test.Log(LogStatus.Fail, "Test Failed Expected not equal");
                        Console.WriteLine("Test Failed Expected not equal");
                        Assert.That(ActualValue, Is.EqualTo(ExpectedValue));


                    }
                }
                
                catch (Exception e)
                {
                    test.Log(LogStatus.Fail, "Test Failed", e.StackTrace);
                    Console.WriteLine("Test Failed");
                }

            }

            [Test]
            public void AddNewCertificationTest()
            {

                GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Profile");
                try
                {
                    // Creates a toggle for the given test, adds all log events under it    
                    test = extent.StartTest("Add New Certificate");

                    // Create an class and object to call the method
                    Profile profile = new Profile();


                    profile.AddNewCertification();

                    
                    string ExpectedValue = GlobalDefinitions.ExcelLib.ReadData(2, "Certificate");
                    Console.WriteLine(ExpectedValue);
                    string ActualValue = profile.GetText(GlobalDefinitions.ExcelLib.ReadData(2, "Certificate"));




                    if (ExpectedValue == ActualValue)
                    {
                        test.Log(LogStatus.Pass, "Test Passed, Added a Certificate Successfully");
                        Console.WriteLine("Test Passed Added a Certificate Successfully");
                    }

                    else
                    {

                        test.Log(LogStatus.Fail, "Test Failed Expected not equal");
                        Console.WriteLine("Test Failed Expected not equal");
                        Assert.That(ActualValue, Is.EqualTo(ExpectedValue));


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
