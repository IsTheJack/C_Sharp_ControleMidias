using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControleMidias.Classes;

namespace ControleMidias.InterfaceUsuario
{
    public partial class frmAddAmigo : Form
    {
        public frmAddAmigo()
        {
            InitializeComponent();
        }

        private void LimparCampos()
        {
            txtNome.Text = "";
            txtApelido.Text = "";
            txtCelular.Text = "";
            txtTelefone.Text = "";
            txtEmail.Text = "";
            txtCidade.Text = "";
            txtBairro.Text = "";
            txtNumeroCasa.Text = "";
            txtNomePai.Text = "";
            txtNomeMae.Text = "";
            amigoTableAdapter.Fill(bancoControleMidiaAmigoDataSet.Amigo);// Recarregando o datagridview
            txtNome.Focus();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void frmAddAmigo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bancoControleMidiaAmigoDataSet.Amigo' table. You can move, or remove it, as needed.
            this.amigoTableAdapter.Fill(this.bancoControleMidiaAmigoDataSet.Amigo);

        }

        private void btnAdd_MouseHover(object sender, EventArgs e)
        {
            lblHeader.Text = "Adicionar Amigo";
            lblDica.Text = "Preencha as informações pessoais\ne clique neste botão para\nadicionar o amigo.";
        }

        private void btnAlterar_MouseHover(object sender, EventArgs e)
        {
            lblHeader.Text = "Alterar Amigo";
            lblDica.Text = "Selecione, na tabela, a linha do\namigo que deseja alterar e \nclique neste botão.";
        }

        private void btnExcluir_MouseHover(object sender, EventArgs e)
        {
            lblHeader.Text = "Excluir Amigo";
            lblDica.Text = "Selecione, na tabela, a linha do\namigo que deseja excluir e \nclique neste botão.";
        }

        private void btnVoltar_MouseHover(object sender, EventArgs e)
        {
            lblHeader.Text = "Voltar ao Menu Principal";
        }

        private void Botoes_MouseLeave(object sender, EventArgs e)
        {
            lblHeader.Text = "Tela de Adição de Amigos";
            lblDica.Text = "";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool CamposVazios = String.IsNullOrWhiteSpace(txtNome.Text.Trim()) ||
                                String.IsNullOrWhiteSpace(txtEmail.Text.Trim()) ||
                                String.IsNullOrWhiteSpace(txtCidade.Text.Trim()) ||
                                String.IsNullOrWhiteSpace(txtBairro.Text.Trim()) ||
                                String.IsNullOrWhiteSpace(txtNumeroCasa.Text.Trim());
            
            if (!CamposVazios)
            {
                _Amigo amigo = new _Amigo();
                amigo.Nome = txtNome.Text.Trim();
                amigo.Apelido = txtApelido.Text.Trim();
                amigo.Celular = txtCelular.Text.Trim();
                amigo.Telefone = txtTelefone.Text.Trim();
                amigo.Email = txtEmail.Text.Trim();
                amigo.Cidade = txtCidade.Text.Trim();
                amigo.Bairro = txtBairro.Text.Trim();
                amigo.NumeroCasa = txtNumeroCasa.Text.Trim();
                amigo.NomePai = txtNomePai.Text.Trim();
                amigo.NomeMae = txtNomeMae.Text.Trim();

                if (amigo.SalvarDados())
                {
                    MessageBox.Show(amigo.Nome + " salvo(a) com sucesso!", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                }
            }
            else
            {
                MessageBox.Show("Preencha os campos obrigatórios!\nOs campos marcados com \"*\" são obrigatórios!");      
            }
        }
    }
}
