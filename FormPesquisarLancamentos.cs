using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Programa_STPMJ
{
    public partial class FormPesquisarLancamentos : Form
    {
        private string id = "";
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

        private void btnFiltroAniversario_Click(object sender, EventArgs e)
        {
            CRUD.sql = "SELECT * FROM LANCAMENTOS WHERE MONTH(DATA_LANCAMENTO)= " + txtMesAniversario.Text + " ORDER BY NOME";

            CRUD.cmd = new MySqlCommand(CRUD.sql, CRUD.con);
            DataTable dt = CRUD.PerformCRUD(CRUD.cmd);

            DataGridView dgv = dataGridView1;

            dgv.MultiSelect = false;
            dgv.AutoGenerateColumns = true;

            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.DataSource = dt;

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

        private void btnFiltroCadastro_Click(object sender, EventArgs e)
        {
            DateTime d1 = DateTime.Parse(txtData1.Text);
            txtData1Convert.Text = d1.ToString("yyyy/MM/dd");
            DateTime d2 = DateTime.Parse(txtData2.Text);
            txtData2Convert.Text = d2.ToString("yyyy/MM/dd");

            var data1 = txtData1Convert.Text;
            var data2 = txtData2Convert.Text;

            CRUD.sql = "SELECT * FROM `LANCAMENTOS` WHERE `DATA_LANCAMENTO` BETWEEN '" + data1 + "' AND '" + data2 + "' ORDER BY NOME;";


            CRUD.cmd = new MySqlCommand(CRUD.sql, CRUD.con);
            DataTable dt = CRUD.PerformCRUD(CRUD.cmd);

            DataGridView dgv = dataGridView1;

            dgv.MultiSelect = false;
            dgv.AutoGenerateColumns = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.DataSource = dt;
            //dgv.Columns["Foto"].Visible = false;
            dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        private void txtData1_DoubleClick(object sender, EventArgs e)
        {
            calendario1.Visible = true;
        }

        private void txtData2_DoubleClick(object sender, EventArgs e)
        {
            calendario2.Visible = true;
        }

        private void calendario1_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtData1Convert.Text = calendario1.SelectionStart.Date.ToString("yyyy/MM/dd");
            txtData1.Text = calendario1.SelectionStart.Date.ToString("dd/MM/yyyy");
            calendario1.Visible = false;
        }

        private void calendario2_DateSelected(object sender, DateRangeEventArgs e)
        {
            txtData2Convert.Text = calendario2.SelectionStart.Date.ToString("yyyy/MM/dd");
            txtData2.Text = calendario2.SelectionStart.Date.ToString("dd/MM/yyyy");
            calendario2.Visible = false;
        }

        private void btnExportarExcel_Click(object sender, EventArgs e)
        {
            // creating Excel Application  
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // see the excel sheet behind the program  
            app.Visible = true;
            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  
            worksheet = workbook.Sheets["Planilha1"];
            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "Exportado da tabela";
            // storing header part in Excel  
            for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }
            MessageBox.Show("Exportação realizada.", "Exportação",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            // save the application  
            //workbook.SaveAs("c:\\output.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            // Exit from the application  
            //app.Quit();
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

            if (MessageBox.Show("Tem certeza que deseja deletar os dados selecionados?", "Deletar Dados",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                CRUD.sql = "DELETE FROM LANCAMENTOS WHERE RegistroSindical = " + registroSelecionado + "";
                CRUD.cmd = new MySqlCommand(CRUD.sql, CRUD.con);
                CRUD.PerformCRUD(CRUD.cmd);

                MessageBox.Show("Dados deletados com sucesso.", "Deletar dados",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

                
            }
        }
    }
}
