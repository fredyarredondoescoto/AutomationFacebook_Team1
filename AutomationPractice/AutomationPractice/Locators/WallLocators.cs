using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;

namespace AutomationPractice.Locators
{
    class WallLocators
    {
        private RemoteWebDriver driver;
        private WebDriverWait wait;

        public WallLocators(RemoteWebDriver Driver, WebDriverWait Wait)
        {
            driver = Driver;
            wait = Wait;
        }
        //CHAT LIST
        //public IWebElement FBChatList => driver.FindElementByXPath("//div[@id='fbDockChatBuddylistNub']/a[@class='fbNubButton']");
        public By FBChatListOld = By.XPath("//div[@id='fbDockChatBuddylistNub']/a[@class='fbNubButton']");
        public By FBChatListNew = By.XPath("//div[@aria-label='Nuevo mensaje']");

        //SEARCH A CONTACT
        //public IWebElement FBClSearchContact => driver.FindElementByXPath("//div[@id='BuddylistPagelet']//input[@placeholder='Buscar']");
        public By FBClSearchContactOld = By.XPath("//div[@id='BuddylistPagelet']//input[@placeholder='Buscar']");
        public By FBClSearchContactNew = By.XPath("//span[@data-testid='Keycommand_wrapper']");

        //SELECT A CONTACT
        //public IWebElement FBClSelectContact => driver.FindElementByXPath("(.//div[text()='Cova LoL'])[position()=1]");
        public By FBClSelectContactOld = By.XPath("(.//div[text()='Cova LoL'])[position()=1]");
        public By FBClSelectContactNew = By.XPath("//div[@aria-label='Cova LoL']");

        //CHAT TEXT BOX
        //public IWebElement FBChatTextBox => driver.FindElementByXPath("//div[@class='fbNubFlyoutFooter']/div[@role='presentation']");
        public By FBChatTextBoxOld = By.XPath("//div[@class='fbNubFlyoutFooter']/div[@role='presentation']");
        public By FBChatTextBoxNew = By.XPath("//div[text()='Aa']");

        //SEND BUTTON
        //public IWebElement FBSentMsgButton => driver.FindElementByXPath("//a[@label='send']");
        public By FBSentMsgButtonOld = By.XPath("//a[@label='send']");
        public By FBSentMsgButtonNew = By.XPath("//div[@aria-label='Presiona \"Enter\" para enviar']");

        //Searh a publication 
        public IWebElement searchBox => driver.FindElementByClassName("_1frb");

    }
}
