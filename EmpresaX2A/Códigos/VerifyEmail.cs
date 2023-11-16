using EmpresaX2A;
using System;

public class VerifyEmail
{
    string email;

    public string Email { get { return email; } set { email = value; } }

    public VerifyEmail(string email) { }
    public VerifyEmail() { }

    public bool Caracteres(string email)
    {
        if(email.Contains("@") && email.Contains(".com"))
        {
            return true;
        }

        else
        {
            return false;
        }
    }
}