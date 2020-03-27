using Daycoval.Selenium.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Dayconnect.Cenarios.Web.Models
{
    public class LoginModalErroModel
    {
        public LoginModalErroModel()
        {
            PageFactory.InitElements(SeleniumProperties.Driver, this);
        }

        [FindsBy(How = How.Id, Using = "dayMensagensBody")]
        public IWebElement ModalErro { get; set; }


        public string RetornarMensageErro()
        {
            var text = ModalErro.Text;
            return text;
        }

    }
}
