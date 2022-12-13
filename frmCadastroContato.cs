using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaSenac
{
    public partial class frmCadastroContato : Form
    {
        public string operacao = ""; //ela vai informar o tipo de operacao que o usuario ira salvar,alterar
        public frmCadastroContato()
        {
            InitializeComponent();
        }
        public void AlteraBotoes(int op)//desativando e ativando o painel caso seje necessario
        {
            pDados.Enabled= false;
            btInserir.Enabled= false;
            btLocalizar.Enabled= false; 
            btAlterar.Enabled= false;
            btExcluir.Enabled= false;
            btSalvar.Enabled= false;
            btCancelar.Enabled= false;

            if(op == 1) 
            {
                btInserir.Enabled= true;
                btLocalizar.Enabled= true;
            }
            if(op == 2) 
            {
                pDados.Enabled = true;
                btSalvar.Enabled= true;
                btCancelar.Enabled= true;  
            }
            if(op == 3)
            {
                btExcluir.Enabled= true;
                btAlterar.Enabled= true;
                btCancelar.Enabled = true;
            }
        }

        public void Limpar()
        {
            txtCodigo.Clear();  
            txtNome.Clear();
            txtEndereco.Clear();
            txtEmail.Clear();
            txtCidade.Clear();
            txtCep.Clear();
            txtBairro.Clear();
            txtEstado.Clear();
            txtTelefone.Clear();

        }

        private void frmCadastroContato_Load(object sender, EventArgs e)
        {
            this.AlteraBotoes(1);
        }

        private void btInserir_Click(object sender, EventArgs e)
        {
            this.operacao = "inserir";
            this.AlteraBotoes(2);
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.AlteraBotoes(1);
            //Limpar os campos
            this.Limpar();
        }

        private void btSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                Contato contato = new Contato();
                if(txtNome.Text.Length <= 0 ) 
                {
                    MessageBox.Show("Nome obrigatório");
                    return;
                }// Terminar de fazer o restante das validaçoes
                contato.Nome = txtNome.Text;
                contato.Endereco = txtEndereco.Text;
                contato.Cep = txtCep.Text;
                contato.Email = txtEmail.Text;
                contato.Bairro = txtBairro.Text;
                contato.Cidade = txtCidade.Text;
                contato.Estado = txtEstado.Text;
                contato.Telefone = txtTelefone.Text;
                String strConexao = "Data Source=DESKTOP-G18LE98;Initial Catalog=Agenda;Integrated Security=True";
                Conexao conexao = new Conexao(strConexao);
                DALContato dal = new DALContato(conexao);
                if (this.operacao == "inserir")
                {
                    dal.Incluir(contato);
                    MessageBox.Show("O codigo gerado foi: " + contato.Codigo.ToString());


                }
                else
                {
                    contato.Codigo = Convert.ToInt32(txtCodigo.Text);
                    //ALTERAR OS CONTATO QUE ESTA NA TELA
                    dal.Alterar(contato);
                    MessageBox.Show("Registro alterado!");

                }

                this.AlteraBotoes(1);
                this.Limpar();
            } catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }

        }

        private void pDados_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btLocalizar_Click(object sender, EventArgs e)
        {
            FormConsultaContatos f = new FormConsultaContatos();
            f.ShowDialog();
            if(f.codigo!=0)
            {
                String strConexao = "Data Source=DESKTOP-G18LE98;Initial Catalog=Agenda;Integrated Security=True";
                Conexao conexao = new Conexao(strConexao);
                DALContato dal = new DALContato(conexao);
                Contato contato = dal.Carregacontato(f.codigo);
                txtCodigo.Text= contato.Codigo.ToString();
                txtNome.Text = contato.Nome;
                txtEmail.Text = contato.Email;
                txtBairro.Text = contato.Bairro;
                txtCep.Text = contato.Cep;
                txtCidade.Text = contato.Cidade;
                txtEndereco.Text = contato.Endereco;
                txtEstado.Text = contato.Estado;
                txtTelefone.Text = contato.Telefone;
                this.AlteraBotoes(3);

            }
            f.Dispose();
        }

        private void btAlterar_Click(object sender, EventArgs e)
        {
            this.operacao = "alterar";
            this.AlteraBotoes(2);
        }

        private void btExcluir_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Deseja excluir o registro?", "Aviso", MessageBoxButtons.YesNo);
            if(d.ToString()=="Yes")
            {
                String strConexao = "Data Source=DESKTOP-G18LE98;Initial Catalog=Agenda;Integrated Security=True";
                Conexao conexao = new Conexao(strConexao);
                DALContato dal = new DALContato(conexao);
                dal.Excluir(Convert.ToInt32(txtCodigo.Text));
                this.AlteraBotoes(1);
                this.Limpar();

            }
        }

        private void lblCidade_Click(object sender, EventArgs e)
        {

        }
    }
}
