using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Loterias
{
    public static class Consts
    {
                                                       
        public const string URL_BASE_LOTERIA_CAIXA = @"http://www1.caixa.gov.br/loterias/loterias";

        public const string URL_BASE_LOTERIA_CAIXA_HTTPS = @"https://www1.caixa.gov.br/loterias/loterias";

        public static readonly string URL_ULTIMO_CONCURSO = string.Concat(URL_BASE_LOTERIA_CAIXA_HTTPS, "/{0}/{1}_pesquisa_new.asp");

        public static readonly string URL_POR_CONCURSO = string.Concat(URL_BASE_LOTERIA_CAIXA_HTTPS, "/{0}/{1}_pesquisa_new.asp?submeteu=sim&opcao=concurso&txtConcurso={2}");
    }
}
