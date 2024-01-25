using System.Collections.Generic;
using System.Linq;

using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;

namespace Bumblebee.Extensions
{
	public static class WebElementConvenience
	{
		public static IWebDriver GetDriver(this IWebElement element)
		{
			return ((IWrapsDriver) element).WrappedDriver;
		}

		public static string GetId(this IWebElement element)
		{
			return element.GetAttribute("id");
		}

		public static IEnumerable<string> GetClasses(this IWebElement element)
		{
			return element.GetAttribute("class").Split(' ');
		}

		public static bool HasClass(this IWebElement element, string className)
		{
			return element.GetClasses().Any(@class => @class.Equals(className));
		}

		public static void SetAttribute(this IWebElement element, string attribute, string value)
		{
			element.GetDriver().ExecuteJavaScript<object>("arguments[0].setAttribute(arguments[1], arguments[2])", element, attribute, value);
		}
	}
}
