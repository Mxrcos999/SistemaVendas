using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoVendas.data
{
    public class banco
    {
        public string msg { get; set; }


        
        SqlCommand cmd = new SqlCommand();
        

        public void CadastroCategoria(int id, string nome, string sobrenome, string cpf, string data, string email)
        {
            //Comando SQL -- SqlCommand insert, update, delete
            cmd.CommandText = $"INSERT INTO clientes (id, nome, sobrenome, cpf, data, email) VALUES ('{id}', {nome}', '{sobrenome}', '{cpf}', '{data}', '{email}')";


            //Parametros
          //  cmd.Parameters.AddWithValue("@nome", nome);


            try
            {
                //Conectar com Banco --Banco(conexao)
                var con = new SQLServerClass();
                cmd.Connection = con.conexao();
                //Executar Comando
                cmd.ExecuteNonQuery();
                //Desconectar com Banco
              //  conexao.desconectar();
                //Monstrar mensagem de erro ou sucesso
               

            }
            catch (Exception e)
            {
                 
            }
        }

    








    public void ToInsertCliente(int id, string nome, string sobrenome, string cpf, string data, string email)
        {
            try
            {
                string SQL;
                SQL = $"INSERT INTO clientes (id, nome, sobrenome, cpf, data, email) VALUES ('{id}', {nome}', '{sobrenome}', '{cpf}', '{data}', '{email}')";
                var db = new SQLServerClass();
                db.SQLCommandInsert(SQL);
                db.Close();
                msg = "certo";
            }
            catch (Exception e)
            {
                msg = e.Message;
                
            }
          
            
        }
        public void IncluirFicharioSQLREL()
        {
            try
            {
                //string SQL;
                
                var db = new SQLServerClass();
                db.Close();

            }
            catch (Exception)
            {
            }

        }
    }
}
