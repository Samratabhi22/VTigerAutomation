using AventStack.ExtentReports;
using AventStack.ExtentReports.Core;
using AventStack.ExtentReports.Reporter;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VTigerAutomation.Generic;

namespace AutomationProject.Generic
{
    [TestClass]
    public class BaseClas
    {
        public static ExtendReportUtility extendReportUtility = new ExtendReportUtility();
        public string ScreenShotPath;
        public static IWebDriver driver;
       // public static ExtentTest extentTest;
        /*public TestContext testContext;

         public TestContext TestContext
         {
             get { return testContext; }
             set { testContext = value; }
         }*/

        [AssemblyInitialize]
        public static void AssemblyIntitial(TestContext context)
        {
            ExtendReportUtility.extentReports.AttachReporter(extendReportUtility.htmlReporter);
            extendReportUtility.htmlReporter.Start();
            ExtendReportUtility.extentTest.Log(Status.Info, "Assembly initialized");
            Console.WriteLine("Assembly started");
        }
        [AssemblyCleanup]
        public static void AssemblyCleanup() 
        {
            ExtendReportUtility.extentReports.Flush();
            extendReportUtility.htmlReporter.Stop();
            Console.WriteLine("Assembly clean up done");
            
        
        }
        [TestInitialize]
        public void initialize()
        {
                driver = new ChromeDriver();
                driver.Url = "http://localhost:8888/";
                WebDriverUtility webDriverUtility = new WebDriverUtility();
                webDriverUtility.Maximize(driver);
                webDriverUtility.ImplicitWait(driver);
                ScreenShotPath = "C:\\Users\\LENOVO\\source\\repos\\BankingProjectPrac\\AutomationProject\\Generic\\ScreenShots\\ss.png";
               // extentTest = extentReports.CreateTest(testContext.TestName);

            
        }

        [TestCleanup]
        public void Cleanup()
        {
            ExtendReportUtility.extentTest.AddScreenCaptureFromPath(ScreenShotPath);
            driver.Close();
            driver.Dispose();
        }

    }
}
