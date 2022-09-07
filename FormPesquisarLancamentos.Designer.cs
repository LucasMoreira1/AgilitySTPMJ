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
            this.btnMostrarTodos.Location = new System.Drawing.Point(186, 23);
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
            this.txtMesAniversario.Location = new System.Drawing.Point(402, 23);
            this.txtMesAniversario.Name = "txtMesAniversario";
            this.txtMesAniversario.Size = new System.Drawing.Size(97, 26);
            this.txtMesAniversario.TabIndex = 6;
            this.txtMesAniversario.Visible = false;
            // 
            // FormPesquisarLancamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1343, 651);
            this.Controls.Add(this.txtMesAniversario);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboxMesAniversario);
            this.Controls.Add(this.btnMostrarTodos);
            this.Controls.Add(this.btnFiltroAniversario);
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
    }
}