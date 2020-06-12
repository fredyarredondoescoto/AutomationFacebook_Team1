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

        //SEARCH BOX
        public IWebElement SearchBoxO => driver.FindElementByClassName("_1frb");
        public IWebElement SearchBoxN => driver.FindElementByXPath("//*[@class = 'oajrlxb2 rq0escxv f1sip0of hidtqoto lzcic4wl ijkhr0an " +
            "nlq1og4t sgqwj88q b3i9ofy5 oo9gr5id b1f16np4 hdh3q7d8 dwo3fsh8 qu0x051f esr5mh6w e9989ue4 r7d6kgcz br7hx15l h2jyy9rg n3ddgdk9" +
            " owxd89k7 ihxqhq3m jq4qci2q k4urcfbm iu8raji3 qypqp5cg l60d2q6s hv4rvrfc hwnh5xvq dati1w0a o1lsuvei o6r2urh6 rmlgq0sb aj8hi1zk" +
            " r4fl40cc kd8v7px7 m07ooulj mzan44vs']");

        //SEARCH ICON (ONLY IN OLD VERSION)
        public IWebElement SearchIcon => driver.FindElementByClassName("_585_");

        //CANAL BUTTON(ONLY IN OLD VERSION)
        public IWebElement CanalButtonO => driver.FindElementByXPath("//body/div/div [@id='globalContainer']/div[@id='content']/div/div" +
            "[@class='clearfix pbm']/div[@class='_1qkq _1qkx']/div/div/div[@id='bootstrap_entity_module']/div/div/div/div/div/div[@class='_77we']" +
            "/div[@class='_6v_9']/div[@class='_6v_a']/div[@class='_6v-_']/div[@class='_6v_0 _4ik4 _4ik5']/a");

        //LIKE BUTTON 
        public IWebElement LikebuttonO => driver.FindElementByXPath("//*[@class = 'likeButton _4jy0 _4jy4 _517h _51sy _42ft']");
        public IWebElement LikebuttonN => driver.FindElementByXPath("//*[@aria-label = 'Me gusta Cova LoL']");
        //FACEBOOK ICON
        public By FacebookIconOld = By.ClassName("._2md");
        public By FacebookIconNew = By.ClassName(".p361ku9c");

    }
}
