﻿using Microsoft.Reporting.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

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
            string conString = "Server=108.167.132.199;Database=soluc963_STPMJ;Uid=soluc963_STPMJ;Pwd=R~X4ro$%K18b; ";
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
