namespace Loterias
{
    partial class LoteriasCaixa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblConcurso = new System.Windows.Forms.Label();
            this.nudConcurso = new System.Windows.Forms.NumericUpDown();
            this.lblServidor = new System.Windows.Forms.Label();
            this.txtServidor = new System.Windows.Forms.TextBox();
            this.chkProxy = new System.Windows.Forms.CheckBox();
            this.txtPorta = new System.Windows.Forms.TextBox();
            this.lblPorta = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.lblLogin = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.btnUltimoLotofacil = new System.Windows.Forms.Button();
            this.rtbRetorno = new System.Windows.Forms.RichTextBox();
            this.cmbLoteria = new System.Windows.Forms.ComboBox();
            this.lblTipoLoteria = new System.Windows.Forms.Label();
            this.txtListaNumeros = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCarregarJogos = new System.Windows.Forms.Button();
            this.btnConcursoAnterior = new System.Windows.Forms.Button();
            this.btnConcursoPosterior = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudConcurso)).BeginInit();
            this.SuspendLayout();
            // 
            // lblConcurso
            // 
            this.lblConcurso.AutoSize = true;
            this.lblConcurso.Location = new System.Drawing.Point(249, 74);
            this.lblConcurso.Name = "lblConcurso";
            this.lblConcurso.Size = new System.Drawing.Size(78, 13);
            this.lblConcurso.TabIndex = 1;
            this.lblConcurso.Text = "Concurso atual";
            // 
            // nudConcurso
            // 
            this.nudConcurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudConcurso.Location = new System.Drawing.Point(252, 87);
            this.nudConcurso.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.nudConcurso.Name = "nudConcurso";
            this.nudConcurso.Size = new System.Drawing.Size(96, 29);
            this.nudConcurso.TabIndex = 5;
            // 
            // lblServidor
            // 
            this.lblServidor.AutoSize = true;
            this.lblServidor.Location = new System.Drawing.Point(97, 16);
            this.lblServidor.Name = "lblServidor";
            this.lblServidor.Size = new System.Drawing.Size(46, 13);
            this.lblServidor.TabIndex = 3;
            this.lblServidor.Text = "Servidor";
            // 
            // txtServidor
            // 
            this.txtServidor.Location = new System.Drawing.Point(149, 12);
            this.txtServidor.Name = "txtServidor";
            this.txtServidor.Size = new System.Drawing.Size(128, 20);
            this.txtServidor.TabIndex = 1;
            this.txtServidor.Text = "proxy.sondait.com.br";
            // 
            // chkProxy
            // 
            this.chkProxy.AutoSize = true;
            this.chkProxy.Checked = true;
            this.chkProxy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkProxy.Location = new System.Drawing.Point(15, 14);
            this.chkProxy.Name = "chkProxy";
            this.chkProxy.Size = new System.Drawing.Size(76, 17);
            this.chkProxy.TabIndex = 0;
            this.chkProxy.Text = "Usar proxy";
            this.chkProxy.UseVisualStyleBackColor = true;
            this.chkProxy.CheckedChanged += new System.EventHandler(this.chkProxy_CheckedChanged);
            // 
            // txtPorta
            // 
            this.txtPorta.Location = new System.Drawing.Point(322, 12);
            this.txtPorta.Name = "txtPorta";
            this.txtPorta.Size = new System.Drawing.Size(56, 20);
            this.txtPorta.TabIndex = 2;
            this.txtPorta.Text = "3128";
            // 
            // lblPorta
            // 
            this.lblPorta.AutoSize = true;
            this.lblPorta.Location = new System.Drawing.Point(284, 16);
            this.lblPorta.Name = "lblPorta";
            this.lblPorta.Size = new System.Drawing.Size(32, 13);
            this.lblPorta.TabIndex = 6;
            this.lblPorta.Text = "Porta";
            // 
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(422, 12);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(100, 20);
            this.txtLogin.TabIndex = 3;
            // 
            // lblLogin
            // 
            this.lblLogin.AutoSize = true;
            this.lblLogin.Location = new System.Drawing.Point(383, 16);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(33, 13);
            this.lblLogin.TabIndex = 8;
            this.lblLogin.Text = "Login";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(569, 12);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '*';
            this.txtSenha.Size = new System.Drawing.Size(100, 20);
            this.txtSenha.TabIndex = 4;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(530, 16);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(38, 13);
            this.lblSenha.TabIndex = 10;
            this.lblSenha.Text = "Senha";
            // 
            // btnUltimoLotofacil
            // 
            this.btnUltimoLotofacil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimoLotofacil.Location = new System.Drawing.Point(407, 87);
            this.btnUltimoLotofacil.Name = "btnUltimoLotofacil";
            this.btnUltimoLotofacil.Size = new System.Drawing.Size(131, 31);
            this.btnUltimoLotofacil.TabIndex = 11;
            this.btnUltimoLotofacil.Text = "Buscar último";
            this.btnUltimoLotofacil.UseVisualStyleBackColor = true;
            this.btnUltimoLotofacil.Click += new System.EventHandler(this.btnUltimoLotofacil_Click);
            // 
            // rtbRetorno
            // 
            this.rtbRetorno.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbRetorno.Location = new System.Drawing.Point(15, 284);
            this.rtbRetorno.Name = "rtbRetorno";
            this.rtbRetorno.Size = new System.Drawing.Size(654, 169);
            this.rtbRetorno.TabIndex = 13;
            this.rtbRetorno.Text = "";
            // 
            // cmbLoteria
            // 
            this.cmbLoteria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbLoteria.FormattingEnabled = true;
            this.cmbLoteria.Items.AddRange(new object[] {
            "MEGA-SENA",
            "FEDERAL",
            "LOTECA",
            "LOTOFÁCIL",
            "LOTOGOL",
            "LOTOMANIA",
            "QUINA",
            "TIMEMANIA",
            "DUPLA SENA",
            "INSTANTÂNEA"});
            this.cmbLoteria.Location = new System.Drawing.Point(15, 87);
            this.cmbLoteria.Name = "cmbLoteria";
            this.cmbLoteria.Size = new System.Drawing.Size(181, 32);
            this.cmbLoteria.TabIndex = 14;
            this.cmbLoteria.Text = "LOTOFÁCIL";
            this.cmbLoteria.SelectedIndexChanged += new System.EventHandler(this.cmbLoteria_SelectedIndexChanged);
            // 
            // lblTipoLoteria
            // 
            this.lblTipoLoteria.AutoSize = true;
            this.lblTipoLoteria.Location = new System.Drawing.Point(12, 71);
            this.lblTipoLoteria.Name = "lblTipoLoteria";
            this.lblTipoLoteria.Size = new System.Drawing.Size(39, 13);
            this.lblTipoLoteria.TabIndex = 15;
            this.lblTipoLoteria.Text = "Loteria";
            // 
            // txtListaNumeros
            // 
            this.txtListaNumeros.Location = new System.Drawing.Point(15, 151);
            this.txtListaNumeros.Multiline = true;
            this.txtListaNumeros.Name = "txtListaNumeros";
            this.txtListaNumeros.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtListaNumeros.Size = new System.Drawing.Size(523, 93);
            this.txtListaNumeros.TabIndex = 16;
            this.txtListaNumeros.WordWrap = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Meus jogos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 268);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Resultado";
            // 
            // btnCarregarJogos
            // 
            this.btnCarregarJogos.Location = new System.Drawing.Point(543, 223);
            this.btnCarregarJogos.Name = "btnCarregarJogos";
            this.btnCarregarJogos.Size = new System.Drawing.Size(25, 21);
            this.btnCarregarJogos.TabIndex = 19;
            this.btnCarregarJogos.Text = "...";
            this.btnCarregarJogos.UseVisualStyleBackColor = true;
            this.btnCarregarJogos.Click += new System.EventHandler(this.btnCarregarJogos_Click);
            // 
            // btnConcursoAnterior
            // 
            this.btnConcursoAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConcursoAnterior.Location = new System.Drawing.Point(210, 86);
            this.btnConcursoAnterior.Name = "btnConcursoAnterior";
            this.btnConcursoAnterior.Size = new System.Drawing.Size(36, 32);
            this.btnConcursoAnterior.TabIndex = 20;
            this.btnConcursoAnterior.Text = "<";
            this.btnConcursoAnterior.UseVisualStyleBackColor = true;
            this.btnConcursoAnterior.Click += new System.EventHandler(this.btnConcursoAnterior_Click);
            // 
            // btnConcursoPosterior
            // 
            this.btnConcursoPosterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConcursoPosterior.Location = new System.Drawing.Point(354, 87);
            this.btnConcursoPosterior.Name = "btnConcursoPosterior";
            this.btnConcursoPosterior.Size = new System.Drawing.Size(36, 32);
            this.btnConcursoPosterior.TabIndex = 21;
            this.btnConcursoPosterior.Text = ">";
            this.btnConcursoPosterior.UseVisualStyleBackColor = true;
            this.btnConcursoPosterior.Click += new System.EventHandler(this.btnConcursoPosterior_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(252, 116);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(96, 20);
            this.btnBuscar.TabIndex = 22;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // LoteriasCaixa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 465);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnConcursoPosterior);
            this.Controls.Add(this.btnConcursoAnterior);
            this.Controls.Add(this.btnCarregarJogos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtListaNumeros);
            this.Controls.Add(this.lblTipoLoteria);
            this.Controls.Add(this.cmbLoteria);
            this.Controls.Add(this.rtbRetorno);
            this.Controls.Add(this.btnUltimoLotofacil);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.txtPorta);
            this.Controls.Add(this.lblPorta);
            this.Controls.Add(this.chkProxy);
            this.Controls.Add(this.txtServidor);
            this.Controls.Add(this.lblServidor);
            this.Controls.Add(this.nudConcurso);
            this.Controls.Add(this.lblConcurso);
            this.Name = "LoteriasCaixa";
            this.Text = "Resultados loteria";
            ((System.ComponentModel.ISupportInitialize)(this.nudConcurso)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblConcurso;
        private System.Windows.Forms.NumericUpDown nudConcurso;
        private System.Windows.Forms.Label lblServidor;
        private System.Windows.Forms.TextBox txtServidor;
        private System.Windows.Forms.CheckBox chkProxy;
        private System.Windows.Forms.TextBox txtPorta;
        private System.Windows.Forms.Label lblPorta;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Button btnUltimoLotofacil;
        private System.Windows.Forms.RichTextBox rtbRetorno;
        private System.Windows.Forms.ComboBox cmbLoteria;
        private System.Windows.Forms.Label lblTipoLoteria;
        private System.Windows.Forms.TextBox txtListaNumeros;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCarregarJogos;
        private System.Windows.Forms.Button btnConcursoAnterior;
        private System.Windows.Forms.Button btnConcursoPosterior;
        private System.Windows.Forms.Button btnBuscar;
    }
}

