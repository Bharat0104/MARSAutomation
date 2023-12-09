using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marsh_Project.Pages
{
    public class LoginPage
    {

        public LoginPage()
        
        {
            // Open the browser
            IWebDriver driver = new ChromeDriver();
            object value = driver.Manage().Window.Maximize();

            // Lanch Marsh Project url navigate to login 
            driver.Navigate().GoToUrl("/http://localhost:5000/Account/Profile");

            //http://localhost:5000/Account/Profile//

            // Identify the username textbox and enter valid username
            IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
            usernameTextbox.SendKeys("bharatpatel@gmail.com");

            // Identify the password textbox and enter valid password
            IWebElement passwordTextbox = driver.FindElement(By.Id("password"));
            usernameTextbox.SendKeys("pramukh2530");

            // Identify login button and click on the button
            IWebElement loginButton = driver.FindElement(By.XPath(" /html/body/div[2]/div/div/div[1]/div/div[1]/input"));
            loginButton.Click();

            //Check if user is login sucessfully
            IWebElement Bharat = driver.FindElement(By.XPath(""));
            //if (helloBharat.Text == Hello "Bharat")

              //{
                //Console.WritenLine("User loggin successfully");
              //}

           // else

            //{
                Console.WritenLine("User has not been logged in");
            //}
        }
    }
}
