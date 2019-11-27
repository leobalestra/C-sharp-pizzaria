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
    public partial class EscolherPizza : Form
    {
        public static int _cdgPizza = 0;

        public EscolherPizza()
        {
            InitializeComponent();
        }

        private void EscolherPizza_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'projetoPizzariaDataSet1.tblProduto'. Você pode movê-la ou removê-la conforme necessário.
            this.tblProdutoTableAdapter.Fill(this.projetoPizzariaDataSet1.tblProduto);

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            EscolherPizza.ActiveForm.Close();
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

        #region SalagadaDoce
        private void rdbDoce_CheckedChanged(object sender, EventArgs e)
        {
            this.tblProdutoTableAdapter.FillByDoce(this.projetoPizzariaDataSet1.tblProduto);
        }

        private void rdbSalgada_CheckedChanged(object sender, EventArgs e)
        {
            this.tblProdutoTableAdapter.Fill(this.projetoPizzariaDataSet1.tblProduto);
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            _cdgPizza = Convert.ToInt32(lstSalgada.SelectedValue);
            EscolherPizza.ActiveForm.Close();
        }
    }
}
