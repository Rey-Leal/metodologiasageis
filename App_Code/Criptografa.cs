using System;
using System.Collections.Generic;
using System.Text;


public class Criptografa
{
    public static int ValidaValor(int temp)
    {
        if (temp < 32)
        {
            temp = temp * 2;
        }
        if (temp > 126)
        {
            temp = (temp - 126) * 3;
        }
        return temp;
    }

    public static String Senha(String senhaReal)
    {
        String senhaCriptografada = null;
        int temp;

        for (int i = 0; i < senhaReal.Length; i++)
        {
            if (i % 2 == 0)
            {
                if (i <= 4)
                {
                    temp = ((int)(Convert.ToChar(senhaReal[i]))) + 5;
                    temp = ValidaValor(temp);
                    senhaCriptografada += (char)temp;
                }
                else
                {
                    temp = ((int)(Convert.ToChar(senhaReal[i]))) - 3;
                    temp = ValidaValor(temp);
                    senhaCriptografada += (char)temp;
                }
            }
            else
            {
                if (i <= 3)
                {
                    temp = ((int)(Convert.ToChar(senhaReal[i]))) + 10;
                    temp = ValidaValor(temp);
                    senhaCriptografada += (char)temp;
                }
                else
                {
                    temp = ((int)(Convert.ToChar(senhaReal[i]))) - 7;
                    temp = ValidaValor(temp);
                    senhaCriptografada += (char)temp;
                }
            }
        }
        return senhaCriptografada;
    }
}

