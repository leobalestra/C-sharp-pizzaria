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
    public partial class Relatorios : Form
    {
        public Relatorios()
        {
            InitializeComponent();
        }

        //1
        private void btnVendasHoje_Click(object sender, EventArgs e)
        {
            PaginaRelatorio2 pagina = new PaginaRelatorio2();
            pagina.ShowDialog();
        }

        //2
        private void btnFuncionarios_Click(object sender, EventArgs e)
        {
            PaginaRelatorio1 pagina = new PaginaRelatorio1();
            pagina.ShowDialog();
        }

        //3
        private void btnFatMensal_Click(object sender, EventArgs e)
        {
            PaginaRelatorio3 pagina = new PaginaRelatorio3();
            pagina.ShowDialog();
        }

        //4
        private void btnSaboresRankig_Click(object sender, EventArgs e)
        {
            PaginaRelatorio4 pagina = new PaginaRelatorio4();
            pagina.ShowDialog();
        }
        
        //5
        private void btnClientes_Click(object sender, EventArgs e)
        {
            PaginaRelatorio5 pagina = new PaginaRelatorio5();
            pagina.ShowDialog();
        }

        //6
        private void btnFatAnual_Click(object sender, EventArgs e)
        {
            PaginaRelatorio6 pagina = new PaginaRelatorio6();
            pagina.ShowDialog();
        }
    }
}
