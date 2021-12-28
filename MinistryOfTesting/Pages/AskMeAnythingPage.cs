using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium;

namespace TestingAskMeAnything.Pages
{
    [Binding]
    public class AskMeAnythingPage
    {
        public IWebDriver driver;

        public AskMeAnythingPage(IWebDriver redriver)
        {
            driver = redriver;
            PageFactory.InitElements(redriver, this);
        }

        By linkSignin = By.XPath("//a[@title='Sign In']");
        By username = By.XPath("//input[@name='user[login]']");
        By password = By.XPath("//input[@type='password']");
        By btnSignIn = By.XPath("//input[@type='submit']");
        By signedInSuccessfulText = By.XPath("//div[@class='mt-3 mx-3 alert alert-success alert-dismissible fade show']");
        By learn = By.CssSelector("#learnNav");
        By askMeAnything = By.XPath("//li[@class='nav-item'] /a[contains(text(),'Ask Me Anythings')]");
        By selectSeries = By.XPath("(//div[@class='list-group-flush']/a)[1]");
        By selectVideos = By.XPath("//ul[@class='list-group'] /a");
        By playButton = By.XPath("//div[@data-handle='smallPlayButton'] //button");
        By storyAnchor = By.XPath("(//div[@aria-label='Playbar']/div)[1]");
        By accessPageContent = By.XPath("//div[@id='wistia_62_right']");
        By descriptionText = By.XPath("(//h2[@class='h4'])[1]");
        By fullScreen = By.XPath("(//div[@data-handle='fullscreenButton'])[1]");
        public IWebElement LinkSignIn()
        {
           return driver.FindElement(linkSignin);
        }

        public IWebElement Username()
        {
            return driver.FindElement(username);
        }

        public IWebElement Password()
        {
            return driver.FindElement(password);
        }

        public IWebElement BtnSignIn()
        {
            return driver.FindElement(btnSignIn);
        }

        public IWebElement SuccessfulLoginText()
        {
            return driver.FindElement(signedInSuccessfulText);
        }

        public IWebElement Learn()
        {
            return driver.FindElement(learn);
        }

        public IWebElement linkAskMeAnything()
        {
            return driver.FindElement(askMeAnything);
        }

        public IWebElement SelectSeries()
        {
            return driver.FindElement(selectSeries);
        }

        public IWebElement SelectVideo()
        {
            return driver.FindElement(selectVideos);
        }

        public IWebElement PlayVideo()
        {
            return driver.FindElement(playButton);
        }

        public IWebElement StoryAnchor()
        {
            return driver.FindElement(storyAnchor);
        }

        public IWebElement temp()
        {
            return driver.FindElement(By.XPath("//div[@aria-label='Playbar']"));
        }

        public IWebElement AccessContent()
        {
            return driver.FindElement(accessPageContent);
        }
        public IWebElement DescText()
        {
            return driver.FindElement(descriptionText);
        }
        public IWebElement BtnFullScreen()
        {
            return driver.FindElement(fullScreen);
        }
    }
}
