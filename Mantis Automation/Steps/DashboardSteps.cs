using TargetCRM_Automation.Pages;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TargetCRM_Automation.Steps
{
    public class DashboardSteps
    {
        public DashboardPage dashboardPage;

        public DashboardSteps(IWebDriver driverReference)
        {
            dashboardPage = new DashboardPage(driverReference);
        }



    }
}
