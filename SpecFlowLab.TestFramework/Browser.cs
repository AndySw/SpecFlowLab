﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SpecFlowLab.TestFramework
{
    public static class Browser
    {
        private static string baseUrl = "http://localhost:51218/";
        private static IWebDriver webDriver = new ChromeDriver();
        public static void Initialize()
        {
            Goto("");
        }

        public static string Title
        {
            get { return webDriver.Title; }
        }

        public static string Url
        {
            get { return webDriver.Url; }
        }

        public static ISearchContext Driver
        {
            get { return webDriver; }
        }

        public static void Goto(string url)
        {
            webDriver.Url = baseUrl + url;
        }

        public static void Close()
        {
            webDriver.Quit();
        }

        public static void Wait()
        {
            var timeout = 10000; // in milliseconds
            var wait = new WebDriverWait(webDriver, TimeSpan.FromMilliseconds(timeout));
            wait.Until(d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));
        }
    }
}
