using NovaAlianca.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NovaAlianca.Apresentacao
{
    public partial class Home : Form
    {
        Controle controle = new Controle();
        public static int _cdgPedido = 0;

        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            lblQtdPizzasHoje.Text = controle.QtdPizzasHoje().ToString();
            PizzasEmAndamento();
            PizzasEntregues();
        }

        private void PizzasEntregues()
        {
            ImageList imga = new ImageList();
            imga.ImageSize = new Size(15, 15);
            String[] paths = { };
            paths = Directory.GetFiles("imagens");
            foreach (String path in paths)
            {
                imga.Images.Add(Image.FromFile(path));
            }

            List<string> pizzasEntregues = new List<string>();
            pizzasEntregues = controle.PizzasEntregues();
            lstUltimosPedidos.Columns.Add("");
            ListViewItem item;
            lstUltimosPedidos.SmallImageList = imga;
            for (int i = 0; i < pizzasEntregues.Count; i++)
            {
                int indexImage;
                item = new ListViewItem();
                item.Text = pizzasEntregues[i].ToString();
                if (item.Text.Substring(0,1) == "C")
                    indexImage = 4;
                else
                    indexImage = 3;
                lstUltimosPedidos.Items.Add(item.Text+"          ", indexImage);
            }
        }

        private void PizzasEmAndamento()
        {
            ImageList imgs = new ImageList();
            imgs.ImageSize = new Size(15, 15);
            String[] paths = { };
            paths = Directory.GetFiles("imagens");
            foreach (String path in paths)
            {
                imgs.Images.Add(Image.FromFile(path));
            }

            List<string> pizzasAndamento = new List<string>();
            pizzasAndamento = controle.PizzasEmAndamento();
            lstPizzaAndamento.Columns.Add("");
            ListViewItem item;
            lstPizzaAndamento.SmallImageList = imgs;
            for (int i = 0; i < pizzasAndamento.Count; i++)
            {
                TimeSpan tempo;
                int indexImage;
                item = new ListViewItem();
                item.Text = pizzasAndamento[i].ToString();
                tempo = Convert.ToDateTime(DateTime.Now.ToString("HH:mm:ss")) - Convert.ToDateTime(item.Text.Substring(0, 8));
                if (Convert.ToInt32(Convert.ToDouble(tempo.TotalMinutes)) < 20)
                    indexImage = 0;
                else if (Convert.ToInt32(Convert.ToDouble(tempo.TotalMinutes)) < 40)
                    indexImage = 1;
                else
                    indexImage = 2;
                lstPizzaAndamento.Items.Add(" "+Convert.ToInt32(Convert.ToDouble(tempo.TotalMinutes)).ToString()+"min | " +item.Text, indexImage);
            }
        }

        private void btnFinalizarPizza_Click(object sender, EventArgs e)
        {
            if (this.lstPizzaAndamento.SelectedItems.Count > 0)
            {
                string linha = lstPizzaAndamento.SelectedItems[0].Text;
                int cdgPedido = Convert.ToInt32(linha.Substring(linha.IndexOf('(') + 5, (linha.IndexOf(')') - linha.IndexOf('(')) - 5));
                DialogResult confirm = MessageBox.Show("Deseja Finalizar o pedido " + cdgPedido + "? ", "Finalizar pedido", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                if (confirm.ToString().ToUpper() == "YES")
                {
                    controle.FinalizarPedido(cdgPedido);
                    lstPizzaAndamento.Clear();
                    PizzasEmAndamento();
                    lstUltimosPedidos.Clear();
                    PizzasEntregues();
                }
            }    
            else
                MessageBox.Show("Escolha uma pizza para Finalizar!");
        }

        private void btnCancelarPizza_Click(object sender, EventArgs e)
        {
            if (this.lstPizzaAndamento.SelectedItems.Count > 0)
            {
                string linha = lstPizzaAndamento.SelectedItems[0].Text;
                int cdgPedido = Convert.ToInt32(linha.Substring(linha.IndexOf('(') + 5, (linha.IndexOf(')') - linha.IndexOf('(')) - 5));
                DialogResult confirm = MessageBox.Show("Deseja Cancelar o pedido " + cdgPedido + "? ", "Cancelar pedido", MessageBoxButtons.YesNo, MessageBoxIcon.Error, MessageBoxDefaultButton.Button2);
                if (confirm.ToString().ToUpper() == "YES")
                {
                    controle.CancelarPedido(cdgPedido);
                    lstPizzaAndamento.Clear();
                    PizzasEmAndamento();
                    lstUltimosPedidos.Clear();
                    PizzasEntregues();
                }
            }
            else
                MessageBox.Show("Escolha uma pizza para Cancelar!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.lstPizzaAndamento.SelectedItems.Count > 0)
            {
                string linha = lstPizzaAndamento.SelectedItems[0].Text;
                _cdgPedido = Convert.ToInt32(linha.Substring(linha.IndexOf('(') + 5, (linha.IndexOf(')') - linha.IndexOf('(')) - 5));
                ResumoPedido pagina = new ResumoPedido();
                pagina.ShowDialog();
            }
            else
                MessageBox.Show("Escolha uma pizza para Visualizar!");
        }
    }
}
