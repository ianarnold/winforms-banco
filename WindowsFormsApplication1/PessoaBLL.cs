using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class PessoaBLL
    {
        public static void conecta()
        {
            PessoaDAL.conecta();
        }

        public static void desconecta()
        {
            PessoaDAL.desconecta();
        }

        public static void validaCodigo(Pessoa novaPessoa)
        {
            Erro.setErro(false);
            if (novaPessoa.getCodigo().Equals(""))
            {
                Erro.setMsg("O código é de preenchimento obrigatório!");
                return;
            }
            PessoaDAL.consultanovaPessoa(novaPessoa);
        }

        public static void validaDados(Pessoa novaPessoa)
        {
            Erro.setErro(false);
            if (novaPessoa.getCodigo().Equals(""))
            {
                Erro.setMsg("O código é de preenchimento obrigatório!");
                return;
            }
            if (novaPessoa.getNome().Equals(""))
            {
                Erro.setMsg("O nome é de preenchimento obrigatório!");
                return;
            }
            if (novaPessoa.getIdade().Equals(""))
            {
                Erro.setMsg("A idade é de preenchimento obrigatório!");
                return;
            }
            if (novaPessoa.getSexo().Equals(""))
            {
                Erro.setMsg("O campo Sexo é de preenchimento obrigatório!");
                return;
            }

            if (novaPessoa.getSexo() != "M" && novaPessoa.getSexo() != "F")
            {
                Erro.setMsg("O campo sexo só aceita M ou F");
                return;
            }

            try
            {
                int.Parse(novaPessoa.getCodigo());
            }
            catch (Exception)
            {
                Erro.setMsg("O campo código deve ser numérico!");
                return;
            }


            if (int.Parse(novaPessoa.getCodigo()) <= 0)
            {
                Erro.setMsg("O valor do código deve ser numérico e positivo!");
                return;
            }

            try
            {
                int.Parse(novaPessoa.getIdade());
            }
            catch (Exception)
            {
                Erro.setMsg("O valor da idade deve ser numérico!");
                return;
            }


            if (int.Parse(novaPessoa.getIdade()) <= 0)
            {
                Erro.setMsg("O valor da idade deve ser numérico e positivo!");
                return;
            }

            PessoaDAL.inserirNovaPessoa(novaPessoa);

        }
    }
}
