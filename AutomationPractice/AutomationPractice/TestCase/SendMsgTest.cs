using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using AutomationPractice.Automation;

namespace AutomationPractice.TestCase
{
    class SendMsgTest : Base.Base
    {
        [Test]//ESTA PRUEBA INICIA SESIÓN EN Youtube
        public virtual void LoginAcciunt_SendMessage()
        {
            try
            {
                var driver = SetUp();
                var loginAccount = new LogIn(driver, new WebDriverWait(driver, TimeSpan.FromSeconds(10)));
                loginAccount.LoginAccount(driver);
                var sendMessage= new SendMsg(driver, new WebDriverWait(driver, TimeSpan.FromSeconds(10)));
                sendMessage.SentTheMessage(driver);
                //driver.Quit();//CIERRA EL NAVEGADOR PARA QUE INICIE LA SIGUIENTE PRUEBA
            }
            catch (Exception e)
            {
                TestContext.Error.WriteLine($"{e.ToString()}");
                //Assert.Ignore();
            }
        }
    }
}
