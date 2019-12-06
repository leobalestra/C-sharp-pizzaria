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
    public partial class ResumoPedido : Form
    {
        Controle controle = new Controle();
        public static string _bancodeDados = "";
        List<string> pedido = new List<string>();

        public ResumoPedido()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ResumoPedido.ActiveForm.Close();
        }

        private void ResumoPedido_Load(object sender, EventArgs e)
        {
            lblPedido.Text = Home._cdgPedido.ToString();
            pedido = controle.ResumoPedido(Home._cdgPedido);
            for (int i = 0; i < pedido.Count; i++)
            {
                lstPedido.Items.Add(pedido[i].ToString());
            }
        }
    }
}
