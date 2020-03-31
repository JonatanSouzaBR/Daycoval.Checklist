using Daycoval.Selenium.Framework.Parametros;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Tesseract;

namespace Daycoval.Selenium.Framework
{
    public class LeitorImagens
    {
        Dictionary<int, string> btnSenhaDicitionary = new Dictionary<int, string>();
        private static TesseractEngine engine = new TesseractEngine(@"./tessdata", "por", EngineMode.Default);

        public LeitorImagens(){}

        public void lerImagensBotoesSenha()
        {
            var ImagePath = new StringBuilder();
            for (int imageCount = 1; imageCount < 6; imageCount++)
            {
                ImagePath.Clear();
                ImagePath.AppendFormat("{0}/", Sistema.DirImagens);
                ImagePath.AppendFormat(Sistema.NomeAqruivoBotao, imageCount);

                using (var img = Pix.LoadFromFile(ImagePath.ToString()))
                {
                    using (var page = engine.Process(img))
                    {
                        var imageText = page.GetText();

                        var numerosBotao = imageText.Substring(0, 3) + ", " + imageText.Substring(5, 1);

                        btnSenhaDicitionary.Add(imageCount, numerosBotao);
                    }
                }
            }
        }

        public List<int> retornarOrdemBotoesSenha(string senha)
        {
            List<int> ordemBotoes = new List<int>();

            for (int posicao = 0; posicao < senha.Length; posicao++)
            {
                ordemBotoes.Add(btnSenhaDicitionary.FirstOrDefault(x => x.Value.Contains(senha[posicao])).Key);
            }

            return ordemBotoes;
        }
    }
}
