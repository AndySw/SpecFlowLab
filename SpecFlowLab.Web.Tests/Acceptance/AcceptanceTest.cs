using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpecFlowLab.TestFramework;
using System.Threading;

namespace SpecFlowLab.Web.Tests.Acceptance
{
    public class AcceptanceTest
    {
        private static WebServer webServer;

        [AssemblyInitialize]
        public static void AssemblyInitialize(TestContext testContext)
        {
            Trace.Write("AcceptanceTest.AssemblyInitialize");
            webServer = WebServer.Start(@"C:\Users\andrew.sweetman\Projects\github\SpecFlowLab\SpecFlowLab.Web", 51218);
            //Thread.Sleep(5000);
        }

        [AssemblyCleanup]
        public static void AssemblyCleanup()
        {
            Trace.Write("AcceptanceTest.AssemblyCleanup");
            //Thread.Sleep(5000);
            webServer.Stop();
        }

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