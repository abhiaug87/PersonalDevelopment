using System;
using NUnit.Framework;
using PersonalDevelopment.Data;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;
using PersonalDevelopment.PageObjects;
using OpenQA.Selenium.Interactions;


namespace PersonalDevelopment.Steps
{
    [Binding]
    public class Stepdefinition : BaseClass
    {
        Pageobjects po = new Pageobjects(Driver);
        WebDriverWait wait = new WebDriverWait(Driver, new TimeSpan(0, 0, 5));
        JSON read = new JSON();


        [Given(@"I am on the login page")]
        public void GivenIAmOnTheLoginPage()
        {
            Driver.Navigate().GoToUrl(read.jsonReader("../PersonalDevelopment/Data/TestData.json", "url"));
            Assert.IsTrue(po.username.GetAttribute("placeholder").Contains(read.jsonReader("../PersonalDevelopment/Data/TestData.json", "usernametxt")), "Text does not match as expected");
            po.username.SendKeys(read.jsonReader("../PersonalDevelopment/Data/TestData.json", "username"));
            Assert.IsTrue(po.cont.Text.Contains(read.jsonReader("../PersonalDevelopment/Data/TestData.json", "continue")), "Text does not match as expected");
            po.cont.Click();
            Assert.IsTrue(po.password.GetAttribute("placeholder").Contains(read.jsonReader("../PersonalDevelopment/Data/TestData.json", "passtxt")), "Text does not match as expected");
            po.password.SendKeys(read.jsonReader("../PersonalDevelopment/Data/TestData.json", "password"));
            Assert.IsTrue(po.login.Text.Contains(read.jsonReader("../PersonalDevelopment/Data/TestData.json", "login")), "Text does not match as expected");
            po.login.Click();
        }

        [Given(@"I click on the Confluence link")]
        public void WhenIClickOnTheConfluenceLink()
        {
            po.confluence.Click();
            Assert.IsTrue(po.confluence.Text.Contains(read.jsonReader("../PersonalDevelopment/Data/TestData.json", "confluence")));
            Assert.IsTrue(po.home.Text.Contains(read.jsonReader("../PersonalDevelopment/Data/TestData.json", "home")));
        }

        [Given(@"I am redirected to the Home page")]
        public void ThenIAmRedirectedToTheHomePage()
        {
            Assert.IsTrue(po.home.Text.Contains(read.jsonReader("../PersonalDevelopment/Data/TestData.json", "home")));
        }

        [When(@"I click on my space")]
        public void WhenIClickOnMySpace()
        {
            Assert.IsTrue(po.space.Text.Contains(read.jsonReader("../PersonalDevelopment/Data/TestData.json", "space")));
            po.space.Click();
        }

        [When(@"I am redirected to the Overview page")]
        [Then(@"I am redirected to the Overview page")]
        public void ThenIAmRedirectedToTheOverviewPage()
        {
            Assert.IsTrue(po.overview.Text.Contains(read.jsonReader("../PersonalDevelopment/Data/TestData.json", "overview")));
        }

        [When(@"I navigate to the restrictions page")]
        public void WhenINavigateToTheRestrictionsPage()
        {
            Sleep(2);
            po.restrictionsmenu.Click();
            Assert.IsTrue(po.restrictionstxt.Text.Contains(read.jsonReader("../PersonalDevelopment/Data/TestData.json", "restrictions")));
            po.restrictionstxt.Click();
        }

        [When(@"I choose the permission")]
        public void WhenIChooseThePermission()
        {
            po.restrictionstf.Click();
            Actions action = new Actions(Driver);
            Actions hover = action.MoveToElement(po.restrictionstxt1).Click().SendKeys(Keys.ArrowUp + Keys.ArrowUp + Keys.Enter);
            hover.Build().Perform();
            Assert.IsTrue(po.apply.GetAttribute("innerHTML").Contains(read.jsonReader("../PersonalDevelopment/Data/TestData.json", "apply")));
            wait.Until(Driver => Driver.FindElement(By.XPath("//*[@id='com-atlassian-confluence']/div[2]/div[3]/div/div[3]/div[2]/div/div/div[2]/footer/div/div[2]/button/span/span")));
            po.apply.Click();
            Sleep(2);
        }

