using System;
using System.Windows.Forms;

namespace Programa_STPMJ
{
    public partial class FormRelacaoAssociados : Form
    {
        public FormRelacaoAssociados()
        {
            InitializeComponent();
        }

        private void FormRelacaoAssociados_Load(object sender, EventArgs e)
        {
            reportViewer1.Dock = DockStyle.Fill;
            this.Controls.Add(reportViewer1);
            reportViewer1.RefreshReport();
            reportViewer1.Refresh();
        }
    }
}
