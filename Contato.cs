using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaSenac
{
    public class Contato
    {
        public Contato() 
        {
            this.Codigo = 0; 
            this.Nome = "";
            this.Endereco = "";
            this.Bairro = "";
            this.Cep = "";
            this.Cidade = "";
            this.Estado = "";
            this.Email = "";
            this.Telefone = "";
        }
        public Contato(int codigo,string nome,string endereco,string bairro, string cep, string cidade,
            string estado, string email, string telefone) 
        {
            this.Codigo = codigo;
            this.Nome = nome;
            this.Endereco = endereco;
            this.Bairro = bairro;
            this.Cep = cep;
            this.Cidade = cidade;
            this.Estado = estado;
            this.Email = email;
            this.Telefone = telefone;
        }


        private int con_cod;
        public int Codigo
        {
            get
            {
                return this.con_cod;
            }
            set
            {
                this.con_cod = value;
            }
        }

        private string con_nome;
        public string Nome
        {
            get
            {
                return this.con_nome;
            }
            set
            {
                this.con_nome = value;
            }
        }

        private string con_email;
        public string Email
        {
            get { return this.con_email; }
            set { this.con_email = value; }            
        }

        private string con_fone;
        public string Telefone
        {
            get { return this.con_fone; }            
            set { this.con_fone = value; }        
        }

        private string con_endereco;
        public string Endereco
        {
            get { return this.con_endereco; }
            set {this.con_endereco = value; }
        }

        private string con_bairro;
        public string Bairro
        {
            get { return this.con_bairro; }
            set { this.con_bairro = value; }
        }
        private string con_cidade;
        public string Cidade
        {
            get { return this.con_cidade; }
            set { this.con_cidade = value; }
        }
        private string con_estado;
        public string Estado
        {
            get { return this.con_estado; }
            set { this.con_estado = value; }
        }
        private string con_cep;
        public string Cep
        {
            get { return this.con_cep; }
            set { this.con_cep = value; }
        }


    }
}
