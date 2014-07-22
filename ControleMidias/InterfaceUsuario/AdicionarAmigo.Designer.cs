namespace ControleMidias.InterfaceUsuario
{
    partial class frmAddAmigo
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtApelido = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtNumeroCasa = new System.Windows.Forms.TextBox();
            this.txtNomePai = new System.Windows.Forms.TextBox();
            this.txtNomeMae = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.gpbInformacao = new System.Windows.Forms.GroupBox();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtCelular = new System.Windows.Forms.MaskedTextBox();
            this.gpbPesquisa = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblDica = new System.Windows.Forms.Label();
            this.lblHeader = new System.Windows.Forms.Label();
            this.dgvAmigos = new System.Windows.Forms.DataGridView();
            this.idAmigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apelidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.celularDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroCasaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomePaiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeMaeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amigoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bancoControleMidiaAmigoDataSet = new ControleMidias.BancoControleMidiaAmigoDataSet();
            this.amigoTableAdapter = new ControleMidias.BancoControleMidiaAmigoDataSetTableAdapters.AmigoTableAdapter();
            this.gpbInformacao.SuspendLayout();
            this.gpbPesquisa.SuspendLayout();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmigos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.amigoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoControleMidiaAmigoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(97, 19);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(209, 20);
            this.txtNome.TabIndex = 0;
            // 
            // txtApelido
            // 
            this.txtApelido.Location = new System.Drawing.Point(431, 18);
            this.txtApelido.Name = "txtApelido";
            this.txtApelido.Size = new System.Drawing.Size(209, 20);
            this.txtApelido.TabIndex = 1;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(97, 71);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(209, 20);
            this.txtEmail.TabIndex = 4;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(431, 70);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(209, 20);
            this.txtCidade.TabIndex = 5;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(97, 97);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(209, 20);
            this.txtBairro.TabIndex = 6;
            // 
            // txtNumeroCasa
            // 
            this.txtNumeroCasa.Location = new System.Drawing.Point(431, 96);
            this.txtNumeroCasa.Name = "txtNumeroCasa";
            this.txtNumeroCasa.Size = new System.Drawing.Size(123, 20);
            this.txtNumeroCasa.TabIndex = 7;
            // 
            // txtNomePai
            // 
            this.txtNomePai.Location = new System.Drawing.Point(97, 123);
            this.txtNomePai.Name = "txtNomePai";
            this.txtNomePai.Size = new System.Drawing.Size(209, 20);
            this.txtNomePai.TabIndex = 8;
            // 
            // txtNomeMae
            // 
            this.txtNomeMae.Location = new System.Drawing.Point(431, 122);
            this.txtNomeMae.Name = "txtNomeMae";
            this.txtNomeMae.Size = new System.Drawing.Size(209, 20);
            this.txtNomeMae.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nome: *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Celular:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Email: *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Bairro: *";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Nome do Pai:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(329, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Apelido:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(329, 48);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Telefone:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(329, 74);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Cidade: *";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(329, 99);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Numero da Casa: *";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(329, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Nome da Mãe:";
            // 
            // gpbInformacao
            // 
            this.gpbInformacao.Controls.Add(this.txtTelefone);
            this.gpbInformacao.Controls.Add(this.txtCelular);
            this.gpbInformacao.Controls.Add(this.label1);
            this.gpbInformacao.Controls.Add(this.label10);
            this.gpbInformacao.Controls.Add(this.txtNome);
            this.gpbInformacao.Controls.Add(this.label9);
            this.gpbInformacao.Controls.Add(this.txtApelido);
            this.gpbInformacao.Controls.Add(this.label8);
            this.gpbInformacao.Controls.Add(this.label7);
            this.gpbInformacao.Controls.Add(this.label6);
            this.gpbInformacao.Controls.Add(this.txtEmail);
            this.gpbInformacao.Controls.Add(this.label5);
            this.gpbInformacao.Controls.Add(this.txtCidade);
            this.gpbInformacao.Controls.Add(this.label4);
            this.gpbInformacao.Controls.Add(this.txtBairro);
            this.gpbInformacao.Controls.Add(this.label3);
            this.gpbInformacao.Controls.Add(this.txtNumeroCasa);
            this.gpbInformacao.Controls.Add(this.label2);
            this.gpbInformacao.Controls.Add(this.txtNomePai);
            this.gpbInformacao.Controls.Add(this.txtNomeMae);
            this.gpbInformacao.Location = new System.Drawing.Point(12, 98);
            this.gpbInformacao.Name = "gpbInformacao";
            this.gpbInformacao.Size = new System.Drawing.Size(679, 162);
            this.gpbInformacao.TabIndex = 20;
            this.gpbInformacao.TabStop = false;
            this.gpbInformacao.Text = "Informações Pessoais:";
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(431, 45);
            this.txtTelefone.Mask = "(00) 9999-9999";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.Size = new System.Drawing.Size(95, 20);
            this.txtTelefone.TabIndex = 3;
            this.txtTelefone.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(97, 44);
            this.txtCelular.Mask = "(00) 99999-9999";
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(95, 20);
            this.txtCelular.TabIndex = 2;
            this.txtCelular.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            // 
            // gpbPesquisa
            // 
            this.gpbPesquisa.Controls.Add(this.label12);
            this.gpbPesquisa.Controls.Add(this.textBox2);
            this.gpbPesquisa.Controls.Add(this.textBox1);
            this.gpbPesquisa.Controls.Add(this.label11);
            this.gpbPesquisa.Location = new System.Drawing.Point(697, 98);
            this.gpbPesquisa.Name = "gpbPesquisa";
            this.gpbPesquisa.Size = new System.Drawing.Size(200, 100);
            this.gpbPesquisa.TabIndex = 21;
            this.gpbPesquisa.TabStop = false;
            this.gpbPesquisa.Text = "Pesquisa:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 47);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 13);
            this.label12.TabIndex = 21;
            this.label12.Text = "Apelido:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(64, 44);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(130, 20);
            this.textBox2.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(64, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 20);
            this.textBox1.TabIndex = 10;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Nome:";
            // 
            // btnAdd
            // 
            this.btnAdd.BackgroundImage = global::ControleMidias.Properties.Resources.CM_AddAmigo;
            this.btnAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAdd.Location = new System.Drawing.Point(21, 266);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 75);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.TabStop = false;
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.MouseLeave += new System.EventHandler(this.Botoes_MouseLeave);
            this.btnAdd.MouseHover += new System.EventHandler(this.btnAdd_MouseHover);
            // 
            // btnAlterar
            // 
            this.btnAlterar.BackgroundImage = global::ControleMidias.Properties.Resources.CM_AlterarAmigo;
            this.btnAlterar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAlterar.Location = new System.Drawing.Point(307, 266);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 75);
            this.btnAlterar.TabIndex = 13;
            this.btnAlterar.TabStop = false;
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            this.btnAlterar.MouseLeave += new System.EventHandler(this.Botoes_MouseLeave);
            this.btnAlterar.MouseHover += new System.EventHandler(this.btnAlterar_MouseHover);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackgroundImage = global::ControleMidias.Properties.Resources.CM_ExcluirAmigo;
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnExcluir.Location = new System.Drawing.Point(577, 266);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 75);
            this.btnExcluir.TabIndex = 14;
            this.btnExcluir.TabStop = false;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            this.btnExcluir.MouseLeave += new System.EventHandler(this.Botoes_MouseLeave);
            this.btnExcluir.MouseHover += new System.EventHandler(this.btnExcluir_MouseHover);
            // 
            // btnVoltar
            // 
            this.btnVoltar.BackgroundImage = global::ControleMidias.Properties.Resources.CM_Voltar;
            this.btnVoltar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnVoltar.Location = new System.Drawing.Point(761, 204);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(75, 75);
            this.btnVoltar.TabIndex = 15;
            this.btnVoltar.TabStop = false;
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            this.btnVoltar.MouseLeave += new System.EventHandler(this.Botoes_MouseLeave);
            this.btnVoltar.MouseHover += new System.EventHandler(this.btnVoltar_MouseHover);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.panelHeader.Controls.Add(this.lblDica);
            this.panelHeader.Controls.Add(this.lblHeader);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(908, 92);
            this.panelHeader.TabIndex = 26;
            // 
            // lblDica
            // 
            this.lblDica.AutoSize = true;
            this.lblDica.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDica.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDica.Location = new System.Drawing.Point(650, 9);
            this.lblDica.Name = "lblDica";
            this.lblDica.Size = new System.Drawing.Size(0, 20);
            this.lblDica.TabIndex = 2;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.ForeColor = System.Drawing.SystemColors.Control;
            this.lblHeader.Location = new System.Drawing.Point(12, 9);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(599, 67);
            this.lblHeader.TabIndex = 1;
            this.lblHeader.Text = "Tela de Adição de Amigos";
            // 
            // dgvAmigos
            // 
            this.dgvAmigos.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gainsboro;
            this.dgvAmigos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAmigos.AutoGenerateColumns = false;
            this.dgvAmigos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAmigos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAmigoDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.apelidoDataGridViewTextBoxColumn,
            this.celularDataGridViewTextBoxColumn,
            this.telefoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.cidadeDataGridViewTextBoxColumn,
            this.bairroDataGridViewTextBoxColumn,
            this.numeroCasaDataGridViewTextBoxColumn,
            this.nomePaiDataGridViewTextBoxColumn,
            this.nomeMaeDataGridViewTextBoxColumn});
            this.dgvAmigos.DataSource = this.amigoBindingSource;
            this.dgvAmigos.Location = new System.Drawing.Point(12, 367);
            this.dgvAmigos.MultiSelect = false;
            this.dgvAmigos.Name = "dgvAmigos";
            this.dgvAmigos.ReadOnly = true;
            this.dgvAmigos.Size = new System.Drawing.Size(885, 327);
            this.dgvAmigos.TabIndex = 27;
            // 
            // idAmigoDataGridViewTextBoxColumn
            // 
            this.idAmigoDataGridViewTextBoxColumn.DataPropertyName = "IdAmigo";
            this.idAmigoDataGridViewTextBoxColumn.HeaderText = "IdAmigo";
            this.idAmigoDataGridViewTextBoxColumn.Name = "idAmigoDataGridViewTextBoxColumn";
            this.idAmigoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idAmigoDataGridViewTextBoxColumn.Visible = false;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 84;
            // 
            // apelidoDataGridViewTextBoxColumn
            // 
            this.apelidoDataGridViewTextBoxColumn.DataPropertyName = "Apelido";
            this.apelidoDataGridViewTextBoxColumn.HeaderText = "Apelido";
            this.apelidoDataGridViewTextBoxColumn.Name = "apelidoDataGridViewTextBoxColumn";
            this.apelidoDataGridViewTextBoxColumn.ReadOnly = true;
            this.apelidoDataGridViewTextBoxColumn.Width = 84;
            // 
            // celularDataGridViewTextBoxColumn
            // 
            this.celularDataGridViewTextBoxColumn.DataPropertyName = "Celular";
            this.celularDataGridViewTextBoxColumn.HeaderText = "Celular";
            this.celularDataGridViewTextBoxColumn.Name = "celularDataGridViewTextBoxColumn";
            this.celularDataGridViewTextBoxColumn.ReadOnly = true;
            this.celularDataGridViewTextBoxColumn.Width = 85;
            // 
            // telefoneDataGridViewTextBoxColumn
            // 
            this.telefoneDataGridViewTextBoxColumn.DataPropertyName = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.HeaderText = "Telefone";
            this.telefoneDataGridViewTextBoxColumn.Name = "telefoneDataGridViewTextBoxColumn";
            this.telefoneDataGridViewTextBoxColumn.ReadOnly = true;
            this.telefoneDataGridViewTextBoxColumn.Width = 84;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            this.emailDataGridViewTextBoxColumn.Width = 84;
            // 
            // cidadeDataGridViewTextBoxColumn
            // 
            this.cidadeDataGridViewTextBoxColumn.DataPropertyName = "Cidade";
            this.cidadeDataGridViewTextBoxColumn.HeaderText = "Cidade";
            this.cidadeDataGridViewTextBoxColumn.Name = "cidadeDataGridViewTextBoxColumn";
            this.cidadeDataGridViewTextBoxColumn.ReadOnly = true;
            this.cidadeDataGridViewTextBoxColumn.Width = 84;
            // 
            // bairroDataGridViewTextBoxColumn
            // 
            this.bairroDataGridViewTextBoxColumn.DataPropertyName = "Bairro";
            this.bairroDataGridViewTextBoxColumn.HeaderText = "Bairro";
            this.bairroDataGridViewTextBoxColumn.Name = "bairroDataGridViewTextBoxColumn";
            this.bairroDataGridViewTextBoxColumn.ReadOnly = true;
            this.bairroDataGridViewTextBoxColumn.Width = 84;
            // 
            // numeroCasaDataGridViewTextBoxColumn
            // 
            this.numeroCasaDataGridViewTextBoxColumn.DataPropertyName = "NumeroCasa";
            this.numeroCasaDataGridViewTextBoxColumn.HeaderText = "Numero da Casa";
            this.numeroCasaDataGridViewTextBoxColumn.Name = "numeroCasaDataGridViewTextBoxColumn";
            this.numeroCasaDataGridViewTextBoxColumn.ReadOnly = true;
            this.numeroCasaDataGridViewTextBoxColumn.Width = 85;
            // 
            // nomePaiDataGridViewTextBoxColumn
            // 
            this.nomePaiDataGridViewTextBoxColumn.DataPropertyName = "NomePai";
            this.nomePaiDataGridViewTextBoxColumn.HeaderText = "Nome do Pai";
            this.nomePaiDataGridViewTextBoxColumn.Name = "nomePaiDataGridViewTextBoxColumn";
            this.nomePaiDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomePaiDataGridViewTextBoxColumn.Width = 84;
            // 
            // nomeMaeDataGridViewTextBoxColumn
            // 
            this.nomeMaeDataGridViewTextBoxColumn.DataPropertyName = "NomeMae";
            this.nomeMaeDataGridViewTextBoxColumn.HeaderText = "Nome da Mae";
            this.nomeMaeDataGridViewTextBoxColumn.Name = "nomeMaeDataGridViewTextBoxColumn";
            this.nomeMaeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeMaeDataGridViewTextBoxColumn.Width = 84;
            // 
            // amigoBindingSource
            // 
            this.amigoBindingSource.DataMember = "Amigo";
            this.amigoBindingSource.DataSource = this.bancoControleMidiaAmigoDataSet;
            // 
            // bancoControleMidiaAmigoDataSet
            // 
            this.bancoControleMidiaAmigoDataSet.DataSetName = "BancoControleMidiaAmigoDataSet";
            this.bancoControleMidiaAmigoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // amigoTableAdapter
            // 
            this.amigoTableAdapter.ClearBeforeFill = true;
            // 
            // frmAddAmigo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 706);
            this.Controls.Add(this.dgvAmigos);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAlterar);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.gpbPesquisa);
            this.Controls.Add(this.gpbInformacao);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmAddAmigo";
            this.Text = "AdicionarAmigo";
            this.Load += new System.EventHandler(this.frmAddAmigo_Load);
            this.gpbInformacao.ResumeLayout(false);
            this.gpbInformacao.PerformLayout();
            this.gpbPesquisa.ResumeLayout(false);
            this.gpbPesquisa.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAmigos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.amigoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bancoControleMidiaAmigoDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtApelido;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtNumeroCasa;
        private System.Windows.Forms.TextBox txtNomePai;
        private System.Windows.Forms.TextBox txtNomeMae;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox gpbInformacao;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.MaskedTextBox txtCelular;
        private System.Windows.Forms.GroupBox gpbPesquisa;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.DataGridView dgvAmigos;
        private BancoControleMidiaAmigoDataSet bancoControleMidiaAmigoDataSet;
        private System.Windows.Forms.BindingSource amigoBindingSource;
        private BancoControleMidiaAmigoDataSetTableAdapters.AmigoTableAdapter amigoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAmigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apelidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn celularDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroCasaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomePaiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeMaeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblDica;
    }
}