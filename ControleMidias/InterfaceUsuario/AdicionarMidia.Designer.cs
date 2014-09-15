namespace ControleMidias.InterfaceUsuario
{
    partial class frmAddMidia
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
            this.components = new System.ComponentModel.Container();
            this.lblHeader = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.gpbPesquisa = new System.Windows.Forms.GroupBox();
            this.pxbPesquisar = new System.Windows.Forms.PictureBox();
            this.txtNomePesquisa = new System.Windows.Forms.TextBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvMidias = new System.Windows.Forms.DataGridView();
            this.idMidiaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.midiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bancoControleMidiaDataSet = new ControleMidias.BancoControleMidiaDataSet();
            this.midiaTableAdapter = new ControleMidias.BancoControleMidiaDataSetTableAdapters.MidiaTableAdapter();
            this.lblDica = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gpbPesquisa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pxbPesquisar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMidias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.midiaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoControleMidiaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.SystemColors.Control;
            this.lblHeader.Location = new System.Drawing.Point(12, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(585, 67);
            this.lblHeader.TabIndex = 0;
            this.lblHeader.Text = "Tela de Adição de Mídias";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panelHeader.Controls.Add(this.lblDica);
            this.panelHeader.Controls.Add(this.lblHeader);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(847, 92);
            this.panelHeader.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nome: *";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(97, 19);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(209, 20);
            this.txtNome.TabIndex = 11;
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(364, 25);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(38, 13);
            this.lblTipo.TabIndex = 13;
            this.lblTipo.Text = "Tipo: *";
            // 
            // cbxTipo
            // 
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Location = new System.Drawing.Point(432, 17);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(159, 21);
            this.cbxTipo.TabIndex = 14;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbxTipo);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.lblTipo);
            this.groupBox1.Location = new System.Drawing.Point(11, 98);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(619, 67);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações da Mídia:";
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackgroundImage = global::ControleMidias.Properties.Resources.CM_Voltar;
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVoltar.Location = new System.Drawing.Point(701, 204);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 75);
            this.btnVoltar.TabIndex = 22;
            this.btnVoltar.TabStop = false;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            this.btnVoltar.MouseLeave += new System.EventHandler(this.Botoes_MouseLeave);
            this.btnVoltar.MouseHover += new System.EventHandler(this.btnVoltar_MouseHover);
            // 
            // gpbPesquisa
            // 
            this.gpbPesquisa.Controls.Add(this.pxbPesquisar);
            this.gpbPesquisa.Controls.Add(this.txtNomePesquisa);
            this.gpbPesquisa.Location = new System.Drawing.Point(636, 98);
            this.gpbPesquisa.Name = "gpbPesquisa";
            this.gpbPesquisa.Size = new System.Drawing.Size(200, 100);
            this.gpbPesquisa.TabIndex = 23;
            this.gpbPesquisa.TabStop = false;
            this.gpbPesquisa.Text = "Pesquisa:";
            // 
            // pxbPesquisar
            // 
            this.pxbPesquisar.BackgroundImage = global::ControleMidias.Properties.Resources.CM_Pesquisar;
            this.pxbPesquisar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pxbPesquisar.Location = new System.Drawing.Point(64, 41);
            this.pxbPesquisar.Name = "pxbPesquisar";
            this.pxbPesquisar.Size = new System.Drawing.Size(75, 50);
            this.pxbPesquisar.TabIndex = 11;
            this.pxbPesquisar.TabStop = false;
            // 
            // txtNomePesquisa
            // 
            this.txtNomePesquisa.Location = new System.Drawing.Point(9, 18);
            this.txtNomePesquisa.Name = "txtNomePesquisa";
            this.txtNomePesquisa.Size = new System.Drawing.Size(185, 20);
            this.txtNomePesquisa.TabIndex = 10;
            this.txtNomePesquisa.TextChanged += new System.EventHandler(this.txtNomePesquisa_TextChanged);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackgroundImage = global::ControleMidias.Properties.Resources.CM_ExcluirAmigo;
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExcluir.Location = new System.Drawing.Point(536, 171);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 75);
            this.btnExcluir.TabIndex = 26;
            this.btnExcluir.TabStop = false;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.MouseLeave += new System.EventHandler(this.Botoes_MouseLeave);
            this.btnExcluir.MouseHover += new System.EventHandler(this.btnExcluir_MouseHover);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackgroundImage = global::ControleMidias.Properties.Resources.CM_AlterarAmigo;
            this.btnAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAlterar.Location = new System.Drawing.Point(290, 171);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 75);
            this.btnAlterar.TabIndex = 25;
            this.btnAlterar.TabStop = false;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.MouseLeave += new System.EventHandler(this.Botoes_MouseLeave);
            this.btnAlterar.MouseHover += new System.EventHandler(this.btnAlterar_MouseHover);
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = global::ControleMidias.Properties.Resources.CM_AddAmigo;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.Location = new System.Drawing.Point(12, 171);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 75);
            this.btnAdd.TabIndex = 24;
            this.btnAdd.TabStop = false;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.MouseLeave += new System.EventHandler(this.Botoes_MouseLeave);
            this.btnAdd.MouseHover += new System.EventHandler(this.btnAdd_MouseHover);
            // 
            // dgvMidias
            // 
            this.dgvMidias.AllowUserToAddRows = false;
            this.dgvMidias.AutoGenerateColumns = false;
            this.dgvMidias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMidias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idMidiaDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn});
            this.dgvMidias.DataSource = this.midiaBindingSource;
            this.dgvMidias.Location = new System.Drawing.Point(12, 299);
            this.dgvMidias.MultiSelect = false;
            this.dgvMidias.Name = "dgvMidias";
            this.dgvMidias.ReadOnly = true;
            this.dgvMidias.Size = new System.Drawing.Size(824, 193);
            this.dgvMidias.TabIndex = 27;
            // 
            // idMidiaDataGridViewTextBoxColumn
            // 
            this.idMidiaDataGridViewTextBoxColumn.DataPropertyName = "IdMidia";
            this.idMidiaDataGridViewTextBoxColumn.HeaderText = "IdMidia";
            this.idMidiaDataGridViewTextBoxColumn.Name = "idMidiaDataGridViewTextBoxColumn";
            this.idMidiaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idMidiaDataGridViewTextBoxColumn.Visible = false;
            this.idMidiaDataGridViewTextBoxColumn.Width = 260;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 391;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "Tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoDataGridViewTextBoxColumn.Width = 390;
            // 
            // midiaBindingSource
            // 
            this.midiaBindingSource.DataMember = "Midia";
            this.midiaBindingSource.DataSource = this.bancoControleMidiaDataSet;
            // 
            // bancoControleMidiaDataSet
            // 
            this.bancoControleMidiaDataSet.DataSetName = "BancoControleMidiaDataSet";
            this.bancoControleMidiaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // midiaTableAdapter
            // 
            this.midiaTableAdapter.ClearBeforeFill = true;
            // 
            // lblDica
            // 
            this.lblDica.AutoSize = true;
            this.lblDica.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDica.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDica.Location = new System.Drawing.Point(620, 9);
            this.lblDica.Name = "lblDica";
            this.lblDica.Size = new System.Drawing.Size(0, 20);
            this.lblDica.TabIndex = 3;
            // 
            // frmAddMidia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 504);
            this.Controls.Add(this.dgvMidias);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.gpbPesquisa);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panelHeader);
            this.Name = "frmAddMidia";
            this.Text = "AdicionarMidias";
            this.Load += new System.EventHandler(this.frmAddMidia_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gpbPesquisa.ResumeLayout(false);
            this.gpbPesquisa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pxbPesquisar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMidias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.midiaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoControleMidiaDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.GroupBox gpbPesquisa;
        private System.Windows.Forms.PictureBox pxbPesquisar;
        private System.Windows.Forms.TextBox txtNomePesquisa;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.DataGridView dgvMidias;
        private BancoControleMidiaDataSet bancoControleMidiaDataSet;
        private System.Windows.Forms.BindingSource midiaBindingSource;
        private BancoControleMidiaDataSetTableAdapters.MidiaTableAdapter midiaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idMidiaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblDica;
    }
}