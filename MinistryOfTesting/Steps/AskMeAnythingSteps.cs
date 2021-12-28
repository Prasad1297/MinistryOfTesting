using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TestingAskMeAnything.Base;
using TestingAskMeAnything.Pages;

namespace MinistryOfTesting.Steps
{
    [Binding]
    public class AskMeAnythingSteps : br
    {
        AskMeAnythingPage ask;
        [Given(@"User is on Ministry of testing home page")]
        public void GivenUserIsOnMinistryOfTestingHomePage()
        {
            ask = new AskMeAnythingPage(driver);
            driver.Navigate().GoToUrl("https://www.ministryoftesting.com/");
        }

        [When(@"User goes to Ask me anything section")]
        public void WhenUserGoesToAskMeAnythingSection()
        {
            ask.LinkSignIn().Click();
            ask.Username().SendKeys("bembdeprasad@gmail.com");
            ask.Password().SendKeys("Prasad567123");
            ask.BtnSignIn().Click();
            ask.Learn().Click();
            ask.linkAskMeAnything().Click();
            ask.SelectSeries().Click();
        }

        [When(@"verify the video in video series")]
        public void WhenVerifyTheVideoInVideoSeries()
        {
            ask.SelectVideo().Click();
        }

        [Then(@"User should be able to play that video")]
        public void ThenUserShouldBeAbleToPlayThatVideo()
        {
            IList<IWebElement> list = driver.FindElements(By.XPath("//ul[@class='list-group'] /a"));
            float width = 513;
            for (int i = 0; i < 2; i++)
            {
                list = driver.FindElements(By.XPath("//ul[@class='list-group'] /a"));
                Thread.Sleep(3000);
                Actions action2 = new Actions(driver);
                action2.MoveToElement(list[i]).Click().Perform();


                string videoSizeInString = ask.temp().GetAttribute("aria-valuemax");
                Actions action = new Actions(driver);
                Console.WriteLine(videoSizeInString);
                Console.WriteLine();
                int x = ask.BtnFullScreen().Location.X;
                int y = ask.BtnFullScreen().Location.Y;
                float videoSize = float.Parse(videoSizeInString);
                Console.WriteLine("video size is");
                Console.WriteLine(videoSize);

                float secondsPerPixel = videoSize / width;
                int pixelBefore10Seconds = (int)((videoSize - 10) / secondsPerPixel);

                action.MoveToElement(ask.StoryAnchor()).MoveByOffset(pixelBefore10Seconds, 0).Click().Perform();
                Thread.Sleep(1000);
                if (ask.PlayVideo().GetAttribute("title") != "Pause")
                {
                    ask.PlayVideo().Click();
                }

                string text = ask.PlayVideo().GetAttribute("title");
                Console.WriteLine(text);
                while (text == ask.PlayVideo().GetAttribute("title"))
                {

                }
                Actions action1 = new Actions(driver);
                action1.MoveToElement(ask.BtnFullScreen()).MoveByOffset(50, 0).Click().Perform();
                Thread.Sleep(2000);
            }
            driver.Close();
            driver.Quit();
        }
    }
    
}
