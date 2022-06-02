using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.IO;
using System.Drawing;

namespace Programa_STPMJ
{

    public partial class FormPesquisa : Form
    {
        private int row = 0;
        private string id = "";
        MySqlDataReader reader;
        public FormPesquisa()
        {
            InitializeComponent();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            loadData();
        }

        public void btnPesquisar_Click(object sender, EventArgs e)
        {
            loadFiltro();
        }

        public void loadFiltro()
        {
            CRUD.sql = "SELECT * FROM SOCIOS WHERE " + cboxFiltro2.Text.Trim() + " LIKE '%" + txtFiltro2.Text.Trim() + "%' AND " +
              "" + cboxFiltro3.Text.Trim() + " LIKE '%" + txtFiltro3.Text.Trim() + "%';";

            CRUD.cmd = new MySqlCommand(CRUD.sql, CRUD.con);
            DataTable dt = CRUD.PerformCRUD(CRUD.cmd);

            DataGridView dgv = dataGridView1;

            dgv.MultiSelect = false;
            dgv.AutoGenerateColumns = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.DataSource = dt;
            dgv.Columns["Foto"].Visible = false;
            dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            
        }

        private void loadData()
        {
            CRUD.sql = "SELECT * FROM SOCIOS LIMIT 50";
            //CRUD.sql = "SELECT * FROM SOCIOS WHERE 1";

            CRUD.cmd = new MySqlCommand(CRUD.sql, CRUD.con);
            DataTable dt = CRUD.PerformCRUD(CRUD.cmd);
            DataGridView dgv = dataGridView1;
            dgv.MultiSelect = false;
            dgv.AutoGenerateColumns = true;

            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.DataSource = dt;

            //dgv.Columns["Matricula"].Visible = true;
            //dgv.Columns["Nome"].Visible = true;
            dgv.Columns["Foto"].Visible = false;


            dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = dataGridView1;
            FormCadastro formcadastro = new FormCadastro();

            //reader = CRUD.cmd.ExecuteReader();
            //if (reader.Read())
            //{
            //    byte[] img = (byte[])(reader["foto"]);
            //    MemoryStream ms = new MemoryStream(img);
            //    formcadastro.imgCamera.Image = Image.FromStream(ms);
            //}

            formcadastro.btnSalvar.Visible = false;
            formcadastro.btnAtualizar.Visible = true;
            formcadastro.Show();
            formcadastro.txtMatricula.Text = Convert.ToString(dgv.CurrentRow.Cells[0].Value);
            formcadastro.txtNome.Text = Convert.ToString(dgv.CurrentRow.Cells[1].Value);
            formcadastro.txtRG.Text = Convert.ToString(dgv.CurrentRow.Cells[2].Value);
            formcadastro.txtCPF.Text = Convert.ToString(dgv.CurrentRow.Cells[3].Value);
            formcadastro.txtDataNascimento.Text = Convert.ToString(dgv.CurrentRow.Cells[4].Value);
            formcadastro.cboxEstadoCivil.Text = Convert.ToString(dgv.CurrentRow.Cells[5].Value);
            formcadastro.txtNacionalidade.Text = Convert.ToString(dgv.CurrentRow.Cells[6].Value);
            formcadastro.txtDataCadastro.Text = Convert.ToString(dgv.CurrentRow.Cells[7].Value);
            formcadastro.cboxEmpresa.Text = Convert.ToString(dgv.CurrentRow.Cells[8].Value);
            formcadastro.txtFuncao.Text = Convert.ToString(dgv.CurrentRow.Cells[9].Value);
            formcadastro.txtAdmissao.Text = Convert.ToString(dgv.CurrentRow.Cells[10].Value);
            formcadastro.txtLocalTrabalho.Text = Convert.ToString(dgv.CurrentRow.Cells[11].Value);
            formcadastro.txtTelefone.Text = Convert.ToString(dgv.CurrentRow.Cells[12].Value);
            formcadastro.txtRecado.Text = Convert.ToString(dgv.CurrentRow.Cells[13].Value);
            formcadastro.txtEmail.Text = Convert.ToString(dgv.CurrentRow.Cells[14].Value);
            formcadastro.txtCEP.Text = Convert.ToString(dgv.CurrentRow.Cells[15].Value);
            formcadastro.txtLogradouro.Text = Convert.ToString(dgv.CurrentRow.Cells[16].Value);
            formcadastro.txtNumero.Text = Convert.ToString(dgv.CurrentRow.Cells[17].Value);
            formcadastro.txtComplemento.Text = Convert.ToString(dgv.CurrentRow.Cells[18].Value);
            formcadastro.txtBairro.Text = Convert.ToString(dgv.CurrentRow.Cells[19].Value);
            formcadastro.txtCidade.Text = Convert.ToString(dgv.CurrentRow.Cells[20].Value);
            formcadastro.txtEstado.Text = Convert.ToString(dgv.CurrentRow.Cells[21].Value);
            formcadastro.txtLimite.Text = Convert.ToString(dgv.CurrentRow.Cells[22].Value);
            formcadastro.txtDisponivel.Text = Convert.ToString(dgv.CurrentRow.Cells[23].Value);
            formcadastro.txtObservacao.Text = Convert.ToString(dgv.CurrentRow.Cells[24].Value);
            MemoryStream ms = new MemoryStream((byte[])dgv.CurrentRow.Cells[25].Value);
            formcadastro.imgCamera.Image = Image.FromStream(ms);
            formcadastro.txtRegistro.Text = Convert.ToString(dgv.CurrentRow.Cells[26].Value);

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridView dgv = dataGridView1;
                this.id = Convert.ToString(dgv.CurrentRow.Cells[0].Value);
                txtRegistroSelecionado.Text = Convert.ToString(dgv.CurrentRow.Cells[26].Value);
                btnAtualizar.Text = "Atualizar (" + this.id + ")";
                btnDeletar.Text = "Deletar (" + this.id + ")";

            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            DataGridView dgv = dataGridView1;
            FormCadastro formcadastro = new FormCadastro();
            formcadastro.btnSalvar.Visible = false;
            formcadastro.btnAtualizar.Visible = true;
            formcadastro.Show();
            formcadastro.txtMatricula.Text = Convert.ToString(dgv.CurrentRow.Cells[0].Value);
            formcadastro.txtNome.Text = Convert.ToString(dgv.CurrentRow.Cells[1].Value);
            formcadastro.txtRG.Text = Convert.ToString(dgv.CurrentRow.Cells[2].Value);
            formcadastro.txtCPF.Text = Convert.ToString(dgv.CurrentRow.Cells[3].Value);
            formcadastro.txtDataNascimento.Text = Convert.ToString(dgv.CurrentRow.Cells[4].Value);
            formcadastro.cboxEstadoCivil.Text = Convert.ToString(dgv.CurrentRow.Cells[5].Value);
            formcadastro.txtNacionalidade.Text = Convert.ToString(dgv.CurrentRow.Cells[6].Value);
            formcadastro.txtDataCadastro.Text = Convert.ToString(dgv.CurrentRow.Cells[7].Value);
            formcadastro.cboxEmpresa.Text = Convert.ToString(dgv.CurrentRow.Cells[8].Value);
            formcadastro.txtFuncao.Text = Convert.ToString(dgv.CurrentRow.Cells[9].Value);
            formcadastro.txtAdmissao.Text = Convert.ToString(dgv.CurrentRow.Cells[10].Value);
            formcadastro.txtLocalTrabalho.Text = Convert.ToString(dgv.CurrentRow.Cells[11].Value);
            formcadastro.txtTelefone.Text = Convert.ToString(dgv.CurrentRow.Cells[12].Value);
            formcadastro.txtRecado.Text = Convert.ToString(dgv.CurrentRow.Cells[13].Value);
            formcadastro.txtEmail.Text = Convert.ToString(dgv.CurrentRow.Cells[14].Value);
            formcadastro.txtCEP.Text = Convert.ToString(dgv.CurrentRow.Cells[15].Value);
            formcadastro.txtLogradouro.Text = Convert.ToString(dgv.CurrentRow.Cells[16].Value);
            formcadastro.txtNumero.Text = Convert.ToString(dgv.CurrentRow.Cells[17].Value);
            formcadastro.txtComplemento.Text = Convert.ToString(dgv.CurrentRow.Cells[18].Value);
            formcadastro.txtBairro.Text = Convert.ToString(dgv.CurrentRow.Cells[19].Value);
            formcadastro.txtCidade.Text = Convert.ToString(dgv.CurrentRow.Cells[20].Value);
            formcadastro.txtEstado.Text = Convert.ToString(dgv.CurrentRow.Cells[21].Value);
            formcadastro.txtLimite.Text = Convert.ToString(dgv.CurrentRow.Cells[22].Value);
            formcadastro.txtDisponivel.Text = Convert.ToString(dgv.CurrentRow.Cells[23].Value);
            formcadastro.txtObservacao.Text = Convert.ToString(dgv.CurrentRow.Cells[24].Value);

            formcadastro.txtRegistro.Text = Convert.ToString(dgv.CurrentRow.Cells[26].Value);

        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            DataGridView dgv = dataGridView1;

            if (dgv.Rows.Count == 0)
            {
                return;
            }
            if (string.IsNullOrEmpty(this.id))
            {
                MessageBox.Show("Por favor, selecione um item da lista.", "Deletar dados",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            int registroSelecionado = Convert.ToInt32(txtRegistroSelecionado.Text);

            if(MessageBox.Show("Tem certeza que deseja deletar os dados selecionados?","Deletar Dados",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CRUD.sql = "DELETE FROM SOCIOS WHERE RegistroSindical = " + registroSelecionado + "";
                CRUD.cmd = new MySqlCommand(CRUD.sql, CRUD.con);
                CRUD.PerformCRUD(CRUD.cmd);

                MessageBox.Show("Dados deletados com sucesso.", "Deletar dados",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                loadData();
            }
        }
        private void FormPesquisa_Load(object sender, EventArgs e)
        {
            //loadData("");
        }

        public void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnPesquisar_Click(sender,e);
        }

        private void filtro1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                filtro1();
        }

        private void filtro1()
        {
            CRUD.sql = "SELECT * FROM SOCIOS WHERE " + txtFiltroMatricula.Text.Trim() + " LIKE '" + txtFiltro1.Text.Trim() + "'";

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
            dgv.Columns["Foto"].Visible = false;
            dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void MostrarCalendario1(object sender, EventArgs e)
        {
            calendario1.Visible = true;
        }

        private void calendario1_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtData1Convert.Text = calendario1.SelectionStart.Date.ToString("yyyy/MM/dd");
            txtData1.Text = calendario1.SelectionStart.Date.ToString("dd/MM/yyyy");
            calendario1.Visible = false;
        }

        private void MostrarCalendario2(object sender, EventArgs e)
        {
            calendario2.Visible = true;
        }

        private void calendario2_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtData2Convert.Text = calendario2.SelectionStart.Date.ToString("yyyy/MM/dd");
            txtData2.Text = calendario2.SelectionStart.Date.ToString("dd/MM/yyyy");
            calendario2.Visible = false;
        }

        private void btnFiltroAniversario_Click(object sender, EventArgs e)
        {
            CRUD.sql = "SELECT * FROM SOCIOS WHERE MONTH(DATANASCIMENTO)= " + txtMesAniversario.Text + "";

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

            //dgv.Columns["Matricula"].Visible = true;
            //dgv.Columns["Nome"].Visible = true;
            dgv.Columns["Foto"].Visible = false;


            dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void btnFiltroCadastro_Click(object sender, EventArgs e)
        {
            DateTime d1 = DateTime.Parse(txtData1.Text);
            txtData1Convert.Text = d1.ToString("yyyy/MM/dd");
            DateTime d2 = DateTime.Parse(txtData2.Text);
            txtData2Convert.Text = d2.ToString("yyyy/MM/dd");

            var data1 = txtData1Convert.Text;
            var data2 = txtData2Convert.Text;

            CRUD.sql = "SELECT * FROM `SOCIOS` WHERE `DataCadastro` BETWEEN '" + data1 + "' AND '" + data2 + "' ;";


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
            dgv.Columns["Foto"].Visible = false;
            dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void cboxMesAniversario_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboxMesAniversario.SelectedIndex)
            {
                case 0:
                    txtMesAniversario.Text = "01";
                    break;

                case 1:
                    txtMesAniversario.Text = "02";
                    break;

                case 2:
                    txtMesAniversario.Text = "03";
                    break;

                case 3:
                    txtMesAniversario.Text = "04";
                    break;

                case 4:
                    txtMesAniversario.Text = "05";
                    break;

                case 5:
                    txtMesAniversario.Text = "06";
                    break;

                case 6:
                    txtMesAniversario.Text = "07";
                    break;

                case 7:
                    txtMesAniversario.Text = "08";
                    break;

                case 8:
                    txtMesAniversario.Text = "09";
                    break;

                case 9:
                    txtMesAniversario.Text = "10";
                    break;

                case 10:
                    txtMesAniversario.Text = "11";
                    break;

                case 11:
                    txtMesAniversario.Text = "12";
                    break;
            }
        }

    }
}
