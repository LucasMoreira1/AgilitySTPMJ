using System;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;
using MySql.Data.MySqlClient;

namespace Programa_STPMJ
{
    public partial class FormChequinho : Form
    {
        public FormChequinho()
        {
            InitializeComponent();
        }

        private void FormChequinho_Load(object sender, EventArgs e)
        {
            //Socios dsSocios = GetSocios();
            Convenio dsConvenio = GetConvenio();
            //ReportDataSource datasource1 = new ReportDataSource("Socios", dsSocios.Tables[1]);
            ReportDataSource datasource2 = new ReportDataSource("Convenio", dsConvenio.Tables[1]);
            this.reportViewer1.LocalReport.DataSources.Clear();
            //this.reportViewer1.LocalReport.DataSources.Add(datasource1);
            this.reportViewer1.LocalReport.DataSources.Add(datasource2);
            this.reportViewer1.RefreshReport();
        }
        private static string getConnectionString()
        {
            string conString = "Server=108.167.132.199;Database=soluc963_STPMJ;Uid=soluc963_STPMJ;Pwd=R~X4ro$%K18b; ";
            return conString;
        }
        //private Socios GetSocios()
        //{


        //    using (MySqlConnection con = new MySqlConnection(getConnectionString()))
        //    {
        //        using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM SOCIOS WHERE MATRICULA LIKE '" + txtMatricula.Text.Trim() + "'"))
        //        {
        //            using (MySqlDataAdapter sda = new MySqlDataAdapter())
        //            {
        //                cmd.Connection = con;
        //                sda.SelectCommand = cmd;

        //                using (Socios dsSocios = new Socios())
        //                {
        //                    sda.Fill(dsSocios);
        //                    return dsSocios;
        //                }

        //            }
        //        }
        //    }
        //}
        private Convenio GetConvenio()
        {


            using (MySqlConnection con = new MySqlConnection(getConnectionString()))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM LANCAMENTOS WHERE CONTROLE = " + txtControle.Text + ";"))
                {
                    using (MySqlDataAdapter sda = new MySqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;

                        using (Convenio dsConvenio = new Convenio())
                        {
                            sda.Fill(dsConvenio);
                            return dsConvenio;
                        }

                    }
                }
            }
        }
    }
}
