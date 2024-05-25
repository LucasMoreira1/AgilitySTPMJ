using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace Programa_STPMJ
{
    class CRUD
    {
        private static string getConnectionString()
        {
            //string conString = "Server=108.167.132.199;Database=soluc963_STPMJ;Uid=soluc963_STPMJ;Pwd=R~X4ro$%K18b; ";
            //string conString = "Server=187.95.26.193;Port=3306;Database=soluc963_STPMJ;Uid=Agility;Pwd=!Parrudo292701;";
            //string conString = "Server=187.95.26.142;Port=3306;Database=soluc963_STPMJ;Uid=Agility;Pwd=!Parrudo292701;";
            //string conString = "Server=187.95.25.106;Port=3306;Database=soluc963_STPMJ;Uid=Agility;Pwd=!Parrudo292701;";
            //string conString = "Server=mysql-agility.advogadodigital.click;Port=3306;Database=soluc963_STPMJ;Uid=Agility;Pwd=!Parrudo292701;";
            string conString = "Server=192.168.15.29;Port=3306;Database=soluc963_STPMJ;Uid=stpmj;Pwd=!Stpmj292701;";
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
