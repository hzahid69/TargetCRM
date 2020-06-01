using TargetCRM_Automation.BaseClasses;
using TargetCRM_Automation.Helpers;
using TargetCRM_Automation.Steps;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using System.Collections;

namespace TargetCRM_Automation.Tests
{
    [TestFixture]
    [Parallelizable(ParallelScope.Fixtures)]
    public class Test_Login : TestBase
    {

        #region Page Objects and steps
        LoginSteps loginSteps = null;
        DashboardSteps dashboardSteps = null;
        #endregion

        #region Data driven provider
        public static IEnumerable loginDataProvider(int dataRow)
        {
            return DataDrivenCSV.returnsCSVData(System.AppDomain.CurrentDomain.BaseDirectory
                + "../../Resources/TestData/Login.csv", dataRow);
        }

        #endregion

        [TestMethod, TestCaseSource("loginDataProvider", new object[] { 1 })]
        public void MyLogin(ArrayList TestData)
        {
            #region Instantiate
            loginSteps = new LoginSteps(driver);
            dashboardSteps = new DashboardSteps(driver);
            #endregion

            loginSteps.LoginApp(TestData[0].ToString(), TestData[1].ToString(), TestData[2].ToString());

            NUnit.Framework.Assert.IsTrue(dashboardSteps.dashboardPage.Is_LoggedInUserLabel_Visible());
            NUnit.Framework.Assert.IsTrue(dashboardSteps.dashboardPage.GetText_loggedInUser().Equals("ADMIN"));

        }


    }
}
