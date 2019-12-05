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
    public partial class CadastrarFuncionario : Form
    {
        Controle controle = new Controle();
        char situacao;

        public CadastrarFuncionario()
        {
            InitializeComponent();
        }

        private void CadastrarFuncionario_Load(object sender, EventArgs e)
        {
            CarregarComboBox();
            CarregarGrid();
        }

        private void CarregarGrid()
        {
            this.tblFuncionarioTableAdapter.Fill(this.projetoPizzariaDataSet21.tblFuncionario);
        }

        private void CarregarComboBox()
        {
            comFuncao.Items.Add("Admin");
            comFuncao.Items.Add("Gerente");
            comFuncao.Items.Add("Pizzaiolo");
            comFuncao.Items.Add("Atendente");
            comFuncao.Items.Add("Entregador");
        }

        private void dtgProfissionais_SelectionChanged(object sender, EventArgs e)
        {
            AlimentarEdicao();
        }

        private void AlimentarEdicao()
        {
            btnCancelar.Visible = false;
            btnSave.Visible = false;

            txtLogin.Enabled = false;
            txtNome.Enabled = false;
            txtSenha.Enabled = false;
            comFuncao.Enabled = false;
            pnlSituacao.Enabled = false;

            btnAdicionar.Visible = true;
            btnEditar.Visible = true;
            btnExcluir.Visible = true;

            if(dtgProfissionais.SelectedRows.Count > 0)
            {
                int index = dtgProfissionais.CurrentRow.Index;
                txtId.Value = Convert.ToInt32(dtgProfissionais.Rows[index].Cells[0].Value);
                txtLogin.Text = dtgProfissionais.Rows[index].Cells[1].Value.ToString();
                txtNome.Text = dtgProfissionais.Rows[index].Cells[2].Value.ToString();
                comFuncao.Text = dtgProfissionais.Rows[index].Cells[3].Value.ToString();
                txtSenha.Text = dtgProfissionais.Rows[index].Cells[4].Value.ToString();
                if (dtgProfissionais.Rows[index].Cells[5].Value.ToString() == "A")
                {
                    rdbAtivo.Checked = true;
                    situacao = 'A';
                }
                else
                {
                    rdbInativo.Checked = true;
                    situacao = 'I';
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtLogin.Enabled = true;
            txtNome.Enabled = true;
            txtSenha.Enabled = true;
            comFuncao.Enabled = true;
            pnlSituacao.Enabled = true;

            btnAdicionar.Visible = false;
            btnEditar.Visible = false;
            btnExcluir.Visible = false;
            btnCancelar.Visible = true;
            btnSave.Visible = true;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            txtLogin.Enabled = true;
            txtNome.Enabled = true;
            txtSenha.Enabled = true;
            comFuncao.Enabled = true;
            pnlSituacao.Enabled = true;
            txtId.Value = 0;
            txtLogin.Text = null;
            txtNome.Text = null;
            txtSenha.Text = null;
            comFuncao.Text = null;

            btnAdicionar.Visible = false;
            btnEditar.Visible = false;
            btnExcluir.Visible = false;
            btnCancelar.Visible = true;
            btnSave.Visible = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            AlimentarEdicao();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtId.Value > 0)
            {
                if (VerificarText())
                {
                    if (VerificarSenha())
                    {
                        if (VerificarLogin(txtLogin.Text) == txtId.Value || VerificarLogin(txtLogin.Text) == 0)
                        {
                            if (controle.EditarProfissional(txtId.Value, txtLogin.Text, txtNome.Text, comFuncao.Text, txtSenha.Text, situacao))
                            {
                                MessageBox.Show("Profissional salvo com sucesso!");
                                CarregarGrid();
                                AlimentarEdicao();
                            }
                        }
                        else
                            MessageBox.Show("Este login já está em uso!");
                    }
                    else
                        MessageBox.Show("A senha deve ter mais de 5 dígitos!");
                }
                else
                    MessageBox.Show("Preencha todos os campos!");
            }
            else
            {
                if (VerificarText())
                {
                    if (VerificarSenha())
                    {
                        if (VerificarLogin(txtLogin.Text) == txtId.Value || VerificarLogin(txtLogin.Text) == 0)
                        {
                            if (controle.CriarProfissional(txtLogin.Text, txtNome.Text, comFuncao.Text, txtSenha.Text, situacao))
                            {
                                MessageBox.Show("Profissional salvo com sucesso!");
                                CarregarGrid();
                                AlimentarEdicao();
                            }
                        }
                        else
                            MessageBox.Show("Este login já está em uso!");
                    }
                    else
                        MessageBox.Show("A senha deve ter mais de 5 dígitos!");
                }
                else
                    MessageBox.Show("Preencha todos os campos!");
            }
        }

        private int VerificarLogin(string login)
        {
            return controle.IddoLogin(login);
        }

        private bool VerificarSenha()
        {
            return (txtSenha.Text.Trim().Length < 5) ? false : true;
        }

        private bool VerificarText()
        {
            bool buli = true;
            if (txtLogin.Text.Trim() == "")
                buli = false;
            else if (txtNome.Text.Trim() == "")
                buli = false;
            else if (txtSenha.Text.Trim() == "")
                buli = false;
            else if (comFuncao.Text.Trim() == "")
                buli = false;
            return buli;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Deseja INATIVAR funcionário?", "Inativar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (confirm.ToString().ToUpper() == "YES")
                controle.InativarProfissional(Convert.ToInt32(txtId.Value));
        }

        private void rdbAtivo_CheckedChanged(object sender, EventArgs e)
        {
            situacao = 'A';
        }

        private void rdbInativo_CheckedChanged(object sender, EventArgs e)
        {
            situacao = 'I';
        }

        private void dtgProfissionais_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            string situacao = dtgProfissionais.Rows[e.RowIndex].Cells[5].Value.ToString();
            if (situacao == "I")
                e.CellStyle.ForeColor = Color.Red;
        }
    }
}
