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
            this.label1 = new System.Windows.Forms.Label();
            this.lblDadosCliente = new System.Windows.Forms.Label();
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.lblTelefone1 = new System.Windows.Forms.Label();
            this.btnPizza2 = new System.Windows.Forms.Button();
            this.btnPizza1 = new System.Windows.Forms.Button();
            this.btnPesquisarTelefone = new System.Windows.Forms.Button();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblEscolhaPizza2 = new System.Windows.Forms.Label();
            this.lblEscolhaPizza1 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlCliente = new System.Windows.Forms.Panel();
            this.lblUltimoPedido = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblProdutoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetoPizzariaDataSet)).BeginInit();
            this.pnlPedido.SuspendLayout();
            this.pnlCliente.SuspendLayout();
            this.SuspendLayout();
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
            // lblDadosCliente
            // 
            this.lblDadosCliente.AutoSize = true;
            this.lblDadosCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDadosCliente.Location = new System.Drawing.Point(5, 21);
            this.lblDadosCliente.Name = "lblDadosCliente";
            this.lblDadosCliente.Size = new System.Drawing.Size(123, 17);
            this.lblDadosCliente.TabIndex = 3;
            this.lblDadosCliente.Text = "Dados do cliente:";
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCliente.Location = new System.Drawing.Point(5, 61);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(0, 17);
            this.lblNomeCliente.TabIndex = 4;
            // 
            // lblTelefone1
            // 
            this.lblTelefone1.AutoSize = true;
            this.lblTelefone1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone1.Location = new System.Drawing.Point(5, 110);
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
            this.btnPizza2.Location = new System.Drawing.Point(112, 45);
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
            this.btnPizza1.Location = new System.Drawing.Point(37, 45);
            this.btnPizza1.Name = "btnPizza1";
            this.btnPizza1.Size = new System.Drawing.Size(65, 137);
            this.btnPizza1.TabIndex = 6;
            this.btnPizza1.UseVisualStyleBackColor = false;
            this.btnPizza1.Click += new System.EventHandler(this.btnPizza1_Click);
            // 
            // btnPesquisarTelefone
            // 
            this.btnPesquisarTelefone.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnPesquisarTelefone.Image = global::NovaAlianca.Properties.Resources.loupe;
            this.btnPesquisarTelefone.Location = new System.Drawing.Point(123, 46);
            this.btnPesquisarTelefone.Name = "btnPesquisarTelefone";
            this.btnPesquisarTelefone.Size = new System.Drawing.Size(30, 25);
            this.btnPesquisarTelefone.TabIndex = 1;
            this.btnPesquisarTelefone.Text = "     ";
            this.btnPesquisarTelefone.UseVisualStyleBackColor = true;
            this.btnPesquisarTelefone.Click += new System.EventHandler(this.btnPesquisarTelefone_Click);
            // 
            // lblTituloPizza
            // 
            this.lblTituloPizza.AutoSize = true;
            this.lblTituloPizza.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloPizza.Location = new System.Drawing.Point(5, 10);
            this.lblTituloPizza.Name = "lblTituloPizza";
            this.lblTituloPizza.Size = new System.Drawing.Size(51, 21);
            this.lblTituloPizza.TabIndex = 8;
            this.lblTituloPizza.Text = "Pizza:";
            // 
            // lblTituloBebida
            // 
            this.lblTituloBebida.AutoSize = true;
            this.lblTituloBebida.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloBebida.Location = new System.Drawing.Point(5, 265);
            this.lblTituloBebida.Name = "lblTituloBebida";
            this.lblTituloBebida.Size = new System.Drawing.Size(69, 21);
            this.lblTituloBebida.TabIndex = 9;
            this.lblTituloBebida.Text = "Bebida:";
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
            this.lstBebidas.Location = new System.Drawing.Point(9, 289);
            this.lstBebidas.Name = "lstBebidas";
            this.lstBebidas.Size = new System.Drawing.Size(207, 68);
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
            this.btnAdicionarBebida.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionarBebida.ForeColor = System.Drawing.Color.White;
            this.btnAdicionarBebida.Location = new System.Drawing.Point(9, 365);
            this.btnAdicionarBebida.Name = "btnAdicionarBebida";
            this.btnAdicionarBebida.Size = new System.Drawing.Size(207, 23);
            this.btnAdicionarBebida.TabIndex = 13;
            this.btnAdicionarBebida.Text = "Adicionar";
            this.btnAdicionarBebida.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAdicionarBebida.UseVisualStyleBackColor = false;
            // 
            // lblTelefone2
            // 
            this.lblTelefone2.AutoSize = true;
            this.lblTelefone2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefone2.Location = new System.Drawing.Point(5, 127);
            this.lblTelefone2.Name = "lblTelefone2";
            this.lblTelefone2.Size = new System.Drawing.Size(0, 17);
            this.lblTelefone2.TabIndex = 15;
            // 
            // lblEndereco
            // 
            this.lblEndereco.AutoSize = true;
            this.lblEndereco.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndereco.Location = new System.Drawing.Point(5, 174);
            this.lblEndereco.Name = "lblEndereco";
            this.lblEndereco.Size = new System.Drawing.Size(0, 17);
            this.lblEndereco.TabIndex = 16;
            // 
            // pnlPedido
            // 
            this.pnlPedido.Controls.Add(this.lblEscolhaPizza2);
            this.pnlPedido.Controls.Add(this.label7);
            this.pnlPedido.Controls.Add(this.lblEscolhaPizza1);
            this.pnlPedido.Controls.Add(this.label6);
            this.pnlPedido.Controls.Add(this.groupBox1);
            this.pnlPedido.Controls.Add(this.button1);
            this.pnlPedido.Controls.Add(this.btnAdicionarBebida);
            this.pnlPedido.Controls.Add(this.lstBebidas);
            this.pnlPedido.Controls.Add(this.lblTituloBebida);
            this.pnlPedido.Controls.Add(this.lblTituloPizza);
            this.pnlPedido.Controls.Add(this.btnPizza2);
            this.pnlPedido.Controls.Add(this.btnPizza1);
            this.pnlPedido.Location = new System.Drawing.Point(166, 4);
            this.pnlPedido.Name = "pnlPedido";
            this.pnlPedido.Size = new System.Drawing.Size(534, 412);
            this.pnlPedido.TabIndex = 17;
            this.pnlPedido.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(226, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(190, 304);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resumo:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(9, 228);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 24);
            this.button1.TabIndex = 18;
            this.button1.Text = "Adicionar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lblEscolhaPizza2
            // 
            this.lblEscolhaPizza2.AutoSize = true;
            this.lblEscolhaPizza2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEscolhaPizza2.Location = new System.Drawing.Point(43, 205);
            this.lblEscolhaPizza2.Name = "lblEscolhaPizza2";
            this.lblEscolhaPizza2.Size = new System.Drawing.Size(0, 16);
            this.lblEscolhaPizza2.TabIndex = 17;
            // 
            // lblEscolhaPizza1
            // 
            this.lblEscolhaPizza1.AutoSize = true;
            this.lblEscolhaPizza1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEscolhaPizza1.Location = new System.Drawing.Point(43, 188);
            this.lblEscolhaPizza1.Name = "lblEscolhaPizza1";
            this.lblEscolhaPizza1.Size = new System.Drawing.Size(0, 16);
            this.lblEscolhaPizza1.TabIndex = 15;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(16, 49);
            this.maskedTextBox1.Mask = "(00) 000000009";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.PromptChar = ' ';
            this.maskedTextBox1.Size = new System.Drawing.Size(101, 20);
            this.maskedTextBox1.TabIndex = 18;
            this.maskedTextBox1.Text = "1132254444";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 20;
            this.label3.Text = "Telefone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 158);
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
            this.pnlCliente.Location = new System.Drawing.Point(8, 87);
            this.pnlCliente.Name = "pnlCliente";
            this.pnlCliente.Size = new System.Drawing.Size(145, 321);
            this.pnlCliente.TabIndex = 22;
            this.pnlCliente.Visible = false;
            // 
            // lblUltimoPedido
            // 
            this.lblUltimoPedido.AutoSize = true;
            this.lblUltimoPedido.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUltimoPedido.Location = new System.Drawing.Point(5, 240);
            this.lblUltimoPedido.Name = "lblUltimoPedido";
            this.lblUltimoPedido.Size = new System.Drawing.Size(0, 17);
            this.lblUltimoPedido.TabIndex = 23;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 224);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 16);
            this.label5.TabIndex = 22;
            this.label5.Text = "Último pedido:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 188);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "Meia: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 205);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 16);
            this.label7.TabIndex = 21;
            this.label7.Text = "Meia: ";
            // 
            // RealizarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(733, 420);
            this.Controls.Add(this.pnlCliente);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.pnlPedido);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPesquisarTelefone);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RealizarPedido";
            this.Text = "RealizarPedido";
            this.Load += new System.EventHandler(this.RealizarPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblProdutoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetoPizzariaDataSet)).EndInit();
            this.pnlPedido.ResumeLayout(false);
            this.pnlPedido.PerformLayout();
            this.pnlCliente.ResumeLayout(false);
            this.pnlCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPesquisarTelefone;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel pnlCliente;
        private System.Windows.Forms.Label lblUltimoPedido;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblEscolhaPizza1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblEscolhaPizza2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}