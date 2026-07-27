using System;
using System.Windows.Forms;
using ControleEstoque.Data;
using ControleEstoque.Forms;

namespace ControleEstoque
{
	
	public partial class MainForm : Form
	{
		private ProdutoDAO produtoDAO = new ProdutoDAO();
		private MovimentacaoDAO movimentacaoDAO = new MovimentacaoDAO();

		public MainForm()
		{
			InitializeComponent();
			dgvAlertasEstoque.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			
			
			CarregarPainelIndicadores();
		}

		
		private void CarregarPainelIndicadores()
		{
			int totalProdutos = produtoDAO.Listar().Count;
			int totalMovimentacoes = movimentacaoDAO.Listar().Count;

			lblTotalProdutos.Text = "Total Produtos: " + totalProdutos;
			lblTotalMovimentacoes.Text = "Total Movimentações: " + totalMovimentacoes;

			
			dgvAlertasEstoque.DataSource = null;
			dgvAlertasEstoque.DataSource = produtoDAO.ListarEstoqueBaixo();
		}

		
		private void BtnAbrirCategoriasClick(object sender, EventArgs e)
		{
			FrmCategorias telaCategorias = new FrmCategorias();
			telaCategorias.ShowDialog();
			CarregarPainelIndicadores();
		}

		
		private void BtnMenuProdutosClick(object sender, EventArgs e)
		{
			FrmProdutos telaProdutos = new FrmProdutos();
			telaProdutos.ShowDialog();
			CarregarPainelIndicadores();
		}

		
		private void BtnMenuMovimentacoesClick(object sender, EventArgs e)
		{
			FrmMovimentacoes telaMov = new FrmMovimentacoes();
			telaMov.ShowDialog();
			CarregarPainelIndicadores();
		}
	}
}
