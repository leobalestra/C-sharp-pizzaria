using NovaAlianca.Apresentacao;
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

namespace NovaAlianca
{
    public partial class Login : Form
    {
        public static string _loginAtual;

        public Login()
        {
            InitializeComponent();
            EscolherBancoDados._bancodeDados = @"(localdb)\Servidor";
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.Acessar(txtLogin.Text.ToUpper(), txtSenha.Text);
            if (controle.mensagemConexao.Equals(""))
            {
                if (controle.acesso)
                {
                    //this.WindowState = FormWindowState.Minimized;
                    txtLogin.Enabled = false;
                    txtSenha.Enabled = false;
                    btnConectar.Enabled = false;
                    _loginAtual = txtLogin.Text;
                    TelaPrincipal tela = new TelaPrincipal();
                    tela.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Login não encontrado", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show(controle.mensagemConexao); ;
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtLogin_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(220, 20, 60);
            panel2.BackColor = Color.FromArgb(128, 0 , 0);
        }

        private void txtSenha_Click(object sender, EventArgs e)
        {
            panel2.BackColor = Color.FromArgb(220, 20, 60);
            panel1.BackColor = Color.FromArgb(128, 0, 0);
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

        private void txtLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)

            {
                txtSenha.Focus();
            }
        }

        private void txtSenha_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Enter)

            {
                btnConectar.PerformClick();
            }
        }

        private void btnBanco_Click(object sender, EventArgs e)
        {
            EscolherBancoDados banco = new EscolherBancoDados();
            banco.ShowDialog();
        }
    }
}
