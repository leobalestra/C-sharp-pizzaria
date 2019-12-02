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
    public partial class FinalizarPedido : Form
    {
        public static bool _pedidoFeito = false;
        Controle controle = new Controle();

        public FinalizarPedido()
        {
            InitializeComponent();
            lblValorTotal.Text = RealizarPedido._valorTotal.ToString();
        }

        #region ArrastarMouse
        Point ArrastarCursor;
        Point ArrastarForm;
        bool Arrastando;
        private void Login_MouseUp(object sender, MouseEventArgs e)
        {
            Arrastando = false;
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            Arrastando = true;
            ArrastarCursor = Cursor.Position;
            ArrastarForm = this.Location;
        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (Arrastando == true)
            {
                Point diferenca = Point.Subtract(Cursor.Position, new Size(ArrastarCursor));
                this.Location = Point.Add(ArrastarForm, new Size(diferenca));
            }
        }
        #endregion

        private void rdbDinheiro_CheckedChanged(object sender, EventArgs e)
        {
            if(rdbDinheiro.Checked == true)
            {
                lblTroco.Visible = true;
                numericUpDown1.Visible = true;
            }
            else
            {
                lblTroco.Visible = false;
                numericUpDown1.Visible = false;
            }            
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            FinalizarPedido.ActiveForm.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
                lblValorTotal.Text = (Convert.ToDouble(lblValorTotal.Text) + 5.00).ToString();
            else
                lblValorTotal.Text = RealizarPedido._valorTotal.ToString();
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            int comanda;
            string tpoPagamento;
            if (rdbCredito.Checked == true)
                tpoPagamento = "C";
            else if (rdbDebito.Checked == true)
                tpoPagamento = "D";
            else if (rdbRefeicao.Checked == true)
                tpoPagamento = "V";
            else
                tpoPagamento = "R";

            comanda = controle.MontarComanda(RealizarPedido._comanda);
            _pedidoFeito = controle.InserirPedido(RealizarPedido._idCliente, comanda, Login._loginAtual, tpoPagamento, numericUpDown1.Value);
            btnSair.PerformClick();
        }
    }
}
