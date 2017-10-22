using System;
using System.Diagnostics;
using NUnit.Framework;
using SpecFlowLab.TestFramework;
using SpecFlowLab.TestFramework.Pages;

namespace SpecFlowLab.Web.Tests.Acceptance
{
    [TestFixture]
    public class ContactPageTests : AcceptanceTest
    {
        [SetUp]
        public void TestSetup()
        {
            Pages.Contact.Goto();
        }

        [Test]
        public void When_I_view_the_Contact_page_Then_it_will_display_the_postal_address()
        {
            // arrange
            var expected = "One Microsoft Way\nRedmond, WA 98052-6399\nP: 425.555.0100";
            // act
            var actual = Pages.Contact.GetAddressText();
            // assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void When_I_view_the_Contact_page_Then_it_will_display_the_support_email_address()
        {
            // arrange
            var expected = "support@example.com";
            // act
            var actual = Pages.Contact.SupportEmailAddress();
            // assert
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void When_I_view_the_Contact_page_Then_it_will_display_the_marketing_email_address()
        {
            // arrange
            var expected = "marketing@example.com";
            // act
            var actual = Pages.Contact.MarketingEmailAddress();
            // assert
            Assert.AreEqual(expected, actual);
        }
    }
}