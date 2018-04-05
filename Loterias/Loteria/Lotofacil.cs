using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using WebConnections.Core;

namespace Loterias.Loteria
{
    public class Lotofacil : BaseLoteria
    {
        public override int PontuacaoMaxima
        {
            get { return 15; }
        }

        public override string ToString()
        {
            return "lotofacil";
        }

        public Lotofacil()
            : base()
        { }

        public Lotofacil(int? concurso = null)
            : base(concurso)
        {
        }

        public override void FetchNumerosSorteados()
        {
            if (ResultDocument != null)
            {
                var desc = ResultDocument.DocumentNode.Descendants();
                if (desc != null)
                {
                    var ret = desc.ToList()[3];
                    if (ret != null && !string.IsNullOrWhiteSpace(ret.InnerText) && !string.IsNullOrEmpty(ret.InnerText))
                    {
                        var sorteados = ret.InnerText.Trim().Split('|');
                        //quando já existir um concurso anterior ou posterior
                        if (sorteados.Count() < PontuacaoMaxima)
                        {
                            ret = desc.ToList()[6];
                            if (ret == null || string.IsNullOrWhiteSpace(ret.InnerText) || string.IsNullOrEmpty(ret.InnerText))
                                return;
                        }

                        sorteados = ret.InnerText.Trim().Split('|');
                        if (sorteados.Length > 0)
                            AdicionarNumeroSorteado(sorteados.Where(s => !string.IsNullOrEmpty(s) && !string.IsNullOrWhiteSpace(s)).Take(PontuacaoMaxima).ToList());
                    }
                }
            }
        }
    }
}
