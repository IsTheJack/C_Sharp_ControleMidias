using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        #endregion

        private void txtNomePesquisa_TextChanged(object sender, EventArgs e)
        {
            PesquisaMidias();
        }

        private void PesquisaMidias()
        {
            midiaBindingSource.Filter = "Nome like '%" + txtNomePesquisa.Text  + "%' OR " +
                                        "Tipo Like '%" + cbxTipo.Text + "%'";
        }
    }
}
