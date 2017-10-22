using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

// ReSharper disable InconsistentNaming
// VS.NET    disable Value never assigned
#pragma warning disable 649

namespace SpecFlowLab.TestFramework.Pages
{
    public class DefaultPage : WaitablePage
    {
        [FindsBy(How = How.Id, Using = "aspnet-link")]
        private IWebElement _aspNetLink;

        [FindsBy(How = How.Id, Using = "gettingstarted-link")]
        private IWebElement _gettingStartedLink;

        [FindsBy(How = How.Id, Using = "getlibraries-link")]
        private IWebElement _getLibrariesLink;

        [FindsBy(How = How.Id, Using = "webhosting-link")]
        private IWebElement _webHostingLink;

        public void Goto()
        {
            Pages.TopNavigation.Home();
            
        }

        public bool IsAt()
        {
            return Browser.Title.Contains("Home");
        }

        public void AspNetLink()
        {
            _aspNetLink.Click();
        }

        public void GettingStartedLink()
        {
            _gettingStartedLink.Click();
            WaitUntilReady();
        }

        public void GetLibrariesLink()
        {
            _getLibrariesLink.Click();
            WaitUntilReady();
        }

        public void WebHostingLink()
        {
            _webHostingLink.Click();
            WaitUntilReady();
        }
    }
}