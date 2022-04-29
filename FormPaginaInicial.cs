using System;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace Programa_STPMJ
{
    public partial class formPaginaInicial : Form
    {
        //public Boolean CameraOn = false;
        public formPaginaInicial()
        {
            InitializeComponent();
            CustomizeDesign();

        }
        private void CustomizeDesign()
        {
            panelCadastros.Visible = false;
            panelPesquisas.Visible = false;
            panelDocumentos.Visible = false;
            //...
        }

        private void EsconderSubmenu()
        {
            if (panelCadastros.Visible == true)
                panelCadastros.Visible = false;
            if (panelPesquisas.Visible == true)
                panelPesquisas.Visible = false;
            if (panelDocumentos.Visible == true)
                panelDocumentos.Visible = false;
            //...
        }
        private void MostrarSubmenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                EsconderSubmenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        #region Cadastros
        private void btnCadastros_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(panelCadastros);
        }

        private void btnCadastroCliente_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormCadastro());
            //..
            //Codigos
            //..
            EsconderSubmenu();
        }

        private void btnCadastroEmpresa_Click(object sender, EventArgs e)
        {
            //..
            //Codigos
            //..
            EsconderSubmenu();
        }
        #endregion
        #region Pesquisar
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(panelPesquisas);
        }

        private void btnPesquisarCliente_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormPesquisa());
            //..
            //Codigos
            //..
            EsconderSubmenu();
        }

        private void btnPesquisarEmpresa_Click(object sender, EventArgs e)
        {
            //..
            //Codigos
            //..
            EsconderSubmenu();
        }
        #endregion
        #region Relatorios
        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            //..
            //Codigos
            //..
            EsconderSubmenu();
        }
#endregion
        #region Documentos
        private void btnDocumentos_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(panelDocumentos);
        }

        private void btnCarteirinha_Click(object sender, EventArgs e)
        {
            //..
            //Codigos
            //..
            EsconderSubmenu();
        }

        private void btnCheques_Click(object sender, EventArgs e)
        {
            //..
            //Codigos
            //..
            EsconderSubmenu();
        }
#endregion
        #region Ajuda
        private void btnAjuda_Click(object sender, EventArgs e)
        {
            //..
            //Codigos
            //..
            EsconderSubmenu();
        }
        #endregion

        private Form activeForm = null;
        public void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelFormCentral.Controls.Add(childForm);
            panelFormCentral.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void formPaginaInicial_FormClosed(object sender, FormClosedEventArgs e)
        {
            //videoCaptureDevice.Stop();
            
            
        }

        private void formPaginaInicial_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormCadastro formCadastro = new FormCadastro();
            formCadastro.btnEncerrarCamera_Click(sender, e);
            formCadastro.EncerrarCamera();
            formCadastro.CameraOn = false;

            var resposta = MessageBox.Show("Deseja fechar a aplicação?", "Confirmação",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (resposta == DialogResult.No)
            {
                e.Cancel = true;
            }
                        
            
        }
    }
}
