using System;

namespace Programa_STPMJ
{
    partial class formPaginaInicial
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formPaginaInicial));
            this.panelEsquerdo = new System.Windows.Forms.Panel();
            this.btnAjuda = new FontAwesome.Sharp.IconButton();
            this.panelDocumentos = new System.Windows.Forms.Panel();
            this.btnCheques = new FontAwesome.Sharp.IconButton();
            this.btnCarteirinha = new FontAwesome.Sharp.IconButton();
            this.btnDocumentos = new FontAwesome.Sharp.IconButton();
            this.btnRelatorios = new FontAwesome.Sharp.IconButton();
            this.btnLancamento = new FontAwesome.Sharp.IconButton();
            this.panelPesquisas = new System.Windows.Forms.Panel();
            this.btnPesquisarEmpresa = new FontAwesome.Sharp.IconButton();
            this.btnPesquisarCliente = new FontAwesome.Sharp.IconButton();
            this.btnPesquisar = new FontAwesome.Sharp.IconButton();
            this.panelCadastros = new System.Windows.Forms.Panel();
            this.btnCadastroEmpresa = new FontAwesome.Sharp.IconButton();
            this.btnCadastroCliente = new FontAwesome.Sharp.IconButton();
            this.btnCadastros = new FontAwesome.Sharp.IconButton();
            this.btnPaginaInicial = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelFormTitulo = new System.Windows.Forms.Panel();
            this.panelFormCentral = new System.Windows.Forms.Panel();
            this.webView21 = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.panelEsquerdo.SuspendLayout();
            this.panelDocumentos.SuspendLayout();
            this.panelPesquisas.SuspendLayout();
            this.panelCadastros.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelFormCentral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).BeginInit();
            this.SuspendLayout();
            // 
            // panelEsquerdo
            // 
            this.panelEsquerdo.AutoScroll = true;
            this.panelEsquerdo.BackColor = System.Drawing.Color.White;
            this.panelEsquerdo.Controls.Add(this.btnAjuda);
            this.panelEsquerdo.Controls.Add(this.panelDocumentos);
            this.panelEsquerdo.Controls.Add(this.btnDocumentos);
            this.panelEsquerdo.Controls.Add(this.btnRelatorios);
            this.panelEsquerdo.Controls.Add(this.btnLancamento);
            this.panelEsquerdo.Controls.Add(this.panelPesquisas);
            this.panelEsquerdo.Controls.Add(this.btnPesquisar);
            this.panelEsquerdo.Controls.Add(this.panelCadastros);
            this.panelEsquerdo.Controls.Add(this.btnCadastros);
            this.panelEsquerdo.Controls.Add(this.btnPaginaInicial);
            this.panelEsquerdo.Controls.Add(this.panelLogo);
            this.panelEsquerdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelEsquerdo.Location = new System.Drawing.Point(0, 0);
            this.panelEsquerdo.Name = "panelEsquerdo";
            this.panelEsquerdo.Size = new System.Drawing.Size(215, 681);
            this.panelEsquerdo.TabIndex = 0;
            // 
            // btnAjuda
            // 
            this.btnAjuda.BackColor = System.Drawing.Color.White;
            this.btnAjuda.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAjuda.FlatAppearance.BorderSize = 0;
            this.btnAjuda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAjuda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAjuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAjuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAjuda.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAjuda.IconChar = FontAwesome.Sharp.IconChar.QuestionCircle;
            this.btnAjuda.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnAjuda.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAjuda.IconSize = 35;
            this.btnAjuda.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjuda.Location = new System.Drawing.Point(0, 652);
            this.btnAjuda.Name = "btnAjuda";
            this.btnAjuda.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnAjuda.Size = new System.Drawing.Size(198, 45);
            this.btnAjuda.TabIndex = 0;
            this.btnAjuda.Text = "Ajuda";
            this.btnAjuda.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAjuda.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAjuda.UseVisualStyleBackColor = false;
            this.btnAjuda.Click += new System.EventHandler(this.btnAjuda_Click);
            // 
            // panelDocumentos
            // 
            this.panelDocumentos.BackColor = System.Drawing.Color.LightGray;
            this.panelDocumentos.Controls.Add(this.btnCheques);
            this.panelDocumentos.Controls.Add(this.btnCarteirinha);
            this.panelDocumentos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDocumentos.Location = new System.Drawing.Point(0, 558);
            this.panelDocumentos.Name = "panelDocumentos";
            this.panelDocumentos.Size = new System.Drawing.Size(198, 94);
            this.panelDocumentos.TabIndex = 0;
            // 
            // btnCheques
            // 
            this.btnCheques.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCheques.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCheques.FlatAppearance.BorderSize = 0;
            this.btnCheques.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCheques.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCheques.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheques.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheques.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCheques.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckAlt;
            this.btnCheques.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCheques.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCheques.IconSize = 35;
            this.btnCheques.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheques.Location = new System.Drawing.Point(0, 45);
            this.btnCheques.Name = "btnCheques";
            this.btnCheques.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnCheques.Size = new System.Drawing.Size(198, 45);
            this.btnCheques.TabIndex = 0;
            this.btnCheques.Text = "Cheques";
            this.btnCheques.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheques.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCheques.UseVisualStyleBackColor = false;
            this.btnCheques.Click += new System.EventHandler(this.btnCheques_Click);
            // 
            // btnCarteirinha
            // 
            this.btnCarteirinha.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCarteirinha.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCarteirinha.FlatAppearance.BorderSize = 0;
            this.btnCarteirinha.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCarteirinha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCarteirinha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCarteirinha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCarteirinha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCarteirinha.IconChar = FontAwesome.Sharp.IconChar.MoneyCheck;
            this.btnCarteirinha.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCarteirinha.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCarteirinha.IconSize = 35;
            this.btnCarteirinha.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCarteirinha.Location = new System.Drawing.Point(0, 0);
            this.btnCarteirinha.Name = "btnCarteirinha";
            this.btnCarteirinha.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnCarteirinha.Size = new System.Drawing.Size(198, 45);
            this.btnCarteirinha.TabIndex = 0;
            this.btnCarteirinha.Text = "Carteirinha";
            this.btnCarteirinha.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCarteirinha.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCarteirinha.UseVisualStyleBackColor = false;
            this.btnCarteirinha.Click += new System.EventHandler(this.btnCarteirinha_Click);
            // 
            // btnDocumentos
            // 
            this.btnDocumentos.BackColor = System.Drawing.Color.White;
            this.btnDocumentos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDocumentos.FlatAppearance.BorderSize = 0;
            this.btnDocumentos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDocumentos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDocumentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDocumentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDocumentos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDocumentos.IconChar = FontAwesome.Sharp.IconChar.FileAlt;
            this.btnDocumentos.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDocumentos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDocumentos.IconSize = 35;
            this.btnDocumentos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDocumentos.Location = new System.Drawing.Point(0, 513);
            this.btnDocumentos.Name = "btnDocumentos";
            this.btnDocumentos.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnDocumentos.Size = new System.Drawing.Size(198, 45);
            this.btnDocumentos.TabIndex = 0;
            this.btnDocumentos.Text = "Documentos";
            this.btnDocumentos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDocumentos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDocumentos.UseVisualStyleBackColor = false;
            this.btnDocumentos.Click += new System.EventHandler(this.btnDocumentos_Click);
            // 
            // btnRelatorios
            // 
            this.btnRelatorios.BackColor = System.Drawing.Color.White;
            this.btnRelatorios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRelatorios.FlatAppearance.BorderSize = 0;
            this.btnRelatorios.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRelatorios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnRelatorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelatorios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRelatorios.IconChar = FontAwesome.Sharp.IconChar.FileContract;
            this.btnRelatorios.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnRelatorios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRelatorios.IconSize = 35;
            this.btnRelatorios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelatorios.Location = new System.Drawing.Point(0, 468);
            this.btnRelatorios.Name = "btnRelatorios";
            this.btnRelatorios.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnRelatorios.Size = new System.Drawing.Size(198, 45);
            this.btnRelatorios.TabIndex = 0;
            this.btnRelatorios.Text = "Relatorios";
            this.btnRelatorios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRelatorios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRelatorios.UseVisualStyleBackColor = false;
            this.btnRelatorios.Click += new System.EventHandler(this.btnRelatorios_Click);
            // 
            // btnLancamento
            // 
            this.btnLancamento.BackColor = System.Drawing.Color.White;
            this.btnLancamento.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLancamento.FlatAppearance.BorderSize = 0;
            this.btnLancamento.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnLancamento.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnLancamento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLancamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLancamento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLancamento.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnLancamento.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLancamento.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLancamento.IconSize = 35;
            this.btnLancamento.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLancamento.Location = new System.Drawing.Point(0, 423);
            this.btnLancamento.Name = "btnLancamento";
            this.btnLancamento.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnLancamento.Size = new System.Drawing.Size(198, 45);
            this.btnLancamento.TabIndex = 0;
            this.btnLancamento.Text = "Lançamentos";
            this.btnLancamento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLancamento.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLancamento.UseVisualStyleBackColor = false;
            this.btnLancamento.Click += new System.EventHandler(this.btnLancamento_Click);
            // 
            // panelPesquisas
            // 
            this.panelPesquisas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelPesquisas.Controls.Add(this.btnPesquisarEmpresa);
            this.panelPesquisas.Controls.Add(this.btnPesquisarCliente);
            this.panelPesquisas.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPesquisas.Location = new System.Drawing.Point(0, 329);
            this.panelPesquisas.Name = "panelPesquisas";
            this.panelPesquisas.Size = new System.Drawing.Size(198, 94);
            this.panelPesquisas.TabIndex = 0;
            // 
            // btnPesquisarEmpresa
            // 
            this.btnPesquisarEmpresa.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPesquisarEmpresa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPesquisarEmpresa.FlatAppearance.BorderSize = 0;
            this.btnPesquisarEmpresa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnPesquisarEmpresa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnPesquisarEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarEmpresa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPesquisarEmpresa.IconChar = FontAwesome.Sharp.IconChar.SearchLocation;
            this.btnPesquisarEmpresa.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPesquisarEmpresa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPesquisarEmpresa.IconSize = 35;
            this.btnPesquisarEmpresa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisarEmpresa.Location = new System.Drawing.Point(0, 45);
            this.btnPesquisarEmpresa.Name = "btnPesquisarEmpresa";
            this.btnPesquisarEmpresa.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnPesquisarEmpresa.Size = new System.Drawing.Size(198, 45);
            this.btnPesquisarEmpresa.TabIndex = 0;
            this.btnPesquisarEmpresa.Text = "Pesquisar Convênio";
            this.btnPesquisarEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisarEmpresa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesquisarEmpresa.UseVisualStyleBackColor = false;
            this.btnPesquisarEmpresa.Click += new System.EventHandler(this.btnPesquisarEmpresa_Click);
            // 
            // btnPesquisarCliente
            // 
            this.btnPesquisarCliente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPesquisarCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPesquisarCliente.FlatAppearance.BorderSize = 0;
            this.btnPesquisarCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnPesquisarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnPesquisarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPesquisarCliente.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnPesquisarCliente.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPesquisarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPesquisarCliente.IconSize = 35;
            this.btnPesquisarCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisarCliente.Location = new System.Drawing.Point(0, 0);
            this.btnPesquisarCliente.Name = "btnPesquisarCliente";
            this.btnPesquisarCliente.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnPesquisarCliente.Size = new System.Drawing.Size(198, 45);
            this.btnPesquisarCliente.TabIndex = 0;
            this.btnPesquisarCliente.Text = "Pesquisar sócio";
            this.btnPesquisarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisarCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesquisarCliente.UseVisualStyleBackColor = false;
            this.btnPesquisarCliente.Click += new System.EventHandler(this.btnPesquisarCliente_Click);
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.Color.White;
            this.btnPesquisar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnPesquisar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPesquisar.IconChar = FontAwesome.Sharp.IconChar.SearchPlus;
            this.btnPesquisar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPesquisar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPesquisar.IconSize = 35;
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.Location = new System.Drawing.Point(0, 284);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnPesquisar.Size = new System.Drawing.Size(198, 45);
            this.btnPesquisar.TabIndex = 0;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // panelCadastros
            // 
            this.panelCadastros.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelCadastros.Controls.Add(this.btnCadastroEmpresa);
            this.panelCadastros.Controls.Add(this.btnCadastroCliente);
            this.panelCadastros.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelCadastros.Location = new System.Drawing.Point(0, 190);
            this.panelCadastros.Name = "panelCadastros";
            this.panelCadastros.Size = new System.Drawing.Size(198, 94);
            this.panelCadastros.TabIndex = 0;
            // 
            // btnCadastroEmpresa
            // 
            this.btnCadastroEmpresa.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCadastroEmpresa.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCadastroEmpresa.FlatAppearance.BorderSize = 0;
            this.btnCadastroEmpresa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCadastroEmpresa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCadastroEmpresa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroEmpresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroEmpresa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCadastroEmpresa.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            this.btnCadastroEmpresa.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCadastroEmpresa.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCadastroEmpresa.IconSize = 35;
            this.btnCadastroEmpresa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroEmpresa.Location = new System.Drawing.Point(0, 45);
            this.btnCadastroEmpresa.Name = "btnCadastroEmpresa";
            this.btnCadastroEmpresa.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnCadastroEmpresa.Size = new System.Drawing.Size(198, 45);
            this.btnCadastroEmpresa.TabIndex = 0;
            this.btnCadastroEmpresa.Text = "Cadastrar Convênio";
            this.btnCadastroEmpresa.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroEmpresa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastroEmpresa.UseVisualStyleBackColor = false;
            this.btnCadastroEmpresa.Click += new System.EventHandler(this.btnCadastroEmpresa_Click);
            // 
            // btnCadastroCliente
            // 
            this.btnCadastroCliente.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnCadastroCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCadastroCliente.FlatAppearance.BorderSize = 0;
            this.btnCadastroCliente.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCadastroCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCadastroCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastroCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCadastroCliente.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnCadastroCliente.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCadastroCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCadastroCliente.IconSize = 35;
            this.btnCadastroCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroCliente.Location = new System.Drawing.Point(0, 0);
            this.btnCadastroCliente.Name = "btnCadastroCliente";
            this.btnCadastroCliente.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.btnCadastroCliente.Size = new System.Drawing.Size(198, 45);
            this.btnCadastroCliente.TabIndex = 0;
            this.btnCadastroCliente.Text = "Cadastrar sócio";
            this.btnCadastroCliente.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastroCliente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastroCliente.UseVisualStyleBackColor = false;
            this.btnCadastroCliente.Click += new System.EventHandler(this.btnCadastroCliente_Click);
            // 
            // btnCadastros
            // 
            this.btnCadastros.BackColor = System.Drawing.Color.White;
            this.btnCadastros.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCadastros.FlatAppearance.BorderSize = 0;
            this.btnCadastros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCadastros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCadastros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCadastros.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnCadastros.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnCadastros.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCadastros.IconSize = 35;
            this.btnCadastros.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastros.Location = new System.Drawing.Point(0, 145);
            this.btnCadastros.Name = "btnCadastros";
            this.btnCadastros.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCadastros.Size = new System.Drawing.Size(198, 45);
            this.btnCadastros.TabIndex = 0;
            this.btnCadastros.Text = "Cadastros";
            this.btnCadastros.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastros.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastros.UseVisualStyleBackColor = false;
            this.btnCadastros.Click += new System.EventHandler(this.btnCadastros_Click);
            // 
            // btnPaginaInicial
            // 
            this.btnPaginaInicial.BackColor = System.Drawing.Color.White;
            this.btnPaginaInicial.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPaginaInicial.FlatAppearance.BorderSize = 0;
            this.btnPaginaInicial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnPaginaInicial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnPaginaInicial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPaginaInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPaginaInicial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPaginaInicial.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnPaginaInicial.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPaginaInicial.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPaginaInicial.IconSize = 35;
            this.btnPaginaInicial.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPaginaInicial.Location = new System.Drawing.Point(0, 100);
            this.btnPaginaInicial.Name = "btnPaginaInicial";
            this.btnPaginaInicial.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnPaginaInicial.Size = new System.Drawing.Size(198, 45);
            this.btnPaginaInicial.TabIndex = 0;
            this.btnPaginaInicial.Text = "Pagina Inicial";
            this.btnPaginaInicial.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPaginaInicial.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPaginaInicial.UseVisualStyleBackColor = false;
            this.btnPaginaInicial.Click += new System.EventHandler(this.btnPaginaInicial_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.Silver;
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(198, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelFormTitulo
            // 
            this.panelFormTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.panelFormTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelFormTitulo.Location = new System.Drawing.Point(215, 0);
            this.panelFormTitulo.Name = "panelFormTitulo";
            this.panelFormTitulo.Size = new System.Drawing.Size(1049, 30);
            this.panelFormTitulo.TabIndex = 0;
            // 
            // panelFormCentral
            // 
            this.panelFormCentral.BackColor = System.Drawing.Color.White;
            this.panelFormCentral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelFormCentral.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelFormCentral.Controls.Add(this.webView21);
            this.panelFormCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormCentral.Location = new System.Drawing.Point(215, 30);
            this.panelFormCentral.Name = "panelFormCentral";
            this.panelFormCentral.Size = new System.Drawing.Size(1049, 651);
            this.panelFormCentral.TabIndex = 0;
            // 
            // webView21
            // 
            this.webView21.AllowExternalDrop = true;
            this.webView21.CreationProperties = null;
            this.webView21.DefaultBackgroundColor = System.Drawing.Color.White;
            this.webView21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webView21.Location = new System.Drawing.Point(0, 0);
            this.webView21.Name = "webView21";
            this.webView21.Size = new System.Drawing.Size(1047, 649);
            this.webView21.Source = new System.Uri("https://stpmj.org.br/", System.UriKind.Absolute);
            this.webView21.TabIndex = 0;
            this.webView21.ZoomFactor = 1D;
            // 
            // formPaginaInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panelFormCentral);
            this.Controls.Add(this.panelFormTitulo);
            this.Controls.Add(this.panelEsquerdo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "formPaginaInicial";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sindicato STPMJ";
            this.TransparencyKey = System.Drawing.Color.Gray;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formPaginaInicial_FormClosing);
            this.panelEsquerdo.ResumeLayout(false);
            this.panelDocumentos.ResumeLayout(false);
            this.panelPesquisas.ResumeLayout(false);
            this.panelCadastros.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelFormCentral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.webView21)).EndInit();
            this.ResumeLayout(false);

        }



        #endregion
        private System.Windows.Forms.Panel panelEsquerdo;
        private FontAwesome.Sharp.IconButton btnAjuda;
        private System.Windows.Forms.Panel panelDocumentos;
        private FontAwesome.Sharp.IconButton btnCheques;
        private FontAwesome.Sharp.IconButton btnCarteirinha;
        private FontAwesome.Sharp.IconButton btnDocumentos;
        private FontAwesome.Sharp.IconButton btnRelatorios;
        private System.Windows.Forms.Panel panelPesquisas;
        private FontAwesome.Sharp.IconButton btnPesquisarEmpresa;
        private FontAwesome.Sharp.IconButton btnPesquisarCliente;
        private FontAwesome.Sharp.IconButton btnPesquisar;
        private System.Windows.Forms.Panel panelCadastros;
        private FontAwesome.Sharp.IconButton btnCadastroEmpresa;
        private FontAwesome.Sharp.IconButton btnCadastroCliente;
        private FontAwesome.Sharp.IconButton btnCadastros;
        private System.Windows.Forms.Panel panelFormTitulo;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Panel panelFormCentral;
        private Microsoft.Web.WebView2.WinForms.WebView2 webView21;
        private FontAwesome.Sharp.IconButton btnPaginaInicial;
        private FontAwesome.Sharp.IconButton btnLancamento;
    }
}

