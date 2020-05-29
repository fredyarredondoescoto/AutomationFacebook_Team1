using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using AutomationPractice.Locators;

namespace AutomationPractice.Automation
{
    class SendMsg
    {
        private RemoteWebDriver driver;
        private WebDriverWait wait;
        public WallLocators wallPage;

        public SendMsg(RemoteWebDriver Driver, WebDriverWait Wait)
        {
            driver = Driver;
            wait = Wait;
        }

        public bool SentTheMessage(RemoteWebDriver driver)
        {
            var isMessageSend = false;
            try
            {
                wallPage = new WallLocators(driver,wait);

                //CLIC PARA ABRIR LA LISTA DE CHAT
                wallPage.FBChatList.Click();
                //ENVIAR TEXTO A LA BUSQUEDA
                wallPage.FBClSearchContact.SendKeys("Oscar Cova");
                //SELECCIONA AL CONTACTO QUE RECIVIRA EL MSJ
                wallPage.FBClSelectContact.Click();
                //REDACTAR TEXTO DEL MSJ
                wallPage.FBChatTextBox.SendKeys("Ejercicio de practica del curso de automation con selenium");
                //ENVIAR EL MSJ
                wallPage.FBSentMsgButton.Click();

                isMessageSend = true;
                //Assert.IsTrue(wallPage.FBMsgText.Displayed);
                return isMessageSend;
            }
            catch (Exception e)
            {
                TestContext.Error.WriteLine("LoginUser test failed " + e.ToString());
                return false;
            }
        }
    }
}
