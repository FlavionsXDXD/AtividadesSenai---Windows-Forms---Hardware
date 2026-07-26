using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Cadastro
{

	public partial class MainForm : Form
	{
		private ClienteOPB ClienteOPB = new ClienteOPB();
		
		private bool ehNovoCadastro = true;
		
		public MainForm()
		{
		
			InitializeComponent();
			
			dgvClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			
			AtualizarTabela();
			
			BloquearCampos(true);
			
			
		}
		
		private void AtualizarTabela()
		{
			dgvClientes.DataSource = null;
			dgvClientes.DataSource = ClienteOPB.ListarTodos();
		}
		private void BloquearCampos(bool bloquear)
		{
			txtNome.Enabled = !bloquear;
			txtCPF.Enabled = !bloquear;
			txtEmail.Enabled = !bloquear;
			txtTelefone.Enabled = !bloquear;
			txtCidade.Enabled = !bloquear;
			chkAtivo.Enabled = !bloquear;
			
			txtId.Enabled = false;
		}
		
		private void LimparCampos()
		{
			txtId.Clear();
			txtNome.Clear();
			txtCPF.Clear();
			txtEmail.Clear();
			txtTelefone.Clear();
			txtCidade.Clear();
			chkAtivo.Checked = true;
		}
		void BtnNovoClick(object sender, EventArgs e)
		{
			ehNovoCadastro = true;
			LimparCampos();
			BloquearCampos(false);
			txtNome.Focus();
		}
		void BtnCancelarClick(object sender, EventArgs e)
		{
			LimparCampos();
			BloquearCampos(true);
		}
		void BtnSalvarClick(object sender, EventArgs e)
		{
			if(string.IsNullOrWhiteSpace(txtNome.Text) || string.IsNullOrWhiteSpace(txtCPF.Text))
			{
				MessageBox.Show("Os campos Nome e Cpf sao obrigatorios!",
				                "Atençao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			return;
			}
		
		string nome = txtNome.Text;
		string cpf = txtCPF.Text;
		string email = txtEmail.Text;
		string telefone = txtTelefone.Text;
		string cidade = txtCidade.Text;
		bool ativo = chkAtivo.Checked;
		
		if (ehNovoCadastro)
		{
			CadastroCliente novoCliente = new CadastroCliente(nome, cpf, email, telefone, cidade);
			
			ClienteOPB.Inserir(novoCliente);
			
			MessageBox.Show("Cliente cadastrado com sucesso !", "sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		
		else
		{
			int id = Convert.ToInt32(txtId.Text);
			
			CadastroCliente clienteEditado = new CadastroCliente(id, nome, cpf, email, telefone, cidade, ativo);
			
			ClienteOPB.Editar(clienteEditado);
			
			MessageBox.Show("Dados do cliente atualizados com sucesso!", "Sucesso",MessageBoxButtons.OK, MessageBoxIcon.Information);
		}
		
		AtualizarTabela();
		LimparCampos();
		BloquearCampos(true);
		}
		void DgvClientesCellClick(object sender, DataGridViewCellEventArgs e)
		{
			if(dgvClientes.CurrentRow == null) return;
			
			CadastroCliente clienteSelecionado = (CadastroCliente)dgvClientes.CurrentRow.DataBoundItem;
			
			txtId.Text = clienteSelecionado.Id.ToString();
			txtNome.Text = clienteSelecionado.Nome;
			txtCPF.Text = clienteSelecionado.Cpf;
			txtEmail.Text = clienteSelecionado.Email;
			txtTelefone.Text = clienteSelecionado.Telefone;
			txtCidade.Text = clienteSelecionado.Cidade;
			chkAtivo.Checked = clienteSelecionado.Ativo;
			
			BloquearCampos(true);
		}
		void BtnEditarClick(object sender, EventArgs e)
		{
			if(string.IsNullOrWhiteSpace(txtId.Text))
			{
				MessageBox.Show("Selecione um cliente na tabela antes de clicar em editar","Atençao",MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			
			ehNovoCadastro = false;
			BloquearCampos(false);
			txtNome.Focus();
		}
		void BtnExcluirClick(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtId.Text))
			{
				MessageBox.Show("selecione um cliente na tabela antes de excluir","Atençao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			
			int id = Convert.ToInt32(txtId.Text);
			string nome = txtNome.Text;
			
			DialogResult resposta = MessageBox.Show("Deseja excluir permanentemente o cliente "+nome+"?","Confirmar Exclusao",
			                                       MessageBoxButtons.YesNo,
			                                       MessageBoxIcon.Question);
			if(resposta == DialogResult.No)
			{
				return;
			}
			ClienteOPB.Excluir(id);
			
			MessageBox.Show("Cliente excluido com sucesso!","Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
			
			AtualizarTabela();
			LimparCampos();
			BloquearCampos(true);
		}
		void BtnAtivarDesativarClick(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtId.Text))
			{
				MessageBox.Show("Selecione um cliente na tabela para alterar o status!",
				                "Atençao", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			int id = Convert.ToInt32(txtId.Text);
			
			bool novoStatus = !chkAtivo.Checked;
			
			ClienteOPB.AlterarStatus(id, novoStatus);
			
			if(novoStatus == true)
			{
				MessageBox.Show("Cliente ativado","Status Atualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show("Cliente desativado","Status Atualizado",MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			
			AtualizarTabela();
			LimparCampos();
			BloquearCampos(true);
		}
		void BtnPesquisarClick(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtPesquisar.Text))
			{
				MessageBox.Show("Digite parte do nome de um cliente","Atençao",MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			string termoBusca = txtPesquisar.Text.ToLower().Trim();
			List<CadastroCliente> todosClientes = ClienteOPB.ListarTodos();
			List<CadastroCliente> resultadoFiltro = new List<CadastroCliente>();
			
			foreach (CadastroCliente c in todosClientes)
			{
				if(c.Nome.ToLower().Contains(termoBusca))
				{
					resultadoFiltro.Add(c);
				}
			}
			
			if(resultadoFiltro.Count == 0)
			{
				MessageBox.Show("Nenhum cliente encontrado com esse nome","Sem Resultados",
				                MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}
			dgvClientes.DataSource = null;
			dgvClientes.DataSource = resultadoFiltro;
		}
		void BtnMostrarTodosClick(object sender, EventArgs e)
		{
			txtPesquisar.Clear();
			
			AtualizarTabela();
		}
		
		
	}
}
