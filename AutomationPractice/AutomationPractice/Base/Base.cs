using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;

namespace AutomationPractice.Base
{
    class Base
    {
        public RemoteWebDriver SetUp()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("--disable-notifications");
            RemoteWebDriver driver = new ChromeDriver(options);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.facebook.com/");
            return driver;
        }
    }
}
