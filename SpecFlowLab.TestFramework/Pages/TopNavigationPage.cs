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
    public class TopNavigationPage
    {
        [FindsBy(How = How.LinkText, Using = "Application name")]
        private IWebElement titleLink;

        [FindsBy(How = How.LinkText, Using = "Home")]
        private IWebElement homeLink;

        [FindsBy(How = How.LinkText, Using = "About")]
        private IWebElement aboutLink;

        [FindsBy(How = How.LinkText, Using = "Contact")]
        private IWebElement contactLink;

        public void Title()
        {
            titleLink.Click();
        }

        public void Home()
        {
            homeLink.Click();
        }

        public void About()
        {
            aboutLink.Click();
        }

        public void Contact()
        {
            contactLink.Click();
        }
    }
}
