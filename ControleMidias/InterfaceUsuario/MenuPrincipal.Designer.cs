namespace ControleMidias
{
    partial class frmMenuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblHeader = new System.Windows.Forms.Label();
            this.panelBottom = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.btnAddAmigo = new System.Windows.Forms.Button();
            this.btnEmprestimos = new System.Windows.Forms.Button();
            this.btnAddMidia = new System.Windows.Forms.Button();
            this.lblQntAmigos = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblQndMidias = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblQntEmprestimosAtrasados = new System.Windows.Forms.ToolStripStatusLabel();
            this.panelHeader.SuspendLayout();
            this.panelBottom.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panelHeader.Controls.Add(this.lblHeader);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(788, 92);
            this.panelHeader.TabIndex = 0;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.SystemColors.Control;
            this.lblHeader.Location = new System.Drawing.Point(12, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(444, 67);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Controle de Mídias";
            // 
            // panelBottom
            // 
            this.panelBottom.Controls.Add(this.statusStrip1);
            this.panelBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBottom.Location = new System.Drawing.Point(0, 242);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new System.Drawing.Size(788, 29);
            this.panelBottom.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblQntAmigos,
            this.lblQndMidias,
            this.lblQntEmprestimosAtrasados});
            this.statusStrip1.Location = new System.Drawing.Point(0, 7);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(788, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // btnAddAmigo
            // 
            this.btnAddAmigo.BackgroundImage = global::ControleMidias.Properties.Resources.CM_Amigo;
            this.btnAddAmigo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddAmigo.FlatAppearance.BorderSize = 0;
            this.btnAddAmigo.Location = new System.Drawing.Point(32, 98);
            this.btnAddAmigo.Name = "btnAddAmigo";
            this.btnAddAmigo.Size = new System.Drawing.Size(138, 138);
            this.btnAddAmigo.TabIndex = 0;
            this.btnAddAmigo.TabStop = false;
            this.btnAddAmigo.UseVisualStyleBackColor = true;
            this.btnAddAmigo.Click += new System.EventHandler(this.btnAddAmigo_Click);
            this.btnAddAmigo.MouseLeave += new System.EventHandler(this.botoesDoMenu_MouseLeave);
            this.btnAddAmigo.MouseHover += new System.EventHandler(this.btnAddAmigo_MouseHover);
            // 
            // btnEmprestimos
            // 
            this.btnEmprestimos.BackgroundImage = global::ControleMidias.Properties.Resources.CM_Emprestimo;
            this.btnEmprestimos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnEmprestimos.FlatAppearance.BorderSize = 0;
            this.btnEmprestimos.Location = new System.Drawing.Point(618, 98);
            this.btnEmprestimos.Name = "btnEmprestimos";
            this.btnEmprestimos.Size = new System.Drawing.Size(138, 138);
            this.btnEmprestimos.TabIndex = 0;
            this.btnEmprestimos.TabStop = false;
            this.btnEmprestimos.UseVisualStyleBackColor = true;
            this.btnEmprestimos.Click += new System.EventHandler(this.btnEmprestimos_Click);
            this.btnEmprestimos.MouseLeave += new System.EventHandler(this.botoesDoMenu_MouseLeave);
            this.btnEmprestimos.MouseHover += new System.EventHandler(this.btnEmprestimos_MouseHover);
            // 
            // btnAddMidia
            // 
            this.btnAddMidia.BackgroundImage = global::ControleMidias.Properties.Resources.CM_Midia;
            this.btnAddMidia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddMidia.FlatAppearance.BorderSize = 0;
            this.btnAddMidia.Location = new System.Drawing.Point(325, 98);
            this.btnAddMidia.Name = "btnAddMidia";
            this.btnAddMidia.Size = new System.Drawing.Size(138, 138);
            this.btnAddMidia.TabIndex = 0;
            this.btnAddMidia.TabStop = false;
            this.btnAddMidia.UseVisualStyleBackColor = true;
            this.btnAddMidia.Click += new System.EventHandler(this.btnAddMidia_Click);
            this.btnAddMidia.MouseLeave += new System.EventHandler(this.botoesDoMenu_MouseLeave);
            this.btnAddMidia.MouseHover += new System.EventHandler(this.btnAddMidia_MouseHover);
            // 
            // lblQntAmigos
            // 
            this.lblQntAmigos.Name = "lblQntAmigos";
            this.lblQntAmigos.Size = new System.Drawing.Size(141, 17);
            this.lblQntAmigos.Text = "Quantidade de Amigos   |";
            // 
            // lblQndMidias
            // 
            this.lblQndMidias.Name = "lblQndMidias";
            this.lblQndMidias.Size = new System.Drawing.Size(132, 17);
            this.lblQndMidias.Text = "Quantidade de Mídias  |";
            // 
            // lblQntEmprestimosAtrasados
            // 
            this.lblQntEmprestimosAtrasados.ForeColor = System.Drawing.Color.Red;
            this.lblQntEmprestimosAtrasados.Name = "lblQntEmprestimosAtrasados";
            this.lblQntEmprestimosAtrasados.Size = new System.Drawing.Size(212, 17);
            this.lblQntEmprestimosAtrasados.Text = "Quantidade de Empréstimos Atrasados";
            // 
            // frmMenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 271);
            this.Controls.Add(this.btnAddMidia);
            this.Controls.Add(this.btnEmprestimos);
            this.Controls.Add(this.btnAddAmigo);
            this.Controls.Add(this.panelBottom);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmMenuPrincipal";
            this.Opacity = 0.95D;
            this.Text = "Menu Principal";
            this.Load += new System.EventHandler(this.frmMenuPrincipal_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.panelBottom.ResumeLayout(false);
            this.panelBottom.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button btnAddAmigo;
        private System.Windows.Forms.Button btnEmprestimos;
        private System.Windows.Forms.Button btnAddMidia;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.ToolStripStatusLabel lblQntAmigos;
        private System.Windows.Forms.ToolStripStatusLabel lblQndMidias;
        private System.Windows.Forms.ToolStripStatusLabel lblQntEmprestimosAtrasados;
    }
}

