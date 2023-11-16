using EmpresaX2A;
using System;
public class Funcionario
{
    private string nome;
    private string estadocivil;
    private string telefone;
    private DateTime datanasc;
    private string rg;
    private string cpf;
    private string email;
    private string funcao;
    private double salario;
    private string endereco;
    private string cidade;
    private string estado;

    public string Nome
    {
        get { return nome; } set { nome = value; }
    }
    public string Estadocivil
    {
        get { return estadocivil; } set { estadocivil = value; }
    }

    public string Telefone
    {
        get { return telefone; } set { telefone = value; }
    }

    public DateTime Datanasc
    {
        get { return datanasc; } set { datanasc = value; }
    }

    public string Rg
    {
        get { return rg; } set { rg = value; }
    }

    public string Cpf
    {
        get { return cpf; } set {  cpf = value; }
    }

    public string Email
    {
        get { return email; } set { email = value; }
    }

    public string Funcao
    {
        get { return funcao; } set { funcao = value; }
    }
    
    public double Salario
    {
        get { return salario; } set { salario = value; }
    }

    public string Endereco
    {
        get { return endereco; } set {  endereco = value; }
    }

    public string Cidade
    {
        get { return cidade; } set { cidade = value; }
    }

    public string Estado
    { 
        get { return estado; } set {  estado = value; }
    }

    public Funcionario(string nome, string estadocivil, string telefone, DateTime datanasc, string rg, string cpf, string email, string funcao, double salario, string endereco, string cidade, string estado   )
    {
        Nome = nome;
        Estadocivil = estadocivil;
        Telefone = telefone;
        Datanasc = datanasc;
        Rg = rg;
        Cpf = cpf;
        Email = email;
        Funcao = funcao;
        Salario = salario;
        Endereco = endereco;
        Cidade = cidade;
        Estado = estado;
        Nome = nome;
        Estadocivil = estadocivil;
        Telefone = telefone;
        Datanasc = datanasc;
        Rg = rg;
        Cpf = cpf;
        Email = email;
        Funcao = funcao;
        Salario = salario;
        Endereco = endereco;
        Cidade = cidade;
        Estado = estado;
    }

    public Funcionario()
    { }
}
