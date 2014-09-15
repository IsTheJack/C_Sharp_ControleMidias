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
    public partial class frmAddMidia : Form
    {

        uint idDeAlteracao;

        public frmAddMidia()
        {
            InitializeComponent();
        }

        private void frmAddMidia_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bancoControleMidiaDataSet.Midia' table. You can move, or remove it, as needed.
            this.midiaTableAdapter.Fill(this.bancoControleMidiaDataSet.Midia);

        }

        private void LimparCampos()
        {
            txtNome.Text = "";
            cbxTipo.Text = "";
            this.midiaTableAdapter.Fill(this.bancoControleMidiaDataSet.Midia); // Recarregando o datagridview
            txtNome.Focus();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        #region Eventos de Mouse (MouseHover e MouseLeave)
        private void btnAdd_MouseHover(object sender, EventArgs e)
        {
            lblHeader.Text = "Adicionar Mídia";
            lblDica.Text = "Preencha as informações\ne clique neste botão para\nadicionar a mídia.";
        }

        private void btnAlterar_MouseHover(object sender, EventArgs e)
        {
            lblHeader.Text = "Alterar Amigo";
            if (idDeAlteracao == default(uint))
            {
                lblDica.Text = "Selecione, na tabela, a linha da\nmídia que deseja alterar e \nclique neste botão.";
            }
            else
            {
                lblDica.Text = "Preencha as informações \ne clique neste botão para\nalterar a mídia.";
            }
        }

        private void btnExcluir_MouseHover(object sender, EventArgs e)
        {
            lblHeader.Text = "Excluir Mídia";
            lblDica.Text = "Selecione, na tabela, a linha da\namídia que deseja excluir e \nclique neste botão.";
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
            bool camposVazios = String.IsNullOrWhiteSpace(txtNome.Text.Trim()) ||
                                String.IsNullOrWhiteSpace(cbxTipo.Text.Trim());

            if (!camposVazios)
            {
                _Midia midia = new _Midia();
                midia.Nome = txtNome.Text.Trim();
                midia.Tipo = cbxTipo.Text.Trim();

                if (midia.SalvarDados())
                {
                    MessageBox.Show("Mídia salva com sucesso!", "Aviso",
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
            bool camposVazios = String.IsNullOrWhiteSpace(txtNome.Text.Trim()) ||
                                String.IsNullOrWhiteSpace(cbxTipo.Text.Trim());

            if (idDeAlteracao == default(uint))
            {
                // Reconhecendo a linda do dgvMidias
                int linha = -1;
                if (dgvMidias.SelectedRows.Count > 0)
                    linha = dgvMidias.SelectedRows[0].Index;
                else if (dgvMidias.SelectedCells.Count > 0)
                    linha = dgvMidias.SelectedCells[0].RowIndex;

                if (linha > -1)
                {
                    // Jogando os dados pros textboxes e salvando o id
                    idDeAlteracao = Convert.ToUInt32(dgvMidias.Rows[linha].Cells[0].Value);
                    txtNome.Text = Convert.ToString(dgvMidias.Rows[linha].Cells[1].Value);
                    cbxTipo.Text = Convert.ToString(dgvMidias.Rows[linha].Cells[2].Value);

                    //Inabilitando os botões salvar e excluir
                    btnAdd.Visible = false;
                    btnExcluir.Visible = false;
                }
            }
            else if (!camposVazios)
            {
                _Midia midia = new _Midia();
                midia.Nome = txtNome.Text.Trim();
                midia.Tipo = cbxTipo.Text.Trim();

                if (midia.AlterarDados(idDeAlteracao))
                {
                    MessageBox.Show("Mídia alterada com sucesso!", "Aviso",
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
            _Midia midia = new _Midia();
            // Reconhecendo a linda do dgvMidias
            int linha = -1;
            if (dgvMidias.SelectedRows.Count > 0)
                linha = dgvMidias.SelectedRows[0].Index;
            else if (dgvMidias.SelectedCells.Count > 0)
                linha = dgvMidias.SelectedCells[0].RowIndex;

            if (linha > -1)
            {
                // Pegando o valor da primeira célula, que é referente ao valor do Id
                uint id;
                id = Convert.ToUInt32(dgvMidias.Rows[linha].Cells[0].Value);

                DialogResult confirmacao = MessageBox.Show("Realmente deseja excluir a mídia?", "Confirmação de Exclusão",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (confirmacao == DialogResult.Yes)
                {
                    if (midia.ExcluirDados(id))
                    {
                        MessageBox.Show("Mídia excluída com sucesso!", "Aviso");

                        LimparCampos();
                    }
                }
            }
        }
        #endregion

        private void txtNomePesquisa_TextChanged(object sender, EventArgs e)
        {
            PesquisaMidias();
        }

        private void PesquisaMidias()
        {
            midiaBindingSource.Filter = "Nome like '%" + txtNomePesquisa.Text.Trim()  + "%' OR " +
                                        "Tipo like '%" + txtNomePesquisa.Text.Trim() + "%'";
        }
    }
}
