namespace NovaAlianca.Apresentacao
{
    partial class PaginaRelatorio2
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
            this.lblRelatorio = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgCliente = new System.Windows.Forms.DataGridView();
            this.stapedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descstapedidoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpopagamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desctpopagamentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qtdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.somaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblClienteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.projetoPizzariaDataSet6 = new NovaAlianca.ProjetoPizzariaDataSet6();
            this.btnSair = new System.Windows.Forms.Button();
            this.tblClienteTableAdapter1 = new NovaAlianca.ProjetoPizzariaDataSet6TableAdapters.tblClienteTableAdapter();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblClienteBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetoPizzariaDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRelatorio
            // 
            this.lblRelatorio.AutoSize = true;
            this.lblRelatorio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRelatorio.Location = new System.Drawing.Point(6, 7);
            this.lblRelatorio.Name = "lblRelatorio";
            this.lblRelatorio.Size = new System.Drawing.Size(79, 21);
            this.lblRelatorio.TabIndex = 3;
            this.lblRelatorio.Text = "Relatório";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.dtgCliente);
            this.panel2.Controls.Add(this.btnSair);
            this.panel2.Controls.Add(this.lblRelatorio);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(511, 509);
            this.panel2.TabIndex = 9;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Login_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Login_MouseUp);
            // 
            // dtgCliente
            // 
            this.dtgCliente.AllowUserToAddRows = false;
            this.dtgCliente.AllowUserToDeleteRows = false;
            this.dtgCliente.AutoGenerateColumns = false;
            this.dtgCliente.BackgroundColor = System.Drawing.Color.White;
            this.dtgCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.stapedidoDataGridViewTextBoxColumn,
            this.descstapedidoDataGridViewTextBoxColumn,
            this.dataDataGridViewTextBoxColumn,
            this.horaDataGridViewTextBoxColumn,
            this.tpopagamentoDataGridViewTextBoxColumn,
            this.desctpopagamentoDataGridViewTextBoxColumn,
            this.qtdDataGridViewTextBoxColumn,
            this.somaDataGridViewTextBoxColumn});
            this.dtgCliente.DataSource = this.tblClienteBindingSource1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgCliente.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgCliente.GridColor = System.Drawing.Color.White;
            this.dtgCliente.Location = new System.Drawing.Point(10, 35);
            this.dtgCliente.Name = "dtgCliente";
            this.dtgCliente.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgCliente.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgCliente.RowHeadersVisible = false;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightCoral;
            this.dtgCliente.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgCliente.Size = new System.Drawing.Size(487, 436);
            this.dtgCliente.TabIndex = 10;
            // 
            // stapedidoDataGridViewTextBoxColumn
            // 
            this.stapedidoDataGridViewTextBoxColumn.DataPropertyName = "sta_pedido";
            this.stapedidoDataGridViewTextBoxColumn.HeaderText = "sta_pedido";
            this.stapedidoDataGridViewTextBoxColumn.Name = "stapedidoDataGridViewTextBoxColumn";
            this.stapedidoDataGridViewTextBoxColumn.ReadOnly = true;
            this.stapedidoDataGridViewTextBoxColumn.Visible = false;
            // 
            // descstapedidoDataGridViewTextBoxColumn
            // 
            this.descstapedidoDataGridViewTextBoxColumn.DataPropertyName = "desc_sta_pedido";
            this.descstapedidoDataGridViewTextBoxColumn.FillWeight = 150F;
            this.descstapedidoDataGridViewTextBoxColumn.HeaderText = "Situação";
            this.descstapedidoDataGridViewTextBoxColumn.Name = "descstapedidoDataGridViewTextBoxColumn";
            this.descstapedidoDataGridViewTextBoxColumn.ReadOnly = true;
            this.descstapedidoDataGridViewTextBoxColumn.Width = 138;
            // 
            // dataDataGridViewTextBoxColumn
            // 
            this.dataDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataDataGridViewTextBoxColumn.DataPropertyName = "data";
            this.dataDataGridViewTextBoxColumn.FillWeight = 80F;
            this.dataDataGridViewTextBoxColumn.HeaderText = "Data";
            this.dataDataGridViewTextBoxColumn.Name = "dataDataGridViewTextBoxColumn";
            this.dataDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // horaDataGridViewTextBoxColumn
            // 
            this.horaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.horaDataGridViewTextBoxColumn.DataPropertyName = "hora";
            this.horaDataGridViewTextBoxColumn.FillWeight = 80F;
            this.horaDataGridViewTextBoxColumn.HeaderText = "Hora";
            this.horaDataGridViewTextBoxColumn.Name = "horaDataGridViewTextBoxColumn";
            this.horaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tpopagamentoDataGridViewTextBoxColumn
            // 
            this.tpopagamentoDataGridViewTextBoxColumn.DataPropertyName = "tpo_pagamento";
            this.tpopagamentoDataGridViewTextBoxColumn.HeaderText = "tpo_pagamento";
            this.tpopagamentoDataGridViewTextBoxColumn.Name = "tpopagamentoDataGridViewTextBoxColumn";
            this.tpopagamentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tpopagamentoDataGridViewTextBoxColumn.Visible = false;
            // 
            // desctpopagamentoDataGridViewTextBoxColumn
            // 
            this.desctpopagamentoDataGridViewTextBoxColumn.DataPropertyName = "desc_tpo_pagamento";
            this.desctpopagamentoDataGridViewTextBoxColumn.FillWeight = 150F;
            this.desctpopagamentoDataGridViewTextBoxColumn.HeaderText = "Pagamento";
            this.desctpopagamentoDataGridViewTextBoxColumn.Name = "desctpopagamentoDataGridViewTextBoxColumn";
            this.desctpopagamentoDataGridViewTextBoxColumn.ReadOnly = true;
            this.desctpopagamentoDataGridViewTextBoxColumn.Width = 130;
            // 
            // qtdDataGridViewTextBoxColumn
            // 
            this.qtdDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.qtdDataGridViewTextBoxColumn.DataPropertyName = "qtd";
            this.qtdDataGridViewTextBoxColumn.FillWeight = 50F;
            this.qtdDataGridViewTextBoxColumn.HeaderText = "Qtd.";
            this.qtdDataGridViewTextBoxColumn.Name = "qtdDataGridViewTextBoxColumn";
            this.qtdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // somaDataGridViewTextBoxColumn
            // 
            this.somaDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.somaDataGridViewTextBoxColumn.DataPropertyName = "soma";
            this.somaDataGridViewTextBoxColumn.FillWeight = 70F;
            this.somaDataGridViewTextBoxColumn.HeaderText = "Valor";
            this.somaDataGridViewTextBoxColumn.Name = "somaDataGridViewTextBoxColumn";
            this.somaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tblClienteBindingSource1
            // 
            this.tblClienteBindingSource1.DataMember = "tblCliente";
            this.tblClienteBindingSource1.DataSource = this.projetoPizzariaDataSet6;
            // 
            // projetoPizzariaDataSet6
            // 
            this.projetoPizzariaDataSet6.DataSetName = "ProjetoPizzariaDataSet6";
            this.projetoPizzariaDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Maroon;
            this.btnSair.Location = new System.Drawing.Point(470, -2);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(39, 27);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "X";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // tblClienteTableAdapter1
            // 
            this.tblClienteTableAdapter1.ClearBeforeFill = true;
            // 
            // PaginaRelatorio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(511, 509);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PaginaRelatorio1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EscolherPizza";
            this.Load += new System.EventHandler(this.PaginaRelatorio_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Login_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Login_MouseUp);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblClienteBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetoPizzariaDataSet6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblRelatorio;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nmeclienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nmrtelefone1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nmrtelefone2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nmrcepDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dscruaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nmrenderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dtacadastroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsclogincadastroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dtgCliente;
        private ProjetoPizzariaDataSet6 projetoPizzariaDataSet6;
        private System.Windows.Forms.BindingSource tblClienteBindingSource1;
        private ProjetoPizzariaDataSet6TableAdapters.tblClienteTableAdapter tblClienteTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn stapedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descstapedidoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tpopagamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn desctpopagamentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn qtdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn somaDataGridViewTextBoxColumn;
    }
}