using System;
using NUnit.Framework;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using AutomationPractice.Locators;
using System.Threading;
using System.Transactions;
using OpenQA.Selenium;

namespace AutomationPractice.Automation
{
    class GiveLike
    {
        private RemoteWebDriver driver;
        private WebDriverWait wait;
        WallLocators likeLocator;

        public GiveLike(RemoteWebDriver Driver, WebDriverWait Wait)
        {
            this.driver = Driver;
            this.wait = Wait;
        }

        public bool Like(RemoteWebDriver driver)
        {
            likeLocator = new WallLocators(driver, wait);

            try
            {
                //lee si el elemento es el icono antiguo de facebook, de serlo entra al if, si no entra al else
                if (driver.FindElement(likeLocator.FacebookIconOld).Displayed)
                {
                    likeLocator.SearchBoxO.Click();
                    likeLocator.SearchBoxO.SendKeys("Cova LoL");
                    Thread.Sleep(5000);
                    likeLocator.SearchIcon.Click();
                    Thread.Sleep(5000);
                    likeLocator.CanalButtonO.Click();
                    Thread.Sleep(5000);
                    likeLocator.LikebuttonO.Click();
                    Thread.Sleep(5000);
                }

                // De entrar al else es el icono nuevo, por lo tanto ejecuta la prueba oara la version nueva
                else
                {
                    likeLocator.SearchBoxN.Click();
                    likeLocator.SearchBoxN.SendKeys("Cova LoL");
                    likeLocator.SearchBoxN.SendKeys(Keys.Enter);
                    Thread.Sleep(5000);
                    likeLocator.LikebuttonN.Click();
                    Thread.Sleep(5000);
                }
                return true;
            }
            catch (Exception e)
            {
                TestContext.Error.WriteLine("Like page test failed" + e.ToString());

                return false;
            }
        }


    }
}
