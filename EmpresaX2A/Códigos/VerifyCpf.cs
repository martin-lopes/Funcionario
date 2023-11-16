using EmpresaX2A;
using System;

public class VerifyCpf
{
    public string cpf;

    public string Cpf { get { return cpf; } set { cpf = value; } }

    public VerifyCpf(string cpf) { }

    public VerifyCpf() { }

    public bool Digitos(string cpf)
    {
        //COMMIT TESTE PROVA
        cpf = cpf.Replace(",", "");
        cpf = cpf.Replace("-", "");

        //MessageBox.Show(cpf);

        int soma = 0;
        int digito = 0;
        int resto = 0;
        int digito1 = 0;
        int digito2 = 0;

        if (cpf.Length == 11)
        {
            //multiplica os 9 primeiro 
            //int cont = 0;//elias

            for (int i = 0; i < 9; i++)
            {
                //digito = Convert.ToInt32(cpf[0]), cpf[0] é igual a 0 (032.877.232-19), só que tá em string
                digito = Convert.ToInt32(cpf[i].ToString());// msm coisa que digito = Convert.ToInt32("0");

                soma = soma + digito * (10 - i);
            }

            resto = soma % 11;//calcula o valor do primeiro digito depois do traço, nesse caso, seria o 1 (-19)
                              //ex: 197 % 11 = 10

            if (resto < 2)
            {
                digito1 = 0;
                //se o resto for menor que 2, o primeiro digito depois do traço deveria ser 0
            }

            else //if (resto > 2)
            {
                digito1 = 11 - resto;
                //se o resto for maior que 2, tem que fazer a subtração pra descobrir qual deveria ser o primeiro digito
                //ex: digito1 = 11 - 10; digito1 = 1; nesse caso o primeiro digito dps do traço DEVERIA ser 1
            }

            //verifica o primeiro digito depois do traço, que seria o 1
            //compara a variavel digito1 com o primeiro digito dps do traço
            //ex: digito1 é diferente de 1? 1 é diferente de 1?, se for diferente, o cpf já é falso

            if (digito1.ToString() != cpf[9].ToString())
            {
                return false;
            }

            //if (digito1.ToString() == cpf[9].ToString())se for igual, prossegue para verificar o segundo digito
            //{
            soma = 0;
            //cont = 0;//elias
            for (int i = 0; i < 10; i++)//multiplica os 10 primeiros digitos, agr conta o 1 dps do traço
            {
                digito = Convert.ToInt32(cpf[i].ToString());
                //cont++;//elias
                soma = soma + digito * (11 - i);
            }

            resto = soma % 11;

            if (resto < 2)
            {
                digito2 = 0;
                //se o resto for menor que 2, o primeiro digito depois do traço deveria ser 0
            }

            else //if (resto > 2)
            {
                digito2 = 11 - resto;
                //se o resto for maior que 2, tem que fazer a subtração pra descobrir qual deveria ser o primeiro digito
            }

            if (digito2.ToString() != cpf[10].ToString())
            {
                return false;
            }

            else
            {
                return true;
            }
            //}

            /*else //if (digito1.ToString() != cpf[9].ToString())
            {
                return false;
            }*/
        }

        else
        {
            return false;
        }
    }
}
