﻿using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TargetCRM_Automation.Helpers
{
    public class WaitHelper
    {
        public static Func<IWebDriver, bool> ElementIsVisible(IWebElement element)
        {
            return (driver) =>
            {
                try
                {
                    return element.Displayed;
                }
                catch (Exception)
                {
                    return false;
                }
            };
        }

        public static Func<IWebDriver, bool> ElementExists(IWebElement element)
        {
            return (driver) =>
            {
                try
                {
                    return element.Enabled;
                }
                catch (Exception)
                {
                    return false;
                }
            };
        }

        public static Func<IWebDriver, bool> URLToBeDiffent(string URL)
        {
            return (driver) =>
            {
                try
                {
                    return !driver.Url.Equals(URL);
                }
                catch (Exception)
                {
                    return false;
                }
            };
        }
    }
}
