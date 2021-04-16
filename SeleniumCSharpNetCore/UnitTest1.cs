using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;

namespace SeleniumCSharpNetCore
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Setup");
        }

        [Test]
        public void Test1()
        {
            var driver = new FirefoxDriver();
            driver.Navigate().GoToUrl("https://demowf.aspnetawesome.com");
            Console.WriteLine("Test1");
            Assert.Pass();
        }
    }
}