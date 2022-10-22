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

            [Test]
            public void addSkill()
            {

                try
                {
                    // Creates a toggle for the given test, adds all log events under it    
                    test = extent.StartTest(" Profile");

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

            }
        }
    }
}
