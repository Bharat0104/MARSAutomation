using OpenQA.Selenium;

internal interface IWebDriver
{
    IWebElement FindElement(By by);
    object Manage();
    object Navigate();
}