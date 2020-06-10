using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;

namespace AutomationPractice.Locators
{
    class LoginLocators
    {
        //SE MANDA LLAMAR EL DRIVER
        private RemoteWebDriver driver;
        private WebDriverWait wait;

        public LoginLocators(RemoteWebDriver Driver, WebDriverWait Wait)
        {
            driver = Driver;
            wait = Wait;
        }

        public IWebElement emailBox => driver.FindElement(By.CssSelector("input[name='email']"));
        public IWebElement pswBox => driver.FindElement(By.CssSelector("input[name='pass']"));
        public IWebElement loginButton => driver.FindElement(By.CssSelector("[type='submit']"));
    }
}
