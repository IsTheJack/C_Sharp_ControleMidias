using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ControleMidias.BancoDeDados;
using ControleMidias.InterfaceUsuario;

namespace ControleMidias
{
    public partial class frmMenuPrincipal : Form
    {
        public frmMenuPrincipal()
        {
            InitializeComponent();
        }

        private void btnAddAmigo_Click(object sender, EventArgs e)
        {
            frmAddAmigo formAmigo = new frmAddAmigo();
            this.Visible = false;
            formAmigo.ShowDialog();
            this.Visible = true;
            CarregarStatusStrip();
        }

        private void btnAddAmigo_MouseHover(object sender, EventArgs e)
        {
            lblHeader.Text = "Adicionar Amigo";
        }

        private void btnAddMidia_Click(object sender, EventArgs e)
        {
            frmAddMidia formMidia = new frmAddMidia();
            this.Visible = false;
            formMidia.ShowDialog();
            this.Visible = true;
            CarregarStatusStrip();
        }

        private void btnAddMidia_MouseHover(object sender, EventArgs e)
        {
            lblHeader.Text = "Adicionar Mídia";
        }

        private void btnEmprestimos_Click(object sender, EventArgs e)
        {
            frmEmprestimos formEmprestimos = new frmEmprestimos();
            this.Visible = false;
            formEmprestimos.ShowDialog();
            this.Visible = true;
            CarregarStatusStrip();
        }

        private void btnEmprestimos_MouseHover(object sender, EventArgs e)
        {
            lblHeader.Text = "Administrar Empréstimo";
        }

        private void botoesDoMenu_MouseLeave(object sender, EventArgs e)
        {
            lblHeader.Text = "Controle de Mídias";
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            CarregarStatusStrip();
        }

        private void CarregarStatusStrip()
        {
            statusStrip1.Focus();
            using (LinqControleMidiaDataContext dc = new LinqControleMidiaDataContext())
            {
                var lista = from Amigo in dc.Amigos select Amigo;
                lblQntAmigos.Text = String.Format("{0} Amigo(s) Cadastrado(s)  |", lista.Count());

                var lista1 = from Midia in dc.Midias select Midia;
                lblQndMidias.Text = String.Format("{0} Mídia(s) Cadastrada(s)  |", lista1.Count());

                var lista2 = from Emprestimo in dc.Emprestimos
                             where Emprestimo.DataPrevistaEntrega < DateTime.Now
                             select Emprestimo;
                lblQntEmprestimosAtrasados.Text = String.Format("{0} Empréstimo(s) atrasado(s)", lista2.Count());
            }
        }
    }
}
