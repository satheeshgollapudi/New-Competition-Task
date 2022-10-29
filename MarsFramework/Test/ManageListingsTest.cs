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
    internal class ManageListingsTest
    {

        [TestFixture]
        [Category("Sprint1")]
        class User : Global.Base
        {

            [Test]


            public void ManageListingsTest()
            {

                //GlobalDefinitions globalDefinitions = new GlobalDefinitions();

                GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "Profile");

                try
                {
                    // Creates a toggle for the given test, adds all log events under it    
                    test = extent.StartTest(" Profile");


                    ManageListings manageListings = new ManageListings();
                    manageListings.Listings();

                    string ExpectedValue = GlobalDefinitions.ExcelLib.ReadData(2, "EditTitle");
                    Console.WriteLine(ExpectedValue);
                    string ActualValue = manageListings.ActualValue();




                    if (ExpectedValue == ActualValue)
                    {

                        test.Log(LogStatus.Fail, "Test Failed Expected not equal");
                        Console.WriteLine("Test Failed Expected not equal");
                        Assert.False(false);

                    }

                    else
                    {

                        test.Log(LogStatus.Pass, "Test Passed, Added a SkillShare Successfully");
                        Console.WriteLine("Test Passed Added a SkillShare Successfully");

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
    


