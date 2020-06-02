using TargetCRM_Automation.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Configuration;

namespace TargetCRM_Automation.BaseClasses
{

    public class TestBase
    {

        public IWebDriver driver { get; set; }

        [SetUp]
        public void SetupTest()
        {
            driver = new DriverFactory().Initialize(ConfigurationManager.AppSettings["Browser"]);
        }

        [TearDown]
        public void TearDownTest()
        {

            driver.Quit();
        }
    }
}
