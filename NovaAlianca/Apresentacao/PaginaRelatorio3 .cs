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
    public partial class PaginaRelatorio3 : Form
    {
        public PaginaRelatorio3()
        {
            InitializeComponent();
        }

        private void PaginaRelatorio_Load(object sender, EventArgs e)
        {
            this.tblComandaTableAdapter.Fill(this.projetoPizzariaDataSet8.tblComanda);
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

        private void btnSair_Click(object sender, EventArgs e)
        {
            PaginaRelatorio3.ActiveForm.Close();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap be = new Bitmap(this.dtgCliente.Width, this.dtgCliente.Height);
            dtgCliente.DrawToBitmap(be, new Rectangle(0, 0, this.dtgCliente.Width, this.dtgCliente.Height));
            e.Graphics.DrawImage(be, 10, 10);
        }
    }
}
