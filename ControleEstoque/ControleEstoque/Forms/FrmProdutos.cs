using System;
using System.Windows.Forms;
using ControleEstoque.Data;
using ControleEstoque.Models;

namespace ControleEstoque.Forms
{
	public partial class FrmProdutos : Form
	{
		private ProdutoDAO produtoDAO = new ProdutoDAO();
		private CategoriaDAO categoriaDAO = new CategoriaDAO(); 
		private bool ehNovoCadastro = true;

		public FrmProdutos()
		{
			InitializeComponent();
			dgvProdutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			
			AtualizarTabela();
			CarregarComboBoxCategorias();
			BloquearCampos(true);
		}

		
		private void AtualizarTabela()
		{
			dgvProdutos.DataSource = null;
			dgvProdutos.DataSource = produtoDAO.Listar();
		}

		private void CarregarComboBoxCategorias()
		{
			cboCategoria.DataSource = null;
			
			cboCategoria.DataSource = categoriaDAO.Listar();
			
			cboCategoria.DisplayMember = "Nome";
			cboCategoria.ValueMember = "Id";
			cboCategoria.SelectedIndex = -1; 
		}

		private void BloquearCampos(bool bloquear)
		{
			txtNome.Enabled = !bloquear;
			cboCategoria.Enabled = !bloquear;
			txtEstoqueMinimo.Enabled = !bloquear;
			chkAtivo.Enabled = !bloquear;
			
			txtId.Enabled = false;
			txtSaldo.Enabled = false; 
		}

		private void LimparCampos()
		{
			txtId.Clear();
			txtNome.Clear();
			txtEstoqueMinimo.Clear();
			txtSaldo.Text = "0";
			cboCategoria.SelectedIndex = -1;
			chkAtivo.Checked = true;
		}

		private void BtnNovoClick(object sender, EventArgs e)
		{
			ehNovoCadastro = true;
			LimparCampos();
			BloquearCampos(false);
			txtNome.Focus();
		}

		private void BtnCancelarClick(object sender, EventArgs e)
		{
			LimparCampos();
			BloquearCampos(true);
		}

		private void BtnSalvarClick(object sender, EventArgs e)
		{

			if (string.IsNullOrWhiteSpace(txtNome.Text) || cboCategoria.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtEstoqueMinimo.Text))
			{
				MessageBox.Show("Por favor, preencha o Nome, a Categoria e o Estoque Mínimo!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			string nome = txtNome.Text;
			int idCategoria = (int)cboCategoria.SelectedValue; 
			int estoqueMinimo = Convert.ToInt32(txtEstoqueMinimo.Text);
			bool ativo = chkAtivo.Checked;

			if (ehNovoCadastro)
			{
				
				Produto novoProduto = new Produto(nome, idCategoria, estoqueMinimo);
				produtoDAO.Inserir(novoProduto);
				MessageBox.Show("Produto cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				int id = Convert.ToInt32(txtId.Text);
				
				Produto produtoEditado = new Produto(id, nome, idCategoria, 0, estoqueMinimo, ativo);
				produtoDAO.Atualizar(produtoEditado);
				MessageBox.Show("Produto atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}

			AtualizarTabela();
			LimparCampos();
			BloquearCampos(true);
		}

		private void DgvProdutosCellClick(object sender, DataGridViewCellEventArgs e)
		{
			if (dgvProdutos.CurrentRow == null) return;

			Produto prodSelecionado = (Produto)dgvProdutos.CurrentRow.DataBoundItem;

			txtId.Text = prodSelecionado.Id.ToString();
			txtNome.Text = prodSelecionado.Nome;
			txtEstoqueMinimo.Text = prodSelecionado.EstoqueMinimo.ToString();
			txtSaldo.Text = prodSelecionado.QuantidadeAtual.ToString();
			cboCategoria.SelectedValue = prodSelecionado.IdCategoria;
			chkAtivo.Checked = prodSelecionado.Ativo;

			ehNovoCadastro = false;
			BloquearCampos(true);
		}

		private void BtnExcluirClick(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtId.Text))
			{
				MessageBox.Show("Selecione um produto na tabela para excluir!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			int id = Convert.ToInt32(txtId.Text);
			DialogResult resposta = MessageBox.Show("Deseja realmente excluir este produto permanentemente?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			
			if (resposta == DialogResult.No) return;

			produtoDAO.Excluir(id);
			MessageBox.Show("Produto excluído!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
			
			AtualizarTabela();
			LimparCampos();
			BloquearCampos(true);
		}
		void BtnEditarClick(object sender, EventArgs e)
		{
	
		}
	}
}
