using NovaAlianca.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NovaAlianca.Apresentacao
{
    public partial class RealizarPedido : Form
    {
        Controle controle = new Controle();

        public RealizarPedido()
        {
            InitializeComponent();
        }

        private void btnPesquisarTelefone_Click(object sender, EventArgs e)
        {
            maskedTextBox1.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            var cliente = controle.PesquisaCliente(Convert.ToInt32(maskedTextBox1.Text));

            lblNomeCliente.Text = cliente[1].ToString();
            lblTelefone1.Text = cliente[2].ToString();
            lblTelefone2.Text = cliente[3].ToString();
            lblEndereco.Text = cliente[5].ToString()+" - "+ cliente[6].ToString()+ "\r\n" + cliente[4].ToString();
            lblUltimoPedido.Text = cliente[7].ToString();
            pnlPedido.Visible = true;
            pnlCliente.Visible = true;
        }

        private void RealizarPedido_Load(object sender, EventArgs e)
        {
            this.tblProdutoTableAdapter.Fill(this.projetoPizzariaDataSet.tblProduto);
        }

        private void btnPizza1_Click(object sender, EventArgs e)
        {
            EscolherPizza pizza1 = new EscolherPizza();
            pizza1.ShowDialog();

            lblEscolhaPizza1.Text = controle.NomeProduto(EscolherPizza._cdgPizza);
        }

        private void btnPizza2_Click(object sender, EventArgs e)
        {
            EscolherPizza pizza2 = new EscolherPizza();
            pizza2.ShowDialog();

            lblEscolhaPizza2.Text = controle.NomeProduto(EscolherPizza._cdgPizza);
        }
    }
}
