using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using AutomationPractice.Locators;
using OpenQA.Selenium.Chrome;

namespace AutomationPractice.Automation
{
    class LogIn
    {
        private RemoteWebDriver driver;
        private WebDriverWait wait;

        LoginLocators loginPage;

        public LogIn(RemoteWebDriver Driver, WebDriverWait Wait)
        {
            driver = Driver;
            wait = Wait;
        }

        public bool LoginAccount(RemoteWebDriver driver)
        {
            var isLoginAccount = false;
            try
            {
                loginPage = new LoginLocators(driver, wait);
                loginPage.emailBox.Click();
                loginPage.emailBox.SendKeys("selenfacepractica1@gmail.com");
                loginPage.pswBox.Click();
                loginPage.pswBox.SendKeys("pecescolorsalmon");
                loginPage.loginButton.Click();

                isLoginAccount = true;

                return isLoginAccount;

            }
            catch (Exception e)
            {
                TestContext.Error.WriteLine("LoginAccount test failed" + e.ToString());
                return false;
            }
        }
    }
}
