using System.Collections.Generic;
using System.Text;
using Tesseract;
using System.Linq;

namespace Daycoval.Selenium.Framework
{
    public class LeitorImagens
    {
        Dictionary<int, string> btnSenhaDicitionary = new Dictionary<int, string>();
        private TesseractEngine engine;

        public LeitorImagens()
        {
            engine = new TesseractEngine(@"./tessdata", "por", EngineMode.Default);
        }

        public void lerImagensBotoesSenha()
        {
            for (int imageCount = 1; imageCount < 6; imageCount++)
            {
                var ImagePath = new StringBuilder();
                ImagePath.AppendFormat("{0}/",Parametros.DirImagens);
                ImagePath.AppendFormat(Parametros.NomeAqruivoBotao, imageCount);

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
