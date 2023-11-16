using EmpresaX2A;
using EmpresaX2A.Configuracao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmpresaX2A
{
    public partial class CadFun : Form
    {
        private Funcionario _funcionario;

        public CadFun()
        {
            InitializeComponent();
            Inserir(_funcionario);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void b_salvar_Click(object sender, EventArgs e)
        {
            string nome = tx_nome.Text;
            string estadocivil = tx_estadocivil.Text;
            string telefone = tx_telefone.Text;
            string txdatanasc = tx_nascimento.Text;
            string rg = tx_rg.Text;
            string txcpf = tx_cpf.Text;
            string txemail = tx_email.Text;
            string funcao = tx_funcao.Text;
            string txsalario = tx_salario.Text;
            string endereco = tx_endereco.Text;
            string cidade = tx_cidade.Text;
            string estado = tx_estado.Text;

            double salario = Convert.ToDouble(txsalario);
            DateTime datanasc = Convert.ToDateTime(txdatanasc);

            VerifyCpf cpf = new VerifyCpf(txcpf);
            bool cpfverificado = cpf.Digitos(txcpf);

            VerifyEmail email = new VerifyEmail(txemail);
            bool emailverificado = email.Caracteres(txemail);

            if (cpf.Digitos(txcpf))
            {
                //MessageBox.Show("CPF válido!", "Validação de CPF", MessageBoxButtons.OK, MessageBoxIcon.None);
                if (email.Caracteres(txemail))
                {
                    //MessageBox.Show("Email válido!", "Validação de email", MessageBoxButtons.OK, MessageBoxIcon.None);
                }

                else
                {
                    MessageBox.Show("Email Inválido! Insira um email verdadeiro.", "Validação de email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            
            else
            {
                MessageBox.Show("CPF Inválido! Insira um CPF verdadeiro para prosseguir.", "Validação de CPF", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if(email.Caracteres(txemail) && cpf.Digitos(txcpf))
            {

                MessageBox.Show("Funcionário Cadastrado com sucesso.", "Cadastro de Funcionário", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _funcionario = new Funcionario(nome, estadocivil, telefone, datanasc, rg, txcpf, txemail, funcao,
                salario, endereco, cidade, estado);
            }

            else
            {
                MessageBox.Show("Erro no cadastro. Revise suas informações.", "Cadastro de Funcionário", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        void Inserir(Funcionario _funcionario)
        {

            try
            {
                Conexao conexao = new Conexao();

                var comando = conexao.Comando("INSERT INTO funcionario (nome_fun, datanasc_fun, cpf_fun, rg_fun, telefone_fun, email_fun" +
                    "endereco_fun, estadocivil_fun, funcao_fun, salario_fun) VALUES @_funcionario.nome, @_funcionario.datanasc," +
                    "@_funcionario.cpf, @_funcionario.rg, @_funcionario.telefone, @_funcionario.email, @_funcionario.endereco," +
                    "@_funcionario.estadocivil, @_funcionario.funcao, @_funcionario.funcao, @_funcionario.salario");

                comando.Parameters.AddWithValue("@_funcionario.nome", _funcionario.Nome);
                comando.Parameters.AddWithValue("@_funcionario.datanasc", _funcionario.Datanasc);
                comando.Parameters.AddWithValue("@_funcionario.cpf", _funcionario.Cpf);
                comando.Parameters.AddWithValue("@_funcionario.rg", _funcionario.Rg);
                comando.Parameters.AddWithValue("@_funcionario.telefone", _funcionario.Telefone);
                comando.Parameters.AddWithValue("@_funcionario.email", _funcionario.Email);
                comando.Parameters.AddWithValue("@_funcionario.endereco", _funcionario.Endereco);
                comando.Parameters.AddWithValue("@_funcionario.estadocivil", _funcionario.Estadocivil);
                comando.Parameters.AddWithValue("@_funcionario.funcao", _funcionario.Funcao);
                comando.Parameters.AddWithValue("@_funcionario.salario", _funcionario.Salario);

            }
            
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }
    }
}
