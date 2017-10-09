using System;
using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SpecFlowLab.TestFramework;
using SpecFlowLab.TestFramework.Pages;

namespace SpecFlowLab.Web.Tests.Acceptance
{
    [TestClass]
    public class DefaultPageTests : AcceptanceTest
    {
        [ClassInitialize]
        public new static void TestFixtureSetup(TestContext testContext) { AcceptanceTest.TestFixtureSetup(testContext); }

        [ClassCleanup]
        public new static void TestFixtureTearDown() { AcceptanceTest.TestFixtureTearDown(); }

        [TestInitialize]
        public void TestSetup()
        {
            Pages.Default.Goto();
        }

        [TestMethod]
        public void When_I_click_the_AspNet_link_Then_it_will_load_the_MS_AspNet_website()
        {
            // arrange
            var expected = "https://www.asp.net/";
            // act
            Pages.Default.AspNetLink();
            // assert
            var actual = Browser.Url;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void When_I_click_the_GettingStarted_link_Then_it_will_load_the_MS_AspNet_WebForms_page()
        {
            // arrange
            var expected = "https://www.asp.net/web-forms";
            // act
            Pages.Default.GettingStartedLink();
            // assert
            var actual = Browser.Url;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void When_I_click_the_GetLibraries_link_Then_it_will_load_the_NuGet_website()
        {
            // arrange
            var expected = "https://www.nuget.org/";
            // act
            Pages.Default.GetLibrariesLink();
            // assert
            var actual = Browser.Url;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void When_I_click_the_WebHosting_link_Then_it_will_load_the_MS_AspNet_Identity_page()
        {
            // arrange
            var expected = "https://www.asp.net/identity";
            // act
            Pages.Default.WebHostingLink();
            // assert
            var actual = Browser.Url;
            Assert.AreEqual(expected, actual);
        }
    }
}