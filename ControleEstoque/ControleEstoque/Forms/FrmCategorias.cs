using System;
using System.Windows.Forms;
using ControleEstoque.Data;
using ControleEstoque.Models;

namespace ControleEstoque.Forms
{
    public partial class FrmCategorias : Form
    {
        
        private CategoriaDAO categoriaDAO = new CategoriaDAO();
        
       
        private bool ehNovoCadastro = true;

        public FrmCategorias()
        {
            InitializeComponent();
            
        
            dgvCategorias.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
          
            AtualizarTabela();
            BloquearCampos(true);
        }

      
        private void AtualizarTabela()
        {
            dgvCategorias.DataSource = null;
            dgvCategorias.DataSource = categoriaDAO.Listar();
        }

       
        private void BloquearCampos(bool bloquear)
        {
            txtNome.Enabled = !bloquear;
            txtId.Enabled = false; 
        }


        private void LimparCampos()
        {
            txtId.Clear();
            txtNome.Clear();
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
            if (string.IsNullOrWhiteSpace(txtNome.Text))
            {
                MessageBox.Show("O campo Nome da Categoria é obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string nome = txtNome.Text;

            if (ehNovoCadastro)
            {
                Categoria novaCategoria = new Categoria(nome);
                categoriaDAO.Inserir(novaCategoria);
                MessageBox.Show("Categoria cadastrada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int id = Convert.ToInt32(txtId.Text);
                Categoria categoriaEditada = new Categoria(id, nome);
                categoriaDAO.Atualizar(categoriaEditada);
                MessageBox.Show("Categoria atualizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            AtualizarTabela();
            LimparCampos();
            BloquearCampos(true);
        }

       
        private void DgvCategoriasCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvCategorias.CurrentRow == null) return;

        
            Categoria catSelecionada = (Categoria)dgvCategorias.CurrentRow.DataBoundItem;

            txtId.Text = catSelecionada.Id.ToString();
            txtNome.Text = catSelecionada.Nome;

            ehNovoCadastro = false; 
            BloquearCampos(true);   
        }


        private void BtnExcluirClick(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text))
            {
                MessageBox.Show("Selecione uma categoria na tabela para excluir!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int id = Convert.ToInt32(txtId.Text);
            
            DialogResult resposta = MessageBox.Show("Tem certeza que deseja excluir esta categoria? Isso pode afetar os produtos vinculados a ela!", 
                                                    "Confirmar Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.No) return;

            categoriaDAO.Excluir(id);
            MessageBox.Show("Categoria excluída com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            AtualizarTabela();
            LimparCampos();
            BloquearCampos(true);
        }
    }
}
