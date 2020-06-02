using TargetCRM_Automation.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TargetCRM_Automation.Steps
{
    public class LoginSteps
    {
        public LoginPage loginPage;

        public LoginSteps(IWebDriver driverReference)
        {
            loginPage = new LoginPage(driverReference);
        }

        public void LoginApp(string dealerId, string username, string password)
        {
            loginPage.fillDealerNumberField(dealerId);
            loginPage.fillUsernameField(username);
            loginPage.fillPasswordField(password);
            loginPage.clickOnLoginButton();
        }
    }
}
