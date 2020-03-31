using Daycoval.Selenium.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Globalization;
using System.Threading;

namespace Dayconnect.Cenarios.Web.Models
{
    public class AplicacaoModel
    {
        public AplicacaoModel()
        {
            PageFactory.InitElements(SeleniumProperties.Driver, this);
        }

        [FindsBy(How = How.Id, Using = "ctl00_cphPrincipal_txtValor")]
        public IWebElement Valor { get; set; }
        [FindsBy(How = How.Id, Using = "ctl00_cphPrincipal_txtDataAgendamento")]
        public IWebElement DataAgendamento { get; set; }
        [FindsBy(How = How.Id, Using = "ctl00_cphPrincipal_btnSolicitar")]
        public IWebElement BotaoSolicitar { get; set; }
        [FindsBy(How = How.Id, Using = "ctl00$cphPrincipal$btnVoltar")]
        public IWebElement BotaoVoltar { get; set; }  

        public void CriarAgendamentoAplicacao(string valor, string data)
        {
            Valor.SendKeys(valor);

            Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");
            DataAgendamento.SendKeys(data);
        }

        public void Solicitar()
        {
            IJavaScriptExecutor executor = (IJavaScriptExecutor)SeleniumProperties.Driver;
            executor.ExecuteScript("arguments[0].click();", BotaoSolicitar);
        }

        public void Voltar()
        {
            IJavaScriptExecutor executor = (IJavaScriptExecutor)SeleniumProperties.Driver;
            executor.ExecuteScript("arguments[0].click();", BotaoVoltar);
        }


    }
}
