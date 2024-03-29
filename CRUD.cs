﻿using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Programa_STPMJ
{
    class CRUD
    {
        private static string getConnectionString()
        {
            string conString = "Server=108.167.132.199;Database=soluc963_STPMJ;Uid=soluc963_STPMJ;Pwd=R~X4ro$%K18b; ";
            return conString;
        }

        public static MySqlConnection con = new MySqlConnection(getConnectionString());
        public static MySqlCommand cmd = default(MySqlCommand);
        public static string sql = string.Empty;

        public static DataTable PerformCRUD(MySqlCommand com)
        {
            MySqlDataAdapter da = default(MySqlDataAdapter);
            DataTable dt = new DataTable();

            try
            {
                da = new MySqlDataAdapter();
                da.SelectCommand = com;
                da.Fill(dt);
                return dt;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Ocorreu um erro: " + ex.Message,
                    "Operação CRUD Falhou : Contate o ADM",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                dt = null;
            }
            return dt;
        }
    }
}
