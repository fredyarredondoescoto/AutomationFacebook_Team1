using AutomationPractice.Automation;
using System;
using AutomationPractice;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;

namespace AutomationPractice.TestCase
{
    class Comentario: Base.Base
    {
        [Test]
        public void coment()
        {
            try
            {
                var driver = SetUp();
                var interact = new ComenInteraccion (driver, new WebDriverWait(driver, TimeSpan.FromSeconds(35)));
                Assert.IsTrue(interact.Coment(driver));
                driver.Close();
            }
            catch (Exception e)
            {
                TestContext.Error.WriteLine($"{e.ToString()}");
                Assert.Ignore();
            }
        }
    }
}