        [When(@"I choose the permission for this scenario")]
        public void WhenIChooseThePermissionForThisScenario()
        {
            po.restrictionstf.Click();
            Actions action = new Actions(Driver);
            Actions hover = action.MoveToElement(po.restrictionstxt1).Click().SendKeys(Keys.ArrowUp + Keys.Enter);
            hover.Build().Perform();
        }

        [When(@"I choose the user for this scenario")]
        public void WhenIChooseTheUserForThisScenario()
        {
            Sleep(2);
            Actions action = new Actions(Driver);
            Actions select = action.MoveToElement(po.usergroup).MoveToElement(Driver.FindElement(By.XPath("//*[@id='com-atlassian-confluence']/div[2]/div[3]/div/div[3]/div[2]/div/div/div[1]/div/div/div[2]/div/div/div[1]/div/div/div/div[1]"))).Click();
            select.Build().Perform();
            Actions keypress = action.MoveToElement(po.usergroup).SendKeys(Keys.Enter + Keys.Tab + Keys.Enter);
            keypress.Build().Perform();
            Sleep(2);
            po.apply.Click();
        }

        [When(@"I choose the user")]
        public void WhenIChooseTheUser()
        {

            wait.Until(Driver => Driver.FindElement(By.XPath("//*[@id='com-atlassian-confluence']/div[2]/div[3]/div/div[3]/div[2]/div/div/div[1]/div/div/div[2]/div/div/div[1]/div/div/div/div[1]")));
            Actions action = new Actions(Driver);
            Actions select = action.MoveToElement(po.usergroup).MoveToElement(Driver.FindElement(By.XPath("//*[@id='com-atlassian-confluence']/div[2]/div[3]/div/div[3]/div[2]/div/div/div[1]/div/div/div[2]/div/div/div[1]/div/div/div/div[1]"))).Click();
            select.Build().Perform();
            Actions keypress = action.MoveToElement(po.usergroup).SendKeys(Keys.Enter + Keys.Tab + Keys.Tab + Keys.Enter);
            keypress.Build().Perform();
        }

        [When(@"click on edit")]
        public void WhenClickOnEdit()
        {
            Actions action = new Actions(Driver);
            Actions select = action.MoveToElement(po.usergroup).MoveToElement(Driver.FindElement(By.XPath("//*[@id='com-atlassian-confluence']/div[2]/div[3]/div/div[3]/div[2]/div/div/div[1]/div/div/div[2]/div/div/div[1]/div/div/div/div[1]"))).Click();
            select.Build().Perform();
            Actions keypress = action.MoveToElement(po.usergroup).SendKeys(Keys.Tab + Keys.Tab + Keys.ArrowDown + Keys.ArrowUp + Keys.Enter);
            keypress.Build().Perform();
            po.apply.Click();
        }


        [When(@"I choose the permission to a specific user")]
        public void WhenIChooseThePermissionToASpecificUser()
        {
            wait.Until(Driver => Driver.FindElement(By.CssSelector("div.css-11e7u0k.e1er2gfe2")));
            Actions action = new Actions(Driver);
            Actions hover = action.MoveToElement(po.restrictionstxt1).Click().SendKeys(Keys.ArrowDown + Keys.Enter);
            hover.Build().Perform();
        }

        [When(@"I am able to add the user")]
        [Then(@"I am able to add the user")]
        public void ThenIAmAbleToAddTheUser()
        {
            Sleep(2);
            po.restrictionsmenu.Click();
            po.restrictionstxt.Click();
        }

        [When(@"I click the cancel button")]
        public void WhenIClickTheCancelButton()
        {
            Assert.IsTrue(po.cancelbtn.GetAttribute("innerHTML").Contains(read.jsonReader("../PersonalDevelopment/Data/TestData.json", "cancel")));
            po.cancelbtn.Click();
        }

        [When(@"I click on the remove button")]
        public void WhenIClickOnTheRemoveButton()
        {
            Assert.IsTrue(po.remove.GetAttribute("innerHTML").Contains(read.jsonReader("../PersonalDevelopment/Data/TestData.json", "remove")));
            po.remove.Click();
            po.apply.Click();
        }

        [Then(@"the user is removed")]
        public void ThenTheUserIsRemoved()
        {
            Sleep(2);
            po.restrictionsmenu.Click();
            po.restrictionstxt.Click();
        }


    }
}
