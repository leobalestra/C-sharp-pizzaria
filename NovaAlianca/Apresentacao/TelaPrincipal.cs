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
    public partial class TelaPrincipal : Form
    {
        public TelaPrincipal()
        {
            InitializeComponent();
            lblUser.Text = lblUser.Text + Login._loginAtual.ToUpper();
            AbrirFormInPanel(new Home());
        }        

        private void btnSair_Click(object sender, EventArgs e)
        {
            TelaPrincipal.ActiveForm.Close();
        }

        #region ArrastarMouse

        Point ArrastarCursor;
        Point ArrastarForm;
        bool Arrastando;
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            Arrastando = false;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            Arrastando = true;
            ArrastarCursor = Cursor.Position;
            ArrastarForm = this.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (Arrastando == true)
            {
                Point diferenca = Point.Subtract(Cursor.Position, new Size(ArrastarCursor));
                this.Location = Point.Add(ArrastarForm, new Size(diferenca));
            }
        }
        #endregion

        #region BotoesLaterais
        private void AbrirFormInPanel(object Formfilho)
        {
            if (this.pnlTelas.Controls.Count > 0)
                this.pnlTelas.Controls.RemoveAt(0);

            Form fh = Formfilho as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.pnlTelas.Controls.Add(fh);
            this.pnlTelas.Tag = fh;
            fh.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Home());
            btnRealizarPedido.BackColor = Color.FromArgb(171, 15, 16);
            btnCadastrarCliente.BackColor = Color.FromArgb(171, 15, 16);
            btnRelatorios.BackColor = Color.FromArgb(171, 15, 16);
            btnCadastrarProduto.BackColor = Color.FromArgb(171, 15, 16);
            btnCadastrarFuncionario.BackColor = Color.FromArgb(171, 15, 16);
        }

        private void btnRealizarPedido_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new RealizarPedido());
            btnRealizarPedido.BackColor = Color.FromArgb(102, 0, 0);
            btnCadastrarCliente.BackColor = Color.FromArgb(171, 15, 16);
            btnRelatorios.BackColor = Color.FromArgb(171, 15, 16);
            btnCadastrarProduto.BackColor = Color.FromArgb(171, 15, 16);
            btnCadastrarFuncionario.BackColor = Color.FromArgb(171, 15, 16);
        }

        private void btnCadastrarCliente_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new CadastrarCliente());
            btnRealizarPedido.BackColor = Color.FromArgb(171, 15, 16);
            btnCadastrarCliente.BackColor = Color.FromArgb(102, 0, 0);
            btnRelatorios.BackColor = Color.FromArgb(171, 15, 16);
            btnCadastrarProduto.BackColor = Color.FromArgb(171, 15, 16);
            btnCadastrarFuncionario.BackColor = Color.FromArgb(171, 15, 16);
        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new Relatorios());
            btnRealizarPedido.BackColor = Color.FromArgb(171, 15, 16);
            btnCadastrarCliente.BackColor = Color.FromArgb(171, 15, 16);
            btnRelatorios.BackColor = Color.FromArgb(102, 0, 0);
            btnCadastrarProduto.BackColor = Color.FromArgb(171, 15, 16);
            btnCadastrarFuncionario.BackColor = Color.FromArgb(171, 15, 16);
        }

        private void btnCadastrarProduto_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new CadastrarProduto());
            btnRealizarPedido.BackColor = Color.FromArgb(171, 15, 16);
            btnCadastrarCliente.BackColor = Color.FromArgb(171, 15, 16);
            btnRelatorios.BackColor = Color.FromArgb(171, 15, 16);
            btnCadastrarProduto.BackColor = Color.FromArgb(102, 0, 0);
            btnCadastrarFuncionario.BackColor = Color.FromArgb(171, 15, 16);
        }

        private void btnCadastrarFuncionario_Click(object sender, EventArgs e)
        {
            AbrirFormInPanel(new CadastrarFuncionario());
            btnRealizarPedido.BackColor = Color.FromArgb(171, 15, 16);
            btnCadastrarCliente.BackColor = Color.FromArgb(171, 15, 16);
            btnRelatorios.BackColor = Color.FromArgb(171, 15, 16);
            btnCadastrarProduto.BackColor = Color.FromArgb(171, 15, 16);
            btnCadastrarFuncionario.BackColor = Color.FromArgb(102, 0, 0);
        }
        #endregion
    }
}
