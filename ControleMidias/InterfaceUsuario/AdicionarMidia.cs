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
        public frmAddMidia()
        {
            InitializeComponent();
        }

        private void frmAddMidia_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bancoControleMidiaDataSet.Midia' table. You can move, or remove it, as needed.
            this.midiaTableAdapter.Fill(this.bancoControleMidiaDataSet.Midia);

        }
    }
}
