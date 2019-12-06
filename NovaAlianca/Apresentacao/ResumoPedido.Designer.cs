namespace NovaAlianca.Apresentacao
{
    partial class ResumoPedido
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
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lstPedido = new System.Windows.Forms.ListBox();
            this.lblPedido = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblProdutoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetoPizzariaDataSet1)).BeginInit();
            this.panel1.SuspendLayout();
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
            this.label1.Location = new System.Drawing.Point(6, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Resumo do pedido:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(11, 301);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(262, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblPedido);
            this.panel1.Controls.Add(this.lstPedido);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(287, 350);
            this.panel1.TabIndex = 3;
            // 
            // lstPedido
            // 
            this.lstPedido.BackColor = System.Drawing.Color.White;
            this.lstPedido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstPedido.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPedido.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lstPedido.FormattingEnabled = true;
            this.lstPedido.ItemHeight = 17;
            this.lstPedido.Location = new System.Drawing.Point(11, 43);
            this.lstPedido.Name = "lstPedido";
            this.lstPedido.Size = new System.Drawing.Size(262, 255);
            this.lstPedido.TabIndex = 3;
            // 
            // lblPedido
            // 
            this.lblPedido.AutoSize = true;
            this.lblPedido.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPedido.Location = new System.Drawing.Point(172, 7);
            this.lblPedido.Name = "lblPedido";
            this.lblPedido.Size = new System.Drawing.Size(0, 21);
            this.lblPedido.TabIndex = 4;
            // 
            // ResumoPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(287, 350);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ResumoPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EscolherBancoDados";
            this.Load += new System.EventHandler(this.ResumoPedido_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblProdutoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetoPizzariaDataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private ProjetoPizzariaDataSet1 projetoPizzariaDataSet1;
        private System.Windows.Forms.BindingSource tblProdutoBindingSource;
        private ProjetoPizzariaDataSet1TableAdapters.tblProdutoTableAdapter tblProdutoTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox lstPedido;
        private System.Windows.Forms.Label lblPedido;
    }
}