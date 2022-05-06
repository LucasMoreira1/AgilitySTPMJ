using System;
using System.Data;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using System.Drawing;
using MySql.Data.MySqlClient;
using System.IO;

namespace Programa_STPMJ
{
    public partial class FormCadastro : Form
    {
        
        public Boolean CameraOn = false;
        public string localizacaoFoto;
        public FormCadastro()
        {
            InitializeComponent();
            ResetMe();

        }
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;

        private void ResetMe()
        {
            txtMatricula.Text = "";
            txtNome.Text = "";
            txtRG.Text = "";
            txtCPF.Text = "";
            txtDataNascimento.Text = "";
            cboxEstadoCivil.SelectedIndex = 0;
            txtNacionalidade.Text = "";
            cboxEmpresa.Text = "";
            txtFuncao.Text = "";
            txtAdmissao.Text = "";
            txtLocalTrabalho.Text = "";
            txtTelefone.Text = "";
            txtRecado.Text = "";
            txtEmail.Text = "";
            txtCEP.Text = "";
            txtLogradouro.Text = "";
            txtNumero.Text = "";
            txtComplemento.Text = "";
            txtBairro.Text = "";
            txtCidade.Text = "";
            txtEstado.Text = "";
            txtLimite.Text = "";
            txtDisponivel.Text = "";
            txtObservacao.Text = "";
            imgCamera.Image = null;
        }

        private void Executar(string mySQL, string param)
        {
            CRUD.cmd = new MySqlCommand(mySQL,CRUD.con);
            AddParametros(param);
            CRUD.PerformCRUD(CRUD.cmd);
        }

