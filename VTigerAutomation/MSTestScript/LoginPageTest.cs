using AutomationProject.Generic;
using AutomationProject.ObjectRepository;
using AventStack.ExtentReports;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AutomationProject.MSTestScript
{
    [TestClass]
    public class LoginPageTest:BaseClas
    {
        WebDriverUtility webDriverUtility = new WebDriverUtility();


       
        [TestMethod]
        [TestCategory("LoginTestVTiger")]
        public void LoginTest()
        {
            LoginPge loginPge = new LoginPge(driver);
            loginPge.Login();
            string eTitle = "Administrator - Home - vtiger CRM 5 - Commercial Open Source CRM";
            string title = driver.Title;
            //bool res = title.Contains(eTitle);
           // var ScreenShotPath = webDriverUtility.TakeScreenShot(driver, MethodBase.GetCurrentMethod().Name);
            Assert.AreEqual(eTitle,title);
               
            
        }
        
    }
}
