using System;
using System.Collections.Generic;
using System.Text;
using AutomationPractice.Locators;

namespace AutomationPractice.Automation
{
    class ComenInteraccion
    {
        private RemoteWebDriver driver;
        private WebDriverWait wait;
        WallLocators basePage;

        public ComenInteraccion(RemoteWebDriver Driver, WebDriverWait Wait)
        {
            driver = Driver;
            wait = Wait;
        }
        public bool Coment(RemoteWebDriver driver)
        {

            var interactionDone = false;
            basePage = new WallLocators (driver, wait);
            try
            {
                basePage.searchBox.SendKeys("Covalol");
                basePage.searchBox.Click();
                Thread.Sleep(5000);
                return true;
            }
            catch (Exception e)
            {
                TestContext.Error.WriteLine("AddFriends test failed " + e.ToString());
                return false;
            }
        }
    }
}
