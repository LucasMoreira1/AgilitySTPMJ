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
            //Socios dsSocios = GetData();
            //ReportDataSource datasource = new ReportDataSource("Socios", dsSocios.Tables[0]);

            //this.reportViewer1.LocalReport.DataSources.Clear();
            //this.reportViewer1.LocalReport.DataSources.Add(datasource);
            //this.reportViewer1.RefreshReport();

            Socios dsCustomers = GetData();
            ReportDataSource datasource = new ReportDataSource("Socios", dsCustomers.Tables[1]);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(datasource);
            this.reportViewer1.RefreshReport();
        }
        private static string getConnectionString()
        {
            string conString = "Server=108.167.132.199;Database=soluc963_STPMJ;Uid=soluc963_STPMJ;Pwd=R~X4ro$%K18b; ";
            return conString;
        }

        

        private Socios GetData()
        {


            using (MySqlConnection con = new MySqlConnection(getConnectionString()))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM SOCIOS LIMIT 1"))
                {
                    using (MySqlDataAdapter sda = new MySqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;

                        using (Socios dsCustomers = new Socios())
                        { 
                            sda.Fill(dsCustomers);
                            return dsCustomers;
                        }
                       
                    }
                }
            }
        }

    }
}
