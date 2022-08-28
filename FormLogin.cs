﻿using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace Programa_STPMJ
{
    public partial class FormLogin : Form
    {
        int i;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            i = 0;

            CRUD.sql = "SELECT * FROM LOGIN WHERE Usuario = '" + txtLogin.Text.Trim() + "' AND Senha = '" + txtSenha.Text.Trim() + "'";
            CRUD.cmd = new MySqlCommand(CRUD.sql, CRUD.con);
            DataTable dt = CRUD.PerformCRUD(CRUD.cmd);
            i = Convert.ToInt32(dt.Rows.Count.ToString());
            DataGridView dgv = dataGridView1;

            dgv.Visible = true;
            dgv.AutoGenerateColumns = true;
            dgv.DataSource = dt;
            string permissao = Convert.ToString(dgv.CurrentRow.Cells[3].Value);



            if (i == 0)
            {
                MessageBox.Show("Usuário ou senha incorretos");
            }
            else if (permissao == "1")
            {
                this.Hide();
                formPaginaInicial FormPaginaInicial = new formPaginaInicial();
                FormPaginaInicial.Show();

            }
            else
            {
                this.Hide();
                formPaginaInicial FormPaginaInicial = new formPaginaInicial();

                FormPaginaInicial.Show();
            }
        }
        private void txtSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnLogin_Click(sender, e);
        }
    }
}
