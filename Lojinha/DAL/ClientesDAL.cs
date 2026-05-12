using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lojinha.Modelos;

namespace Lojinha.DAL
{
    public class ClientesDAL
    {

        public void Incluir(ClienteInformation cliente)
        {

            //conexao com o bloco de dados
            SqlConnection cn = new SqlConnection();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Altera_cliente";
                //parametros da stored procedure
                SqlParameter pcodigo = new SqlParameter("@codigo", SqlDbType.Int);
                pcodigo.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pcodigo);
                SqlParameter prome = new SqlParameter("@nome", SqlDbType.VarChar, 100)
                        prome.Value = cliente.pnome;
                cmd.Parameters.Add(prome);

                SqlParameter pemail = new SqlParameter("@email", SqlDbType.VarChar, 100)
                        pemail.Value = cliente.telefone;
                cmd.Parameters.Add(pemail);

                SqlParameter ptelefone = new SqlParameter("@ptelefone", SqlDbType.VarChar, 100)
                        ptelefone.Value = cliente.Nome;
                cmd.Parameters.Add(ptelefone);

                cn.Open();
                cmd.ExecuteNonQuery();

                cliente.codigo = (Int32)cmd.Parameters["2Codigo"].Value;

            }
            catch (SqlException ex)
            {
                throw new Exception("erro ao acessar o banco de dados." + ex.Number);
            }
            catch {

                throw new Exception("erro desconhecido ao acessar o Banco de dados.");
            }

            finally
            {
                cn.Close();
            }
        }
        public void Alterar(ClienteInformation cliente)
        {
            //conexao com o bloco de dados
            SqlConnection cn = new SqlConnection();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "insere_clientes";
                //parametros da stored procedure
                SqlParameter pcodigo = new SqlParameter("@codigo", SqlDbType.Int);
                pcodigo.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(pcodigo);
                SqlParameter prome = new SqlParameter("@nome", SqlDbType.VarChar, 100)
                        prome.Value = cliente.pnome;
                cmd.Parameters.Add(prome);

                SqlParameter pemail = new SqlParameter("@email", SqlDbType.VarChar, 100)
                        pemail.Value = cliente.telefone;
                cmd.Parameters.Add(pemail);

                SqlParameter ptelefone = new SqlParameter("@ptelefone", SqlDbType.VarChar, 100)
                        ptelefone.Value = cliente.Nome;
                cmd.Parameters.Add(ptelefone);

                cn.Open();
                cmd.ExecuteNonQuery();

                cliente.codigo = (Int32)cmd.Parameters["2Codigo"].Value;

            }
            catch (SqlException ex)
            {
                throw new Exception("erro ao acessar o banco de dados." + ex.Number);
            }
            catch
            {

                throw new Exception("erro desconhecido ao acessar o Banco de dados.");
            }

            finally
            {
                cn.Close();

                {

                }
            }
        }






        public DataTable Listagem(string Filtro)
        {
            DataTable tabela = new DataTable();
            //conexao com o bloco de dados
            SqlConnection cn = new SqlConnection();
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "listagem_clientes";
                //parametros da stored procedure
                SqlParameter pfiltro = new SqlParameter("@filtro", SqlDbType.VarChar, 100);
                pfiltro.Value = Filtro;
                cmd.Parameters.Add(pfiltro);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(tabela);
            }
            catch (SqlException ex)
            {
                throw new Exception("erro ao acessar o banco de dados." + ex.Number);
            }
            catch
            {
                throw new Exception("erro desconhecido ao acessar o Banco de dados.");
            }
            finally
            {
                cn.Close();
            }
            return tabela;
            {
                //conexao com o bloco de dados
                SqlConnection cn = new SqlConnection();
                try
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = cn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "excluir_clientes";
                    //parametros da stored procedure
                    SqlParameter pcodigo = new SqlParameter("@codigo", SqlDbType.Int);
                    pcodigo.Direction = ParameterDirection.Output;
                    cmd.Parameters.Add(pcodigo);
                    SqlParameter prome = new SqlParameter("@nome", SqlDbType.VarChar, 100)
                            prome.Value = cliente.pnome;
                    cmd.Parameters.Add(prome);

                    SqlParameter pemail = new SqlParameter("@email", SqlDbType.VarChar, 100)
                            pemail.Value = cliente.telefone;
                    cmd.Parameters.Add(pemail);

                    SqlParameter ptelefone = new SqlParameter("@ptelefone", SqlDbType.VarChar, 100)
                            ptelefone.Value = cliente.Nome;
                    cmd.Parameters.Add(ptelefone);

                    cn.Open();
                    cmd.ExecuteNonQuery();

                    cliente.codigo = (Int32)cmd.Parameters["2Codigo"].Value;

                }
                catch (SqlException ex)
                {
                    throw new Exception("erro ao acessar o banco de dados." + ex.Number);
                }
                catch
                {

                    throw new Exception("erro desconhecido ao acessar o Banco de dados.");
                }

                finally
                {
                    cn.Close();

                }
            }
        }

    }
}
        
    




