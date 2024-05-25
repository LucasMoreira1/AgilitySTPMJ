namespace Programa_STPMJ
{
    partial class FormLancamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLancamentos));
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSecretaria = new System.Windows.Forms.TextBox();
            this.txtConvenio = new System.Windows.Forms.TextBox();
            this.txtCodConvenio = new System.Windows.Forms.TextBox();
            this.txtAtuacao = new System.Windows.Forms.TextBox();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.cboxUsuario = new System.Windows.Forms.ComboBox();
            this.txtDataLancamento = new System.Windows.Forms.MaskedTextBox();
            this.txtControle = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnImprimir = new FontAwesome.Sharp.IconButton();
            this.btnRegistrar = new FontAwesome.Sharp.IconButton();
            this.btnLimpar = new FontAwesome.Sharp.IconButton();
            this.btnAtualizar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(364, 146);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNome.Name = "txtNome";
            this.txtNome.ReadOnly = true;
            this.txtNome.Size = new System.Drawing.Size(608, 30);
            this.txtNome.TabIndex = 2;
            // 
            // txtMatricula
            // 
            this.txtMatricula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMatricula.Location = new System.Drawing.Point(192, 146);
            this.txtMatricula.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(163, 30);
            this.txtMatricula.TabIndex = 1;
            this.txtMatricula.TextChanged += new System.EventHandler(this.txtMatricula_TextChanged);
            this.txtMatricula.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtMatricula_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 96);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Controle";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 150);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Matricula";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 204);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Empresa";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(40, 258);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cod. Convênio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(40, 313);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Convênio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(40, 367);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Usuário";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(40, 421);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(122, 25);
            this.label7.TabIndex = 4;
            this.label7.Text = "Data Lançto.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(733, 421);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 25);
            this.label8.TabIndex = 4;
            this.label8.Text = "Valor";
            // 
            // txtSecretaria
            // 
            this.txtSecretaria.Enabled = false;
            this.txtSecretaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecretaria.Location = new System.Drawing.Point(192, 201);
            this.txtSecretaria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSecretaria.Name = "txtSecretaria";
            this.txtSecretaria.ReadOnly = true;
            this.txtSecretaria.Size = new System.Drawing.Size(780, 30);
            this.txtSecretaria.TabIndex = 3;
            // 
            // txtConvenio
            // 
            this.txtConvenio.Enabled = false;
            this.txtConvenio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConvenio.Location = new System.Drawing.Point(192, 309);
            this.txtConvenio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtConvenio.Name = "txtConvenio";
            this.txtConvenio.ReadOnly = true;
            this.txtConvenio.Size = new System.Drawing.Size(608, 30);
            this.txtConvenio.TabIndex = 5;
            // 
            // txtCodConvenio
            // 
            this.txtCodConvenio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodConvenio.Location = new System.Drawing.Point(192, 255);
            this.txtCodConvenio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCodConvenio.Name = "txtCodConvenio";
            this.txtCodConvenio.Size = new System.Drawing.Size(163, 30);
            this.txtCodConvenio.TabIndex = 4;
            this.txtCodConvenio.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodConvenio_KeyDown);
            // 
            // txtAtuacao
            // 
            this.txtAtuacao.Enabled = false;
            this.txtAtuacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAtuacao.Location = new System.Drawing.Point(809, 309);
            this.txtAtuacao.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAtuacao.Name = "txtAtuacao";
            this.txtAtuacao.ReadOnly = true;
            this.txtAtuacao.Size = new System.Drawing.Size(163, 30);
            this.txtAtuacao.TabIndex = 6;
            // 
            // txtValor
            // 
            this.txtValor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValor.Location = new System.Drawing.Point(809, 417);
            this.txtValor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(163, 30);
            this.txtValor.TabIndex = 9;
            // 
            // cboxUsuario
            // 
            this.cboxUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxUsuario.FormattingEnabled = true;
            this.cboxUsuario.Location = new System.Drawing.Point(192, 364);
            this.cboxUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cboxUsuario.Name = "cboxUsuario";
            this.cboxUsuario.Size = new System.Drawing.Size(608, 30);
            this.cboxUsuario.TabIndex = 7;
            // 
            // txtDataLancamento
            // 
            this.txtDataLancamento.Enabled = false;
            this.txtDataLancamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataLancamento.Location = new System.Drawing.Point(192, 417);
            this.txtDataLancamento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDataLancamento.Mask = "00/00/0000";
            this.txtDataLancamento.Name = "txtDataLancamento";
            this.txtDataLancamento.ReadOnly = true;
            this.txtDataLancamento.Size = new System.Drawing.Size(163, 30);
            this.txtDataLancamento.TabIndex = 8;
            this.txtDataLancamento.ValidatingType = typeof(System.DateTime);
            // 
            // txtControle
            // 
            this.txtControle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtControle.Location = new System.Drawing.Point(192, 92);
            this.txtControle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtControle.Name = "txtControle";
            this.txtControle.Size = new System.Drawing.Size(163, 30);
            this.txtControle.TabIndex = 0;
            this.txtControle.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtControle_KeyDown);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(191, 26);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(585, 31);
            this.label9.TabIndex = 15;
            this.label9.Text = "Tela para Lançamento de Pedidos de Convênio";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(45, 490);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(95, 76);
            this.dataGridView1.TabIndex = 16;
            this.dataGridView1.Visible = false;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnImprimir.IconColor = System.Drawing.Color.Black;
            this.btnImprimir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnImprimir.Location = new System.Drawing.Point(617, 523);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(113, 43);
            this.btnImprimir.TabIndex = 10;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnRegistrar.IconColor = System.Drawing.Color.Black;
            this.btnRegistrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRegistrar.Location = new System.Drawing.Point(860, 523);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(113, 43);
            this.btnRegistrar.TabIndex = 11;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnLimpar.IconColor = System.Drawing.Color.Black;
            this.btnLimpar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpar.Location = new System.Drawing.Point(739, 523);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(113, 43);
            this.btnLimpar.TabIndex = 10;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtualizar.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAtualizar.IconColor = System.Drawing.Color.Black;
            this.btnAtualizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAtualizar.Location = new System.Drawing.Point(859, 455);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(113, 43);
            this.btnAtualizar.TabIndex = 17;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // FormLancamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 622);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtControle);
            this.Controls.Add(this.txtDataLancamento);
            this.Controls.Add(this.cboxUsuario);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.txtAtuacao);
            this.Controls.Add(this.txtConvenio);
            this.Controls.Add(this.txtSecretaria);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtCodConvenio);
            this.Controls.Add(this.txtMatricula);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormLancamentos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lançamentos";
            this.Load += new System.EventHandler(this.FormLancamentos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtNome;
        public System.Windows.Forms.TextBox txtMatricula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox txtSecretaria;
        public System.Windows.Forms.TextBox txtConvenio;
        public System.Windows.Forms.TextBox txtCodConvenio;
        public System.Windows.Forms.TextBox txtAtuacao;
        public System.Windows.Forms.TextBox txtValor;
        public System.Windows.Forms.TextBox txtControle;
        public FontAwesome.Sharp.IconButton btnRegistrar;
        public FontAwesome.Sharp.IconButton btnImprimir;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.ComboBox cboxUsuario;
        public System.Windows.Forms.MaskedTextBox txtDataLancamento;
        public FontAwesome.Sharp.IconButton btnLimpar;
        public FontAwesome.Sharp.IconButton btnAtualizar;
    }
}