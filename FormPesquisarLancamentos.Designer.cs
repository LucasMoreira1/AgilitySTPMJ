namespace Programa_STPMJ
{
    partial class FormPesquisarLancamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPesquisarLancamentos));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cboxMesAniversario = new System.Windows.Forms.ComboBox();
            this.btnMostrarTodos = new FontAwesome.Sharp.IconButton();
            this.btnFiltroAniversario = new FontAwesome.Sharp.IconButton();
            this.txtMesAniversario = new System.Windows.Forms.TextBox();
            this.calendario2 = new System.Windows.Forms.MonthCalendar();
            this.calendario1 = new System.Windows.Forms.MonthCalendar();
            this.label2 = new System.Windows.Forms.Label();
            this.txtData2 = new System.Windows.Forms.TextBox();
            this.txtData1 = new System.Windows.Forms.TextBox();
            this.btnFiltroCadastro = new FontAwesome.Sharp.IconButton();
            this.txtData2Convert = new System.Windows.Forms.TextBox();
            this.txtData1Convert = new System.Windows.Forms.TextBox();
            this.btnExportarExcel = new System.Windows.Forms.Button();
            this.btnDeletar = new FontAwesome.Sharp.IconButton();
            this.txtRegistroSelecionado = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(12, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView1.Size = new System.Drawing.Size(1319, 510);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Mês Lançamento";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.cboxMesAniversario.Location = new System.Drawing.Point(16, 32);
            this.cboxMesAniversario.Name = "cboxMesAniversario";
            this.cboxMesAniversario.Size = new System.Drawing.Size(121, 28);
            this.cboxMesAniversario.TabIndex = 3;
            this.cboxMesAniversario.SelectedIndexChanged += new System.EventHandler(this.cboxMesAniversario_SelectedIndexChanged);
            // 
            // btnMostrarTodos
            // 
            this.btnMostrarTodos.BackColor = System.Drawing.Color.LightGray;
            this.btnMostrarTodos.FlatAppearance.BorderSize = 0;
            this.btnMostrarTodos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnMostrarTodos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMostrarTodos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrarTodos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarTodos.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnMostrarTodos.IconColor = System.Drawing.Color.Black;
            this.btnMostrarTodos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMostrarTodos.IconSize = 32;
            this.btnMostrarTodos.Location = new System.Drawing.Point(384, 23);
            this.btnMostrarTodos.Name = "btnMostrarTodos";
            this.btnMostrarTodos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMostrarTodos.Size = new System.Drawing.Size(147, 47);
            this.btnMostrarTodos.TabIndex = 4;
            this.btnMostrarTodos.Text = "Mostrar Todos";
            this.btnMostrarTodos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMostrarTodos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMostrarTodos.UseMnemonic = false;
            this.btnMostrarTodos.UseVisualStyleBackColor = false;
            this.btnMostrarTodos.Click += new System.EventHandler(this.btnMostrarTodos_Click);
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
            this.btnFiltroAniversario.Location = new System.Drawing.Point(23, 65);
            this.btnFiltroAniversario.Name = "btnFiltroAniversario";
            this.btnFiltroAniversario.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnFiltroAniversario.Size = new System.Drawing.Size(110, 27);
            this.btnFiltroAniversario.TabIndex = 5;
            this.btnFiltroAniversario.Text = "Filtrar";
            this.btnFiltroAniversario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFiltroAniversario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFiltroAniversario.UseMnemonic = false;
            this.btnFiltroAniversario.UseVisualStyleBackColor = false;
            this.btnFiltroAniversario.Click += new System.EventHandler(this.btnFiltroAniversario_Click);
            // 
            // txtMesAniversario
            // 
            this.txtMesAniversario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMesAniversario.Location = new System.Drawing.Point(1044, 12);
            this.txtMesAniversario.Name = "txtMesAniversario";
            this.txtMesAniversario.Size = new System.Drawing.Size(97, 26);
            this.txtMesAniversario.TabIndex = 6;
            this.txtMesAniversario.Visible = false;
            // 
            // calendario2
            // 
            this.calendario2.Location = new System.Drawing.Point(145, 44);
            this.calendario2.Name = "calendario2";
            this.calendario2.TabIndex = 7;
            this.calendario2.Visible = false;
            this.calendario2.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calendario2_DateSelected);
            // 
            // calendario1
            // 
            this.calendario1.Location = new System.Drawing.Point(145, 44);
            this.calendario1.Name = "calendario1";
            this.calendario1.TabIndex = 8;
            this.calendario1.Visible = false;
            this.calendario1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.calendario1_DateSelected);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(186, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Data Lançamento";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtData2
            // 
            this.txtData2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData2.Location = new System.Drawing.Point(259, 32);
            this.txtData2.Name = "txtData2";
            this.txtData2.Size = new System.Drawing.Size(97, 26);
            this.txtData2.TabIndex = 10;
            this.txtData2.DoubleClick += new System.EventHandler(this.txtData2_DoubleClick);
            // 
            // txtData1
            // 
            this.txtData1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData1.Location = new System.Drawing.Point(156, 32);
            this.txtData1.Name = "txtData1";
            this.txtData1.Size = new System.Drawing.Size(97, 26);
            this.txtData1.TabIndex = 11;
            this.txtData1.DoubleClick += new System.EventHandler(this.txtData1_DoubleClick);
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
            this.btnFiltroCadastro.Location = new System.Drawing.Point(202, 65);
            this.btnFiltroCadastro.Name = "btnFiltroCadastro";
            this.btnFiltroCadastro.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnFiltroCadastro.Size = new System.Drawing.Size(110, 27);
            this.btnFiltroCadastro.TabIndex = 12;
            this.btnFiltroCadastro.Text = "Filtrar";
            this.btnFiltroCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFiltroCadastro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFiltroCadastro.UseMnemonic = false;
            this.btnFiltroCadastro.UseVisualStyleBackColor = false;
            this.btnFiltroCadastro.Click += new System.EventHandler(this.btnFiltroCadastro_Click);
            // 
            // txtData2Convert
            // 
            this.txtData2Convert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData2Convert.Location = new System.Drawing.Point(1147, 44);
            this.txtData2Convert.Name = "txtData2Convert";
            this.txtData2Convert.Size = new System.Drawing.Size(97, 26);
            this.txtData2Convert.TabIndex = 13;
            this.txtData2Convert.Visible = false;
            // 
            // txtData1Convert
            // 
            this.txtData1Convert.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData1Convert.Location = new System.Drawing.Point(1147, 12);
            this.txtData1Convert.Name = "txtData1Convert";
            this.txtData1Convert.Size = new System.Drawing.Size(97, 26);
            this.txtData1Convert.TabIndex = 14;
            this.txtData1Convert.Visible = false;
            // 
            // btnExportarExcel
            // 
            this.btnExportarExcel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportarExcel.Location = new System.Drawing.Point(537, 23);
            this.btnExportarExcel.Name = "btnExportarExcel";
            this.btnExportarExcel.Size = new System.Drawing.Size(147, 47);
            this.btnExportarExcel.TabIndex = 15;
            this.btnExportarExcel.Text = "Exportar Excel";
            this.btnExportarExcel.UseVisualStyleBackColor = true;
            this.btnExportarExcel.Click += new System.EventHandler(this.btnExportarExcel_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeletar.BackColor = System.Drawing.Color.LightGray;
            this.btnDeletar.FlatAppearance.BorderSize = 0;
            this.btnDeletar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnDeletar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnDeletar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeletar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeletar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btnDeletar.IconColor = System.Drawing.Color.Black;
            this.btnDeletar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDeletar.IconSize = 32;
            this.btnDeletar.Location = new System.Drawing.Point(690, 23);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDeletar.Size = new System.Drawing.Size(147, 47);
            this.btnDeletar.TabIndex = 16;
            this.btnDeletar.Text = "Deletar ( )";
            this.btnDeletar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeletar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeletar.UseMnemonic = false;
            this.btnDeletar.UseVisualStyleBackColor = false;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // txtRegistroSelecionado
            // 
            this.txtRegistroSelecionado.Location = new System.Drawing.Point(1044, 44);
            this.txtRegistroSelecionado.Name = "txtRegistroSelecionado";
            this.txtRegistroSelecionado.Size = new System.Drawing.Size(18, 20);
            this.txtRegistroSelecionado.TabIndex = 17;
            this.txtRegistroSelecionado.Visible = false;
            // 
            // FormPesquisarLancamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 651);
            this.Controls.Add(this.txtRegistroSelecionado);
            this.Controls.Add(this.btnDeletar);
            this.Controls.Add(this.btnExportarExcel);
            this.Controls.Add(this.txtData2Convert);
            this.Controls.Add(this.txtData1Convert);
            this.Controls.Add(this.calendario2);
            this.Controls.Add(this.calendario1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtData2);
            this.Controls.Add(this.txtData1);
            this.Controls.Add(this.txtMesAniversario);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboxMesAniversario);
            this.Controls.Add(this.btnMostrarTodos);
            this.Controls.Add(this.btnFiltroAniversario);
            this.Controls.Add(this.btnFiltroCadastro);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPesquisarLancamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pesquisar Lancamentos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboxMesAniversario;
        private FontAwesome.Sharp.IconButton btnMostrarTodos;
        public FontAwesome.Sharp.IconButton btnFiltroAniversario;
        public System.Windows.Forms.TextBox txtMesAniversario;
        private System.Windows.Forms.MonthCalendar calendario2;
        private System.Windows.Forms.MonthCalendar calendario1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtData2;
        public System.Windows.Forms.TextBox txtData1;
        public FontAwesome.Sharp.IconButton btnFiltroCadastro;
        public System.Windows.Forms.TextBox txtData2Convert;
        public System.Windows.Forms.TextBox txtData1Convert;
        private System.Windows.Forms.Button btnExportarExcel;
        private FontAwesome.Sharp.IconButton btnDeletar;
        private System.Windows.Forms.TextBox txtRegistroSelecionado;
    }
}