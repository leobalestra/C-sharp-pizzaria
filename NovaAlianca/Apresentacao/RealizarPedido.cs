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
        int cdgPizza1, cdgPizza2;
        public static double _valorTotal;
        public static int _idCliente;
        public static List<string> _comanda = new List<string>();

        public RealizarPedido()
        {
            InitializeComponent();
        }

        private void btnPesquisarTelefone_Click(object sender, EventArgs e)
        {
            txtTelefone.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            var cliente = controle.PesquisaCliente(Convert.ToInt64(txtTelefone.Text));

            _idCliente = Convert.ToInt32(cliente[0]);
            lblNomeCliente.Text = cliente[1].ToString();
            lblTelefone1.Text = cliente[2].ToString();
            lblTelefone2.Text = cliente[3].ToString();
            lblEndereco.Text = cliente[5].ToString()+ "\r\nNº " + cliente[6].ToString()+ "\r\n" + cliente[4].ToString();
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

            cdgPizza1 = EscolherPizza._cdgPizza;
            lblEscolhaPizza1.Text = controle.NomeProduto(EscolherPizza._cdgPizza);
        }

        private void btnPizza2_Click(object sender, EventArgs e)
        {
            EscolherPizza pizza2 = new EscolherPizza();
            pizza2.ShowDialog();

            cdgPizza2 = EscolherPizza._cdgPizza;
            lblEscolhaPizza2.Text = controle.NomeProduto(EscolherPizza._cdgPizza);
        }

        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(220, 20, 60);
        }

        private void lblEscolhaPizza2_TextChanged(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(lblEscolhaPizza1.Text) == false && String.IsNullOrEmpty(lblEscolhaPizza2.Text) == false)
            {
                btnAdicionarPizza.Enabled = true;
                btnAdicionarPizza.Text = "Adicionar +";
            }
            else
                btnAdicionarPizza.Enabled = false;
        }

        private void btnAdicionarPizza_Click(object sender, EventArgs e)
        {
            if (cdgPizza1 > 0 && cdgPizza2 > 0)
                AdiconarPizzaComanda(cdgPizza1, cdgPizza2);
        }

        private void AdiconarPizzaComanda(int cdgPizza1, int cdgPizza2)
        {
            lstPedido.Items.Add(cdgPizza1.ToString()+" - "+lblEscolhaPizza1.Text);
            lstPedido.Items.Add(cdgPizza2.ToString()+" - "+lblEscolhaPizza2.Text);
        }

        private void btnAdicionarBebida_Click(object sender, EventArgs e)
        {
            AdiconarBebidaComanda();
        }

        private void AdiconarBebidaComanda()
        {
            lstPedido.Items.Add(lstBebidas.SelectedValue.ToString() + " - " + lstBebidas.GetItemText(lstBebidas.SelectedItem) );
        }

        private void btnLimparComanda_Click(object sender, EventArgs e)
        {
            lstPedido.Items.Clear();
        }

        private void btnRemoverItemComanda_Click(object sender, EventArgs e)
        {
            if (this.lstPedido.SelectedItem != null)
                this.lstPedido.Items.Remove(this.lstPedido.SelectedItem);
            else
                MessageBox.Show("Escolha um item da lista de Resumo!");
        }

        private void btnFinalizarPedido_Click(object sender, EventArgs e)
        {
            if(lstPedido.Items.Count > 0)
            {
                _comanda.Clear();
                for (int i = 0; i < lstPedido.Items.Count; i++)
                {
                    _comanda.Add(lstPedido.GetItemText(lstPedido.Items[i]));
                }
                panel2.Enabled = false;
                _valorTotal = controle.ValorPedido(lstPedido);
                FinalizarPedido finalizar = new FinalizarPedido();
                finalizar.ShowDialog();
                if(FinalizarPedido._pedidoFeito == true)
                {
                    MessageBox.Show("Pedido realizado!");
                    panel2.Enabled = true;
                    fecharTelasPedido();
                }
                else
                    panel2.Enabled = true;
            }
            else
            {
                MessageBox.Show("Adicione produtos a lista.");
            }
        }

        private void fecharTelasPedido()
        {
            lblEscolhaPizza1.Text = null;
            lblEscolhaPizza2.Text = null;
            lstPedido.Items.Clear();
            cdgPizza1 = 0;
            cdgPizza2 = 0;
            _valorTotal = 0;
            _idCliente = 0;
            lblNomeCliente.Text = null;
            lblTelefone1.Text = null;
            lblTelefone2.Text = null;
            lblEndereco.Text = null;
            lblUltimoPedido.Text = null;
            pnlPedido.Visible = true;
            pnlCliente.Visible = true;
            _comanda.Clear();
            pnlPedido.Visible = false;
            pnlCliente.Visible = false;
        }
    }
}
