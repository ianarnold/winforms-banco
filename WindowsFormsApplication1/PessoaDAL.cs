using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;

namespace WindowsFormsApplication1
{
    class PessoaDAL
    {
        private static String strConexao = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=BDPessoas.mdb";
        private static OleDbConnection conn = new OleDbConnection(strConexao);
        private static OleDbCommand strSQL;
        private static OleDbDataReader result;

        public static void conecta()
        {
            try
            {
                conn.Open();
            }
            catch (Exception)
            {
                Erro.setMsg("Problemas ao se conectar ao Banco de Dados");
            }

        }

        public static void desconecta()
        {
            conn.Close();
        }

        public static void inserirNovaPessoa(Pessoa novaPessoa)
        {
            conn.Open();
            String aux = "insert into TabPessoa(codigo,nome,idade,sexo) values (@codigo,@nome,@idade,@sexo)";
            strSQL = new OleDbCommand(aux, conn);

            strSQL.Parameters.Add("@codigo", OleDbType.VarChar).Value = novaPessoa.getCodigo();
            strSQL.Parameters.Add("@nome", OleDbType.VarChar).Value = novaPessoa.getNome();
            strSQL.Parameters.Add("@idade", OleDbType.VarChar).Value = novaPessoa.getIdade();
            strSQL.Parameters.Add("@sexo", OleDbType.VarChar).Value = novaPessoa.getSexo();
            strSQL.ExecuteNonQuery();
            conn.Close();
        }

        public static void consultanovaPessoa(Pessoa novaPessoa)
        {
            conn.Open();
            String aux = "select * from TabPessoa where codigo = @codigo";
            strSQL = new OleDbCommand(aux, conn);

            strSQL.Parameters.Add("@codigo", OleDbType.VarChar).Value = novaPessoa.getCodigo();

            result = strSQL.ExecuteReader();
            Erro.setErro(false);
            if (result.Read())
            {
                novaPessoa.setNome(result.GetString(1));
                novaPessoa.setIdade(result.GetString(2));
                novaPessoa.setSexo(result.GetString(3));
            }
            else
                Erro.setMsg("Pessoa não cadastrada.");

            conn.Close();
        }
    }
}
