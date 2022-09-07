namespace Programa_STPMJ
{
    partial class FormChequinho
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
            this.txtControle = new System.Windows.Forms.TextBox();
            this.txtMatricula = new System.Windows.Forms.TextBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // txtControle
            // 
            this.txtControle.Location = new System.Drawing.Point(431, 192);
            this.txtControle.Name = "txtControle";
            this.txtControle.Size = new System.Drawing.Size(112, 20);
            this.txtControle.TabIndex = 5;
            this.txtControle.Visible = false;
            // 
            // txtMatricula
            // 
            this.txtMatricula.Location = new System.Drawing.Point(278, 192);
            this.txtMatricula.Name = "txtMatricula";
            this.txtMatricula.Size = new System.Drawing.Size(112, 20);
            this.txtMatricula.TabIndex = 4;
            this.txtMatricula.Visible = false;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Programa_STPMJ.reportChequinho.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 665);
            this.reportViewer1.TabIndex = 3;
            // 
            // FormChequinho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 665);
            this.Controls.Add(this.txtControle);
            this.Controls.Add(this.txtMatricula);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormChequinho";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormChequinho";
            this.Load += new System.EventHandler(this.FormChequinho_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtControle;
        public System.Windows.Forms.TextBox txtMatricula;
        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}