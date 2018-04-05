using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using WebConnections.Core;
using WebConnections.Core.Common;

namespace Loterias.Loteria
{
    public class BaseLoteria : BaseWebConnection
    {
        public int? Concurso { get; set; }

        public int? ConcursoLocalizado { get { return _concursoLocalizado == null ? GetConcursoLocalizado() : _concursoLocalizado; } }
        private int? _concursoLocalizado;

        public HtmlAgilityPack.HtmlDocument ResultDocument { get; private set; }

        public List<string> ArrayNumerosSorteados { get; set; }

        public List<string> JogosParaConferencia { get; set; }

        public List<string> AcertosComputados { get; private set; }

        public string NumerosSorteados
        {
            get
            {
                var num = string.Empty;
                if (ArrayNumerosSorteados == null || ArrayNumerosSorteados.Count == 0)
                    return string.Empty;
                else
                    ArrayNumerosSorteados.ForEach(sorteado =>
                    {
                        if (string.IsNullOrEmpty(num))
                            num = sorteado;
                        else
                            num = string.Concat(num, "-", sorteado);
                    });
                return num;
            }
        }

        public virtual int PontuacaoMaxima { get { return 0; } }

        public BaseLoteria()
        {
            Init();
        }

        public BaseLoteria(int? concurso = null)
            : base()
        {
            Init(concurso);
        }

        private void Init(int? concurso = null)
        {
            Concurso = concurso;
            _concursoLocalizado = null;
            ResultDocument = null;
            ArrayNumerosSorteados = new List<string>();
            JogosParaConferencia = new List<string>();
            AcertosComputados = new List<string>();
            this.ReturnResponseServerData += new ReturnConnection(RetornoConcurso);
        }

        #region Configurar informações básicas pra chamada das API, URI

        public override string URLBase
        {
            get
            {
                if (Concurso.HasValue && Concurso.Value > 0)
                    return string.Format(Consts.URL_POR_CONCURSO, this.ToString(), this.ToString(), Concurso.Value);
                else
                    return string.Format(Consts.URL_ULTIMO_CONCURSO, this.ToString(), this.ToString());
            }
        }

        public override string UserAgent
        {
            get
            {
                return "Mozilla/5.0 (Windows NT 10.0; WOW64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/43.0.2357.81 Safari/537.36";
            }
        }

        public override string Accept
        {
            get
            {
                return "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,*/*;q=0.8";
            }
        }
        public override bool KeepAlive
        {
            get
            {
                return true;
            }
        }

        public override string RequestMethods
        {
            get
            {
                return "Get";
            }
        }

        public override string Host
        {
            get
            {
                return "www1.caixa.gov.br";
            }
        }
        

        public override System.Net.WebHeaderCollection Header
        {
            get
            {
                var h = new System.Net.WebHeaderCollection();
                h[HttpRequestHeader.AcceptEncoding] = "gzip, deflate, sdch";
                h[HttpRequestHeader.AcceptLanguage] = "en-US,en;q=0.8,pt-BR;q=0.6,pt;q=0.4,es;q=0.2";
                h[HttpRequestHeader.Cookie] = "security=true";                
                //h["Proxy-Connection"] = "keep-alive";
                return h;
            }
        }

        #endregion Configurar informações básicas pra chamada das API, URI

        private void RetornoConcurso(BaseConnection connection, string context)
        {
            if (string.IsNullOrEmpty(context) || string.IsNullOrWhiteSpace(context))
                return;

            if (context.ToUpper().Contains("NÃO EXISTE RESUL"))
                throw new Exception("NÃO EXISTE RESULTADO");

            //context = string.Concat("<html><body>", context, "</body></html>");
            var byteArray = Encoding.UTF8.GetBytes(context);
            using (var stream = new MemoryStream(byteArray))
            {
                ResultDocument = new HtmlAgilityPack.HtmlDocument();
                ResultDocument.Load(stream);

                GetConcursoLocalizado();

                FetchNumerosSorteados();

                ContarAcertos();
            }
        }

        public virtual int? GetConcursoLocalizado()
        {
            _concursoLocalizado = null;
            if (ResultDocument != null)
            {
                var desc = ResultDocument.DocumentNode.Descendants();
                if (desc != null)
                {
                    var ret = desc.FirstOrDefault(d => d.Name == "#text");
                    if (ret != null)
                    {
                        var nrConc = ret.InnerText.Substring(0, ret.InnerText.IndexOf('|')).Replace("|", "").Trim();
                        int retNrConc = 0;
                        int.TryParse(nrConc, out retNrConc);
                        _concursoLocalizado = retNrConc;
                    }
                }
            }
            return _concursoLocalizado;
        }

        public virtual void AdicionarNumeroSorteado(List<string> sorteados)
        {
            sorteados.ToList().ForEach(sorteado =>
            {
                if (!string.IsNullOrEmpty(sorteado) && !string.IsNullOrWhiteSpace(sorteado) && !ArrayNumerosSorteados.Contains(sorteado))
                    ArrayNumerosSorteados.Add(sorteado);
            });
        }

        public virtual void FetchNumerosSorteados()
        {
            throw new NotImplementedException();
        }

        public virtual void ContarAcertos()
        {
            ContarAcertos(JogosParaConferencia);
        }

        public virtual List<string> ContarAcertos(List<string> jogosComparar)
        {
            AcertosComputados = new List<string>();

            if (jogosComparar != null)
                foreach (string linha in jogosComparar)
                {
                    string[] seqNumeros = linha.Split('-');
                    int contAcerto = 0;
                    foreach (string numero in seqNumeros)
                        if (ArrayNumerosSorteados.Contains(numero.Trim().PadLeft(2, '0')))
                            contAcerto++;
                    AcertosComputados.Add(string.Concat(linha.Trim(), " - Acertos: ", contAcerto));
                }

            return AcertosComputados;
        }
    }
}
