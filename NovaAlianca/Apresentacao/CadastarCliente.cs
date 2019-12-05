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
    public partial class CadastrarCliente : Form
    {
        Controle controle = new Controle();

        public CadastrarCliente()
        {
            InitializeComponent();
        }

        private void CadastrarCliente_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void CarregarGrid()
        {
            this.tblClienteTableAdapter.Fill(this.projetoPizzariaDataSet3.tblCliente);
        }

        private void dtgClientes_SelectionChanged(object sender, EventArgs e)
        {
            AlimentarEdicao();
        }

        private void AlimentarEdicao()
        {
            btnCancelar.Visible = false;
            btnSave.Visible = false;

            pnlCampos.Enabled = false;
            txtNome.Enabled = false;
            txtEndereco.Enabled = false;
            txtNumero.Enabled = false;

            btnAdicionar.Visible = true;
            btnEditar.Visible = true;
            btnExcluir.Visible = true;

            if (dtgClientes.SelectedRows.Count > 0)
            {
                int index = dtgClientes.CurrentRow.Index;
                txtId.Value = Convert.ToInt32(dtgClientes.Rows[index].Cells[0].Value);
                txtNome.Text = dtgClientes.Rows[index].Cells[1].Value.ToString();
                txtTelefone1.Text = dtgClientes.Rows[index].Cells[2].Value.ToString();
                txtTelefone2.Text = dtgClientes.Rows[index].Cells[3].Value.ToString();
                txtCep.Text = dtgClientes.Rows[index].Cells[4].Value.ToString();
                txtNumero.Value = Convert.ToInt32(dtgClientes.Rows[index].Cells[6].Value);
                txtEndereco.Text = dtgClientes.Rows[index].Cells[5].Value.ToString();

            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            pnlCampos.Enabled = true;
            txtNome.Enabled = true;
            txtEndereco.Enabled = true;

            btnAdicionar.Visible = false;
            btnEditar.Visible = false;
            btnExcluir.Visible = false;
            btnCancelar.Visible = true;
            btnSave.Visible = true;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            pnlCampos.Enabled = true;
            txtNome.Enabled = true;
            txtEndereco.Enabled = true;
            txtNumero.Enabled = true;

            txtId.Value = 0;
            txtNome.Text = null;
            txtTelefone1.Text = null;
            txtTelefone2.Text = null;
            txtCep.Text = null;
            txtNumero.Value = 0;
            txtEndereco.Text = null;

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
                    txtTelefone1.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                    txtTelefone2.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                    txtCep.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                    if (VerificarTelefone(Convert.ToInt64(txtTelefone1.Text), (txtTelefone2.Text) == "" ? (long?)null : Convert.ToInt64(txtTelefone2.Text)) == 0 || VerificarTelefone(Convert.ToInt64(txtTelefone1.Text), (txtTelefone2.Text) == "" ? (long?)null : Convert.ToInt64(txtTelefone2.Text)) == Convert.ToInt32(txtId.Value))
                    {
                        if (controle.EditarCliente(Convert.ToInt32(txtId.Value), txtNome.Text, Convert.ToInt64(txtTelefone1.Text), (txtTelefone2.Text) == "" ? (long?)null : Convert.ToInt64(txtTelefone2.Text), txtCep.Text, Convert.ToInt32(txtNumero.Value), txtEndereco.Text))
                        {
                            MessageBox.Show("Cliente salvo com sucesso!");
                            CarregarGrid();
                            AlimentarEdicao();
                        }
                    }
                    else
                        MessageBox.Show("Este telefone já existe no código: "+ VerificarTelefone(Convert.ToInt64(txtTelefone1.Text), (txtTelefone2.Text) == "" ? (long?)null : Convert.ToInt64(txtTelefone2.Text)));
                }
                else
                    MessageBox.Show("Preencha todos os campos!");
            }
            else
            {
                if (VerificarText())
                {
                    txtTelefone1.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                    txtTelefone2.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                    txtCep.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
                    if (VerificarTelefone(Convert.ToInt64(txtTelefone1.Text), (txtTelefone2.Text) == "" ? (long?)null : Convert.ToInt64(txtTelefone2.Text)) == 0 || VerificarTelefone(Convert.ToInt64(txtTelefone1.Text), (txtTelefone2.Text) == "" ? (long?)null : Convert.ToInt64(txtTelefone2.Text)) == Convert.ToInt32(txtId.Value))
                    {
                        if (controle.CriarCliente(Convert.ToInt32(txtId.Value), txtNome.Text, Convert.ToInt64(txtTelefone1.Text), (txtTelefone2.Text) == "" ? (long?)null : Convert.ToInt64(txtTelefone2.Text), txtCep.Text, Convert.ToInt32(txtNumero.Value), txtEndereco.Text))
                        {
                            MessageBox.Show("Cliente salvo com sucesso!");
                            CarregarGrid();
                            AlimentarEdicao();
                        }
                    }
                    else
                        MessageBox.Show("Este telefone já existe no código: " + VerificarTelefone(Convert.ToInt64(txtTelefone1.Text), (txtTelefone2.Text) == "" ? (long?)null : Convert.ToInt64(txtTelefone2.Text)));
                }
                else
                    MessageBox.Show("Preencha todos os campos!");
            }
        }

        private int VerificarTelefone(long tel1, long? tel2)
        {
            return controle.VerificarTelefone(tel1, tel2);
        }

        private bool VerificarText()
        {
            bool buli = true;
            if (txtNome.Text.Trim() == "")
                buli = false;
            else if (txtTelefone1.Text.Trim() == "")
                buli = false;
            else if (txtCep.Text.Trim() == "")
                buli = false;
            else if (txtEndereco.Text.Trim() == "")
                buli = false;
            return buli;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (!controle.VerificarClientePedido(Convert.ToInt32(txtId.Value)))
            {
                DialogResult confirm = MessageBox.Show("Deseja EXCLUIR cliente?", "Excluir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (confirm.ToString().ToUpper() == "YES")
                {
                    controle.ExcluirCliente(Convert.ToInt32(txtId.Value));
                    CarregarGrid();
                    AlimentarEdicao();
                }
            }
            else
                MessageBox.Show("Este cliente possui um pedido e não pode ser excluído!");
        }
    }


}
