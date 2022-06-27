using System;
using System.Windows.Forms;
using System.Data;
using MySql.Data.MySqlClient;
using Microsoft.Reporting.WinForms;

namespace Programa_STPMJ
{
    public partial class FormFichaCadastral : Form
    {
        public FormFichaCadastral()
        {
            InitializeComponent();
        }

        private void FormFichaCadastral_Load(object sender, EventArgs e)
        { 
            Socios dsSocios = GetData();
            ReportDataSource datasource = new ReportDataSource("Socios", dsSocios.Tables[0]);

            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(datasource);
            this.reportViewer1.RefreshReport();
        }
        private Socios GetData()
        {
            CRUD.sql = "SELECT * FROM SOCIOS LIMIT 50";
            
            CRUD.cmd = new MySqlCommand(CRUD.sql, CRUD.con);
            DataTable dt = CRUD.PerformCRUD(CRUD.cmd);
            MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter();
            
            sqlDataAdapter.SelectCommand = CRUD.cmd;
            Socios dsSocios = new Socios();
            dsSocios.DataSetName = "SOCIOS";
            dsSocios.CreateDataReader(dt);
            //sqlDataAdapter.Fill(dsSocios, "SOCIOS");
            return dsSocios;
                

            
            //using (MySqlDataAdapter sqlDataAdapter = new MySqlDataAdapter())
            //{
            //    sqlDataAdapter.SelectCommand = CRUD.cmd;
            //    using (Socios dsSocios = new Socios())
            //    {
            //        sqlDataAdapter.Fill(dsSocios, "SOCIOS");
            //        return dsSocios;
            //    }

            //}

        }
    }
}
