namespace NovaAlianca.Apresentacao
{
    partial class Home
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancelarPizza = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFinalizarPizza = new System.Windows.Forms.Button();
            this.lstPizzaAndamento = new System.Windows.Forms.ListView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lstUltimosPedidos = new System.Windows.Forms.ListView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblQtdPizzasHoje = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pizzas em andamento:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ultimos pedidos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Qtd. Pizzas hoje:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btnCancelarPizza);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btnFinalizarPizza);
            this.panel1.Controls.Add(this.lstPizzaAndamento);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 230);
            this.panel1.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(254, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Finalizar";
            // 
            // btnCancelarPizza
            // 
            this.btnCancelarPizza.BackColor = System.Drawing.Color.Transparent;
            this.btnCancelarPizza.BackgroundImage = global::NovaAlianca.Properties.Resources.images1;
            this.btnCancelarPizza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnCancelarPizza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarPizza.FlatAppearance.BorderSize = 0;
            this.btnCancelarPizza.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnCancelarPizza.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnCancelarPizza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarPizza.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelarPizza.Location = new System.Drawing.Point(412, 184);
            this.btnCancelarPizza.Name = "btnCancelarPizza";
            this.btnCancelarPizza.Size = new System.Drawing.Size(33, 36);
            this.btnCancelarPizza.TabIndex = 3;
            this.btnCancelarPizza.Tag = "";
            this.btnCancelarPizza.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancelarPizza.UseVisualStyleBackColor = false;
            this.btnCancelarPizza.Click += new System.EventHandler(this.btnCancelarPizza_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(353, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cancelar";
            // 
            // btnFinalizarPizza
            // 
            this.btnFinalizarPizza.BackColor = System.Drawing.Color.Transparent;
            this.btnFinalizarPizza.BackgroundImage = global::NovaAlianca.Properties.Resources._41462_200;
            this.btnFinalizarPizza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFinalizarPizza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFinalizarPizza.FlatAppearance.BorderSize = 0;
            this.btnFinalizarPizza.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnFinalizarPizza.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnFinalizarPizza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFinalizarPizza.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFinalizarPizza.Location = new System.Drawing.Point(302, 184);
            this.btnFinalizarPizza.Name = "btnFinalizarPizza";
            this.btnFinalizarPizza.Size = new System.Drawing.Size(33, 38);
            this.btnFinalizarPizza.TabIndex = 2;
            this.btnFinalizarPizza.Tag = " Finalizar Pizza";
            this.btnFinalizarPizza.UseVisualStyleBackColor = false;
            this.btnFinalizarPizza.Click += new System.EventHandler(this.btnFinalizarPizza_Click);
            // 
            // lstPizzaAndamento
            // 
            this.lstPizzaAndamento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstPizzaAndamento.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPizzaAndamento.GridLines = true;
            this.lstPizzaAndamento.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lstPizzaAndamento.HideSelection = false;
            this.lstPizzaAndamento.Location = new System.Drawing.Point(31, 38);
            this.lstPizzaAndamento.MultiSelect = false;
            this.lstPizzaAndamento.Name = "lstPizzaAndamento";
            this.lstPizzaAndamento.Size = new System.Drawing.Size(417, 140);
            this.lstPizzaAndamento.TabIndex = 1;
            this.lstPizzaAndamento.UseCompatibleStateImageBehavior = false;
            this.lstPizzaAndamento.View = System.Windows.Forms.View.SmallIcon;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lstUltimosPedidos);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(1, 229);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(605, 178);
            this.panel2.TabIndex = 4;
            // 
            // lstUltimosPedidos
            // 
            this.lstUltimosPedidos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstUltimosPedidos.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstUltimosPedidos.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.lstUltimosPedidos.HideSelection = false;
            this.lstUltimosPedidos.LabelWrap = false;
            this.lstUltimosPedidos.Location = new System.Drawing.Point(31, 39);
            this.lstUltimosPedidos.MultiSelect = false;
            this.lstUltimosPedidos.Name = "lstUltimosPedidos";
            this.lstUltimosPedidos.Size = new System.Drawing.Size(560, 135);
            this.lstUltimosPedidos.TabIndex = 2;
            this.lstUltimosPedidos.UseCompatibleStateImageBehavior = false;
            this.lstUltimosPedidos.View = System.Windows.Forms.View.SmallIcon;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lblQtdPizzasHoje);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(466, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(154, 190);
            this.panel3.TabIndex = 5;
            // 
            // lblQtdPizzasHoje
            // 
            this.lblQtdPizzasHoje.AutoSize = true;
            this.lblQtdPizzasHoje.Font = new System.Drawing.Font("Century Gothic", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQtdPizzasHoje.ForeColor = System.Drawing.Color.Maroon;
            this.lblQtdPizzasHoje.Location = new System.Drawing.Point(29, 55);
            this.lblQtdPizzasHoje.Name = "lblQtdPizzasHoje";
            this.lblQtdPizzasHoje.Size = new System.Drawing.Size(69, 77);
            this.lblQtdPizzasHoje.TabIndex = 3;
            this.lblQtdPizzasHoje.Text = "0";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(633, 411);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.Text = "RealizarPedido";
            this.Load += new System.EventHandler(this.Home_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblQtdPizzasHoje;
        private System.Windows.Forms.ListView lstPizzaAndamento;
        private System.Windows.Forms.Button btnFinalizarPizza;
        private System.Windows.Forms.Button btnCancelarPizza;
        private System.Windows.Forms.ListView lstUltimosPedidos;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}