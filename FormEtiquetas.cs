
using System.Windows.Forms;

namespace Programa_STPMJ
{
    public partial class FormEtiquetas : Form
    {
        public FormEtiquetas()
        {
            InitializeComponent();
        }

        private void FormEtiquetas_Load(object sender, System.EventArgs e)
        {
            reportViewer1.Dock = DockStyle.Fill;
            this.Controls.Add(reportViewer1);
            reportViewer1.RefreshReport();
            reportViewer1.Refresh();
        }
    }
}
