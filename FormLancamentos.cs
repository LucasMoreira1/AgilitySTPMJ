using System;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Programa_STPMJ
{
    public partial class FormLancamentos : Form
    {
        public FormLancamentos()
        {
            InitializeComponent();
        }

        private void FormLancamentos_Load(object sender, EventArgs e)
        {
            txtDataLancamento.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
        private void CarregarCbox()
        {
            CRUD.sql = "SELECT * FROM DEPENDENTES WHERE MatReferencia = " + txtMatricula.Text + ";";
            CRUD.cmd = new MySqlCommand(CRUD.sql, CRUD.con);

            DataTable dt = CRUD.PerformCRUD(CRUD.cmd);

            foreach (DataRow dr in dt.Rows)
            {
                cboxUsuario.Items.Add(dr[1]).ToString();

            }
        }



        private void btnImprimir_Click(object sender, EventArgs e)
        {
            FormChequinho formChequinho = new FormChequinho();
            //formChequinho.txtMatricula.Text = txtMatricula.Text;
            formChequinho.txtControle.Text = txtControle.Text;
            formChequinho.Show();
        }
        private void Executar(string mySQL, string param)
        {
            CRUD.cmd = new MySqlCommand(mySQL, CRUD.con);
            AddParametros(param);
            CRUD.PerformCRUD(CRUD.cmd);
        }
        private void AddParametros(string str)
        {
            CRUD.cmd.Parameters.Clear();

            //Dados sócio
            CRUD.cmd.Parameters.AddWithValue("matricula", txtMatricula.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("nome", txtNome.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("empresa", txtSecretaria.Text.Trim());
            //Dados convênio
            CRUD.cmd.Parameters.AddWithValue("cod_convenio", txtCodConvenio.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("convenio", txtConvenio.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("atuacao", txtAtuacao.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("usuario", cboxUsuario.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("data_lancamento", Convert.ToDateTime(txtDataLancamento.Text.Trim()));
            CRUD.cmd.Parameters.AddWithValue("valor", txtValor.Text.Trim());
            
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMatricula.Text.Trim()))
            {
                MessageBox.Show("Campos obrigatórios: Matricula", "Dados Obrigatórios",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            CRUD.sql = "INSERT INTO LANCAMENTOS(matricula,nome,empresa,cod_convenio,convenio,atuacao," +
                "usuario,data_lancamento,valor)" +
                "Values(@matricula,@nome,@empresa,@cod_convenio,@convenio,@atuacao,@usuario," +
                "@data_lancamento,@valor);";


            Executar(CRUD.sql, "Insert");

            CRUD.sql = "SELECT LAST_INSERT_ID()";

            CRUD.cmd = new MySqlCommand(CRUD.sql, CRUD.con);
            DataTable dt = CRUD.PerformCRUD(CRUD.cmd);


            DataGridView dgv = dataGridView1;
            dgv.Visible = true;

            dgv.MultiSelect = false;
            dgv.AutoGenerateColumns = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.DataSource = dt;
            dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            string NumeroRegistro = dgv.CurrentCell.Value.ToString();
            txtControle.Text = NumeroRegistro;
            dgv.Visible = false;

            MessageBox.Show("Lançamento realizado. Controle número: " + NumeroRegistro + ".", "Convênio",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void txtMatricula_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pesquisaSocio();
            }
        }
        public void pesquisaSocio()
        {

            CRUD.sql = "SELECT * FROM SOCIOS WHERE MATRICULA LIKE '" + txtMatricula.Text.Trim() + "'";

            CRUD.cmd = new MySqlCommand(CRUD.sql, CRUD.con);
            DataTable dt = CRUD.PerformCRUD(CRUD.cmd);
            DataGridView dgv = dataGridView1;

            dgv.Visible = true;
            dgv.MultiSelect = false;
            dgv.AutoGenerateColumns = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.DataSource = dt;
            dgv.Columns["Foto"].Visible = false;
            dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            txtMatricula.Text = Convert.ToString(dgv.CurrentRow.Cells[0].Value);
            txtNome.Text = Convert.ToString(dgv.CurrentRow.Cells[1].Value);
            txtSecretaria.Text = Convert.ToString(dgv.CurrentRow.Cells[8].Value);
            
            dgv.Visible = false;

            CarregarCbox();


        }

        private void txtCodConvenio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pesquisaConvenio();
            }
        }
        public void pesquisaConvenio()
        {

            CRUD.sql = "SELECT * FROM CONVENIO WHERE COD_CONVENIO LIKE '" + txtCodConvenio.Text.Trim() + "'";

            CRUD.cmd = new MySqlCommand(CRUD.sql, CRUD.con);
            DataTable dt = CRUD.PerformCRUD(CRUD.cmd);
            DataGridView dgv = dataGridView1;

            dgv.Visible = true;
            dgv.MultiSelect = false;
            dgv.AutoGenerateColumns = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.DataSource = dt;
            dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            txtConvenio.Text = Convert.ToString(dgv.CurrentRow.Cells[1].Value);
            txtAtuacao.Text = Convert.ToString(dgv.CurrentRow.Cells[3].Value);
            txtValor.Text = Convert.ToString(dgv.CurrentRow.Cells[4].Value);

            dgv.Visible = false;

        }

        private void txtControle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pesquisaLancamento();
            }
        }
        public void pesquisaLancamento()
        {

            CRUD.sql = "SELECT * FROM LANCAMENTOS WHERE CONTROLE LIKE '" + txtControle.Text.Trim() + "'";

            CRUD.cmd = new MySqlCommand(CRUD.sql, CRUD.con);
            DataTable dt = CRUD.PerformCRUD(CRUD.cmd);
            DataGridView dgv = dataGridView1;

            dgv.Visible = true;
            dgv.MultiSelect = false;
            dgv.AutoGenerateColumns = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.DataSource = dt;
            dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            txtMatricula.Text = Convert.ToString(dgv.CurrentRow.Cells[1].Value);
            txtNome.Text = Convert.ToString(dgv.CurrentRow.Cells[2].Value);
            txtSecretaria.Text = Convert.ToString(dgv.CurrentRow.Cells[3].Value);
            txtCodConvenio.Text = Convert.ToString(dgv.CurrentRow.Cells[4].Value);
            txtConvenio.Text = Convert.ToString(dgv.CurrentRow.Cells[5].Value);
            txtAtuacao.Text = Convert.ToString(dgv.CurrentRow.Cells[6].Value);
            cboxUsuario.Text = Convert.ToString(dgv.CurrentRow.Cells[7].Value);
            txtDataLancamento.Text = Convert.ToString(dgv.CurrentRow.Cells[8].Value);
            txtValor.Text = Convert.ToString(dgv.CurrentRow.Cells[9].Value);


            dgv.Visible = false;

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtControle.Text = "";
            txtMatricula.Text = "";
            txtNome.Text = "";
            txtSecretaria.Text = "";
            txtCodConvenio.Text = "";
            txtConvenio.Text = "";
            txtAtuacao.Text = "";
            cboxUsuario.Text = "";
            txtDataLancamento.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtValor.Text = "";
        }
    }
}
