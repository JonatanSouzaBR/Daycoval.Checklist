using Dayconnect.Cenarios.Web.Models.Base;
using Daycoval.Selenium.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace Dayconnect.Cenarios.Web.Models.Investimento.RendaFixa
{
    public class ConfirmacaoModel : SenhaBase
    {

        public ConfirmacaoModel()
        {
            PageFactory.InitElements(SeleniumProperties.Driver, this);
            _leitor = new LeitorImagens();
        }


        [FindsBy(How = How.Id, Using = "ctl00_cphPrincipal_codigoSeguranca_CodigoSeguranca1_btnKey_1")]
        public override  IWebElement BotaoSenha1 { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_cphPrincipal_codigoSeguranca_CodigoSeguranca1_btnKey_2")]
        public override  IWebElement BotaoSenha2 { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_cphPrincipal_codigoSeguranca_CodigoSeguranca1_btnKey_3")]
        public override  IWebElement BotaoSenha3 { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_cphPrincipal_codigoSeguranca_CodigoSeguranca1_btnKey_4")]
        public override  IWebElement BotaoSenha4 { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_cphPrincipal_codigoSeguranca_CodigoSeguranca1_btnKey_5")]
        public override  IWebElement BotaoSenha5 { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_cphPrincipal_codigoSeguranca_CodigoSeguranca1_btnEnviar")]
        public override  IWebElement BotaoEnviar { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_cphPrincipal_codigoSeguranca_CodigoSeguranca1_btnLimpar")]
        public override  IWebElement BotaoLimpar { get; set; } 
        [FindsBy(How = How.Id, Using = "ctl00_cphPrincipal_btnVoltar")]
        public  IWebElement BotaoVoltar { get; set; }

      
        public void Voltar()
        {
            BotaoVoltar.Click();
        }
    }
}
