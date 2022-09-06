using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;


namespace Programa_STPMJ
{
    public partial class FormDependentes : Form
    {
        public FormDependentes()
        {
            InitializeComponent();
        }

        private void FormDependentes_Load(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void CarregarDados()
        {
            CRUD.sql = "SELECT * FROM DEPENDENTES WHERE MatReferencia = " + txtMatReferencia.Text + ";";
            CRUD.cmd = new MySqlCommand(CRUD.sql, CRUD.con);


            DataTable dt = CRUD.PerformCRUD(CRUD.cmd);

            //if (dt.Rows.Count > 0)
            //{
            //    row = Convert.ToInt32(dt.Rows.Count.ToString());
            //}
            //else
            //{
            //    row = 0;
            //}

            //toolStripStatusLabel1.Text = "Número de linha(s): " + row.ToString();

            DataGridView dgv = dataGridView1;

            dgv.MultiSelect = false;
            dgv.AutoGenerateColumns = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.DataSource = dt;
            dgv.Columns["MatReferencia"].Visible = false;
            dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void btnExluir_Click(object sender, EventArgs e)
        {
            string registroSelecionado = txtSelecionado.Text.Trim();


            if (MessageBox.Show("Tem certeza que deseja deletar os dados selecionados?", "Deletar Dados",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CRUD.sql = "DELETE FROM DEPENDENTES WHERE MatReferencia = '" + txtMatReferencia.Text + "' AND NOME = '" + registroSelecionado + "'";
                CRUD.cmd = new MySqlCommand(CRUD.sql, CRUD.con);
                CRUD.PerformCRUD(CRUD.cmd);

                MessageBox.Show("Dados deletados com sucesso.", "Deletar dados",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                CarregarDados();
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            CarregarDados();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            DataGridView dgv = dataGridView1;
            FormCadastro formcadastro = new FormCadastro();


            formcadastro.btnSalvar.Visible = false;
            formcadastro.btnAtualizar.Visible = true;
            formcadastro.btnAdcDependente.Visible = false;
            formcadastro.btnAtualizarDependente.Visible = true;
            formcadastro.Show();

            formcadastro.txtMatricula.Text = txtMatReferencia.Text.Trim();

            formcadastro.txtNomeDependente.Text = Convert.ToString(dgv.CurrentRow.Cells[1].Value);
            formcadastro.txtGrauParentesco.Text = Convert.ToString(dgv.CurrentRow.Cells[3].Value);
            formcadastro.txtDataNascimentoDependente.Text = Convert.ToString(dgv.CurrentRow.Cells[2].Value);
            formcadastro.pesquisa();



        }

        private void SelecionarDependente(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridView dgv = dataGridView1;
                //this.id = Convert.ToString(dgv.CurrentRow.Cells[0].Value);
                txtSelecionado.Text = Convert.ToString(dgv.CurrentRow.Cells[1].Value);

            }
        }

        private void EditarDependente(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = dataGridView1;
            FormCadastro formcadastro = new FormCadastro();


            formcadastro.btnSalvar.Visible = false;
            formcadastro.btnAtualizar.Visible = true;
            formcadastro.btnAdcDependente.Visible = false;
            formcadastro.btnAtualizarDependente.Visible = true;
            formcadastro.Show();

            formcadastro.txtMatricula.Text = txtMatReferencia.Text.Trim();

            formcadastro.txtNomeDependente.Text = Convert.ToString(dgv.CurrentRow.Cells[1].Value);
            formcadastro.txtGrauParentesco.Text = Convert.ToString(dgv.CurrentRow.Cells[3].Value);
            formcadastro.txtDataNascimentoDependente.Text = Convert.ToString(dgv.CurrentRow.Cells[2].Value);
            formcadastro.pesquisa();
        }
    }
}
