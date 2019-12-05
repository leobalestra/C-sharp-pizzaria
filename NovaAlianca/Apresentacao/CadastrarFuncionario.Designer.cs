namespace NovaAlianca.Apresentacao
{
    partial class CadastrarFuncionario
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgProfissionais = new System.Windows.Forms.DataGridView();
            this.idfuncionarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dscloginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mmefuncionarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpofuncaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsc_senha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sta_funcionario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblFuncionarioBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.projetoPizzariaDataSet21 = new NovaAlianca.ProjetoPizzariaDataSet2();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.comFuncao = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.NumericUpDown();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlSituacao = new System.Windows.Forms.Panel();
            this.rdbInativo = new System.Windows.Forms.RadioButton();
            this.rdbAtivo = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.tblFuncionarioTableAdapter = new NovaAlianca.ProjetoPizzariaDataSet2TableAdapters.tblFuncionarioTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProfissionais)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFuncionarioBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetoPizzariaDataSet21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId)).BeginInit();
            this.pnlSituacao.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lista de funcionários:";
            // 
            // dtgProfissionais
            // 
            this.dtgProfissionais.AllowUserToAddRows = false;
            this.dtgProfissionais.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dtgProfissionais.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgProfissionais.AutoGenerateColumns = false;
            this.dtgProfissionais.BackgroundColor = System.Drawing.Color.White;
            this.dtgProfissionais.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgProfissionais.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgProfissionais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProfissionais.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idfuncionarioDataGridViewTextBoxColumn,
            this.dscloginDataGridViewTextBoxColumn,
            this.mmefuncionarioDataGridViewTextBoxColumn,
            this.tpofuncaoDataGridViewTextBoxColumn,
            this.dsc_senha,
            this.sta_funcionario});
            this.dtgProfissionais.DataSource = this.tblFuncionarioBindingSource2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgProfissionais.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgProfissionais.GridColor = System.Drawing.Color.Silver;
            this.dtgProfissionais.Location = new System.Drawing.Point(16, 41);
            this.dtgProfissionais.MultiSelect = false;
            this.dtgProfissionais.Name = "dtgProfissionais";
            this.dtgProfissionais.ReadOnly = true;
            this.dtgProfissionais.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgProfissionais.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgProfissionais.RowHeadersVisible = false;
            this.dtgProfissionais.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgProfissionais.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgProfissionais.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgProfissionais.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgProfissionais.Size = new System.Drawing.Size(385, 344);
            this.dtgProfissionais.TabIndex = 1;
            this.dtgProfissionais.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgProfissionais_CellFormatting);
            this.dtgProfissionais.SelectionChanged += new System.EventHandler(this.dtgProfissionais_SelectionChanged);
            // 
            // idfuncionarioDataGridViewTextBoxColumn
            // 
            this.idfuncionarioDataGridViewTextBoxColumn.DataPropertyName = "id_funcionario";
            this.idfuncionarioDataGridViewTextBoxColumn.FillWeight = 40F;
            this.idfuncionarioDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idfuncionarioDataGridViewTextBoxColumn.Name = "idfuncionarioDataGridViewTextBoxColumn";
            this.idfuncionarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.idfuncionarioDataGridViewTextBoxColumn.Width = 25;
            // 
            // dscloginDataGridViewTextBoxColumn
            // 
            this.dscloginDataGridViewTextBoxColumn.DataPropertyName = "dsc_login";
            this.dscloginDataGridViewTextBoxColumn.HeaderText = "Login";
            this.dscloginDataGridViewTextBoxColumn.Name = "dscloginDataGridViewTextBoxColumn";
            this.dscloginDataGridViewTextBoxColumn.ReadOnly = true;
            this.dscloginDataGridViewTextBoxColumn.Width = 80;
            // 
            // mmefuncionarioDataGridViewTextBoxColumn
            // 
            this.mmefuncionarioDataGridViewTextBoxColumn.DataPropertyName = "mme_funcionario";
            this.mmefuncionarioDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.mmefuncionarioDataGridViewTextBoxColumn.Name = "mmefuncionarioDataGridViewTextBoxColumn";
            this.mmefuncionarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.mmefuncionarioDataGridViewTextBoxColumn.Width = 150;
            // 
            // tpofuncaoDataGridViewTextBoxColumn
            // 
            this.tpofuncaoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tpofuncaoDataGridViewTextBoxColumn.DataPropertyName = "tpo_funcao";
            this.tpofuncaoDataGridViewTextBoxColumn.HeaderText = "Função";
            this.tpofuncaoDataGridViewTextBoxColumn.Name = "tpofuncaoDataGridViewTextBoxColumn";
            this.tpofuncaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dsc_senha
            // 
            this.dsc_senha.DataPropertyName = "dsc_senha";
            this.dsc_senha.HeaderText = "dsc_senha";
            this.dsc_senha.Name = "dsc_senha";
            this.dsc_senha.ReadOnly = true;
            this.dsc_senha.Visible = false;
            // 
            // sta_funcionario
            // 
            this.sta_funcionario.DataPropertyName = "sta_funcionario";
            this.sta_funcionario.HeaderText = "sta_funcionario";
            this.sta_funcionario.Name = "sta_funcionario";
            this.sta_funcionario.ReadOnly = true;
            this.sta_funcionario.Visible = false;
            // 
            // tblFuncionarioBindingSource2
            // 
            this.tblFuncionarioBindingSource2.DataMember = "tblFuncionario";
            this.tblFuncionarioBindingSource2.DataSource = this.projetoPizzariaDataSet21;
            // 
            // projetoPizzariaDataSet21
            // 
            this.projetoPizzariaDataSet21.DataSetName = "ProjetoPizzariaDataSet2";
            this.projetoPizzariaDataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(430, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(430, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Login";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(430, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nome";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(430, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Função";
            // 
            // txtLogin
            // 
            this.txtLogin.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtLogin.Enabled = false;
            this.txtLogin.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLogin.Location = new System.Drawing.Point(433, 162);
            this.txtLogin.MaxLength = 30;
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(159, 21);
            this.txtLogin.TabIndex = 6;
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(433, 213);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(159, 21);
            this.txtNome.TabIndex = 7;
            // 
            // comFuncao
            // 
            this.comFuncao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comFuncao.Enabled = false;
            this.comFuncao.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comFuncao.FormattingEnabled = true;
            this.comFuncao.Location = new System.Drawing.Point(433, 261);
            this.comFuncao.Name = "comFuncao";
            this.comFuncao.Size = new System.Drawing.Size(159, 24);
            this.comFuncao.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(429, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(147, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Editar funcionários:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackgroundImage = global::NovaAlianca.Properties.Resources.icons8_cancel_96;
            this.btnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Location = new System.Drawing.Point(468, 348);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(35, 35);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Visible = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackgroundImage = global::NovaAlianca.Properties.Resources.icons8_delete_bin_96;
            this.btnExcluir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Location = new System.Drawing.Point(551, 345);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(40, 40);
            this.btnExcluir.TabIndex = 14;
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.BackgroundImage = global::NovaAlianca.Properties.Resources.icons8_add_96;
            this.btnAdicionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdicionar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionar.FlatAppearance.BorderSize = 0;
            this.btnAdicionar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnAdicionar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnAdicionar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Location = new System.Drawing.Point(493, 345);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(40, 40);
            this.btnAdicionar.TabIndex = 12;
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.BackgroundImage = global::NovaAlianca.Properties.Resources.icons8_edit_128;
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Location = new System.Drawing.Point(433, 345);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(40, 40);
            this.btnEditar.TabIndex = 10;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackgroundImage = global::NovaAlianca.Properties.Resources.icons8_save_96;
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(523, 345);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(40, 40);
            this.btnSave.TabIndex = 13;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(455, 80);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(48, 20);
            this.txtId.TabIndex = 3;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSenha
            // 
            this.txtSenha.Enabled = false;
            this.txtSenha.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSenha.Location = new System.Drawing.Point(433, 312);
            this.txtSenha.MaxLength = 20;
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(159, 21);
            this.txtSenha.TabIndex = 9;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(430, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "Senha";
            // 
            // pnlSituacao
            // 
            this.pnlSituacao.Controls.Add(this.rdbInativo);
            this.pnlSituacao.Controls.Add(this.rdbAtivo);
            this.pnlSituacao.Enabled = false;
            this.pnlSituacao.Location = new System.Drawing.Point(491, 109);
            this.pnlSituacao.Name = "pnlSituacao";
            this.pnlSituacao.Size = new System.Drawing.Size(111, 26);
            this.pnlSituacao.TabIndex = 23;
            // 
            // rdbInativo
            // 
            this.rdbInativo.AutoSize = true;
            this.rdbInativo.Location = new System.Drawing.Point(51, 4);
            this.rdbInativo.Name = "rdbInativo";
            this.rdbInativo.Size = new System.Drawing.Size(57, 17);
            this.rdbInativo.TabIndex = 5;
            this.rdbInativo.TabStop = true;
            this.rdbInativo.Text = "Inativo";
            this.rdbInativo.UseVisualStyleBackColor = true;
            this.rdbInativo.CheckedChanged += new System.EventHandler(this.rdbInativo_CheckedChanged);
            // 
            // rdbAtivo
            // 
            this.rdbAtivo.AutoSize = true;
            this.rdbAtivo.Location = new System.Drawing.Point(3, 4);
            this.rdbAtivo.Name = "rdbAtivo";
            this.rdbAtivo.Size = new System.Drawing.Size(49, 17);
            this.rdbAtivo.TabIndex = 4;
            this.rdbAtivo.TabStop = true;
            this.rdbAtivo.Text = "Ativo";
            this.rdbAtivo.UseVisualStyleBackColor = true;
            this.rdbAtivo.CheckedChanged += new System.EventHandler(this.rdbAtivo_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(430, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 17);
            this.label8.TabIndex = 24;
            this.label8.Text = "Situação";
            // 
            // tblFuncionarioTableAdapter
            // 
            this.tblFuncionarioTableAdapter.ClearBeforeFill = true;
            // 
            // CadastrarFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(681, 417);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pnlSituacao);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comFuncao);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgProfissionais);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CadastrarFuncionario";
            this.Text = "RealizarPedido";
            this.Load += new System.EventHandler(this.CadastrarFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProfissionais)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFuncionarioBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetoPizzariaDataSet21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId)).EndInit();
            this.pnlSituacao.ResumeLayout(false);
            this.pnlSituacao.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private ProjetoPizzariaDataSet2TableAdapters.tblFuncionarioTableAdapter tblFuncionarioTableAdapter;
        private System.Windows.Forms.DataGridView dtgProfissionais;
        private ProjetoPizzariaDataSet2 projetoPizzariaDataSet21;
        private System.Windows.Forms.BindingSource tblFuncionarioBindingSource2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ComboBox comFuncao;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.NumericUpDown txtId;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnlSituacao;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rdbInativo;
        private System.Windows.Forms.RadioButton rdbAtivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idfuncionarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dscloginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mmefuncionarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tpofuncaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsc_senha;
        private System.Windows.Forms.DataGridViewTextBoxColumn sta_funcionario;
    }
}