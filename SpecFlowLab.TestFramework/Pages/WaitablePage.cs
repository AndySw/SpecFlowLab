using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SpecFlowLab.TestFramework.Pages
{
    public class WaitablePage
    {
        protected void WaitUntilReady(string url)
        {
            var timeoutInMilliseconds = 10000;
            var wait = Browser.Wait(timeoutInMilliseconds);
            wait.Until(d =>
            {
                return d.Url.Equals(url, StringComparison.Ordinal);
            });
        }
    }
}