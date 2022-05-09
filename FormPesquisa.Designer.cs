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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.btnPesquisar.Location = new System.Drawing.Point(580, 44);
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
            this.btnMostrarTodos.Location = new System.Drawing.Point(580, 97);
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
            "Empresa",
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
            this.cboxFiltro2.Text = "Matricula";
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
            "Empresa",
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
            this.cboxFiltro3.Text = "Matricula";
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Location = new System.Drawing.Point(12, 150);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView1.Size = new System.Drawing.Size(1025, 476);
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
            this.statusStrip1.Size = new System.Drawing.Size(1049, 22);
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
            this.btnAtualizar.Location = new System.Drawing.Point(837, 44);
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
            this.btnDeletar.Location = new System.Drawing.Point(837, 97);
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
            this.label3.Location = new System.Drawing.Point(419, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Reg. Selecionado";
            this.label3.Visible = false;
            // 
            // txtRegistroSelecionado
            // 
            this.txtRegistroSelecionado.Location = new System.Drawing.Point(517, 90);
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
            this.txtFiltro1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // FormPesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1049, 651);
            this.Controls.Add(this.txtFiltroMatricula);
            this.Controls.Add(this.txtRegistroSelecionado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblFiltro3);
            this.Controls.Add(this.txtFiltro3);
            this.Controls.Add(this.lblFiltro1);
            this.Controls.Add(this.lblFiltro2);
            this.Controls.Add(this.cboxFiltro3);
            this.Controls.Add(this.txtFiltro1);
            this.Controls.Add(this.txtFiltro2);
            this.Controls.Add(this.cboxFiltro2);
            this.Controls.Add(this.iconButton3);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnMostrarTodos);
            this.Controls.Add(this.btnAtualizar);
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
    }
}