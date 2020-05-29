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
        public IWebElement FBChatList => driver.FindElementByXPath("//div[@id='fbDockChatBuddylistNub']/a[@class='fbNubButton']");
        //SEARCH A CONTACT
        public IWebElement FBClSearchContact => driver.FindElementByXPath("//div[@id='BuddylistPagelet']//input[@placeholder='Buscar']");
        //SELECT A CONTACT
        public IWebElement FBClSelectContact => driver.FindElementByXPath("(.//div[text()='Oscar Cova'])[position()=2]");
        //CHAT TEXT BOX
        public IWebElement FBChatTextBox => driver.FindElementByXPath("//div[@class='fbNubFlyoutFooter']/div[@role='presentation']");
        //SEND BUTTON
        public IWebElement FBSentMsgButton => driver.FindElementByXPath("//a[@label='send']");
        //Searh a publication 
        public IWebElement searchBox => driver.FindElementByClassName("_1frb");


        /*public IList<IWebElement> ContactOptions => driver.FindElements(By.XPath("//div[text()='Oscar Cova']"));*/

    }
}
