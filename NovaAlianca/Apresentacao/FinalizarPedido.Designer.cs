namespace NovaAlianca.Apresentacao
{
    partial class FinalizarPedido
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
            this.tblProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projetoPizzariaDataSet1 = new NovaAlianca.ProjetoPizzariaDataSet1();
            this.tblProdutoTableAdapter = new NovaAlianca.ProjetoPizzariaDataSet1TableAdapters.tblProdutoTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdbDinheiro = new System.Windows.Forms.RadioButton();
            this.rdbRefeicao = new System.Windows.Forms.RadioButton();
            this.rdbCredito = new System.Windows.Forms.RadioButton();
            this.rdbDebito = new System.Windows.Forms.RadioButton();
            this.lblTroco = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tblProdutoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetoPizzariaDataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tblProdutoBindingSource
            // 
            this.tblProdutoBindingSource.DataMember = "tblProduto";
            this.tblProdutoBindingSource.DataSource = this.projetoPizzariaDataSet1;
            // 
            // projetoPizzariaDataSet1
            // 
            this.projetoPizzariaDataSet1.DataSetName = "ProjetoPizzariaDataSet1";
            this.projetoPizzariaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblProdutoTableAdapter
            // 
            this.tblProdutoTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Forma de pagamento:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdbDinheiro);
            this.panel1.Controls.Add(this.rdbRefeicao);
            this.panel1.Controls.Add(this.rdbCredito);
            this.panel1.Controls.Add(this.rdbDebito);
            this.panel1.Location = new System.Drawing.Point(16, 145);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 98);
            this.panel1.TabIndex = 1;
            // 
            // rdbDinheiro
            // 
            this.rdbDinheiro.AutoSize = true;
            this.rdbDinheiro.Location = new System.Drawing.Point(4, 76);
            this.rdbDinheiro.Name = "rdbDinheiro";
            this.rdbDinheiro.Size = new System.Drawing.Size(64, 17);
            this.rdbDinheiro.TabIndex = 3;
            this.rdbDinheiro.TabStop = true;
            this.rdbDinheiro.Text = "Dinheiro";
            this.rdbDinheiro.UseVisualStyleBackColor = true;
            this.rdbDinheiro.CheckedChanged += new System.EventHandler(this.rdbDinheiro_CheckedChanged);
            // 
            // rdbRefeicao
            // 
            this.rdbRefeicao.AutoSize = true;
            this.rdbRefeicao.Location = new System.Drawing.Point(4, 52);
            this.rdbRefeicao.Name = "rdbRefeicao";
            this.rdbRefeicao.Size = new System.Drawing.Size(87, 17);
            this.rdbRefeicao.TabIndex = 2;
            this.rdbRefeicao.Text = "Vale refeição";
            this.rdbRefeicao.UseVisualStyleBackColor = true;
            // 
            // rdbCredito
            // 
            this.rdbCredito.AutoSize = true;
            this.rdbCredito.Location = new System.Drawing.Point(4, 28);
            this.rdbCredito.Name = "rdbCredito";
            this.rdbCredito.Size = new System.Drawing.Size(58, 17);
            this.rdbCredito.TabIndex = 1;
            this.rdbCredito.Text = "Crédito";
            this.rdbCredito.UseVisualStyleBackColor = true;
            // 
            // rdbDebito
            // 
            this.rdbDebito.AutoSize = true;
            this.rdbDebito.Checked = true;
            this.rdbDebito.Location = new System.Drawing.Point(4, 4);
            this.rdbDebito.Name = "rdbDebito";
            this.rdbDebito.Size = new System.Drawing.Size(56, 17);
            this.rdbDebito.TabIndex = 0;
            this.rdbDebito.TabStop = true;
            this.rdbDebito.Text = "Débito";
            this.rdbDebito.UseVisualStyleBackColor = true;
            // 
            // lblTroco
            // 
            this.lblTroco.AutoSize = true;
            this.lblTroco.Location = new System.Drawing.Point(26, 247);
            this.lblTroco.Name = "lblTroco";
            this.lblTroco.Size = new System.Drawing.Size(85, 13);
            this.lblTroco.TabIndex = 2;
            this.lblTroco.Text = "Troco para (R$):";
            this.lblTroco.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Valor total:";
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValorTotal.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblValorTotal.Location = new System.Drawing.Point(59, 39);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(0, 33);
            this.lblValorTotal.TabIndex = 4;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BackColor = System.Drawing.Color.White;
            this.numericUpDown1.Location = new System.Drawing.Point(117, 245);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(66, 20);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.Visible = false;
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnFinalizar.FlatAppearance.BorderSize = 0;
            this.btnFinalizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LimeGreen;
            this.btnFinalizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizar.ForeColor = System.Drawing.Color.White;
            this.btnFinalizar.Location = new System.Drawing.Point(16, 291);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(184, 37);
            this.btnFinalizar.TabIndex = 7;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = false;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.White;
            this.checkBox1.Location = new System.Drawing.Point(100, 83);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(100, 17);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Frete + R$ 5,00";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnSair);
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.btnFinalizar);
            this.panel2.Controls.Add(this.numericUpDown1);
            this.panel2.Controls.Add(this.lblValorTotal);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.lblTroco);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(221, 344);
            this.panel2.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "R$ ";
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Maroon;
            this.btnSair.Location = new System.Drawing.Point(180, -2);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(39, 27);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "X";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // FinalizarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(221, 344);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FinalizarPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EscolherPizza";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Login_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Login_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.tblProdutoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetoPizzariaDataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private ProjetoPizzariaDataSet1 projetoPizzariaDataSet1;
        private System.Windows.Forms.BindingSource tblProdutoBindingSource;
        private ProjetoPizzariaDataSet1TableAdapters.tblProdutoTableAdapter tblProdutoTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdbDinheiro;
        private System.Windows.Forms.RadioButton rdbRefeicao;
        private System.Windows.Forms.RadioButton rdbCredito;
        private System.Windows.Forms.RadioButton rdbDebito;
        private System.Windows.Forms.Label lblTroco;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label label3;
    }
}