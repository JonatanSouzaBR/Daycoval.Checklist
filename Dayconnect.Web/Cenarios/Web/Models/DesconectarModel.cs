using Daycoval.Selenium.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dayconnect.Cenarios.Web.Models
{
    public class DesconectarModel
    {
        public DesconectarModel()
        {
            PageFactory.InitElements(SeleniumProperties.Driver, this);
        }

        [FindsBy(How = How.Id, Using = "ctl00_cphPrincipal_btnSair")]
        private IWebElement BotaoSim { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_cphPrincipal_btnCancelar")]
        private IWebElement BotaoNao { get; set; }
    
        
        public void Desconectar()
        {
            BotaoSim.Click();
        }

        public void NaoDesconectar()
        {
            BotaoNao.Click();
        }
    }
}
