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
            formAmigo.ShowDialog();
            CarregarStatusStrip();
        }

        private void btnAddAmigo_MouseHover(object sender, EventArgs e)
        {
            lblHeader.Text = "Adicionar Amigo";
        }

        private void botoesDoMenu_MouseLeave(object sender, EventArgs e)
        {
            lblHeader.Text = "Controle de Mídias";
        }

        private void btnAddMidia_Click(object sender, EventArgs e)
        {
            statusStrip1.Focus();
        }


        private void btnAddMidia_MouseHover(object sender, EventArgs e)
        {
            lblHeader.Text = "Adicionar Mídia";
        }

        private void btnEmprestimos_Click(object sender, EventArgs e)
        {
            statusStrip1.Focus();
        }

        private void btnEmprestimos_MouseHover(object sender, EventArgs e)
        {
            lblHeader.Text = "Administrar Empréstimo";
        }

        private void frmMenuPrincipal_Load(object sender, EventArgs e)
        {
            CarregarStatusStrip();
        }

        private void CarregarStatusStrip()
        {
            using (LinqControleMidiaDataContext dc = new LinqControleMidiaDataContext())
            {
                var lista = from Amigo in dc.Amigos select Amigo;
                lblQntAmigos.Text = String.Format("{0} Amigo(s) Cadastrados  |", lista.Count());

                var lista1 = from Midia in dc.Midias select Midia;
                lblQndMidias.Text = String.Format("{0} Mídias Cadastradas  |", lista1.Count());

                var lista2 = from Emprestimo in dc.Emprestimos
                             where Emprestimo.DataPrevistaEntrega < DateTime.Now
                             select Emprestimo;
                lblQntEmprestimosAtrasados.Text = String.Format("{0} Empréstimos atrasados", lista2.Count());
            }
        }
    }
}
