using NovaAlianca.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace NovaAlianca.Apresentacao
{
    public partial class CadastrarProduto : Form
    {
        Controle controle = new Controle();
        char situacao;

        public CadastrarProduto()
        {
            InitializeComponent();
        }

        private void CadastrarProduto_Load(object sender, EventArgs e)
        {
            CarregarComboBox();
            CarregarGrid();            
        }

        private void CarregarGrid()
        {
            this.tblProdutoTableAdapter.Fill(this.projetoPizzariaDataSet4.tblProduto);
        }

        private void CarregarComboBox()
        {
            comTipo.DisplayMember = "Text";
            comTipo.ValueMember = "Value";

            var items = new[]
            {
                new { Text = "Água", Value = "A" },
                new { Text = "Suco", Value = "S" },
                new { Text = "Cerveja", Value = "C" },
                new { Text = "Refrigerante", Value = "R" },
                new { Text = "Pizza Doce", Value = "D" },
                new { Text = "Pizza Salgada", Value = "P" },
            };

            comTipo.DataSource = items;
        }

        private void dtgProfissionais_SelectionChanged(object sender, EventArgs e)
        {
            AlimentarEdicao();
        }

        private void AlimentarEdicao()
        {
            btnCancelar.Visible = false;
            btnSave.Visible = false;

            txtNome.Enabled = false;
            txtValor.Enabled = false;
            comTipo.Enabled = false;
            pnlSituacao.Enabled = false;

            btnAdicionar.Visible = true;
            btnEditar.Visible = true;
            btnExcluir.Visible = true;

            if (dtgProduto.SelectedRows.Count > 0)
            {
                int index = dtgProduto.CurrentRow.Index;
                txtId.Value = Convert.ToInt32(dtgProduto.Rows[index].Cells[0].Value);
                comTipo.SelectedValue = dtgProduto.Rows[index].Cells[5].Value.ToString();
                txtNome.Text = dtgProduto.Rows[index].Cells[2].Value.ToString();
                txtValor.Value = Convert.ToDecimal(dtgProduto.Rows[index].Cells[3].Value.ToString());
                if (dtgProduto.Rows[index].Cells[4].Value.ToString() == "A")
                {
                    rdbAtivo.Checked = true;
                    situacao = 'A';
                }
                else
                {
                    rdbInativo.Checked = true;
                    situacao = 'F';
                }
            }
        }

        private void dtgProduto_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            string situacao = dtgProduto.Rows[e.RowIndex].Cells[4].Value.ToString();
            if (situacao == "F")
                e.CellStyle.ForeColor = Color.Red;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtNome.Enabled = true;
            txtValor.Enabled = true;
            comTipo.Enabled = true;
            pnlSituacao.Enabled = true;

            btnAdicionar.Visible = false;
            btnEditar.Visible = false;
            btnExcluir.Visible = false;
            btnCancelar.Visible = true;
            btnSave.Visible = true;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            txtNome.Enabled = true;
            txtValor.Enabled = true;
            comTipo.Enabled = true;
            pnlSituacao.Enabled = true;

            txtId.Value = 0;
            txtNome.Text = null;
            txtValor.Value = 0;
            comTipo.Text = null;

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
            if (txtId.Value > 0)
            {
                if (VerificarText())
                {
                    if (controle.EditarProduto(txtId.Value, txtNome.Text, txtValor.Value, Convert.ToChar(comTipo.SelectedValue.ToString()), situacao))
                    {
                        MessageBox.Show("Produto salvo com sucesso!");
                        CarregarGrid();
                        AlimentarEdicao();
                    }
                }
                else
                    MessageBox.Show("Preencha todos os campos!");
            }
            else
            {
                if (VerificarText())
                {
                    if (controle.CriarProduto(txtId.Value, txtNome.Text, txtValor.Value, Convert.ToChar(comTipo.SelectedValue), situacao))
                    {
                        MessageBox.Show("Produto salvo com sucesso!");
                        CarregarGrid();
                        AlimentarEdicao();
                    }
                }
                else
                    MessageBox.Show("Preencha todos os campos!");
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Deseja INATIVAR produto?", "Produto", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (confirm.ToString().ToUpper() == "YES")
                controle.InativarProduto(Convert.ToInt32(txtId.Value));
        }

        private bool VerificarText()
        {
            bool buli = true;
            if (txtNome.Text.Trim() == "")
                buli = false;
            else if (txtValor.Text.Trim() == "")
                buli = false;
            else if (comTipo.Text.Trim() == "")
                buli = false;
            return buli;
        }

        private void rdbAtivo_CheckedChanged(object sender, EventArgs e)
        {
            situacao = 'A';
        }

        private void rdbInativo_CheckedChanged(object sender, EventArgs e)
        {
            situacao = 'F';
        }
    }
}
