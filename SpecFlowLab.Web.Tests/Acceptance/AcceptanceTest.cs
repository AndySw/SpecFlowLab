using System.Diagnostics;
using NUnit;
using SpecFlowLab.TestFramework;
using System.Threading;
using NUnit.Framework;

namespace SpecFlowLab.Web.Tests.Acceptance
{
    [TestFixture]
    public class AcceptanceTest
    {
        [OneTimeSetUp]
        public static void TestFixtureSetup()
        {
            Browser.Initialize();
            Trace.Write("AcceptanceTest.TestFixtureSetup");
            //UserGenerator.Initialize();
        }

        [OneTimeTearDown]
        public static void TestFixtureTearDown()
        {
            Trace.Write("AcceptanceTest.TestFixtureTearDown");
            Browser.Close();
        }

        [TearDown]
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