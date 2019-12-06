namespace NovaAlianca.Apresentacao
{
    partial class PaginaRelatorio1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblRelatorio = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgCliente = new System.Windows.Forms.DataGridView();
            this.idfuncionarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dsc_funcao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.situacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mmefuncionarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dscloginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dta_alteraco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dscloginalterouDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblFuncionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.projetoPizzariaDataSet7 = new NovaAlianca.ProjetoPizzariaDataSet7();
            this.btnSair = new System.Windows.Forms.Button();
            this.tblFuncionarioTableAdapter = new NovaAlianca.ProjetoPizzariaDataSet7TableAdapters.tblFuncionarioTableAdapter();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblFuncionarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetoPizzariaDataSet7)).BeginInit();
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
            this.panel2.Controls.Add(this.btnImprimir);
            this.panel2.Controls.Add(this.dtgCliente);
            this.panel2.Controls.Add(this.btnSair);
            this.panel2.Controls.Add(this.lblRelatorio);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(733, 509);
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
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.IndianRed;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dtgCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idfuncionarioDataGridViewTextBoxColumn,
            this.dsc_funcao,
            this.situacao,
            this.mmefuncionarioDataGridViewTextBoxColumn,
            this.dscloginDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn11,
            this.dta_alteraco,
            this.dscloginalterouDataGridViewTextBoxColumn});
            this.dtgCliente.DataSource = this.tblFuncionarioBindingSource;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgCliente.DefaultCellStyle = dataGridViewCellStyle14;
            this.dtgCliente.GridColor = System.Drawing.Color.White;
            this.dtgCliente.Location = new System.Drawing.Point(10, 35);
            this.dtgCliente.Name = "dtgCliente";
            this.dtgCliente.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.LightCoral;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgCliente.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dtgCliente.RowHeadersVisible = false;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.LightCoral;
            this.dtgCliente.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dtgCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgCliente.Size = new System.Drawing.Size(709, 436);
            this.dtgCliente.TabIndex = 10;
            // 
            // idfuncionarioDataGridViewTextBoxColumn
            // 
            this.idfuncionarioDataGridViewTextBoxColumn.DataPropertyName = "id_funcionario";
            this.idfuncionarioDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idfuncionarioDataGridViewTextBoxColumn.Name = "idfuncionarioDataGridViewTextBoxColumn";
            this.idfuncionarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.idfuncionarioDataGridViewTextBoxColumn.Width = 30;
            // 
            // dsc_funcao
            // 
            this.dsc_funcao.DataPropertyName = "dsc_funcao";
            this.dsc_funcao.HeaderText = "Função";
            this.dsc_funcao.Name = "dsc_funcao";
            this.dsc_funcao.ReadOnly = true;
            this.dsc_funcao.Width = 125;
            // 
            // situacao
            // 
            this.situacao.DataPropertyName = "situacao";
            this.situacao.HeaderText = "Situação";
            this.situacao.Name = "situacao";
            this.situacao.ReadOnly = true;
            this.situacao.Width = 75;
            // 
            // mmefuncionarioDataGridViewTextBoxColumn
            // 
            this.mmefuncionarioDataGridViewTextBoxColumn.DataPropertyName = "mme_funcionario";
            this.mmefuncionarioDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.mmefuncionarioDataGridViewTextBoxColumn.Name = "mmefuncionarioDataGridViewTextBoxColumn";
            this.mmefuncionarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.mmefuncionarioDataGridViewTextBoxColumn.Width = 150;
            // 
            // dscloginDataGridViewTextBoxColumn
            // 
            this.dscloginDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dscloginDataGridViewTextBoxColumn.DataPropertyName = "dsc_login";
            this.dscloginDataGridViewTextBoxColumn.FillWeight = 75F;
            this.dscloginDataGridViewTextBoxColumn.HeaderText = "Login";
            this.dscloginDataGridViewTextBoxColumn.Name = "dscloginDataGridViewTextBoxColumn";
            this.dscloginDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn11.DataPropertyName = "dsc_login_cadastro";
            this.dataGridViewTextBoxColumn11.FillWeight = 75F;
            this.dataGridViewTextBoxColumn11.HeaderText = "Data de cadastro";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            // 
            // dta_alteraco
            // 
            this.dta_alteraco.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dta_alteraco.DataPropertyName = "dta_alteraco";
            this.dta_alteraco.FillWeight = 75F;
            this.dta_alteraco.HeaderText = "Data de alteração";
            this.dta_alteraco.Name = "dta_alteraco";
            this.dta_alteraco.ReadOnly = true;
            // 
            // dscloginalterouDataGridViewTextBoxColumn
            // 
            this.dscloginalterouDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dscloginalterouDataGridViewTextBoxColumn.DataPropertyName = "dsc_login_alterou";
            this.dscloginalterouDataGridViewTextBoxColumn.FillWeight = 90F;
            this.dscloginalterouDataGridViewTextBoxColumn.HeaderText = "Login alterou";
            this.dscloginalterouDataGridViewTextBoxColumn.Name = "dscloginalterouDataGridViewTextBoxColumn";
            this.dscloginalterouDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tblFuncionarioBindingSource
            // 
            this.tblFuncionarioBindingSource.DataMember = "tblFuncionario";
            this.tblFuncionarioBindingSource.DataSource = this.projetoPizzariaDataSet7;
            // 
            // projetoPizzariaDataSet7
            // 
            this.projetoPizzariaDataSet7.DataSetName = "ProjetoPizzariaDataSet7";
            this.projetoPizzariaDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.FlatAppearance.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.btnSair.FlatAppearance.BorderSize = 0;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Berlin Sans FB", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.Color.Maroon;
            this.btnSair.Location = new System.Drawing.Point(692, -2);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(39, 27);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "X";
            this.btnSair.UseVisualStyleBackColor = false;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // tblFuncionarioTableAdapter
            // 
            this.tblFuncionarioTableAdapter.ClearBeforeFill = true;
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.Maroon;
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.ForeColor = System.Drawing.Color.White;
            this.btnImprimir.Location = new System.Drawing.Point(644, 479);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 12;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // PaginaRelatorio1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(733, 509);
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
            ((System.ComponentModel.ISupportInitialize)(this.tblFuncionarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.projetoPizzariaDataSet7)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private ProjetoPizzariaDataSet7 projetoPizzariaDataSet7;
        private System.Windows.Forms.BindingSource tblFuncionarioBindingSource;
        private ProjetoPizzariaDataSet7TableAdapters.tblFuncionarioTableAdapter tblFuncionarioTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idfuncionarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dsc_funcao;
        private System.Windows.Forms.DataGridViewTextBoxColumn situacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn mmefuncionarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dscloginDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dta_alteraco;
        private System.Windows.Forms.DataGridViewTextBoxColumn dscloginalterouDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnImprimir;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}