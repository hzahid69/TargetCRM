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

namespace TargetCRM_Automation.Pages
{
    public class LoginPage
    {
        #region Variables and Constructors
        WebDriverWait wait = null;
        int waitComponent;
        IWebDriver driver = null;
        #endregion

        public LoginPage(IWebDriver driverReference)
        {
            driver = driverReference;
            waitComponent = Convert.ToInt16(ConfigurationManager.AppSettings["ComponentTimeout"]);
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(waitComponent));
        }

        #region Web Elements

        protected IWebElement DealerNumberField => driver.FindElement(By.Id("dealerId"));
        protected IWebElement UserNameField => driver.FindElement(By.Id("username"));

        protected IWebElement PasswordField => driver.FindElement(By.Id("password"));

        protected IWebElement LoginButton => driver.FindElement(By.Id("login_btn"));


        #endregion

        #region Methods

        public void fillDealerNumberField(string dealerId)
        {
            wait.Until(WaitHelper.ElementIsVisible(DealerNumberField));
            DealerNumberField.SendKeys(dealerId);
        }

        public void fillUsernameField(string username)
        {
            wait.Until(WaitHelper.ElementIsVisible(UserNameField));
            UserNameField.SendKeys(username);
        }

        public void fillPasswordField(string password)
        {
            wait.Until(WaitHelper.ElementIsVisible(UserNameField));
            PasswordField.SendKeys(password);
        }

        public void clickOnLoginButton()
        {
            wait.Until(WaitHelper.ElementIsVisible(LoginButton));
            LoginButton.Click();
        }

        #endregion
    }
}
