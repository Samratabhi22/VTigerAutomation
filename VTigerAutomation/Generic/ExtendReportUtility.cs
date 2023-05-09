using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Reflection;

namespace VTigerAutomation.Generic
{
    public class ExtendReportUtility
    {
        public TestContext testContext;
        public TestContext TestContext
        {
            get { return testContext; }
            set { testContext = value; }
        }

        public static string htmlReportPath = "C:\\Users\\LENOVO\\source\\repos\\VTigerAutomation\\VTigerAutomation\\Generic\\Report\\";
        public static ExtentReports extentReports = new ExtentReports();
        public ExtentHtmlReporter htmlReporter = new ExtentHtmlReporter(htmlReportPath);
        public static ExtentTest extentTest = extentReports.CreateTest(MethodBase.GetCurrentMethod().Name);

        public void extentreportmethod(string url)
        {
            if (extentTest.Status == Status.Fail)
            {
                extentTest.Log(Status.Fail, "this data is failed");
                extentTest.Info("URL Is : " + url);

            }
            else if (extentTest.Status == Status.Pass)
            {
                extentTest.Log(Status.Pass, " data is passed");
                extentTest.Info("URL Is : " + url);
            }
            else if (extentTest.Status == Status.Skip)
            {
                extentTest.Log(Status.Info, "skipped");
            }
        }
    }

}
