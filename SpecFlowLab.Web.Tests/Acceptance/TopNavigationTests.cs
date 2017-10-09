using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpecFlowLab.TestFramework;
using SpecFlowLab.TestFramework.Pages;

namespace SpecFlowLab.Web.Tests.Acceptance
{
    [TestClass]
    public class TopNavigationTests : AcceptanceTest
    {
        [ClassInitialize]
        public new static void TestFixtureSetup(TestContext testContext) { AcceptanceTest.TestFixtureSetup(testContext); }

        [ClassCleanup]
        public new static void TestFixtureTearDown() { AcceptanceTest.TestFixtureTearDown(); }

        [TestMethod]
        public void When_I_click_the_Home_link_Then_it_will_load_the_Default_page()
        {
            // arrange
            var expected = "/";
            // act
            Pages.TopNavigation.Home();
            // assert
            var actual = new Uri(Browser.Url).PathAndQuery;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void When_I_click_the_About_link_Then_it_will_load_the_About_page()
        {
            // arrange
            var expected = "/About";
            // act
            Pages.TopNavigation.About();
            // assert
            var actual = new Uri(Browser.Url).PathAndQuery;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void When_I_click_the_Contact_link_Then_it_will_load_the_Contact_page()
        {
            // arrange
            var expected = "/Contact";
            // act
            Pages.TopNavigation.Contact();
            // assert
            var actual = new Uri(Browser.Url).PathAndQuery;
            Assert.AreEqual(expected, actual);
        }
    }
}