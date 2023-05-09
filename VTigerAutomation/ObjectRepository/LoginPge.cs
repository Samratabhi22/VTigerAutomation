using AutomationProject.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationProject.ObjectRepository
{
    
    public class LoginPge
    {
        WebDriverUtility webDriverUtility = new WebDriverUtility();

        [SeleniumExtras.PageObjects.FindsBy(How=SeleniumExtras.PageObjects.How.Name ,Using="user_name")]
        private IWebElement userNameTxt {  get; set; }
        [SeleniumExtras.PageObjects.FindsBy(How=SeleniumExtras.PageObjects.How.Name,Using = "user_password")]
        private IWebElement passwordTxt { get; set;}
        [SeleniumExtras.PageObjects.FindsBy(How = SeleniumExtras.PageObjects.How.Id, Using = "submitButton")]
        private IWebElement loginBtn { get; set; }
        public LoginPge(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
                
        }
        public void Login()
        {
            userNameTxt.SendKeys("admin");
            passwordTxt.SendKeys("admin");
            loginBtn.Click();
        }
        
    }
}
