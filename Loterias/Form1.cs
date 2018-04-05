using HtmlAgilityPack;
using Loterias.Loteria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WebConnections.Core;
using WebConnections.Core.Common;
using WebConnections.Core.Entity;

namespace Loterias
{
    public partial class LoteriasCaixa : Form
    {
        public LoteriasCaixa()
        {
            InitializeComponent();

            //cmbLoteria.Text = "QUINA";

            CarregarJogos();
        }

        private void CarregarJogos()
        {
            var slug = string.Concat(Utils.GetSlug(cmbLoteria.Text), ".txt");
            txtListaNumeros.Clear();
            if (File.Exists(slug))
                using (StreamReader srMeusJogos = new StreamReader(slug))
                    txtListaNumeros.Text = srMeusJogos.ReadToEnd();
        }

        void Suspender()
        {
            this.Cursor = Cursors.WaitCursor;
            rtbRetorno.Clear();
            txtListaNumeros.Enabled = false;
            rtbRetorno.Enabled = false;
            btnUltimoLotofacil.Enabled = false;
            btnConcursoAnterior.Enabled = false;
            btnConcursoPosterior.Enabled = false;
            cmbLoteria.Enabled = false;
            nudConcurso.Enabled = false;
            Application.DoEvents();
        }

        void Resumir()
        {
            txtListaNumeros.Enabled = true;
            rtbRetorno.Enabled = true;
            btnUltimoLotofacil.Enabled = true;
            btnConcursoAnterior.Enabled = true;
            btnConcursoPosterior.Enabled = true;
            cmbLoteria.Enabled = true;
            nudConcurso.Enabled = true;
            this.Cursor = Cursors.Default;
            Application.DoEvents();
        }

        private void chkProxy_CheckedChanged(object sender, EventArgs e)
        {
            lblServidor.Visible = lblPorta.Visible = lblLogin.Visible = lblSenha.Visible = chkProxy.Checked;
            txtServidor.Visible = txtPorta.Visible = txtLogin.Visible = txtSenha.Visible = chkProxy.Checked;
        }

        private void ConfigProxy()
        {
            ICredentials credentials = new NetworkCredential(txtLogin.Text, txtSenha.Text);
            IWebProxy proxy = new WebProxy(txtServidor.Text, Convert.ToInt32(txtPorta.Text));
            proxy.Credentials = credentials;
        }

        private void BuscarLoteria<T>(int? concurso = null) where T : BaseLoteria, new()
        {
            if (chkProxy.Checked)
                ConfigProxy();

            Suspender();
            var loteria = new T();
            loteria.Concurso = concurso;

            char[] charSeparators = new Char[] { '\n' };
            if (!string.IsNullOrEmpty(txtListaNumeros.Text.Trim()))
            {
                string[] linhasNumeros = txtListaNumeros.Text.Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);
                if (linhasNumeros.Length > 0)
                    loteria.JogosParaConferencia = linhasNumeros.ToList();
            }
            loteria.ReturnResponseServerData += new ReturnConnection(RetornoConcurso);
            loteria.ExceptionCalled += loteria_ExceptionCalled;
            loteria.OpenConnection();
        }

        void loteria_ExceptionCalled(object sender, Exception e)
        {
            Action DoUpdateInfo = () =>
            {
                try
                {
                    if (e.Message.Contains("NÃO EXISTE RESULTADO"))
                        MessageBox.Show("O concurso pesquisado não foi localizado :-(", "NÃO TÁ PRONTINHO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show(e.Message, "NÃO TÁ PRONTINHO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    Resumir();
                }
            };
            this.BeginInvoke(DoUpdateInfo);
        }

        void RetornoConcurso(BaseConnection connection, string context)
        {
            Action DoUpdateInfo = () =>
            {
                try
                {
                    var loteria = connection as BaseLoteria;
                    nudConcurso.Value = loteria.ConcursoLocalizado.HasValue ? (int)loteria.ConcursoLocalizado.Value : 0;
                    rtbRetorno.Text += string.Format("Números sorteados{0}{1}{0}{0}", Environment.NewLine, loteria.NumerosSorteados);
                    loteria.AcertosComputados.ForEach(a => rtbRetorno.Text += string.Concat(a, Environment.NewLine));
                }
                finally
                {
                    Resumir();
                }
            };

            this.BeginInvoke(DoUpdateInfo);
        }

        private void btnUltimoLotofacil_Click(object sender, EventArgs e)
        {
            TipoLoteria(null);
        }

        private void btnConcursoLotofacil_Click(object sender, EventArgs e)
        {
            TipoLoteria(Convert.ToInt32(nudConcurso.Value));
        }

        private void TipoLoteria(int? value)
        {
            string str = cmbLoteria.Text;

            /*
            MEGA-SENA
            FEDERAL
            LOTECA
            LOTOFÁCIL
            LOTOGOL
            LOTOMANIA
            QUINA
            TIMEMANIA
            DUPLA SENA
            INSTANTÂNEA
            */

            switch (str)
            {
                case "MEGA-SENA":
                    BuscarLoteria<Megasena>(value);
                    break;
                case "FEDERAL":
                    BuscarLoteria<Federal>(value);
                    break;
                case "LOTECA":
                    BuscarLoteria<Loteca>(value);
                    break;
                case "LOTOGOL":
                    BuscarLoteria<Lotogol>(value);
                    break;
                case "LOTOMANIA":
                    BuscarLoteria<Lotomania>(value);
                    break;
                case "QUINA":
                    BuscarLoteria<Quina>(value);
                    break;
                case "TIMEMANIA":
                    BuscarLoteria<Timemania>(value);
                    break;
                case "DUPLA SENA":
                    BuscarLoteria<Duplasena>(value);
                    break;
                case "INSTANTÂNEA":
                    BuscarLoteria<Instantanea>(value);
                    break;
                default:
                    BuscarLoteria<Lotofacil>(value);
                    break;
            }
        }

        private void btnCarregarJogos_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
                using (StreamReader srMeusJogos = new StreamReader(ofd.FileName))
                    txtListaNumeros.Text = srMeusJogos.ReadToEnd();
        }

        private void cmbLoteria_SelectedIndexChanged(object sender, EventArgs e)
        {
            nudConcurso.Value = 0;
            if (cmbLoteria.Text == "MEGA-SENA" || cmbLoteria.Text == "LOTOFÁCIL" || cmbLoteria.Text == "QUINA")
                CarregarJogos();
            else
            {
                MessageBox.Show("SÓ ESTÁ PRONTO.\n\nFunciona apenas para MEGA-SENA, LOTOFÁCIL e QUINA.\n\nDesculpa :-(", "NÃO TÁ PRONTINHO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbLoteria.Text = "LOTOFÁCIL";
                return;
            }
        }

        private void btnConcursoAnterior_Click(object sender, EventArgs e)
        {
            if (nudConcurso.Value > 1)
                --nudConcurso.Value;
            else
                nudConcurso.Value = 1;                
            TipoLoteria(Convert.ToInt32(nudConcurso.Value));
        }

        private void btnConcursoPosterior_Click(object sender, EventArgs e)
        {
            if (nudConcurso.Value <= 0)
                nudConcurso.Value = 1;
            else
                ++nudConcurso.Value;
            TipoLoteria(Convert.ToInt32(nudConcurso.Value));
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            TipoLoteria(Convert.ToInt32(nudConcurso.Value));
        }
    }
}
