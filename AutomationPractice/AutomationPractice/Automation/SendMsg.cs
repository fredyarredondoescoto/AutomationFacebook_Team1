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

                IWebElement element = null; //Crea un elemento IWebEleent inicializado en null

                //CLIC PARA ABRIR LA LISTA DE CHAT
                var FBChatListO = driver.FindElement(wallPage.FBChatListOld);
                var FBChatListN = driver.FindElement(wallPage.FBChatListNew);

                if (TryFindElement(By.XPath("//div[@id='fbDockChatBuddylistNub']/a[@class='fbNubButton']"), out element))
                {/*Verify if it is the old version*/
                    bool visible = IsElementVisible(element);
                    if (visible)
                    {
                        FBChatListO.Click();
                    }
                }
                else if (TryFindElement(By.XPath("//div[@aria-label='Nuevo mensaje']"), out element))
                {/*Verify if it is the new version*/
                    bool visible = IsElementVisible(element);
                    if (visible)
                    {
                        FBChatListN.Click();
                    }
                }

                //ENVIAR TEXTO A LA BUSQUEDA
                var FBClSearchContactO = driver.FindElement(wallPage.FBClSearchContactOld);
                var FBClSearchContactN = driver.FindElement(wallPage.FBClSearchContactNew);

                if (TryFindElement(By.XPath("//div[@id='fbDockChatBuddylistNub']/a[@class='fbNubButton']"), out element))
                {/*Verify if it is the old version*/
                    bool visible = IsElementVisible(element);
                    if (visible)
                    {
                        FBClSearchContactO.SendKeys("Cova LoL");
                    }
                }
                else if (TryFindElement(By.XPath("//div[@aria-label='Nuevo mensaje']"), out element))
                {/*Verify if it is the new version*/
                    bool visible = IsElementVisible(element);
                    if (visible)
                    {
                        FBClSearchContactN.SendKeys("Cova LoL");
                    }
                }

                //SELECCIONA AL CONTACTO QUE RECIVIRA EL MSJ
                var FBClSelectContactO = driver.FindElement(wallPage.FBClSelectContactOld);
                var FBClSelectContactN = driver.FindElement(wallPage.FBClSelectContactNew);

                if (TryFindElement(By.XPath("//div[@id='fbDockChatBuddylistNub']/a[@class='fbNubButton']"), out element))
                {/*Verify if it is the old version*/
                    bool visible = IsElementVisible(element);
                    if (visible)
                    {
                        FBClSelectContactO.Click();
                    }
                }
                else if (TryFindElement(By.XPath("//div[@aria-label='Nuevo mensaje']"), out element))
                {/*Verify if it is the new version*/
                    bool visible = IsElementVisible(element);
                    if (visible)
                    {
                        FBClSelectContactN.Click();
                    }
                }

                //REDACTAR TEXTO DEL MSJ
                var FBChatTextBoxO = driver.FindElement(wallPage.FBChatTextBoxOld);
                var FBChatTextBoxN = driver.FindElement(wallPage.FBChatTextBoxNew);

                if (TryFindElement(By.XPath("//div[@id='fbDockChatBuddylistNub']/a[@class='fbNubButton']"), out element))
                {/*Verify if it is the old version*/
                    bool visible = IsElementVisible(element);
                    if (visible)
                    {
                        FBChatTextBoxO.SendKeys("Ejercicio de practica del curso de automation con selenium");
                    }
                }
                else if (TryFindElement(By.XPath("//div[@aria-label='Nuevo mensaje']"), out element))
                {/*Verify if it is the new version*/
                    bool visible = IsElementVisible(element);
                    if (visible)
                    {
                        FBChatTextBoxN.SendKeys("Ejercicio de practica del curso de automation con selenium");
                    }
                }

                //ENVIAR EL MSJ
                var FBSentMsgButtonO = driver.FindElement(wallPage.FBSentMsgButtonOld);
                var FBSentMsgButtonN = driver.FindElement(wallPage.FBSentMsgButtonNew);

                if (TryFindElement(By.XPath("//div[@id='fbDockChatBuddylistNub']/a[@class='fbNubButton']"), out element))
                {/*Verify if it is the old version*/
                    bool visible = IsElementVisible(element);
                    if (visible)
                    {
                        FBSentMsgButtonO.Click();
                    }
                }
                else if (TryFindElement(By.XPath("//div[@aria-label='Nuevo mensaje']"), out element))
                {/*Verify if it is the new version*/
                    bool visible = IsElementVisible(element);
                    if (visible)
                    {
                        FBSentMsgButtonN.Click();
                    }
                }

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

        public bool TryFindElement(By by, out IWebElement element) //Method to find the element
        {
            try
            {
                element = driver.FindElement(by);
            }
            catch (NoSuchElementException e)
            {
                element = null;
                return false;
            }
            return true;
        }

        public bool IsElementVisible(IWebElement element)//Method to check if the element is displayed
        {
            return element.Displayed;
        }
    }
}
