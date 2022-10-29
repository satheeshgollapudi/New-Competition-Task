using MarsFramework.Global;
using MarsFramework.Pages;
using NUnit.Framework;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsFramework.Test
{
    internal class ShareSkillTest
    {
        [TestFixture]
        class User : Global.Base
        {

           /* [Test]
            public void addSkill()
            {

                try
                {
                    // Creates a toggle for the given test, adds all log events under it    
                    test = extent.StartTest(" Profile");

                    //GlobalDefinitions globalDefinitions = new GlobalDefinitions();

                    // Create an class and object to call the method
                    ShareSkill shareSkill = new ShareSkill();
                    shareSkill.EnterShareSkill();
                    test.Log(LogStatus.Pass, "Test Passed");
                    Console.WriteLine("Test Passed");
                }
                catch (Exception e)
                {
                    test.Log(LogStatus.Fail, "Test Failed", e.Message);
                    Console.WriteLine("Test Failed");
                }

            }*/


            [Test]


            public void skillShareTest()
            {

                GlobalDefinitions globalDefinitions = new GlobalDefinitions();

                GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Profile");
                try
                {
                    // Creates a toggle for the given test, adds all log events under it    
                    test = extent.StartTest(" SkillShare");

                    // Create an class and object to call the method
                    ShareSkill shareSkill = new ShareSkill();
                    shareSkill.EnterShareSkill();

                    string ExpectedValue = GlobalDefinitions.ExcelLib.ReadData(2, "Title");
                    Console.WriteLine(ExpectedValue);
                    string ActualValue = shareSkill.GetText(GlobalDefinitions.ExcelLib.ReadData(2, "Title"));




                    if (ExpectedValue == ActualValue)
                    {
                        test.Log(LogStatus.Pass, "Test Passed, Added a SkillShare Successfully");
                        Console.WriteLine("Test Passed Added a SkillShare Successfully");

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
        }
    }
}