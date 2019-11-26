namespace NovaAlianca.Apresentacao
{
    partial class EscolherPizza
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
            this.lstSalgada = new System.Windows.Forms.ListBox();
            this.tblProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projetoPizzariaDataSet1 = new NovaAlianca.ProjetoPizzariaDataSet1();
            this.tblProdutoTableAdapter = new NovaAlianca.ProjetoPizzariaDataSet1TableAdapters.tblProdutoTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdbDoce = new System.Windows.Forms.RadioButton();
            this.rdbSalgada = new System.Windows.Forms.RadioButton();
            this.btnSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tblProdutoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetoPizzariaDataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstSalgada
            // 
            this.lstSalgada.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstSalgada.DataSource = this.tblProdutoBindingSource;
            this.lstSalgada.DisplayMember = "dsc_produto";
            this.lstSalgada.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSalgada.ForeColor = System.Drawing.Color.Brown;
            this.lstSalgada.FormattingEnabled = true;
            this.lstSalgada.ItemHeight = 16;
            this.lstSalgada.Location = new System.Drawing.Point(12, 69);
            this.lstSalgada.Name = "lstSalgada";
            this.lstSalgada.Size = new System.Drawing.Size(225, 176);
            this.lstSalgada.TabIndex = 0;
            this.lstSalgada.ValueMember = "id_produto";
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 261);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(225, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "OK";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdbDoce);
            this.panel1.Controls.Add(this.rdbSalgada);
            this.panel1.Location = new System.Drawing.Point(12, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 37);
            this.panel1.TabIndex = 2;
            // 
            // rdbDoce
            // 
            this.rdbDoce.AutoSize = true;
            this.rdbDoce.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDoce.Location = new System.Drawing.Point(127, 8);
            this.rdbDoce.Name = "rdbDoce";
            this.rdbDoce.Size = new System.Drawing.Size(59, 21);
            this.rdbDoce.TabIndex = 1;
            this.rdbDoce.Text = "Doce";
            this.rdbDoce.UseVisualStyleBackColor = true;
            this.rdbDoce.CheckedChanged += new System.EventHandler(this.rdbDoce_CheckedChanged);
            // 
            // rdbSalgada
            // 
            this.rdbSalgada.AutoSize = true;
            this.rdbSalgada.Checked = true;
            this.rdbSalgada.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbSalgada.Location = new System.Drawing.Point(31, 8);
            this.rdbSalgada.Name = "rdbSalgada";
            this.rdbSalgada.Size = new System.Drawing.Size(76, 21);
            this.rdbSalgada.TabIndex = 0;
            this.rdbSalgada.TabStop = true;
            this.rdbSalgada.Text = "Salgada";
            this.rdbSalgada.UseVisualStyleBackColor = true;
            this.rdbSalgada.CheckedChanged += new System.EventHandler(this.rdbSalgada_CheckedChanged);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Maroon;
            this.btnSair.Location = new System.Drawing.Point(219, -3);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(39, 27);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "X";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // EscolherPizza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(251, 314);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lstSalgada);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EscolherPizza";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EscolherPizza";
            this.Load += new System.EventHandler(this.EscolherPizza_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Login_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Login_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.tblProdutoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetoPizzariaDataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstSalgada;
        private ProjetoPizzariaDataSet1 projetoPizzariaDataSet1;
        private System.Windows.Forms.BindingSource tblProdutoBindingSource;
        private ProjetoPizzariaDataSet1TableAdapters.tblProdutoTableAdapter tblProdutoTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rdbDoce;
        private System.Windows.Forms.RadioButton rdbSalgada;
        private System.Windows.Forms.Button btnSair;
    }
}