using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace SpecFlowLab.TestFramework.Pages
{
    public class WaitablePage
    {
        protected void WaitUntilReady()
        {
            var timeoutInMilliseconds = 10000;
            var wait = Browser.Wait(timeoutInMilliseconds);
            wait.Until(d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));
        }
    }
}
