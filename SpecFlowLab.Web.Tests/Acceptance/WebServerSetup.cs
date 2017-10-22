using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SpecFlowLab.Web.Tests.Acceptance
{
    [SetUpFixture]
    public class WebServerSetup
    {
        private static WebServer webServer;

        [OneTimeSetUp]
        public void RunBeforeAnyTests()
        {
            webServer = WebServer.Start(@"C:\Users\andrew.sweetman\Projects\github\SpecFlowLab\SpecFlowLab.Web", 51218);
        }

        [OneTimeTearDown]
        public void RunAfterAnyTests()
        {
           webServer.Stop();
        }
    }
}