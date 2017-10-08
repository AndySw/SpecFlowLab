using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpecFlowLab.TestFramework;

namespace SpecFlowLab.Web.Tests.Acceptance
{
    public class AcceptanceTest
    {
        public static void TestFixtureSetup(TestContext testContext)
        {
            Browser.Initialize();
            Trace.Write("AcceptanceTest.TestFixtureSetup");
            //UserGenerator.Initialize();
        }

        public static void TestFixtureTearDown()
        {
            Trace.Write("AcceptanceTest.TestFixtureTearDown");
            Browser.Close();
        }

        [TestCleanup]
        public void TearDown()
        {
            Trace.Write("AcceptanceTest.TearDown");
            //if (Pages.TopNavigation.IsLoggedIn())
            //    Pages.TopNavigation.LogOut();

            //if (UserGenerator.LastGeneratedUser != null)
            //    Browser.Goto("Account/DeleteUsers.cshtml");
        }
    }
}