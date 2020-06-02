using TargetCRM_Automation.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SeleniumExtras.WaitHelpers;

namespace TargetCRM_Automation.Pages
{
    public class DashboardPage
    {
        #region Variables and Constructors
        WebDriverWait wait = null;
        int waitComponent;
        IWebDriver driver = null;
        #endregion

        public DashboardPage(IWebDriver driverReference)
        {
            driver = driverReference;
            waitComponent = Convert.ToInt16(ConfigurationManager.AppSettings["ComponentTimeout"]);
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(waitComponent));
        }

        #region Web Elements

        protected IWebElement LoggedInUserLabel => driver.FindElement(By.Id("userFullName"));


        #endregion

        #region Methods

        public bool Is_LoggedInUserLabel_Visible()
        {
            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.Id("userFullName")));
            try
            {
                return LoggedInUserLabel.Displayed;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        public string GetText_loggedInUser()
        {
            return LoggedInUserLabel.Text;
        }


        #endregion
    }
}
