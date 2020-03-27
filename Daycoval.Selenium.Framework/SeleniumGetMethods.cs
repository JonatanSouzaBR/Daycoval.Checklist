using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Daycoval.Selenium.Framework
{
    public class SeleniumGetMethods
    {
        public static string ObterTexto(IWebElement elemento)
        {
            return elemento.GetAttribute("Value");
        }

        public static string ObterTextoDeUmDropBox(IWebElement elemento)
        {
            return new SelectElement(elemento).AllSelectedOptions.SingleOrDefault().Text;
        }
    }
}
