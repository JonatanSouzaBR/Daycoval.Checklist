using Daycoval.Selenium.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Dayconnect.Cenarios.Web.Models.Base
{
    public abstract class SenhaBase
    {
        public LeitorImagens _leitor;

        public abstract IWebElement BotaoSenha1 { get; set; }
        public abstract IWebElement BotaoSenha2 { get; set; }
        public abstract IWebElement BotaoSenha3 { get; set; }
        public abstract IWebElement BotaoSenha4 { get; set; }
        public abstract IWebElement BotaoSenha5 { get; set; }
        public abstract IWebElement BotaoEnviar { get; set; }
        public abstract IWebElement BotaoLimpar { get; set; }

        public void PreencherSenha(string senha)
        {
            TimeSpan timeout = new TimeSpan(0, 5, 0);
            WebDriverWait wait = new WebDriverWait(SeleniumProperties.Driver, timeout);

            wait.Until(ExpectedConditions.ElementToBeClickable(BotaoSenha1));

            SalvarImagensBotoes();
            _leitor.lerImagensBotoesSenha();

            var ordem = _leitor.retornarOrdemBotoesSenha(senha);
            ordem.ForEach(x =>
            {
                wait.Until(ExpectedConditions.ElementToBeClickable(BotaoSenha1));
                ClicarBotoesSenha(x);
            });
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
            BotaoEnviar.Click();
        }

        public void LimparSenha()
        {
            BotaoLimpar.Click();
        }
    }
}
