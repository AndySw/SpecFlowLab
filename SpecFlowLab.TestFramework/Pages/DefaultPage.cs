using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
// ReSharper disable InconsistentNaming
// VS.NET    disable Value never assigned
#pragma warning disable 649

namespace SpecFlowLab.TestFramework.Pages
{
    public class DefaultPage
    {
        [FindsBy(How = How.Id, Using = "aspnet-link")]
        private IWebElement aspNetLink;

        [FindsBy(How = How.Id, Using = "gettingstarted-link")]
        private IWebElement gettingStartedLink;

        [FindsBy(How = How.Id, Using = "getlibraries-link")]
        private IWebElement getLibrariesLink;

        [FindsBy(How = How.Id, Using = "webhosting-link")]
        private IWebElement webHostingLink;

        public void Goto()
        {
            Browser.Initialize();
        }

        public void AspNetLink()
        {
            aspNetLink.Click();
        }

        public void GettingStartedLink()
        {
            gettingStartedLink.Click();
        }

        public void GetLibrariesLink()
        {
            getLibrariesLink.Click();
        }

        public void WebHostingLink()
        {
            webHostingLink.Click();
        }
    }
}