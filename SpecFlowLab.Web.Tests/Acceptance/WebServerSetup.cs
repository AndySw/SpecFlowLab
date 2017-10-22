using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SpecFlowLab.TestFramework;

namespace SpecFlowLab.Web.Tests.Acceptance
{
    [SetUpFixture]
    public class WebServerSetup
    {
        private WebServer webServer;

        [OneTimeSetUp]
        public void RunBeforeAnyTests()
        {
            webServer = WebServer.Start(@"C:\Projects\github\SpecFlowLab\SpecFlowLab.Web", 51218);
            Browser.Initialize();
        }

        [OneTimeTearDown]
        public void RunAfterAnyTests()
        {
            webServer.Stop();
            Browser.Close();
        }
    }
}