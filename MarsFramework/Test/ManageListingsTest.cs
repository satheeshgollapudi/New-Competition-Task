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


            public void ManageListings()
            {
                try
                {
                    // Creates a toggle for the given test, adds all log events under it    
                    test = extent.StartTest(" Profile");


                    ManageListings manageListings = new ManageListings();
                    manageListings.Listings();

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

