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
    public partial class EscolherBancoDados : Form
    {
        public static string _bancodeDados = "";

        public EscolherBancoDados()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _bancodeDados = textBox1.Text;
            EscolherBancoDados.ActiveForm.Close();
        }
    }
}
