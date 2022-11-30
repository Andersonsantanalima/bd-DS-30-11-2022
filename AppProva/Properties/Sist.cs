using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace AppProva.Properties
{
    class Sist
    {

        private MySqlConnection objConexao = new MySqlConnection();
        private MySqlCommand objComandos = new MySqlCommand();
        private MySqlDataAdapter objDadosEmMemoria;
        private string msgErro;
        private string strDeConexao;
        private int lastId;



        public Sist(string server, string dataBase, string user, string password = "")
        {
            strDeConexao = "Persist Security Info=False;";
            strDeConexao += $"Server={server};";
            strDeConexao += $"Database={dataBase};";
            strDeConexao += $"User={user};";
            strDeConexao += $"Pwd={password};";
            strDeConexao += $"SslMode=none";
        }



        public int getLastId()
        {
            return this.lastId;
        }



        public string getMsgErro()
        {
            return this.msgErro;
        }



        private bool conectar()
        {
            try
            {
                desconectar();
                objConexao.ConnectionString = strDeConexao;

                objComandos.Connection = objConexao;

                objConexao.Open();
                return true;
            }
            catch (Exception erro)
            {
                msgErro = erro.Message.ToString();
                return false;
            }
        }



        private bool desconectar()
        {
            try
            {
                if (objConexao.State == ConnectionState.Open)
                {
                    objConexao.Close();
                }
                return true;
            }
            catch (Exception erro)
            {
                this.msgErro = erro.Message.ToString();
                return false;
            }
        }


        public bool testarConexao()
        {
            return conectar();
        }



        public int INSERT(string comandoSql)
        {
            try
            {
                if (this.conectar())
                {
                    objComandos.CommandText = comandoSql;
                    int result = objComandos.ExecuteNonQuery();
                    if (result > 0)
                    {
                        DataTable retorno = SELECT("SELECT LAST_INSERT_ID() as lastId");
                        this.lastId = Convert.ToInt32(retorno.Rows[0]["lastId"]);
                        return result;
                    }
                    else
                    {
                        msgErro = "Erro na inclusão de dados\nNenhum dado novo incluido";
                    }



                }
                return 0;
            }
            catch (Exception erro)
            {
                msgErro = erro.Message.ToString();
                return 0;
            }
        }



        public int UPDATE(string comandoSql)
        {
            try
            {
                if (conectar())
                {
                    objComandos.CommandText = comandoSql;
                    int result = objComandos.ExecuteNonQuery();
                    if (result > 0)
                    {
                        return result;
                    }
                    msgErro = "Erro na alteração de dados";

                }
                return 0;
            }
            catch (Exception erro)
            {
                msgErro = erro.Message.ToString();
                return 0;
            }
        }



        public int DELETE(string comandoSql)
        {
            try
            {
                if (conectar())
                {
                    objComandos.CommandText = comandoSql;
                    int result = objComandos.ExecuteNonQuery();
                    if (result > 0)
                    {
                        return result;
                    }
                    msgErro = "Erro na exclusão de dados";
                }
                return 0;
            }
            catch (Exception erro)
            {
                msgErro = erro.Message.ToString();
                return 0;
            }
        }



        public DataTable SELECT(string comandoSql)
        {
            try
            {
                if (conectar())
                {
                    this.objDadosEmMemoria = new MySqlDataAdapter(comandoSql, objConexao);



                    DataTable tabelaDeDados = new DataTable();



                    objDadosEmMemoria.Fill(tabelaDeDados);



                    if (tabelaDeDados.Rows.Count > 0)
                    {
                        return tabelaDeDados;
                    }
                }
                return null;
            }
            catch (Exception erro)
            {
                msgErro = erro.Message.ToString();
                return null;
            }
        }



    }
}
    

