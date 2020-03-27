using Daycoval.Selenium.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System.Collections.Generic;

namespace Dayconnect.Cenarios.Web.Models
{
    public class LoginSenhaModel
    {
        private readonly LeitorImagens _leitor;

        public LoginSenhaModel()
        {
            PageFactory.InitElements(SeleniumProperties.Driver, this);
            _leitor = new LeitorImagens();
        }

        [FindsBy(How = How.Id, Using = "ctl00_cphLogin_senhaEletronica_CodigoSeguranca1_btnKey_1")]
        private IWebElement BotaoSenha1 { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_cphLogin_senhaEletronica_CodigoSeguranca1_btnKey_2")]
        private IWebElement BotaoSenha2 { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_cphLogin_senhaEletronica_CodigoSeguranca1_btnKey_3")]
        private IWebElement BotaoSenha3 { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_cphLogin_senhaEletronica_CodigoSeguranca1_btnKey_4")]
        private IWebElement BotaoSenha4 { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_cphLogin_senhaEletronica_CodigoSeguranca1_btnKey_5")]
        private IWebElement BotaoSenha5 { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_cphLogin_senhaEletronica_CodigoSeguranca1_btnEnviar")]
        private IWebElement BotaoLogin { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_cphLogin_senhaEletronica_CodigoSeguranca1_btnLimpar")]
        private IWebElement BotaoLimpar { get; set; }

        public void PreencherSenha(string senha)
        {
            SalvarImagensBotoes();
            _leitor.lerImagensBotoesSenha();
            var ordem = _leitor.retornarOrdemBotoesSenha(senha);
            ordem.ForEach(x => ClicarBotoesSenha(x));
            EnviarSenha();
        }

        private void SalvarImagensBotoes()
        {
            BotaoSenha1.SalvarImagemBotao(nameof(BotaoSenha1));
            BotaoSenha2.SalvarImagemBotao(nameof(BotaoSenha2));
            BotaoSenha3.SalvarImagemBotao(nameof(BotaoSenha3));
            BotaoSenha4.SalvarImagemBotao(nameof(BotaoSenha4));
            BotaoSenha5.SalvarImagemBotao(nameof(BotaoSenha5));
        }

        private void ClicarBotoesSenha(int numeroBotao)
        {
            switch (numeroBotao)
            {
                case 1:
                    BotaoSenha1.Click();
                    break;
                case 2:
                    BotaoSenha2.Click();
                    break;
                case 3:
                    BotaoSenha3.Click();
                    break;
                case 4:
                    BotaoSenha4.Click();
                    break;
                case 5:
                    BotaoSenha5.Click();
                    break;
            }
        }

        public void EnviarSenha()
        {
            BotaoLogin.Click();
        }

        public void LimparSenha()
        {
            BotaoLimpar.Click();
        }

    }
}
