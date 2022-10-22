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


            }



        }
    }
