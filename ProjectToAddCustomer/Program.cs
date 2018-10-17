using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Interactions;
using System.Threading;
using System.Data;

namespace ProjectToAddCustomer
{
    class Program
    {

        private static string Value;

        static void Main(string[] args)
        {
            DataTable DT = new DataTable();
            DT = ReadingExcelSheet.returingExcelData();
            IWebDriver driver = new InternetExplorerDriver(@"C:\Users\Administrator\Documents\visual studio 2015\Projects\ProjectToAddCustomer\ProjectToAddCustomer\");
            driver.Navigate().GoToUrl("http://automationpractice.com");
            driver.Manage().Window.Maximize();

            IWebElement LoginLink = driver.FindElement(By.CssSelector("[class='login']"));
            IWebElement EmailInput = driver.FindElement(By.Id("email_create"));
            IWebElement CreateNewAccountButton = driver.FindElement(By.Name("SubmitCreate"));
            IWebElement GenderMale = driver.FindElement(By.Id("uniform-id_gender1"));
            IWebElement Password = driver.FindElement(By.Id("passwd"));
            IWebElement DOBDropDown = driver.FindElement(By.Name("days"));
            IWebElement MonthDropDown = driver.FindElement(By.Name("days"));
            IWebElement YearDropDown = driver.FindElement(By.Id("years"));
            IWebElement SignupNewsletter = driver.FindElement(By.Id("uniform-newsletter"));
            IWebElement recieveSpecialOffer = driver.FindElement(By.Id("optin"));
            IWebElement AddressFirstName = driver.FindElement(By.Id("firstname"));
            IWebElement AddressLastName = driver.FindElement(By.Id("lastname"));
            IWebElement CompanyName = driver.FindElement(By.Id("company"));
            IWebElement AddressLine1 = driver.FindElement(By.Id("address1"));
            IWebElement AddressLine2 = driver.FindElement(By.Id("address2"));
            IWebElement City = driver.FindElement(By.Id("city"));
            IWebElement State = driver.FindElement(By.Id("State"));
            IWebElement ZipCode = driver.FindElement(By.Id("postcode"));
            IWebElement Country = driver.FindElement(By.Id("id_country"));
            IWebElement AdditionalInfo = driver.FindElement(By.Id("other"));
            IWebElement Phone = driver.FindElement(By.Id("phone"));
            IWebElement AddressforFuture = driver.FindElement(By.Id("alias"));
            IWebElement GenderFemale = driver.FindElement(By.Id("id_gender2"));

            IWebElement FirstName = driver.FindElement(By.Id("customer_firstname"));
            IWebElement LastName = driver.FindElement(By.Id("customer_lastname"));
            IWebElement Emailvalue = driver.FindElement(By.Id("email"));
            IWebElement SubmitButton = driver.FindElement(By.Id("submitAccount"));





            foreach (DataRow dr in DT.Rows)
            {
                if (dr["LoginLink"].ToString() != null)
                {
                    LoginLink.Click();
                }

                if (dr["EmailInput"].ToString() != null)
                {
                    Value = dr["EmailInput"].ToString();
                    EmailInput.SendKeys(Value);
                }
                if (dr["CreateNewAccountButton"].ToString() != null)
                {
                    CreateNewAccountButton.Click();
                }

                if (dr["GenderMale"].ToString() !=null)
                {
                    GenderMale.Click();
                }
                if(dr["GenderFemale"].ToString()!=null)
                {
                    GenderFemale.Click();
                } 
                if (dr["FirstName"].ToString() != null)
                {
                    Value = dr["FirstName"].ToString();
                    FirstName.SendKeys(Value);
                }

                if (dr["LastName"].ToString() != null)
                {
                    Value = dr["LastName"].ToString();
                    FirstName.SendKeys(Value);
                }
                
                if (dr["Password"].ToString() != null)
                {
                    Value = dr["Password"].ToString();
                    Password.SendKeys(Value);
                }

                if (dr["DOBDropDown"].ToString() != null)
                {
                    Value = dr["DOBDropDown"].ToString();
                    DOBDropDown.SendKeys(Value);
                }

                if (dr["MonthDropDown"].ToString() != null)
                {
                    Value = dr["MonthDropDown"].ToString();
                    MonthDropDown.SendKeys(Value);
                }

                if (dr["YearDropDown"].ToString() != null)
                {
                    Value = dr["YearDropDown"].ToString();
                    MonthDropDown.SendKeys(Value);
                }


                if (dr["SignupNewsletter"].ToString() != null)
                {
                   SignupNewsletter.Click();
                }
                if (dr["recieveSpecialOffer"].ToString() != null)
                {
                    recieveSpecialOffer.Click();
                }
                if (dr["AddressFirstName"].ToString() != null)
                {
                    Value = dr["AddressFirstName"].ToString();
                    AddressFirstName.SendKeys(Value);
                }
                if (dr["AddressLastName"].ToString() != null)
                {
                    Value = dr["AddressLastName"].ToString();
                    AddressLastName.SendKeys(Value);
                }
                if (dr["CompanyName"].ToString() != null)
                {
                    Value = dr["CompanyName"].ToString();
                    CompanyName.SendKeys(Value);
                }
                if (dr["AddressLine1"].ToString() != null)
                {
                    Value = dr["AddressLine1"].ToString();
                    AddressLine1.SendKeys(Value);
                }
                if (dr["AddressLine2"].ToString() != null)
                {
                    Value = dr["AddressLine2"].ToString();
                    AddressLine2.SendKeys(Value);
                }

                if (dr["City"].ToString() != null)
                {
                    Value = dr["City"].ToString();
                    City.SendKeys(Value);
                }
                if (dr["State"].ToString() != null)
                {
                    Value = dr["State"].ToString();
                    MonthDropDown.SendKeys(Value);
                }
                if (dr["ZipCode"].ToString() != null)
                {
                    Value = dr["ZipCode"].ToString();
                    MonthDropDown.SendKeys(Value);
                }
                if (dr["Country"].ToString() != null)
                {
                    Value = dr["Country"].ToString();
                    Country.SendKeys(Value);
                }
                if (dr["AdditionalInfo"].ToString() != null)
                { 
                    Value = dr["AdditionalInfo"].ToString();
                    AdditionalInfo.SendKeys(Value);
                }
                if (dr["Phone"].ToString() != null)
                {
                    Value = dr["Phone"].ToString();
                    Phone.SendKeys(Value);
                }
                if (dr["AddressforFuture"].ToString() != null)
                {
                    Value = dr["AddressforFuture"].ToString();
                    AddressforFuture.SendKeys(Value);
                }

                if (dr["SubmitButton"].ToString() != null)
                {
                    SubmitButton.Click();
                }

                IWebElement RegisteredName = driver.FindElement(By.CssSelector("class='account']");
                if(RegisteredName.Text!=  dr["FirstName"].ToString())
                {
                    Console.WriteLine("Assertion Failed");
                }
                else
                {
                    Console.WriteLine("Assertion passed");
                }
                IWebElement WishList = driver.FindElement(By.CssSelector("[class='lnk_wishlist']"));
                if(WishList.Displayed)
                {
                    Console.WriteLine("Wish List is present");
                }
                else
                {
                    Console.WriteLine("Wish List is not available");
                }

               List<IWebElement> DressSelect = driver.FindElements(By.CssSelector("[title='Printed Dress']")).ToList();
                DressSelect[0].Click();
                IWebElement Elemet= driver.FindElement(By.CssSelector("[name ='Submit']"));
                Elemet.Click();
                IWebElement ContinueShopping = driver.FindElement(By.CssSelector("[title ='Continue shopping']"));
                ContinueShopping.Click();


            }
        }
    }
}
