using MinistryOfTesting.Pages;
using NUnit.Framework;
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

namespace MinistryOfTesting.Steps
{
    [Binding]
    public class CoursesSteps : br
    {
        CoursesPage course;
        [Given(@"User is Ministry of testing page")]
        public void GivenUserIsMinistryOfTestingPage()
        {
            course = new CoursesPage(driver);
            driver.Navigate().GoToUrl("https://www.ministryoftesting.com/");
        }

        [When(@"user log in")]
        public void WhenUserLogIn()
        {
            course.LinkSignIn().Click();
            course.Username().SendKeys("bembdeprasad@gmail.com");
            course.Password().SendKeys("Prasad567123");
            course.BtnSignIn().Click();
        }

        [Then(@"verifying elements available on page")]
        public void ThenVerifyingElementsAvailableOnPage()
        {
            Assert.IsTrue(course.SuccessfulLoginText().Displayed);
            IList<IWebElement> list = driver.FindElements(By.XPath("//li[@class='nav-item']"));
            for (int i = 0; i < list.Count; i++)
            {
                if (i == 16 || i == 17) { }
                else {
                    Assert.IsTrue(list[i].Displayed);
                }
            }
        }

        [When(@"User goes to the courses")]
        public void WhenUserGoesToTheCourses()
        {
            course.Learn().Click();
            course.LinkCourses().Click();
            IList<IWebElement> list = driver.FindElements(By.XPath("//div[@class='card h-100']"));

            for (int i = 0; i < 5; i++)
            {
                Thread.Sleep(1000);
                list = driver.FindElements(By.XPath("//div[@class='card h-100']"));
                if (i == 1 || i == 2)
                { }
                else
                {
                    list[i].Click();
                    course.StartCourse().Click();
                    if (course.MembershipText().Displayed) { }
                    else { Console.WriteLine("Course is available in current plan"); }
                    course.Learn().Click();
                    course.LinkCourses().Click();
                }
            }
        }
        

        [Then(@"verifying the courses available according to the plan")]
        public void ThenVerifyingTheCoursesAvailableAccordingToThePlan()
        {
            course.SelectCourse().Click();
            Thread.Sleep(2000);
            Actions action = new Actions(driver);
            Actions act1 = new Actions(driver);

            course.FullScreen().Click();
            course.BtnPlay().Click();
            Thread.Sleep(1500);
            act1.SendKeys(Keys.Tab).Build().Perform();

            string text = course.PlayandPause().GetAttribute("title");
            Console.WriteLine(text);
            while (text == course.PlayandPause().GetAttribute("title"))
            {
                action.KeyDown(Keys.ArrowRight).Build().Perform();
                action.KeyUp(Keys.ArrowRight).Build().Perform();
            }
            Thread.Sleep(1000);
            Actions act = new Actions(driver);
            //course.FullScreen().Click();
            course.FullScreen().Click();
            act.KeyDown(Keys.LeftShift).Build().Perform();
            for (int i = 0; i < 5; i++)
            {
                Actions act2 = new Actions(driver);
                act2.KeyDown(Keys.ArrowLeft).Perform();
                act2.KeyUp(Keys.ArrowLeft).Perform();
            }

            act.KeyUp(Keys.LeftShift).Build().Perform();
            Thread.Sleep(1000);
            course.BtnPlay().Click();
            text = course.PlayandPause().GetAttribute("title");
            //course.FullScreen().Click();
            while (text == course.PlayandPause().GetAttribute("title"))
            { 
            
            }
            driver.Close();
            driver.Quit();
        }

    }
}
