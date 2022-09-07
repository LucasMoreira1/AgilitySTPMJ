using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Programa_STPMJ
{
    public partial class FormPesquisarLancamentos : Form
    {
        public FormPesquisarLancamentos()
        {
            InitializeComponent();
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            CRUD.sql = "SELECT * FROM LANCAMENTOS ORDER BY NOME";

            CRUD.cmd = new MySqlCommand(CRUD.sql, CRUD.con);
            DataTable dt = CRUD.PerformCRUD(CRUD.cmd);
            DataGridView dgv = dataGridView1;
            dgv.MultiSelect = false;
            dgv.AutoGenerateColumns = true;

            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.DataSource = dt;

            dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = dataGridView1;
            FormLancamentos formLancamentos = new FormLancamentos();

            formLancamentos.Show();
            formLancamentos.txtControle.Text = Convert.ToString(dgv.CurrentRow.Cells[0].Value);
            formLancamentos.txtMatricula.Text = Convert.ToString(dgv.CurrentRow.Cells[1].Value);
            formLancamentos.txtNome.Text = Convert.ToString(dgv.CurrentRow.Cells[2].Value);
            formLancamentos.txtSecretaria.Text = Convert.ToString(dgv.CurrentRow.Cells[3].Value);
            formLancamentos.txtCodConvenio.Text = Convert.ToString(dgv.CurrentRow.Cells[4].Value);
            formLancamentos.txtConvenio.Text = Convert.ToString(dgv.CurrentRow.Cells[5].Value);
            formLancamentos.txtAtuacao.Text = Convert.ToString(dgv.CurrentRow.Cells[6].Value);
            formLancamentos.cboxUsuario.Text = Convert.ToString(dgv.CurrentRow.Cells[7].Value);
            formLancamentos.txtDataLancamento.Text = Convert.ToString(dgv.CurrentRow.Cells[8].Value);
            formLancamentos.txtValor.Text = Convert.ToString(dgv.CurrentRow.Cells[9].Value);
        }
    }
}
