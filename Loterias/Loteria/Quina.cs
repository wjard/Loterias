using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loterias.Loteria
{
    public class Quina: BaseLoteria
    {
        public override int PontuacaoMaxima
        {
            get
            {
                return 5;
            }
        }

        public override string ToString()
        {
            return "quina";
        }

        public Quina()
            : base()
        { }

        public Quina(int? concurso = null)
            :base(concurso)
        {
        }

        public override void FetchNumerosSorteados()
        {
            if (ResultDocument != null)
            {
                var desc = ResultDocument.DocumentNode.Descendants();

                var listNumSort = ResultDocument.DocumentNode.SelectNodes("//*[@id='sorteio1']");
                if (listNumSort != null && listNumSort.Count > 0 && listNumSort.LastOrDefault().Descendants("ul") != null)
                {
                    foreach (var ul in listNumSort.LastOrDefault().Descendants("ul"))
                    {
                        var li = ul.Descendants("li");
                        if (li != null)
                            AdicionarNumeroSorteado(li.Select(a => a.InnerText).ToList());
                    }
                }
            }
        }
    }
}
