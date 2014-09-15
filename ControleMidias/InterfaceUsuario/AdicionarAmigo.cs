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

        uint idDeAlteracao;

        public frmAddAmigo()
        {
            InitializeComponent();
        }

        private void frmAddAmigo_Load(object sender, EventArgs e)
        {
            txtNome.Focus();
            // TODO: This line of code loads data into the 'bancoControleMidiaAmigoDataSet.Amigo' table. You can move, or remove it, as needed.
            this.amigoTableAdapter.Fill(this.bancoControleMidiaAmigoDataSet.Amigo);

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

        #region Eventos de Mouse (MouseHover e MouseLeave)
        private void btnAdd_MouseHover(object sender, EventArgs e)
        {
            lblHeader.Text = "Adicionar Amigo";
            lblDica.Text = "Preencha as informações pessoais\ne clique neste botão para\nadicionar o amigo.";
        }

        private void btnAlterar_MouseHover(object sender, EventArgs e)
        {
            lblHeader.Text = "Alterar Amigo";
            if (idDeAlteracao == default(uint))
            {
                lblDica.Text = "Selecione, na tabela, a linha do\namigo que deseja alterar e \nclique neste botão.";
            }
            else
            {
                lblDica.Text = "Preencha as informações pessoais\ne clique neste botão para\nalterar o amigo.";
            }
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
        #endregion

        #region Eventos de Clique
        // Evento de clique do Botão btnAdd
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
                MessageBox.Show("Preencha os campos obrigatórios!\nOs campos marcados com \"*\" são obrigatórios!", "Atenção!",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNome.Focus();
            }
        }

        // Evento de clique do Botão btnAlterar
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            bool CamposVazios = String.IsNullOrWhiteSpace(txtNome.Text.Trim()) ||
                                String.IsNullOrWhiteSpace(txtEmail.Text.Trim()) ||
                                String.IsNullOrWhiteSpace(txtCidade.Text.Trim()) ||
                                String.IsNullOrWhiteSpace(txtBairro.Text.Trim()) ||
                                String.IsNullOrWhiteSpace(txtNumeroCasa.Text.Trim());

            if (idDeAlteracao == default(uint))
            {
                // Reconhecendo a linha do dgvAmigos
                int linha = -1;
                if (dgvAmigos.SelectedRows.Count > 0)
                    linha = dgvAmigos.SelectedRows[0].Index;
                else if (dgvAmigos.SelectedCells.Count > 0)
                    linha = dgvAmigos.SelectedCells[0].RowIndex;

                if (linha > -1)
                {
                    // Jogando os dados pros textboxes e salvando o id
                    idDeAlteracao = Convert.ToUInt32(dgvAmigos.Rows[linha].Cells[0].Value);
                    txtNome.Text = Convert.ToString(dgvAmigos.Rows[linha].Cells[1].Value);
                    txtApelido.Text = Convert.ToString(dgvAmigos.Rows[linha].Cells[2].Value);
                    txtCelular.Text = Convert.ToString(dgvAmigos.Rows[linha].Cells[3].Value);
                    txtTelefone.Text = Convert.ToString(dgvAmigos.Rows[linha].Cells[4].Value);
                    txtEmail.Text = Convert.ToString(dgvAmigos.Rows[linha].Cells[5].Value);
                    txtCidade.Text = Convert.ToString(dgvAmigos.Rows[linha].Cells[6].Value);
                    txtBairro.Text = Convert.ToString(dgvAmigos.Rows[linha].Cells[7].Value);
                    txtNumeroCasa.Text = Convert.ToString(dgvAmigos.Rows[linha].Cells[8].Value);
                    txtNomePai.Text = Convert.ToString(dgvAmigos.Rows[linha].Cells[9].Value);
                    txtNomeMae.Text = Convert.ToString(dgvAmigos.Rows[linha].Cells[10].Value);

                    //Inabilitando os botões salvar e excluir
                    btnAdd.Visible = false;
                    btnExcluir.Visible = false;
                }                
            }
            else if (!CamposVazios)
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

                if (amigo.AlterarDados(idDeAlteracao))
                {
                    MessageBox.Show(amigo.Nome + " alterado(a) com sucesso!", "Aviso",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                    // Liberando os botões salvar e excluir, deixando idDeAlteração com valor default
                    btnAdd.Visible = true;
                    btnExcluir.Visible = true;
                    idDeAlteracao = default(uint);
                }
            }
            else
            {
                MessageBox.Show("Preencha os campos obrigatórios!\nOs campos marcados com \"*\" são obrigatórios!", "Atenção!",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNome.Focus();
            }
        }

        // Evento de clique do Botão btnExcluir
        private void btnExcluir_Click(object sender, EventArgs e)
        {
            _Amigo amigo = new _Amigo();
            // Reconhecendo a linha do dgvAmigos
            int linha = -1;
            if (dgvAmigos.SelectedRows.Count > 0)
                linha = dgvAmigos.SelectedRows[0].Index;
            else if (dgvAmigos.SelectedCells.Count > 0)
                linha = dgvAmigos.SelectedCells[0].RowIndex;

            if (linha > -1)
            {
                // Pegando o valor da primeira célula, que é referente ao valor do Id
                uint id;
                id = Convert.ToUInt32(dgvAmigos.Rows[linha].Cells[0].Value);

                DialogResult confirmacao = MessageBox.Show("Realmente deseja excluir o amigo?", "Confirmação de Exclusão",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmacao == DialogResult.Yes)
                {
                    if (amigo.ExcluirDados(id))
                    {
                        MessageBox.Show("Amigo excluído com sucesso!", "Aviso");

                        LimparCampos();
                    }
                }
            }
        }
        #endregion

        private void pesquisa_TextChanged(object sender, EventArgs e)
        {
            PesquisaAmigos();
        }

        private void PesquisaAmigos()
        {
            amigoBindingSource.Filter = "Nome like '%" + txtNomePesquisa.Text + "%' OR " +
                                        "Apelido like '%" + txtNomePesquisa.Text.Trim() + "%' OR " +
                                        "Celular like '%" + txtNomePesquisa.Text.Trim() + "%' OR " +
                                        "Telefone like '%" + txtNomePesquisa.Text.Trim() + "%' OR " +
                                        "Email like '%" + txtNomePesquisa.Text.Trim() + "%' OR " +
                                        "Cidade like '%" + txtNomePesquisa.Text.Trim() + "%' OR " +
                                        "Bairro like '%" + txtNomePesquisa.Text.Trim() + "%' OR " +
                                        "NumeroCasa like '%" + txtNomePesquisa.Text.Trim() + "%' OR " +
                                        "NomePai like '%" + txtNomePesquisa.Text.Trim() + "%' OR " +
                                        "NomeMae like '%" + txtNomePesquisa.Text.Trim() + "%'";
        }
    }
}
