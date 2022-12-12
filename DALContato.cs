using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace AgendaSenac
{
    class DALContato
    {
     private  Conexao objConexao;

        public DALContato(Conexao conexao)
        {
            objConexao= conexao;
        }
        public void Incluir(Contato contato)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;
            cmd.CommandText = "insert into contato(con_nome, con_email, con_fone, con_endereco, con_bairro, " +
                " con_cidade, con_estado, con_cep) " +
                "values (@nome, @email, @fone, @endereco, @bairro, @cidade, @estado, @cep); select @@IDENTITY;";
            cmd.Parameters.AddWithValue("@nome", contato.Nome);
            cmd.Parameters.AddWithValue("@email", contato.Email);
            cmd.Parameters.AddWithValue("@fone", contato.Telefone);
            cmd.Parameters.AddWithValue("@endereco", contato.Endereco);
            cmd.Parameters.AddWithValue("@bairro", contato.Bairro);
            cmd.Parameters.AddWithValue("@cidade", contato.Cidade);
            cmd.Parameters.AddWithValue("@estado", contato.Estado);
            cmd.Parameters.AddWithValue("@cep", contato.Cep);
            objConexao.Conectar();
            contato.Codigo = Convert.ToInt32(cmd.ExecuteScalar());
            objConexao.Desconectar();//o metodo  para desconectar

        }

        public void Alterar(Contato contato)//metodo criado de alterar com ajuda
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;
            cmd.CommandText = "update contato set con_nome = @nome," +
                "con_email=@email,con_fone=@fone,con_endereco=@endereco,con_bairro=@bairro," +
                "con_cidade=@cidade, con_estado=@estado, con_cep=@cep" +
                "where con_cod=@cod";
            cmd.Parameters.AddWithValue("@nome" , contato.Nome);
            cmd.Parameters.AddWithValue("@email", contato.Email);
            cmd.Parameters.AddWithValue("@fone", contato.Telefone);
            cmd.Parameters.AddWithValue("@endereco", contato.Endereco);
            cmd.Parameters.AddWithValue("@bairro", contato.Bairro);
            cmd.Parameters.AddWithValue("@cidade", contato.Cidade);
            cmd.Parameters.AddWithValue("@estado", contato.Estado);
            cmd.Parameters.AddWithValue("@cep", contato.Cep);
            cmd.Parameters.AddWithValue("@cod", contato.Codigo);
            objConexao.Conectar();
            cmd.ExecuteNonQuery();
            objConexao.Desconectar();

        }

        public void Excluir(int codigo) //esse foi o metodo exlcuir 
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;
            cmd.CommandText = "delete from contato" +
                " where con_cod =@cod";
            cmd.Parameters.AddWithValue("@cod", codigo);
            objConexao.Conectar();
            cmd.ExecuteNonQuery() ;
            objConexao.Desconectar();
        }

        public DataTable Localizar(String valor)
        {
            DataTable tabela = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from contato where con_nome like '% " +
            valor + "%'", objConexao.StringConexao);
            da.Fill(tabela);
            return tabela;
        }
        public Contato Carregacontato(int codigo)
        {
            Contato modelo = new Contato();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = objConexao.ObjetoConexao;
            cmd.CommandText = "select * from contato where con_cod =" + codigo.ToString();
            objConexao.Conectar();
            SqlDataReader registro = cmd.ExecuteReader();
            if (registro.HasRows) 
            {
                registro.Read();
                modelo.Codigo = Convert.ToInt32(registro["con_cod"]);
                modelo.Nome = Convert.ToString(registro["con_nome"]);
                modelo.Email = Convert.ToString(registro["con_email"]);
                modelo.Telefone = Convert.ToString(registro["con_fone"]);
                modelo.Endereco = Convert.ToString(registro["con_endereco"]);
                modelo.Bairro = Convert.ToString(registro["con_bairro"]);
                modelo.Cidade = Convert.ToString(registro["con_cidade"]);
                modelo.Estado = Convert.ToString(registro["con_estado"]);
                modelo.Cep = Convert.ToString(registro["con_cep"]);

            }
            return modelo;
        }
    }


}
