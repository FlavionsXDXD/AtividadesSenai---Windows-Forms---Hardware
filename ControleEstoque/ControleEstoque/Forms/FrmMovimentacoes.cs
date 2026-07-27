using System;
using System.Windows.Forms;
using ControleEstoque.Data;
using ControleEstoque.Models;

namespace ControleEstoque.Forms
{
    public partial class FrmMovimentacoes : Form
    {
        private MovimentacaoDAO movimentacaoDAO = new MovimentacaoDAO();
        private ProdutoDAO produtoDAO = new ProdutoDAO(); 

        public FrmMovimentacoes()
        {
            InitializeComponent();
            dgvHistorico.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
            CarregarProdutos();
            AtualizarHistorico();
        }

        
        private void AtualizarHistorico()
        {
            dgvHistorico.DataSource = null;
            dgvHistorico.DataSource = movimentacaoDAO.Listar();
        }

        private void CarregarProdutos()
        {
            cboProduto.DataSource = null;
         
            cboProduto.DataSource = produtoDAO.Listar().FindAll(p => p.Ativo);
            cboProduto.DisplayMember = "Nome";
            cboProduto.ValueMember = "Id";
            cboProduto.SelectedIndex = -1; 
        }

        private void LimparCampos()
        {
            cboProduto.SelectedIndex = -1;
            cboTipo.SelectedIndex = -1;
            txtQuantidade.Clear();
            txtDescricao.Clear();
        }

        private void BtnLimparClick(object sender, EventArgs e)
        {
            LimparCampos();
        }

    
        private void BtnRegistrarClick(object sender, EventArgs e)
        {
         
            if (cboProduto.SelectedIndex == -1 || cboTipo.SelectedIndex == -1 || string.IsNullOrWhiteSpace(txtQuantidade.Text))
            {
                MessageBox.Show("Por favor, selecione o Produto, o Tipo e digite a Quantidade!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idProduto = (int)cboProduto.SelectedValue;
            string tipo = cboTipo.Text;
            int quantidade = Convert.ToInt32(txtQuantidade.Text);
            string descricao = txtDescricao.Text;

            if (quantidade <= 0)
            {
                MessageBox.Show("A quantidade deve ser um número maior que zero!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Movimentacao novaMov = new Movimentacao(idProduto, tipo, quantidade, descricao);

         
            try
            {
             
                movimentacaoDAO.Registrar(novaMov);
                
                MessageBox.Show("Movimentação de estoque registrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                LimparCampos();
                AtualizarHistorico(); 
            }
            catch (Exception ex)
            {
              
                MessageBox.Show(ex.Message, "Erro na Transação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
