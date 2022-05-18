using System;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


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
    }
}
