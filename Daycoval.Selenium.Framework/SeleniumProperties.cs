using OpenQA.Selenium;

namespace Daycoval.Selenium.Framework
{
    public enum TipoPropriedade
    {
        Id,
        Name,
        LinkText,
        CssName,
        ClassName
    }
    
    public class SeleniumProperties
    {
        public static IWebDriver Driver { get; set; }
    }
}