        private void AddParametros(string str)
        {
            CRUD.cmd.Parameters.Clear();

            //byte[] img = null;

            //FileStream Stream = new FileStream(localizacaoFoto, FileMode.Open, FileAccess.Read);
            //BinaryReader brs = new BinaryReader(Stream);
            //img = brs.ReadBytes((int)Stream.Length);

            MemoryStream ms = new MemoryStream();
            if (imgCamera.Image == null)
            {
                imgCamera.BackgroundImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            else
            {
                imgCamera.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            
            
            byte[] img = ms.GetBuffer();

            


            CRUD.cmd.Parameters.AddWithValue("matricula", txtMatricula.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("nome", txtNome.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("rg", txtRG.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("cpf", txtCPF.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("data_nascimento", txtDataNascimento.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("estado_civil", cboxEstadoCivil.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("nacionalidade", txtNacionalidade.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("data_cadastro", txtDataCadastro.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("empresa", cboxEmpresa.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("funcao", txtFuncao.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("admissao", txtAdmissao.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("local_trabalho", txtLocalTrabalho.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("telefone", txtTelefone.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("recado", txtRecado.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("email", txtEmail.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("cep", txtCEP.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("logradouro", txtLogradouro.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("numero", txtNumero.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("complemento", txtComplemento.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("bairro", txtBairro.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("cidade", txtCidade.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("estado", txtEstado.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("limite", txtLimite.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("disponivel", txtDisponivel.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("observacao", txtObservacao.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("foto", img);
            CRUD.cmd.Parameters.AddWithValue("registro_sindical", txtRegistro.Text.Trim());
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMatricula.Text.Trim()) ||
                    string.IsNullOrEmpty(txtNome.Text.Trim()))
            {
                MessageBox.Show("Por favor insira a Matrícula e Nome completo", "Dados Obrigatórios",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            

            CRUD.sql = "INSERT INTO SOCIOS(matricula,nome,rg,cpf,datanascimento,estadocivil," +
                "nacionalidade,datacadastro,empresa,funcao,admissao,localtrabalho," +
                "telefone,recados,email,cep,logradouro,numero,complemento,bairro,cidade,estado," +
                "limite,disponivel,observacao,foto)" +
                "Values(@matricula,@nome,@rg,@cpf,@data_nascimento,@estado_civil,@nacionalidade," +
                "@data_cadastro,@empresa,@funcao,@admissao,@local_trabalho," +
                "@telefone,@recado,@email,@cep,@logradouro,@numero,@complemento,@bairro,@cidade,@estado," +
                "@limite,@disponivel,@observacao,@foto);";


            Executar(CRUD.sql, "Insert");

            MessageBox.Show("Sócio registrado.", "Cadastro",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            //loadData("");
            ResetMe();
        }

        private void btnBuscarCEP_Click(object sender, EventArgs e)
        {
            try
            {
                DataSet ds = new DataSet();
                string xml = "http://cep.republicavirtual.com.br/web_cep.php?cep=@cep&formato=xml".Replace("@cep",txtCEP.Text);

                ds.ReadXml(xml);

                txtLogradouro.Text = ds.Tables[0].Rows[0]["logradouro"].ToString();
                txtBairro.Text = ds.Tables[0].Rows[0]["bairro"].ToString();
                txtCidade.Text = ds.Tables[0].Rows[0]["cidade"].ToString();
                txtEstado.Text = ds.Tables[0].Rows[0]["uf"].ToString();
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro ao buscar CEP");
            }

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            ResetMe();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            

            if (string.IsNullOrEmpty(txtMatricula.Text.Trim()) || 
                    string.IsNullOrEmpty(txtNome.Text.Trim()))
            {
                MessageBox.Show("Por favor insira a Matrícula e Nome completo", "Dados Obrigatórios",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            CRUD.sql = "UPDATE SOCIOS SET matricula = @matricula, nome = @nome, rg = @rg, cpf = @cpf, " +
                "datanascimento = @data_nascimento, estadocivil = @estado_civil," +
                "nacionalidade = @nacionalidade, datacadastro = @data_cadastro, empresa = @empresa, " +
                "funcao = @funcao, admissao = @admissao, localtrabalho = @local_trabalho, " +
                "telefone = @telefone, recados = @recado, email = @email, cep = @cep, " +
                "logradouro = @logradouro, numero = @numero, complemento = @complemento, bairro = @bairro," +
                "cidade = @cidade, estado = @estado, limite = @limite, disponivel = @disponivel, " +
                "observacao = @observacao, foto = @foto WHERE registrosindical = @registro_sindical";


            Executar(CRUD.sql, "Update");

            MessageBox.Show("Dados atualizados.", "Cadastro",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            ResetMe();
            this.Close();
        }

        private void FormCadastro_Load(object sender, EventArgs e)
        {
            txtDataCadastro.Text = DateTime.Now.ToString("dd/MM/yyyy");
            
            //formPaginaInicial formPaginaInicial = new formPaginaInicial();
            ////cboxCamera.Items.Add(formPaginaInicial.comboCamera.Text);
            //cboxCamera.SelectedValue = formPaginaInicial.comboCamera.SelectedItem;

            //Camera
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
                cboxCamera.Items.Add(filterInfo.Name);
            if (cboxCamera.Items.Count >= 1) 
            {
                cboxCamera.SelectedIndex = 0;
            }
            //cboxCamera.SelectedIndex = 0;
            videoCaptureDevice = new VideoCaptureDevice();
        }

        private void btnIniciarCamera_Click(object sender, EventArgs e)
        {
            if (!CameraOn)
            {
                videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cboxCamera.SelectedIndex].MonikerString);
                videoCaptureDevice.NewFrame += new NewFrameEventHandler(VideoCaptureDevice_NewFrame);
                CameraOn = true;
                videoCaptureDevice.Start();
            }
        }
        public void EncerrarCamera()
        {
            if (CameraOn)
            {
                //  FinalVideo.Stop();     // <-removed
                videoCaptureDevice.SignalToStop();
                // FinalVideo.WaitForStop();  // <- removed this to my suprice isn't needed, in fact my closing started to work only after marking this one out
                CameraOn = false;
                videoCaptureDevice.NewFrame -= new NewFrameEventHandler(VideoCaptureDevice_NewFrame); // <- decouple the newFrame event.
                videoCaptureDevice = null;
                imgCamera.Image = null;
            }
        }

        private void VideoCaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            imgCamera.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void FormCadastro_FormClosing(object sender, FormClosingEventArgs e)
        {
            EncerrarCamera();
        }

        private void btnTirarFoto_Click(object sender, EventArgs e)
        {

            if (CameraOn)
            {
                //  FinalVideo.Stop();     // <-removed
                videoCaptureDevice.SignalToStop();
                // FinalVideo.WaitForStop();  // <- removed this to my suprice isn't needed, in fact my closing started to work only after marking this one out
                CameraOn = false;
                videoCaptureDevice.NewFrame -= new NewFrameEventHandler(VideoCaptureDevice_NewFrame); // <- decouple the newFrame event.
                videoCaptureDevice = null;
            }

        }

        public void btnEncerrarCamera_Click(object sender, EventArgs e)
        {
            imgCamera.Image = null;
        }

        private void btnImportarFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Escolha a foto(*.jpeg;*.png;*.gif) |*.jpeg;*.png;*.gif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                localizacaoFoto = ofd.FileName.ToString();
                imgCamera.ImageLocation = localizacaoFoto;
            }
        }

        private void btnImagemEmBranco_Click(object sender, EventArgs e)
        {


            CRUD.sql = "UPDATE SOCIOS SET foto = @foto";


            Executar(CRUD.sql, "Update");

            MessageBox.Show("Dados atualizados.", "Cadastro",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            FormPesquisa formpesquisa = new FormPesquisa();
            formpesquisa.btnPesquisar_Click(sender, e);

            ResetMe();
            this.Close();
        }
    }
}
