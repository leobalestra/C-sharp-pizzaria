namespace NovaAlianca.Apresentacao
{
    partial class CadastrarProduto
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
            this.label8 = new System.Windows.Forms.Label();
            this.pnlSituacao = new System.Windows.Forms.Panel();
            this.rdbInativo = new System.Windows.Forms.RadioButton();
            this.rdbAtivo = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.comTipo = new System.Windows.Forms.ComboBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtgProduto = new System.Windows.Forms.DataGridView();
            this.idprodutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpoprodutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dscprodutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vlrprodutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staprodutoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpo_produto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projetoPizzariaDataSet4 = new NovaAlianca.ProjetoPizzariaDataSet4();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.NumericUpDown();
            this.tblProdutoTableAdapter = new NovaAlianca.ProjetoPizzariaDataSet4TableAdapters.tblProdutoTableAdapter();
            this.pnlSituacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProduto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProdutoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetoPizzariaDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValor)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(430, 122);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 17);
            this.label8.TabIndex = 44;
            this.label8.Text = "Situação";
            // 
            // pnlSituacao
            // 
            this.pnlSituacao.Controls.Add(this.rdbInativo);
            this.pnlSituacao.Controls.Add(this.rdbAtivo);
            this.pnlSituacao.Enabled = false;
            this.pnlSituacao.Location = new System.Drawing.Point(491, 118);
            this.pnlSituacao.Name = "pnlSituacao";
            this.pnlSituacao.Size = new System.Drawing.Size(111, 26);
            this.pnlSituacao.TabIndex = 43;
            // 
            // rdbInativo
            // 
            this.rdbInativo.AutoSize = true;
            this.rdbInativo.Location = new System.Drawing.Point(51, 4);
            this.rdbInativo.Name = "rdbInativo";
            this.rdbInativo.Size = new System.Drawing.Size(63, 17);
            this.rdbInativo.TabIndex = 3;
            this.rdbInativo.TabStop = true;
            this.rdbInativo.Text = "Em falta";
            this.rdbInativo.UseVisualStyleBackColor = true;
            this.rdbInativo.CheckedChanged += new System.EventHandler(this.rdbInativo_CheckedChanged);
            // 
            // rdbAtivo
            // 
            this.rdbAtivo.AutoSize = true;
            this.rdbAtivo.Location = new System.Drawing.Point(3, 4);
            this.rdbAtivo.Name = "rdbAtivo";
            this.rdbAtivo.Size = new System.Drawing.Size(49, 17);
            this.rdbAtivo.TabIndex = 2;
            this.rdbAtivo.TabStop = true;
            this.rdbAtivo.Text = "Ativo";
            this.rdbAtivo.UseVisualStyleBackColor = true;
            this.rdbAtivo.CheckedChanged += new System.EventHandler(this.rdbAtivo_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(429, 274);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 17);
            this.label7.TabIndex = 41;
            this.label7.Text = "Valor";
            // 
            // txtId
            // 
            this.txtId.Enabled = false;
            this.txtId.Location = new System.Drawing.Point(455, 80);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(48, 20);
            this.txtId.TabIndex = 1;
            this.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.btnSave.TabIndex = 10;
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
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
            this.btnCancelar.TabIndex = 8;
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
            this.btnExcluir.TabIndex = 11;
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
            this.btnAdicionar.TabIndex = 9;
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
            this.btnEditar.TabIndex = 7;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(429, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 20);
            this.label6.TabIndex = 34;
            this.label6.Text = "Editar produtos:";
            // 
            // comTipo
            // 
            this.comTipo.BackColor = System.Drawing.Color.White;
            this.comTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comTipo.Enabled = false;
            this.comTipo.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comTipo.FormattingEnabled = true;
            this.comTipo.Location = new System.Drawing.Point(432, 180);
            this.comTipo.Name = "comTipo";
            this.comTipo.Size = new System.Drawing.Size(159, 24);
            this.comTipo.TabIndex = 4;
            // 
            // txtNome
            // 
            this.txtNome.Enabled = false;
            this.txtNome.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(432, 238);
            this.txtNome.MaxLength = 30;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(159, 21);
            this.txtNome.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(429, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 17);
            this.label5.TabIndex = 30;
            this.label5.Text = "Tipo do produto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(429, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "Descrição";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(430, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Id";
            // 
            // dtgProduto
            // 
            this.dtgProduto.AllowUserToAddRows = false;
            this.dtgProduto.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dtgProduto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgProduto.AutoGenerateColumns = false;
            this.dtgProduto.BackgroundColor = System.Drawing.Color.White;
            this.dtgProduto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgProduto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProduto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idprodutoDataGridViewTextBoxColumn,
            this.tpoprodutoDataGridViewTextBoxColumn,
            this.dscprodutoDataGridViewTextBoxColumn,
            this.vlrprodutoDataGridViewTextBoxColumn,
            this.staprodutoDataGridViewTextBoxColumn,
            this.tpo_produto});
            this.dtgProduto.DataSource = this.tblProdutoBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgProduto.DefaultCellStyle = dataGridViewCellStyle3;
            this.dtgProduto.GridColor = System.Drawing.Color.Silver;
            this.dtgProduto.Location = new System.Drawing.Point(16, 41);
            this.dtgProduto.MultiSelect = false;
            this.dtgProduto.Name = "dtgProduto";
            this.dtgProduto.ReadOnly = true;
            this.dtgProduto.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgProduto.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgProduto.RowHeadersVisible = false;
            this.dtgProduto.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgProduto.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dtgProduto.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgProduto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgProduto.Size = new System.Drawing.Size(385, 344);
            this.dtgProduto.TabIndex = 0;
            this.dtgProduto.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtgProduto_CellFormatting);
            this.dtgProduto.SelectionChanged += new System.EventHandler(this.dtgProfissionais_SelectionChanged);
            // 
            // idprodutoDataGridViewTextBoxColumn
            // 
            this.idprodutoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.idprodutoDataGridViewTextBoxColumn.DataPropertyName = "id_produto";
            this.idprodutoDataGridViewTextBoxColumn.FillWeight = 30F;
            this.idprodutoDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idprodutoDataGridViewTextBoxColumn.Name = "idprodutoDataGridViewTextBoxColumn";
            this.idprodutoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tpoprodutoDataGridViewTextBoxColumn
            // 
            this.tpoprodutoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tpoprodutoDataGridViewTextBoxColumn.DataPropertyName = "dsc_tpo_produto";
            this.tpoprodutoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tpoprodutoDataGridViewTextBoxColumn.Name = "tpoprodutoDataGridViewTextBoxColumn";
            this.tpoprodutoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dscprodutoDataGridViewTextBoxColumn
            // 
            this.dscprodutoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dscprodutoDataGridViewTextBoxColumn.DataPropertyName = "dsc_produto";
            this.dscprodutoDataGridViewTextBoxColumn.FillWeight = 180F;
            this.dscprodutoDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.dscprodutoDataGridViewTextBoxColumn.Name = "dscprodutoDataGridViewTextBoxColumn";
            this.dscprodutoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // vlrprodutoDataGridViewTextBoxColumn
            // 
            this.vlrprodutoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.vlrprodutoDataGridViewTextBoxColumn.DataPropertyName = "vlr_produto";
            this.vlrprodutoDataGridViewTextBoxColumn.FillWeight = 90F;
            this.vlrprodutoDataGridViewTextBoxColumn.HeaderText = "Valor (R$)";
            this.vlrprodutoDataGridViewTextBoxColumn.Name = "vlrprodutoDataGridViewTextBoxColumn";
            this.vlrprodutoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // staprodutoDataGridViewTextBoxColumn
            // 
            this.staprodutoDataGridViewTextBoxColumn.DataPropertyName = "sta_produto";
            this.staprodutoDataGridViewTextBoxColumn.HeaderText = "sta_produto";
            this.staprodutoDataGridViewTextBoxColumn.Name = "staprodutoDataGridViewTextBoxColumn";
            this.staprodutoDataGridViewTextBoxColumn.ReadOnly = true;
            this.staprodutoDataGridViewTextBoxColumn.Visible = false;
            // 
            // tpo_produto
            // 
            this.tpo_produto.DataPropertyName = "tpo_produto";
            this.tpo_produto.HeaderText = "tpo_produto";
            this.tpo_produto.Name = "tpo_produto";
            this.tpo_produto.ReadOnly = true;
            this.tpo_produto.Visible = false;
            // 
            // tblProdutoBindingSource
            // 
            this.tblProdutoBindingSource.DataMember = "tblProduto";
            this.tblProdutoBindingSource.DataSource = this.projetoPizzariaDataSet4;
            // 
            // projetoPizzariaDataSet4
            // 
            this.projetoPizzariaDataSet4.DataSetName = "ProjetoPizzariaDataSet4";
            this.projetoPizzariaDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 21);
            this.label1.TabIndex = 25;
            this.label1.Text = "Lista de produtos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(430, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 17);
            this.label4.TabIndex = 46;
            this.label4.Text = "R$ ";
            // 
            // txtValor
            // 
            this.txtValor.DecimalPlaces = 2;
            this.txtValor.Enabled = false;
            this.txtValor.Location = new System.Drawing.Point(455, 296);
            this.txtValor.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(76, 20);
            this.txtValor.TabIndex = 6;
            this.txtValor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtValor.ThousandsSeparator = true;
            // 
            // tblProdutoTableAdapter
            // 
            this.tblProdutoTableAdapter.ClearBeforeFill = true;
            // 
            // CadastrarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(638, 420);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.pnlSituacao);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comTipo);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtgProduto);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CadastrarProduto";
            this.Text = "RealizarPedido";
            this.Load += new System.EventHandler(this.CadastrarProduto_Load);
            this.pnlSituacao.ResumeLayout(false);
            this.pnlSituacao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProduto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblProdutoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetoPizzariaDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtValor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pnlSituacao;
        private System.Windows.Forms.RadioButton rdbInativo;
        private System.Windows.Forms.RadioButton rdbAtivo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown txtId;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comTipo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dtgProduto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown txtValor;
        private ProjetoPizzariaDataSet4 projetoPizzariaDataSet4;
        private System.Windows.Forms.BindingSource tblProdutoBindingSource;
        private ProjetoPizzariaDataSet4TableAdapters.tblProdutoTableAdapter tblProdutoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idprodutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tpoprodutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dscprodutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vlrprodutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staprodutoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tpo_produto;
    }
}