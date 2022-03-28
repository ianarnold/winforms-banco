using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Pessoa minhaPessoa = new Pessoa();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            minhaPessoa.setCodigo(textBox1.Text);
            minhaPessoa.setNome(textBox2.Text);
            minhaPessoa.setIdade(textBox3.Text);
            minhaPessoa.setSexo(textBox5.Text);
            PessoaBLL.validaDados(minhaPessoa);

            if (Erro.getErro())
                MessageBox.Show(Erro.getMsg());
            else
                MessageBox.Show("Dados inseridos com sucesso!");
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            minhaPessoa.setCodigo(textBox4.Text);
            PessoaBLL.validaCodigo(minhaPessoa);
            if (Erro.getErro())
                MessageBox.Show(Erro.getMsg());
            else
            {
                MessageBox.Show("Código: "+ minhaPessoa.getCodigo(),
                    "Nome: "+ minhaPessoa.getNome(),
                    "Nome: "+ minhaPessoa.getNome(),
                    


                textBox1.Text = " ";
                textBox2.Text = " ";
                textBox3.Text = " ";
                textBox5.Text = " ";
            }
        }
       

    }
}
