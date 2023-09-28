using System;
using System.Collections.Generic;

public static class Telefono
{

    public static string Check(string[] input)
    {
        string inizio="+39";
        int lunghezza = input.Length;
        string[] numero = input;
            if(lunghezza==10)
            {
                if(numero.StartsWith(inizio))
                return numero;
                else
                return "";
            }
            else 
            return "";
    }
}