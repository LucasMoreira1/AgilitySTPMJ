namespace Programa_STPMJ
{
    partial class FormEtiquetas
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
            this.txtMatriculaDependente = new System.Windows.Forms.TextBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // txtMatriculaDependente
            // 
            this.txtMatriculaDependente.Location = new System.Drawing.Point(431, 192);
            this.txtMatriculaDependente.Name = "txtMatriculaDependente";
            this.txtMatriculaDependente.Size = new System.Drawing.Size(112, 20);
            this.txtMatriculaDependente.TabIndex = 8;
            this.txtMatriculaDependente.Visible = false;
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(278, 192);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(112, 20);
            this.txtMatricula.TabIndex = 7;
            this.txtMatricula.Visible = false;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Programa_STPMJ.reportEtiquetas.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 665);
            this.reportViewer1.TabIndex = 6;
            // 
            // FormEtiquetas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 665);
            this.Controls.Add(this.txtMatriculaDependente);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormEtiquetas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Etiquetas";
            this.Load += new System.EventHandler(this.FormEtiquetas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtMatriculaDependente;
        public System.Windows.Forms.TextBox txtMatricula;
        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}