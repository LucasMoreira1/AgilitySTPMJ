using System;

namespace Programa_STPMJ
{
    partial class FormPesquisa
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnPesquisar = new FontAwesome.Sharp.IconButton();
            this.btnMostrarTodos = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.cboxFiltro2 = new System.Windows.Forms.ComboBox();
            this.txtFiltro2 = new System.Windows.Forms.TextBox();
            this.lblFiltro2 = new System.Windows.Forms.Label();
            this.cboxFiltro3 = new System.Windows.Forms.ComboBox();
            this.txtFiltro3 = new System.Windows.Forms.TextBox();
            this.lblFiltro3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnAtualizar = new FontAwesome.Sharp.IconButton();
            this.btnDeletar = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRegistroSelecionado = new System.Windows.Forms.TextBox();
            this.txtFiltroMatricula = new System.Windows.Forms.TextBox();
            this.lblFiltro1 = new System.Windows.Forms.Label();
            this.txtFiltro1 = new System.Windows.Forms.TextBox();
            this.cboxMesAniversario = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.calendario1 = new System.Windows.Forms.MonthCalendar();
            this.txtData1 = new System.Windows.Forms.TextBox();
            this.txtData2 = new System.Windows.Forms.TextBox();
            this.calendario2 = new System.Windows.Forms.MonthCalendar();
            this.btnFiltroAniversario = new FontAwesome.Sharp.IconButton();
            this.btnFiltroCadastro = new FontAwesome.Sharp.IconButton();
            this.txtData1Convert = new System.Windows.Forms.TextBox();
            this.txtData2Convert = new System.Windows.Forms.TextBox();
            this.txtMesAniversario = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisar.BackColor = System.Drawing.Color.LightGray;
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnPesquisar.IconColor = System.Drawing.Color.Black;
            this.btnPesquisar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnPesquisar.IconSize = 32;
            this.btnPesquisar.Location = new System.Drawing.Point(874, 44);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnPesquisar.Size = new System.Drawing.Size(200, 47);
            this.btnPesquisar.TabIndex = 1;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesquisar.UseMnemonic = false;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMostrarTodos.BackColor = System.Drawing.Color.LightGray;
            this.btnMostrarTodos.FlatAppearance.BorderSize = 0;
            this.btnMostrarTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarTodos.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnMostrarTodos.IconColor = System.Drawing.Color.Black;
            this.btnMostrarTodos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMostrarTodos.IconSize = 32;
            this.btnMostrarTodos.Location = new System.Drawing.Point(874, 97);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMostrarTodos.Size = new System.Drawing.Size(200, 47);
            this.btnMostrarTodos.TabIndex = 1;
            this.btnMostrarTodos.Text = "Mostrar Todos";
            this.btnMostrarTodos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMostrarTodos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMostrarTodos.UseMnemonic = false;
            this.btnMostrarTodos.UseVisualStyleBackColor = false;
            this.btnMostrarTodos.Click += new System.EventHandler(this.btnMostrarTodos_Click);
            // 
            // iconButton3
            // 
            this.iconButton3.BackColor = System.Drawing.Color.White;
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.iconButton3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Reply;
            this.iconButton3.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 35;
            this.iconButton3.Location = new System.Drawing.Point(12, 0);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(37, 32);
            this.iconButton3.TabIndex = 2;
            this.iconButton3.UseVisualStyleBackColor = false;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // cboxFiltro2
            // 
            this.cboxFiltro2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxFiltro2.FormattingEnabled = true;
            this.cboxFiltro2.Items.AddRange(new object[] {
            "RegistroSindical",
            "Matricula",
            "Nome",
            "RG",
            "CPF",
            "DataNascimento",
            "EstadoCivil",
            "Naturalidade",
            "DataCadastro",
            "Secretaria",
            "Funcao",
            "Admissao",
            "LocalTrabalho",
            "CEP",
            "Logradouro",
            "Numero",
            "Complemento",
            "Bairro",
            "Cidade",
            "Estado",
            "Telefone",
            "Recados",
            "Limite",
            "Disponivel"});
            this.cboxFiltro2.Location = new System.Drawing.Point(139, 85);
            this.cboxFiltro2.Name = "cboxFiltro2";
            this.cboxFiltro2.Size = new System.Drawing.Size(121, 28);
            this.cboxFiltro2.TabIndex = 3;
            this.cboxFiltro2.Text = "Nome";
            // 
            // txtFiltro2
            // 
            this.txtFiltro2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltro2.Location = new System.Drawing.Point(139, 118);
            this.txtFiltro2.Name = "txtFiltro2";
            this.txtFiltro2.Size = new System.Drawing.Size(121, 26);
            this.txtFiltro2.TabIndex = 4;
            this.txtFiltro2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // lblFiltro2
            // 
            this.lblFiltro2.AutoSize = true;
            this.lblFiltro2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro2.Location = new System.Drawing.Point(135, 62);
            this.lblFiltro2.Name = "lblFiltro2";
            this.lblFiltro2.Size = new System.Drawing.Size(57, 20);
            this.lblFiltro2.TabIndex = 5;
            this.lblFiltro2.Text = "Filtro 2";
            this.lblFiltro2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cboxFiltro3
            // 
            this.cboxFiltro3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxFiltro3.FormattingEnabled = true;
            this.cboxFiltro3.Items.AddRange(new object[] {
            "Matricula",
            "Nome",
            "RG",
            "CPF",
            "DataNascimento",
            "EstadoCivil",
            "Naturalidade",
            "RegistroSindical",
            "DataCadastro",
            "Secretaria",
            "Funcao",
            "Admissao",
            "LocalTrabalho",
            "CEP",
            "Logradouro",
            "Numero",
            "Complemento",
            "Bairro",
            "Cidade",
            "Estado",
            "Telefone",
            "Recados",
            "Limite",
            "Disponivel"});
            this.cboxFiltro3.Location = new System.Drawing.Point(266, 85);
            this.cboxFiltro3.Name = "cboxFiltro3";
            this.cboxFiltro3.Size = new System.Drawing.Size(121, 28);
            this.cboxFiltro3.TabIndex = 3;
            this.cboxFiltro3.Text = "Secretaria";
            // 
            // txtFiltro3
            // 
            this.txtFiltro3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltro3.Location = new System.Drawing.Point(266, 118);
            this.txtFiltro3.Name = "txtFiltro3";
            this.txtFiltro3.Size = new System.Drawing.Size(121, 26);
            this.txtFiltro3.TabIndex = 4;
            this.txtFiltro3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // lblFiltro3
            // 
            this.lblFiltro3.AutoSize = true;
            this.lblFiltro3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro3.Location = new System.Drawing.Point(262, 62);
            this.lblFiltro3.Name = "lblFiltro3";
            this.lblFiltro3.Size = new System.Drawing.Size(57, 20);
            this.lblFiltro3.TabIndex = 5;
            this.lblFiltro3.Text = "Filtro 3";
            this.lblFiltro3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 150);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView1.Size = new System.Drawing.Size(1319, 476);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 629);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1343, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Red;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(115, 17);
            this.toolStripStatusLabel1.Text = "Número de linha(s): ";
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtualizar.BackColor = System.Drawing.Color.LightGray;
            this.btnAtualizar.FlatAppearance.BorderSize = 0;
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnAtualizar.IconColor = System.Drawing.Color.Black;
            this.btnAtualizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAtualizar.IconSize = 32;
            this.btnAtualizar.Location = new System.Drawing.Point(1131, 44);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnAtualizar.Size = new System.Drawing.Size(200, 47);
            this.btnAtualizar.TabIndex = 1;
            this.btnAtualizar.Text = "Atualizar ( )";
            this.btnAtualizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtualizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAtualizar.UseMnemonic = false;
            this.btnAtualizar.UseVisualStyleBackColor = false;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeletar.BackColor = System.Drawing.Color.LightGray;
            this.btnDeletar.FlatAppearance.BorderSize = 0;
            this.btnDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnDeletar.IconColor = System.Drawing.Color.Black;
            this.btnDeletar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeletar.IconSize = 32;
            this.btnDeletar.Location = new System.Drawing.Point(1131, 97);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDeletar.Size = new System.Drawing.Size(200, 47);
            this.btnDeletar.TabIndex = 1;
            this.btnDeletar.Text = "Deletar ( )";
            this.btnDeletar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeletar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeletar.UseMnemonic = false;
            this.btnDeletar.UseVisualStyleBackColor = false;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(263, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Reg. Selecionado";
            this.label3.Visible = false;
            // 
            // txtRegistroSelecionado
            // 
            this.txtRegistroSelecionado.Location = new System.Drawing.Point(361, 16);
            this.txtRegistroSelecionado.Name = "txtRegistroSelecionado";
            this.txtRegistroSelecionado.Size = new System.Drawing.Size(18, 20);
            this.txtRegistroSelecionado.TabIndex = 10;
            this.txtRegistroSelecionado.Visible = false;
            // 
            // txtFiltroMatricula
            // 
            this.txtFiltroMatricula.Enabled = false;
            this.txtFiltroMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltroMatricula.Location = new System.Drawing.Point(12, 86);
            this.txtFiltroMatricula.Name = "txtFiltroMatricula";
            this.txtFiltroMatricula.Size = new System.Drawing.Size(121, 26);
            this.txtFiltroMatricula.TabIndex = 11;
            this.txtFiltroMatricula.Text = "Matricula";
            // 
            // lblFiltro1
            // 
            this.lblFiltro1.AutoSize = true;
            this.lblFiltro1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFiltro1.Location = new System.Drawing.Point(12, 62);
            this.lblFiltro1.Name = "lblFiltro1";
            this.lblFiltro1.Size = new System.Drawing.Size(57, 20);
            this.lblFiltro1.TabIndex = 5;
            this.lblFiltro1.Text = "Filtro 1";
            this.lblFiltro1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtFiltro1
            // 
            this.txtFiltro1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFiltro1.Location = new System.Drawing.Point(12, 118);
            this.txtFiltro1.Name = "txtFiltro1";
            this.txtFiltro1.Size = new System.Drawing.Size(121, 26);
            this.txtFiltro1.TabIndex = 4;
            this.txtFiltro1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.filtro1_KeyDown);
            // 
            // cboxMesAniversario
            // 
            this.cboxMesAniversario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxMesAniversario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxMesAniversario.FormattingEnabled = true;
            this.cboxMesAniversario.Items.AddRange(new object[] {
            "Janeiro",
            "Fevereiro",
            "Março",
            "Abril",
            "Maio",
            "Junho",
            "Julho",
            "Agosto",
            "Setembro",
            "Outubro",
            "Novembro",
            "Dezembro"});
            this.cboxMesAniversario.Location = new System.Drawing.Point(393, 84);
            this.cboxMesAniversario.Name = "cboxMesAniversario";
            this.cboxMesAniversario.Size = new System.Drawing.Size(121, 28);
            this.cboxMesAniversario.TabIndex = 3;
            this.cboxMesAniversario.SelectedIndexChanged += new System.EventHandler(this.cboxMesAniversario_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(389, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Mês Aniversário";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(583, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Data Cadastro";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // calendario1
            // 
            this.calendario1.Location = new System.Drawing.Point(526, 90);
            this.calendario1.Name = "calendario1";
            this.calendario1.TabIndex = 12;
            this.calendario1.Visible = false;
            this.calendario1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calendario1_DateSelected);
            // 
            // txtData1
            // 
            this.txtData1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData1.Location = new System.Drawing.Point(541, 84);
            this.txtData1.Name = "txtData1";
            this.txtData1.Size = new System.Drawing.Size(97, 26);
            this.txtData1.TabIndex = 4;
            this.txtData1.DoubleClick += new System.EventHandler(this.MostrarCalendario1);
            // 
            // txtData2
            // 
            this.txtData2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData2.Location = new System.Drawing.Point(644, 84);
            this.txtData2.Name = "txtData2";
            this.txtData2.Size = new System.Drawing.Size(97, 26);
            this.txtData2.TabIndex = 4;
            this.txtData2.DoubleClick += new System.EventHandler(this.MostrarCalendario2);
            // 
            // calendario2
            // 
            this.calendario2.Location = new System.Drawing.Point(526, 90);
            this.calendario2.Name = "calendario2";
            this.calendario2.TabIndex = 13;
            this.calendario2.Visible = false;
            this.calendario2.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calendario2_DateSelected);
            // 
            // btnFiltroAniversario
            // 
            this.btnFiltroAniversario.BackColor = System.Drawing.Color.LightGray;
            this.btnFiltroAniversario.FlatAppearance.BorderSize = 0;
            this.btnFiltroAniversario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltroAniversario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltroAniversario.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnFiltroAniversario.IconColor = System.Drawing.Color.Black;
            this.btnFiltroAniversario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFiltroAniversario.IconSize = 25;
            this.btnFiltroAniversario.Location = new System.Drawing.Point(400, 117);
            this.btnFiltroAniversario.Name = "btnFiltroAniversario";
            this.btnFiltroAniversario.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnFiltroAniversario.Size = new System.Drawing.Size(110, 27);
            this.btnFiltroAniversario.TabIndex = 1;
            this.btnFiltroAniversario.Text = "Filtrar";
            this.btnFiltroAniversario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFiltroAniversario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFiltroAniversario.UseMnemonic = false;
            this.btnFiltroAniversario.UseVisualStyleBackColor = false;
            this.btnFiltroAniversario.Click += new System.EventHandler(this.btnFiltroAniversario_Click);
            // 
            // btnFiltroCadastro
            // 
            this.btnFiltroCadastro.BackColor = System.Drawing.Color.LightGray;
            this.btnFiltroCadastro.FlatAppearance.BorderSize = 0;
            this.btnFiltroCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltroCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltroCadastro.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnFiltroCadastro.IconColor = System.Drawing.Color.Black;
            this.btnFiltroCadastro.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFiltroCadastro.IconSize = 25;
            this.btnFiltroCadastro.Location = new System.Drawing.Point(586, 118);
            this.btnFiltroCadastro.Name = "btnFiltroCadastro";
            this.btnFiltroCadastro.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnFiltroCadastro.Size = new System.Drawing.Size(110, 27);
            this.btnFiltroCadastro.TabIndex = 1;
            this.btnFiltroCadastro.Text = "Filtrar";
            this.btnFiltroCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFiltroCadastro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFiltroCadastro.UseMnemonic = false;
            this.btnFiltroCadastro.UseVisualStyleBackColor = false;
            this.btnFiltroCadastro.Click += new System.EventHandler(this.btnFiltroCadastro_Click);
            // 
            // txtData1Convert
            // 
            this.txtData1Convert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData1Convert.Location = new System.Drawing.Point(703, 12);
            this.txtData1Convert.Name = "txtData1Convert";
            this.txtData1Convert.Size = new System.Drawing.Size(97, 26);
            this.txtData1Convert.TabIndex = 4;
            // 
            // txtData2Convert
            // 
            this.txtData2Convert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData2Convert.Location = new System.Drawing.Point(703, 44);
            this.txtData2Convert.Name = "txtData2Convert";
            this.txtData2Convert.Size = new System.Drawing.Size(97, 26);
            this.txtData2Convert.TabIndex = 4;
            this.txtData2Convert.Visible = false;
            // 
            // txtMesAniversario
            // 
            this.txtMesAniversario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMesAniversario.Location = new System.Drawing.Point(406, 118);
            this.txtMesAniversario.Name = "txtMesAniversario";
            this.txtMesAniversario.Size = new System.Drawing.Size(97, 26);
            this.txtMesAniversario.TabIndex = 4;
            this.txtMesAniversario.Visible = false;
            // 
            // FormPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1343, 651);
            this.Controls.Add(this.calendario2);
            this.Controls.Add(this.calendario1);
            this.Controls.Add(this.txtFiltroMatricula);
            this.Controls.Add(this.txtRegistroSelecionado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblFiltro3);
            this.Controls.Add(this.txtData2);
            this.Controls.Add(this.txtMesAniversario);
            this.Controls.Add(this.txtData2Convert);
            this.Controls.Add(this.txtData1Convert);
            this.Controls.Add(this.txtData1);
            this.Controls.Add(this.txtFiltro3);
            this.Controls.Add(this.lblFiltro1);
            this.Controls.Add(this.lblFiltro2);
            this.Controls.Add(this.cboxMesAniversario);
            this.Controls.Add(this.cboxFiltro3);
            this.Controls.Add(this.txtFiltro1);
            this.Controls.Add(this.txtFiltro2);
            this.Controls.Add(this.cboxFiltro2);
            this.Controls.Add(this.iconButton3);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnMostrarTodos);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnFiltroCadastro);
            this.Controls.Add(this.btnFiltroAniversario);
            this.Controls.Add(this.btnPesquisar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPesquisa";
            this.Text = "Pesquisa";
            this.Load += new System.EventHandler(this.FormPesquisa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }





        #endregion
        private FontAwesome.Sharp.IconButton btnMostrarTodos;
        private FontAwesome.Sharp.IconButton iconButton3;
        private System.Windows.Forms.ComboBox cboxFiltro2;
        private System.Windows.Forms.Label lblFiltro2;
        private System.Windows.Forms.ComboBox cboxFiltro3;
        private System.Windows.Forms.Label lblFiltro3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private FontAwesome.Sharp.IconButton btnAtualizar;
        private FontAwesome.Sharp.IconButton btnDeletar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRegistroSelecionado;
        public FontAwesome.Sharp.IconButton btnPesquisar;
        private System.Windows.Forms.Label lblFiltro1;
        public System.Windows.Forms.TextBox txtFiltroMatricula;
        public System.Windows.Forms.TextBox txtFiltro2;
        public System.Windows.Forms.TextBox txtFiltro3;
        public System.Windows.Forms.TextBox txtFiltro1;
        private System.Windows.Forms.ComboBox cboxMesAniversario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtData1;
        public System.Windows.Forms.TextBox txtData2;
        private System.Windows.Forms.MonthCalendar calendario1;
        private System.Windows.Forms.MonthCalendar calendario2;
        public FontAwesome.Sharp.IconButton btnFiltroAniversario;
        public FontAwesome.Sharp.IconButton btnFiltroCadastro;
        public System.Windows.Forms.TextBox txtData1Convert;
        public System.Windows.Forms.TextBox txtData2Convert;
        public System.Windows.Forms.TextBox txtMesAniversario;
    }
}