using Microsoft.IdentityModel.Protocols;
using Order;
using SistemaDeVendas.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoVendas.data
{
    public class SQLServerClass
    {
        public string stringConn;
        public SqlConnection connDB;
        SqlDataReader reader = null;
        [Required(ErrorMessage = "o campo id do cliente é obrigatorio")]

        public string id { get; set; }
        [Required(ErrorMessage = "o campo id do produto é obrigatorio")]

        public string idProdut { get; set; }
        [Required(ErrorMessage = "o campo quantidade de produtos é obrigatorio")]

        public string _quantidade { get; set; }
        public decimal valor { get; set; }
        public string msg { get; set; }
        
        public SqlConnection conexao()
        {
            try
            {
                stringConn = "Data Source=LAPTOP-81KFE72D;Initial Catalog=SistemaVenda;Persist Security Info=True;User ID=sa;Password=26092004";
                connDB = new SqlConnection(stringConn);
                connDB.Open();
                return connDB;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
          
        }

       
        public bool SQLCommandInsert(string SQL)
        {
            var cmd = new SqlCommand();
            cmd.CommandText = SQL;


       

            try
            {
                cmd.Connection = conexao();
                cmd.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
            finally
            {
                connDB.Close();
            }

        }
        public bool SQLCommandSelectCliente(int idCliente)
        {
         
            var cmd = new SqlCommand();
            cmd.CommandText = $"select id from clientes WHERE id ={ idCliente}";


    
            try
            {
                cmd.Connection = conexao();
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                  id = Convert.ToString(reader.GetInt32(0));

                  

                }
                if(Convert.ToInt32( id) == 0)
                {
                    msg = "Insira um cliente valido!";
                    return false;

                }



                return true;
            }
            catch(SqlException ex)
            {
                return false;
            }
            finally
            {
                connDB.Close();
            }

        }
        public bool SQLCommandSelecProdutos( int idProduto, int quantidade)
        {
            var cmd = new SqlCommand();
            cmd.CommandText = $"select id, quantidade, valor from produtos WHERE id={idProduto}";

            try
            {
                cmd.Connection = conexao();
                reader = cmd.ExecuteReader();
                
                while (reader.Read())
                {
                    idProdut = Convert.ToString(reader.GetInt32(0));
                    _quantidade = Convert.ToString(reader.GetInt32(1));
                    valor = reader.GetDecimal(2);

                }
                if(Convert.ToInt32(idProdut) == 0)
                {
                    throw new SelectException("Insira um produto valido!");

                }
                var teste = new OrderItem(Convert.ToInt32(_quantidade));
                teste.recebeDado(valor, Convert.ToInt32(id), Convert.ToInt32(idProdut), quantidade);
                return true;

               
            }
            catch(SelectException ex)
            {
                msg = ex.Message;
                return false;
            }
            finally
            {
                connDB.Close();
            }

        }
        public void Close()
        {
            connDB.Close();
        }
    }
}
