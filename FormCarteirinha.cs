using Microsoft.Reporting.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Programa_STPMJ
{
    public partial class FormCarteirinha : Form
    {
        public FormCarteirinha()
        {
            InitializeComponent();
        }

        private void FormCarteirinha_Load(object sender, EventArgs e)
        {
            Socios dsSocios = GetSocios();
            Dependentes dsDependentes = GetDependentes();
            Fotos dsFotos = GetFotos();
            ReportDataSource datasource1 = new ReportDataSource("Socios", dsSocios.Tables[1]);
            ReportDataSource datasource2 = new ReportDataSource("Dependentes", dsDependentes.Tables[1]);
            ReportDataSource datasource3 = new ReportDataSource("Fotos", dsFotos.Tables[1]);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(datasource1);
            this.reportViewer1.LocalReport.DataSources.Add(datasource2);
            this.reportViewer1.LocalReport.DataSources.Add(datasource3);
            this.reportViewer1.RefreshReport();
        }

        private static string getConnectionString()
        {
            //string conString = "Server=108.167.132.199;Database=soluc963_STPMJ;Uid=soluc963_STPMJ;Pwd=R~X4ro$%K18b; ";
            //string conString = "Server=187.95.26.193;Port=3306;Database=soluc963_STPMJ;Uid=
            //;Pwd=!Parrudo292701;";
            //string conString = "Server=mysql-agility.advogadodigital.click;Port=3306;Database=soluc963_STPMJ;Uid=Agility;Pwd=!Parrudo292701;";
            string conString = "Server=192.168.15.29;Port=3306;Database=soluc963_STPMJ;Uid=stpmj;Pwd=!Stpmj292701;";
            return conString;
        }



        private Socios GetSocios()
        {


            using (MySqlConnection con = new MySqlConnection(getConnectionString()))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM SOCIOS WHERE MATRICULA LIKE '" + txtMatricula.Text.Trim() + "'"))
                {
                    using (MySqlDataAdapter sda = new MySqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;

                        using (Socios dsSocios = new Socios())
                        {
                            sda.Fill(dsSocios);
                            return dsSocios;
                        }

                    }
                }
            }
        }
        private Dependentes GetDependentes()
        {


            using (MySqlConnection con = new MySqlConnection(getConnectionString()))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM DEPENDENTES WHERE MatReferencia = " + txtMatricula.Text + ";"))
                {
                    using (MySqlDataAdapter sda = new MySqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;

                        using (Dependentes dsDependentes = new Dependentes())
                        {
                            sda.Fill(dsDependentes);
                            return dsDependentes;
                        }

                    }
                }
            }
        }
        private Fotos GetFotos()
        {


            using (MySqlConnection con = new MySqlConnection(getConnectionString()))
            {
                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM FOTOS WHERE SOCIO_ID = " + txtMatricula.Text + ";"))
                {
                    using (MySqlDataAdapter sda = new MySqlDataAdapter())
                    {
                        cmd.Connection = con;
                        sda.SelectCommand = cmd;

                        using (Fotos dsFotos = new Fotos())
                        {
                            sda.Fill(dsFotos);
                            return dsFotos;
                        }

                    }
                }
            }
        }
    }
}
