﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace WebAddressbookTests
{
	public class ApplicationManager
	{
		protected IWebDriver driver;
		protected string baseURL;

		protected LoginHelper loginHelper;
		protected NavigationHelper navigationHelper;
		protected GroupHelper groupHelper;
		protected ContactHelper contactHelper;
		

		public ApplicationManager()
		{
			driver = new FirefoxDriver();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            baseURL = "http://localhost/addressbook/";

			loginHelper = new LoginHelper(this);
			navigationHelper = new NavigationHelper(this, baseURL);
			groupHelper = new GroupHelper(this);
			contactHelper = new ContactHelper(this);
		}

		public IWebDriver Driver
		{
			get
			{
				return driver;
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            }
		}


		public void Stop()
		{
			try
			{
				driver.Quit();
			}
			catch (Exception)
			{
				// Ignore errors if unable to close the browser
			}
		}

		public LoginHelper Auth
		{
			get
			{
				return loginHelper;
			}
		}

		public NavigationHelper Navigator
		{
			get
			{
				return navigationHelper;
			}
		}

		public GroupHelper Groups
		{
			get
			{
				return groupHelper;
			}
		}

		public ContactHelper Contacts
		{
			get
			{
				return contactHelper;
			}
		}

	}
}
