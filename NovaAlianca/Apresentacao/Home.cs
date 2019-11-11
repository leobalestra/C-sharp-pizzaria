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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            //controle.Acessar(txtLogin.Text.ToUpper(), txtSenha.Text);
            lblQtdPizzasHoje.Text = controle.QtdPizzasHoje().ToString();

            listView1.View = View.Details;
            listView1.Columns.Add("", 250);
            popularList();
        }

        private void popularList()
        {
            listView1.Items.Add("Leonardo", 0);
            listView1.Items.Add("TESTEE", 0);
            listView1.Items.Add("LASHDD", 0);
            listView1.Items.Add("XXXXXX", 0);
            listView1.Items.Add("VVVVVV", 0);
            listView1.Items.Add("RRRRRR", 0);
            listView1.Items.Add("ÇÇÇÇÇÇ", 0);
            listView1.Items.Add("YYYYYY", 0);
        }
    }
}
