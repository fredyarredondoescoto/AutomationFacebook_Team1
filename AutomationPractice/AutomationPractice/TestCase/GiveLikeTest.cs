using System;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using AutomationPractice.Automation;
using AutomationPractice.Base;

namespace AutomationPractice.TestCase
{
    class GiveLikeTest : Base.Base
    {

        [Test]
        public void LogIn_GiveLike()
        {
            try
            {
                var driver = SetUp();
                var loginAccount = new LogIn(driver, new WebDriverWait(driver, TimeSpan.FromSeconds(10)));
                loginAccount.LoginAccount(driver);
                var like = new GiveLike(driver, new WebDriverWait(driver, TimeSpan.FromSeconds(10)));
                like.Like(driver);
                driver.Quit();
            }
            catch (Exception e)
            {
                TestContext.Error.WriteLine($"{e.ToString()}");
            }
        }
    }
}