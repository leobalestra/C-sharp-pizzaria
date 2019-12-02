namespace NovaAlianca.Apresentacao
{
    partial class RealizarPedido
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
            this.lblDadosCliente = new System.Windows.Forms.Label();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.lblTelefone1 = new System.Windows.Forms.Label();
            this.btnPizza2 = new System.Windows.Forms.Button();
            this.btnPizza1 = new System.Windows.Forms.Button();
            this.lblTituloPizza = new System.Windows.Forms.Label();
            this.lblTituloBebida = new System.Windows.Forms.Label();
            this.tblProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projetoPizzariaDataSet = new NovaAlianca.ProjetoPizzariaDataSet();
            this.tblProdutoTableAdapter = new NovaAlianca.ProjetoPizzariaDataSetTableAdapters.tblProdutoTableAdapter();
            this.lstBebidas = new System.Windows.Forms.ListBox();
            this.btnAdicionarBebida = new System.Windows.Forms.Button();
            this.lblTelefone2 = new System.Windows.Forms.Label();
            this.lblEndereco = new System.Windows.Forms.Label();
            this.pnlPedido = new System.Windows.Forms.Panel();
            this.btnFinalizarPedido = new System.Windows.Forms.Button();
            this.btnRemoverItemComanda = new System.Windows.Forms.Button();
            this.btnLimparListaComanda = new System.Windows.Forms.Button();
            this.lblEscolhaPizza2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblEscolhaPizza1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstPedido = new System.Windows.Forms.ListBox();
            this.btnAdicionarPizza = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlCliente = new System.Windows.Forms.Panel();
            this.lblUltimoPedido = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPesquisarTelefone = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tblProdutoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetoPizzariaDataSet)).BeginInit();
            this.pnlPedido.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlCliente.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDadosCliente
            // 
            this.lblDadosCliente.AutoSize = true;
            this.lblDadosCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDadosCliente.Location = new System.Drawing.Point(5, 15);
            this.lblDadosCliente.Name = "lblDadosCliente";
            this.lblDadosCliente.Size = new System.Drawing.Size(123, 17);
            this.lblDadosCliente.TabIndex = 3;
            this.lblDadosCliente.Text = "Dados do cliente:";
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCliente.Location = new System.Drawing.Point(5, 55);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(0, 17);
            this.lblNomeCliente.TabIndex = 4;
            // 
            // lblTelefone1
            // 
            this.lblTelefone1.AutoSize = true;
            this.lblTelefone1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone1.Location = new System.Drawing.Point(5, 113);
            this.lblTelefone1.Name = "lblTelefone1";
            this.lblTelefone1.Size = new System.Drawing.Size(0, 17);
            this.lblTelefone1.TabIndex = 5;
            // 
            // btnPizza2
            // 
            this.btnPizza2.BackColor = System.Drawing.Color.White;
            this.btnPizza2.BackgroundImage = global::NovaAlianca.Properties.Resources.opte_pizza__2_;
            this.btnPizza2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPizza2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPizza2.FlatAppearance.BorderSize = 0;
            this.btnPizza2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPizza2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPizza2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPizza2.Location = new System.Drawing.Point(113, 41);
            this.btnPizza2.Name = "btnPizza2";
            this.btnPizza2.Size = new System.Drawing.Size(69, 137);
            this.btnPizza2.TabIndex = 7;
            this.btnPizza2.UseVisualStyleBackColor = false;
            this.btnPizza2.Click += new System.EventHandler(this.btnPizza2_Click);
            // 
            // btnPizza1
            // 
            this.btnPizza1.BackColor = System.Drawing.Color.White;
            this.btnPizza1.BackgroundImage = global::NovaAlianca.Properties.Resources.opte_pizza__1_;
            this.btnPizza1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPizza1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPizza1.FlatAppearance.BorderSize = 0;
            this.btnPizza1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPizza1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPizza1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPizza1.ForeColor = System.Drawing.Color.Transparent;
            this.btnPizza1.Location = new System.Drawing.Point(42, 41);
            this.btnPizza1.Name = "btnPizza1";
            this.btnPizza1.Size = new System.Drawing.Size(65, 137);
            this.btnPizza1.TabIndex = 6;
            this.btnPizza1.UseVisualStyleBackColor = false;
            this.btnPizza1.Click += new System.EventHandler(this.btnPizza1_Click);
            // 
            // lblTituloPizza
            // 
            this.lblTituloPizza.AutoSize = true;
            this.lblTituloPizza.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloPizza.Location = new System.Drawing.Point(8, 10);
            this.lblTituloPizza.Name = "lblTituloPizza";
            this.lblTituloPizza.Size = new System.Drawing.Size(73, 21);
            this.lblTituloPizza.TabIndex = 8;
            this.lblTituloPizza.Text = "1 - Pizza:";
            // 
            // lblTituloBebida
            // 
            this.lblTituloBebida.AutoSize = true;
            this.lblTituloBebida.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloBebida.Location = new System.Drawing.Point(8, 265);
            this.lblTituloBebida.Name = "lblTituloBebida";
            this.lblTituloBebida.Size = new System.Drawing.Size(91, 21);
            this.lblTituloBebida.TabIndex = 9;
            this.lblTituloBebida.Text = "2 - Bebida:";
            // 
            // tblProdutoBindingSource
            // 
            this.tblProdutoBindingSource.DataMember = "tblProduto";
            this.tblProdutoBindingSource.DataSource = this.projetoPizzariaDataSet;
            // 
            // projetoPizzariaDataSet
            // 
            this.projetoPizzariaDataSet.DataSetName = "ProjetoPizzariaDataSet";
            this.projetoPizzariaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblProdutoTableAdapter
            // 
            this.tblProdutoTableAdapter.ClearBeforeFill = true;
            // 
            // lstBebidas
            // 
            this.lstBebidas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstBebidas.DataSource = this.tblProdutoBindingSource;
            this.lstBebidas.DisplayMember = "dsc_produto";
            this.lstBebidas.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstBebidas.FormattingEnabled = true;
            this.lstBebidas.ItemHeight = 17;
            this.lstBebidas.Location = new System.Drawing.Point(12, 289);
            this.lstBebidas.Name = "lstBebidas";
            this.lstBebidas.Size = new System.Drawing.Size(196, 68);
            this.lstBebidas.TabIndex = 12;
            this.lstBebidas.ValueMember = "id_produto";
            // 
            // btnAdicionarBebida
            // 
            this.btnAdicionarBebida.BackColor = System.Drawing.Color.Maroon;
            this.btnAdicionarBebida.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionarBebida.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnAdicionarBebida.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown;
            this.btnAdicionarBebida.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdicionarBebida.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarBebida.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarBebida.ForeColor = System.Drawing.Color.White;
            this.btnAdicionarBebida.Location = new System.Drawing.Point(12, 365);
            this.btnAdicionarBebida.Name = "btnAdicionarBebida";
            this.btnAdicionarBebida.Size = new System.Drawing.Size(196, 23);
            this.btnAdicionarBebida.TabIndex = 13;
            this.btnAdicionarBebida.Text = "Adicionar +";
            this.btnAdicionarBebida.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdicionarBebida.UseVisualStyleBackColor = false;
            this.btnAdicionarBebida.Click += new System.EventHandler(this.btnAdicionarBebida_Click);
            // 
            // lblTelefone2
            // 
            this.lblTelefone2.AutoSize = true;
            this.lblTelefone2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone2.Location = new System.Drawing.Point(5, 130);
            this.lblTelefone2.Name = "lblTelefone2";
            this.lblTelefone2.Size = new System.Drawing.Size(0, 17);
            this.lblTelefone2.TabIndex = 15;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(5, 177);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(0, 17);
            this.lblEndereco.TabIndex = 16;
            // 
            // pnlPedido
            // 
            this.pnlPedido.Controls.Add(this.button1);
            this.pnlPedido.Controls.Add(this.btnFinalizarPedido);
            this.pnlPedido.Controls.Add(this.btnRemoverItemComanda);
            this.pnlPedido.Controls.Add(this.btnLimparListaComanda);
            this.pnlPedido.Controls.Add(this.lblEscolhaPizza2);
            this.pnlPedido.Controls.Add(this.label7);
            this.pnlPedido.Controls.Add(this.lblEscolhaPizza1);
            this.pnlPedido.Controls.Add(this.label6);
            this.pnlPedido.Controls.Add(this.groupBox1);
            this.pnlPedido.Controls.Add(this.btnAdicionarPizza);
            this.pnlPedido.Controls.Add(this.btnAdicionarBebida);
            this.pnlPedido.Controls.Add(this.lstBebidas);
            this.pnlPedido.Controls.Add(this.lblTituloBebida);
            this.pnlPedido.Controls.Add(this.lblTituloPizza);
            this.pnlPedido.Controls.Add(this.btnPizza2);
            this.pnlPedido.Controls.Add(this.btnPizza1);
            this.pnlPedido.Location = new System.Drawing.Point(149, 4);
            this.pnlPedido.Name = "pnlPedido";
            this.pnlPedido.Size = new System.Drawing.Size(456, 412);
            this.pnlPedido.TabIndex = 17;
            this.pnlPedido.Visible = false;
            // 
            // btnFinalizarPedido
            // 
            this.btnFinalizarPedido.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnFinalizarPedido.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinalizarPedido.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnFinalizarPedido.FlatAppearance.BorderSize = 0;
            this.btnFinalizarPedido.FlatAppearance.MouseDownBackColor = System.Drawing.Color.YellowGreen;
            this.btnFinalizarPedido.FlatAppearance.MouseOverBackColor = System.Drawing.Color.OliveDrab;
            this.btnFinalizarPedido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizarPedido.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarPedido.ForeColor = System.Drawing.Color.White;
            this.btnFinalizarPedido.Location = new System.Drawing.Point(230, 352);
            this.btnFinalizarPedido.Name = "btnFinalizarPedido";
            this.btnFinalizarPedido.Size = new System.Drawing.Size(207, 36);
            this.btnFinalizarPedido.TabIndex = 25;
            this.btnFinalizarPedido.Text = "Finalizar Pedido";
            this.btnFinalizarPedido.UseVisualStyleBackColor = false;
            this.btnFinalizarPedido.Click += new System.EventHandler(this.btnFinalizarPedido_Click);
            // 
            // btnRemoverItemComanda
            // 
            this.btnRemoverItemComanda.BackColor = System.Drawing.Color.Maroon;
            this.btnRemoverItemComanda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoverItemComanda.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnRemoverItemComanda.FlatAppearance.BorderSize = 0;
            this.btnRemoverItemComanda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.RosyBrown;
            this.btnRemoverItemComanda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRemoverItemComanda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoverItemComanda.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoverItemComanda.ForeColor = System.Drawing.Color.White;
            this.btnRemoverItemComanda.Location = new System.Drawing.Point(334, 315);
            this.btnRemoverItemComanda.Name = "btnRemoverItemComanda";
            this.btnRemoverItemComanda.Size = new System.Drawing.Size(103, 36);
            this.btnRemoverItemComanda.TabIndex = 24;
            this.btnRemoverItemComanda.Text = "Remover";
            this.btnRemoverItemComanda.UseVisualStyleBackColor = false;
            this.btnRemoverItemComanda.Click += new System.EventHandler(this.btnRemoverItemComanda_Click);
            // 
            // btnLimparListaComanda
            // 
            this.btnLimparListaComanda.BackColor = System.Drawing.Color.MistyRose;
            this.btnLimparListaComanda.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimparListaComanda.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnLimparListaComanda.FlatAppearance.BorderSize = 0;
            this.btnLimparListaComanda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.btnLimparListaComanda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLimparListaComanda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimparListaComanda.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparListaComanda.ForeColor = System.Drawing.Color.Maroon;
            this.btnLimparListaComanda.Location = new System.Drawing.Point(230, 315);
            this.btnLimparListaComanda.Name = "btnLimparListaComanda";
            this.btnLimparListaComanda.Size = new System.Drawing.Size(103, 36);
            this.btnLimparListaComanda.TabIndex = 23;
            this.btnLimparListaComanda.Text = "Limpar";
            this.btnLimparListaComanda.UseVisualStyleBackColor = false;
            this.btnLimparListaComanda.Click += new System.EventHandler(this.btnLimparComanda_Click);
            // 
            // lblEscolhaPizza2
            // 
            this.lblEscolhaPizza2.AutoSize = true;
            this.lblEscolhaPizza2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEscolhaPizza2.Location = new System.Drawing.Point(46, 203);
            this.lblEscolhaPizza2.Name = "lblEscolhaPizza2";
            this.lblEscolhaPizza2.Size = new System.Drawing.Size(0, 16);
            this.lblEscolhaPizza2.TabIndex = 17;
            this.lblEscolhaPizza2.TextChanged += new System.EventHandler(this.lblEscolhaPizza2_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "Meia: ";
            // 
            // lblEscolhaPizza1
            // 
            this.lblEscolhaPizza1.AutoSize = true;
            this.lblEscolhaPizza1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEscolhaPizza1.Location = new System.Drawing.Point(46, 186);
            this.lblEscolhaPizza1.Name = "lblEscolhaPizza1";
            this.lblEscolhaPizza1.Size = new System.Drawing.Size(0, 16);
            this.lblEscolhaPizza1.TabIndex = 15;
            this.lblEscolhaPizza1.TextChanged += new System.EventHandler(this.lblEscolhaPizza2_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 186);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Meia: ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstPedido);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(230, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(207, 304);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "3 - Resumo:";
            // 
            // lstPedido
            // 
            this.lstPedido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstPedido.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPedido.FormattingEnabled = true;
            this.lstPedido.ItemHeight = 17;
            this.lstPedido.Location = new System.Drawing.Point(6, 29);
            this.lstPedido.Name = "lstPedido";
            this.lstPedido.Size = new System.Drawing.Size(195, 255);
            this.lstPedido.TabIndex = 0;
            // 
            // btnAdicionarPizza
            // 
            this.btnAdicionarPizza.BackColor = System.Drawing.Color.Maroon;
            this.btnAdicionarPizza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdicionarPizza.Enabled = false;
            this.btnAdicionarPizza.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btnAdicionarPizza.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown;
            this.btnAdicionarPizza.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAdicionarPizza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarPizza.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarPizza.ForeColor = System.Drawing.Color.White;
            this.btnAdicionarPizza.Location = new System.Drawing.Point(12, 223);
            this.btnAdicionarPizza.Name = "btnAdicionarPizza";
            this.btnAdicionarPizza.Size = new System.Drawing.Size(196, 24);
            this.btnAdicionarPizza.TabIndex = 18;
            this.btnAdicionarPizza.Text = "Escolha a pizza";
            this.btnAdicionarPizza.UseVisualStyleBackColor = false;
            this.btnAdicionarPizza.Click += new System.EventHandler(this.btnAdicionarPizza_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Telefone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 21;
            this.label4.Text = "Endereço:";
            // 
            // pnlCliente
            // 
            this.pnlCliente.Controls.Add(this.lblUltimoPedido);
            this.pnlCliente.Controls.Add(this.label5);
            this.pnlCliente.Controls.Add(this.label4);
            this.pnlCliente.Controls.Add(this.label3);
            this.pnlCliente.Controls.Add(this.label2);
            this.pnlCliente.Controls.Add(this.lblEndereco);
            this.pnlCliente.Controls.Add(this.lblTelefone2);
            this.pnlCliente.Controls.Add(this.lblTelefone1);
            this.pnlCliente.Controls.Add(this.lblNomeCliente);
            this.pnlCliente.Controls.Add(this.lblDadosCliente);
            this.pnlCliente.Location = new System.Drawing.Point(8, 103);
            this.pnlCliente.Name = "pnlCliente";
            this.pnlCliente.Size = new System.Drawing.Size(140, 300);
            this.pnlCliente.TabIndex = 22;
            this.pnlCliente.Visible = false;
            // 
            // lblUltimoPedido
            // 
            this.lblUltimoPedido.AutoSize = true;
            this.lblUltimoPedido.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUltimoPedido.Location = new System.Drawing.Point(5, 255);
            this.lblUltimoPedido.Name = "lblUltimoPedido";
            this.lblUltimoPedido.Size = new System.Drawing.Size(0, 17);
            this.lblUltimoPedido.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Último pedido:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Telefone:";
            // 
            // txtTelefone
            // 
            this.txtTelefone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtTelefone.Location = new System.Drawing.Point(16, 49);
            this.txtTelefone.Mask = "(00) 000000009";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.PromptChar = ' ';
            this.txtTelefone.Size = new System.Drawing.Size(101, 13);
            this.txtTelefone.TabIndex = 18;
            this.txtTelefone.Text = "1132254444";
            this.txtTelefone.TextChanged += new System.EventHandler(this.txtTelefone_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Location = new System.Drawing.Point(14, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(80, 1);
            this.panel1.TabIndex = 23;
            // 
            // btnPesquisarTelefone
            // 
            this.btnPesquisarTelefone.BackColor = System.Drawing.Color.Transparent;
            this.btnPesquisarTelefone.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPesquisarTelefone.FlatAppearance.BorderSize = 0;
            this.btnPesquisarTelefone.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPesquisarTelefone.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPesquisarTelefone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarTelefone.Image = global::NovaAlianca.Properties.Resources.loupe;
            this.btnPesquisarTelefone.Location = new System.Drawing.Point(96, 43);
            this.btnPesquisarTelefone.Name = "btnPesquisarTelefone";
            this.btnPesquisarTelefone.Size = new System.Drawing.Size(30, 25);
            this.btnPesquisarTelefone.TabIndex = 1;
            this.btnPesquisarTelefone.Text = "     ";
            this.btnPesquisarTelefone.UseVisualStyleBackColor = false;
            this.btnPesquisarTelefone.Click += new System.EventHandler(this.btnPesquisarTelefone_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.btnPesquisarTelefone);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.pnlCliente);
            this.panel2.Controls.Add(this.txtTelefone);
            this.panel2.Controls.Add(this.pnlPedido);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(648, 441);
            this.panel2.TabIndex = 24;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Maroon;
            this.panel3.Location = new System.Drawing.Point(146, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2, 385);
            this.panel3.TabIndex = 24;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 45);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 133);
            this.button1.TabIndex = 26;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // RealizarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(681, 472);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RealizarPedido";
            this.Text = "RealizarPedido";
            this.Load += new System.EventHandler(this.RealizarPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblProdutoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetoPizzariaDataSet)).EndInit();
            this.pnlPedido.ResumeLayout(false);
            this.pnlPedido.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.pnlCliente.ResumeLayout(false);
            this.pnlCliente.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblDadosCliente;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.Label lblTelefone1;
        private System.Windows.Forms.Button btnPizza1;
        private System.Windows.Forms.Button btnPizza2;
        private System.Windows.Forms.Label lblTituloPizza;
        private System.Windows.Forms.Label lblTituloBebida;
        private ProjetoPizzariaDataSet projetoPizzariaDataSet;
        private System.Windows.Forms.BindingSource tblProdutoBindingSource;
        private ProjetoPizzariaDataSetTableAdapters.tblProdutoTableAdapter tblProdutoTableAdapter;
        private System.Windows.Forms.ListBox lstBebidas;
        private System.Windows.Forms.Button btnAdicionarBebida;
        private System.Windows.Forms.Label lblTelefone2;
        private System.Windows.Forms.Label lblEndereco;
        private System.Windows.Forms.Panel pnlPedido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlCliente;
        private System.Windows.Forms.Label lblUltimoPedido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblEscolhaPizza1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAdicionarPizza;
        private System.Windows.Forms.Label lblEscolhaPizza2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox lstPedido;
        private System.Windows.Forms.Button btnFinalizarPedido;
        private System.Windows.Forms.Button btnRemoverItemComanda;
        private System.Windows.Forms.Button btnLimparListaComanda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPesquisarTelefone;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
    }
}