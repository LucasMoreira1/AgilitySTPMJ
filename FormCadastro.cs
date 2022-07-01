using System;
using System.Data;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using AForge.Imaging.Filters;
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
        Bitmap bitmap;

        private void ResetMe()
        {
            //txtMatricula.Text = "";
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
            txtNomeDependente.Text = "";
            txtDataNascimentoDependente.Text = "";
            txtGrauParentesco.Text = "";
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
            CRUD.cmd.Parameters.AddWithValue("data_nascimento", Convert.ToDateTime(txtDataNascimento.Text.Trim()));
            //CRUD.cmd.Parameters.AddWithValue("data_nascimento", txtDataNascimento.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("estado_civil", cboxEstadoCivil.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("nacionalidade", txtNacionalidade.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("data_cadastro", Convert.ToDateTime(txtDataCadastro.Text.Trim()));
            //CRUD.cmd.Parameters.AddWithValue("data_cadastro", txtDataCadastro.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("secretaria", cboxEmpresa.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("funcao", txtFuncao.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("admissao", txtAdmissao.Text.Trim());
            //CRUD.cmd.Parameters.AddWithValue("admissao", txtAdmissao.Text.Trim());
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
            CRUD.cmd.Parameters.AddWithValue("nomeDependente", txtNomeDependente.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("DataNascimentoDependente", txtDataNascimentoDependente.Text.Trim());
            CRUD.cmd.Parameters.AddWithValue("GrauParentesco", txtGrauParentesco.Text.Trim());
           
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMatricula.Text.Trim()) &&
                    string.IsNullOrEmpty(txtNome.Text.Trim()) &&
                    string.IsNullOrEmpty(txtDataNascimento.Text.Trim()))
            {
                MessageBox.Show("Campos obrigatórios: Matricula, Nome, Data Nascimento", "Dados Obrigatórios",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            CRUD.sql = "INSERT INTO SOCIOS(matricula,nome,rg,cpf,datanascimento,estadocivil," +
                "nacionalidade,datacadastro,secretaria,funcao,admissao,localtrabalho," +
                "telefone,recados,email,cep,logradouro,numero,complemento,bairro,cidade,estado," +
                "limite,disponivel,observacao,foto)" +
                "Values(@matricula,@nome,@rg,@cpf,@data_nascimento,@estado_civil,@nacionalidade," +
                "@data_cadastro,@secretaria,@funcao,@admissao,@local_trabalho," +
                "@telefone,@recado,@email,@cep,@logradouro,@numero,@complemento,@bairro,@cidade,@estado," +
                "@limite,@disponivel,@observacao,@foto);";


            Executar(CRUD.sql, "Insert");

            CRUD.sql = "SELECT LAST_INSERT_ID()";

            CRUD.cmd = new MySqlCommand(CRUD.sql, CRUD.con);
            DataTable dt = CRUD.PerformCRUD(CRUD.cmd);
            

            DataGridView dgv = dataGridView1;
            dgv.Visible = true;

            dgv.MultiSelect = false;
            dgv.AutoGenerateColumns = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.DataSource = dt;
            // dgv.Columns["Foto"].Visible = false;
            dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            string NumeroRegistro = dgv.CurrentCell.Value.ToString();
            // .CurrentRow.Cells[0].Value
            dgv.Visible = false;

            MessageBox.Show("Sócio registrado. Registro número: " + NumeroRegistro + ".", "Cadastro",
                MessageBoxButtons.OK, MessageBoxIcon.Information) ;

            

            
            //loadData("");
            ResetMe();
            pesquisa();
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
                    string.IsNullOrEmpty(txtNome.Text.Trim()) ||
                    string.IsNullOrEmpty(txtDataNascimento.Text.Trim()) ||
                    string.IsNullOrEmpty(txtAdmissao.Text.Trim()))
            {
                MessageBox.Show("Campos obrigatórios: Matricula, Nome, Data Nascimento, Data Admissão", "Dados Obrigatórios",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            CRUD.sql = "UPDATE SOCIOS SET matricula = @matricula, nome = @nome, rg = @rg, cpf = @cpf, " +
                "datanascimento = @data_nascimento, estadocivil = @estado_civil," +
                "nacionalidade = @nacionalidade, datacadastro = @data_cadastro, secretaria = @secretaria, " +
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

            //FormPesquisa formPesquisa = new FormPesquisa();
            //formPesquisa.loadFiltro();
            
        }

        private void FormCadastro_Load(object sender, EventArgs e)
        {
            txtDataCadastro.Text = DateTime.Now.ToString("dd/MM/yyyy");
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

            AlimentarComboBox();

        }

        public void AlimentarComboBox()
        {
            CRUD.sql = "SELECT * FROM SECRETARIAS";
            CRUD.cmd = new MySqlCommand(CRUD.sql, CRUD.con);

            DataTable dt = CRUD.PerformCRUD(CRUD.cmd);

            foreach (DataRow dr in dt.Rows)
            {
                cboxEmpresa.Items.Add(dr[0]).ToString();

            }
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
            //imgCamera.Image = (Bitmap)eventArgs.Frame.Clone();

            bitmap = (Bitmap)eventArgs.Frame.Clone();

            ///add these two lines to mirror the image
            var filter = new Mirror(false, true);
            
            filter.ApplyInPlace(bitmap);

            ///

            imgCamera.Image = bitmap;
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

        }

        private void btnAdcDependente_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMatricula.Text.Trim()) ||
                   string.IsNullOrEmpty(txtNome.Text.Trim()))
            {
                MessageBox.Show("Por favor insira a Matrícula e Nome completo", "Dados Obrigatórios",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }


            CRUD.sql = "INSERT INTO DEPENDENTES(MatReferencia,Nome,DataNascimento,GrauParantesco)" +
                "Values(@matricula, @nomeDependente, @DataNascimentoDependente, @GrauParentesco);";


            Executar(CRUD.sql, "Insert");

            MessageBox.Show("Dependente registrado.", "Cadastro Dependente",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            //loadData("");
            ResetDependente();
        }

        private void ResetDependente()
        {
            txtNomeDependente.Text = "";
            txtDataNascimentoDependente.Text = "";
            txtGrauParentesco.Text = "";
        }

        private void btnListaDependentes_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMatricula.Text.Trim()))
            {
                MessageBox.Show("Por favor insira a Matrícula", "Dados Obrigatórios",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            FormDependentes formDependentes = new FormDependentes();
            formDependentes.txtMatReferencia.Text = txtMatricula.Text;
            formDependentes.txtNomeSocio.Text = txtNome.Text;
            formDependentes.Show();
            
        }

        private void IniciarEsquerda(object sender, EventArgs e)
        {
            
            txtRG.SelectionStart = 0;
            txtCPF.SelectionStart = 0;
            txtDataNascimento.SelectionStart = 0;
            txtAdmissao.SelectionStart = 0;
            txtTelefone.SelectionStart = 0;
            txtRecado.SelectionStart = 0;

            txtDataNascimentoDependente.SelectionStart = 0;
            
            txtCEP.SelectionStart = 0;

        }

        public void pesquisa()
        {

            CRUD.sql = "SELECT * FROM SOCIOS WHERE MATRICULA LIKE '" + txtMatricula.Text.Trim() + "'";

            CRUD.cmd = new MySqlCommand(CRUD.sql, CRUD.con);
            DataTable dt = CRUD.PerformCRUD(CRUD.cmd);
            DataGridView dgv = dataGridView1;

            dgv.Visible = true;
            dgv.MultiSelect = false;
            dgv.AutoGenerateColumns = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.DataSource = dt;
            dgv.Columns["Foto"].Visible = false;
            dgv.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);

            btnSalvar.Visible = false;
            btnAtualizar.Visible = true;

            txtMatricula.Text = Convert.ToString(dgv.CurrentRow.Cells[0].Value);
            txtNome.Text = Convert.ToString(dgv.CurrentRow.Cells[1].Value);
            txtRG.Text = Convert.ToString(dgv.CurrentRow.Cells[2].Value);
            txtCPF.Text = Convert.ToString(dgv.CurrentRow.Cells[3].Value);
            txtDataNascimento.Text = Convert.ToString(dgv.CurrentRow.Cells[4].Value);
            cboxEstadoCivil.Text = Convert.ToString(dgv.CurrentRow.Cells[5].Value);
            txtNacionalidade.Text = Convert.ToString(dgv.CurrentRow.Cells[6].Value);
            txtDataCadastro.Text = Convert.ToString(dgv.CurrentRow.Cells[7].Value);
            cboxEmpresa.Text = Convert.ToString(dgv.CurrentRow.Cells[8].Value);
            txtFuncao.Text = Convert.ToString(dgv.CurrentRow.Cells[9].Value);
            txtAdmissao.Text = Convert.ToString(dgv.CurrentRow.Cells[10].Value);
            txtLocalTrabalho.Text = Convert.ToString(dgv.CurrentRow.Cells[11].Value);
            txtTelefone.Text = Convert.ToString(dgv.CurrentRow.Cells[12].Value);
            txtRecado.Text = Convert.ToString(dgv.CurrentRow.Cells[13].Value);
            txtEmail.Text = Convert.ToString(dgv.CurrentRow.Cells[14].Value);
            txtCEP.Text = Convert.ToString(dgv.CurrentRow.Cells[15].Value);
            txtLogradouro.Text = Convert.ToString(dgv.CurrentRow.Cells[16].Value);
            txtNumero.Text = Convert.ToString(dgv.CurrentRow.Cells[17].Value);
            txtComplemento.Text = Convert.ToString(dgv.CurrentRow.Cells[18].Value);
            txtBairro.Text = Convert.ToString(dgv.CurrentRow.Cells[19].Value);
            txtCidade.Text = Convert.ToString(dgv.CurrentRow.Cells[20].Value);
            txtEstado.Text = Convert.ToString(dgv.CurrentRow.Cells[21].Value);
            txtLimite.Text = Convert.ToString(dgv.CurrentRow.Cells[22].Value);
            txtDisponivel.Text = Convert.ToString(dgv.CurrentRow.Cells[23].Value);
            txtObservacao.Text = Convert.ToString(dgv.CurrentRow.Cells[24].Value);
            MemoryStream ms = new MemoryStream((byte[])dgv.CurrentRow.Cells[25].Value);
            imgCamera.Image = Image.FromStream(ms);
            txtRegistro.Text = Convert.ToString(dgv.CurrentRow.Cells[26].Value);

            dgv.Visible = false;

          
            
        }

        private void Pesquisar(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                pesquisa();
            }
               
        }

        private void Imprimir(object sender, EventArgs e)
        {
            FormFichaCadastral formFichaCadastral = new FormFichaCadastral();
            formFichaCadastral.txtMatricula.Text = txtMatricula.Text;
            formFichaCadastral.Show();
            

        }

        private void btnAtualizarDependente_Click(object sender, EventArgs e)
        {
            CRUD.sql = "UPDATE DEPENDENTES SET Nome = @nomeDependente, DataNascimento = @DataNascimentoDependente,GrauParantesco = @GrauParentesco WHERE MatReferencia = @matricula";

            //"UPDATE DEPENDENTES SET Nome = @nomeDependente, DataNascimento = @DataNascimentoDependente, GrauParentesco = @GrauParentesco WHERE MatReferencia = @matricula";


            Executar(CRUD.sql, "Update");

            MessageBox.Show("Dados atualizados.", "Cadastro",
                MessageBoxButtons.OK, MessageBoxIcon.Information);

            ResetMe();
            this.Close();
        }
    }
}
