using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinistryOfTesting.Pages
{
    internal class CoursesPage
    {
        public IWebDriver driver;

        public CoursesPage(IWebDriver redriver)
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
        By linkCourses = By.XPath("//a[contains(text(),'Courses')]");
        By startCourse = By.XPath("//a[contains(text(),'Start Course')]");
        By membership = By.XPath("//div[@class='container'] /div/h1");
        By selectCourse = By.XPath("(//div[@class='card h-100'])[1]");
        By btnPlay = By.XPath("//button[@title='Play Video']");
        By playAndpause = By.XPath("(//button[@tagname='button'])[1]");
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

        public IWebElement LinkCourses()
        {
            return driver.FindElement(linkCourses);
        }

        public IWebElement StartCourse()
        {
            return driver.FindElement(startCourse);
        }

        public IWebElement MembershipText()
        {
            return driver.FindElement(membership);
        }
        public IWebElement SelectCourse()
        {
            return driver.FindElement(selectCourse);
        }
        public IWebElement BtnPlay()
        {
            return driver.FindElement(btnPlay);
        }
        public IWebElement FullScreen()
        {
            return driver.FindElement(fullScreen);
        }
        public IWebElement PlayandPause()
        {
            return driver.FindElement(playAndpause);
        }
    }
}
