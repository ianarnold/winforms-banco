using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Pessoa
    {
        private String codigoPessoa;
        private String nomePessoa;
        private String idadePessoa;
        private String sexoPessoa;

        public void setCodigo(String _codigoPessoa) { codigoPessoa = _codigoPessoa; }
        public void setNome(String _nomePessoa) { nomePessoa = _nomePessoa; }
        public void setIdade(String _idadePessoa) { idadePessoa = _idadePessoa; }
        public void setSexo(String _sexoPessoa) { sexoPessoa = _sexoPessoa; }

        public String getCodigo() { return codigoPessoa; }
        public String getNome() { return nomePessoa; }
        public String getIdade() { return idadePessoa; }
        public String getSexo() { return sexoPessoa; }
    }
}
