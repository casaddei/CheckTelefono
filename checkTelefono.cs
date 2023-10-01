using System;
using System.Collections.Generic;

public static class Telefono
{

    public static string Check(string[] input)
    {
       foreach(var valore in input)
       {
        if(Numerovero(valore))
        return valore;
       }
       return"";
    }
    private static bool Numerovero(string valore)
    {
        if(valore.Length == 13 && ( valore.StartsWith("+39") || valore.StartsWith("0039")))
        return true;
        if(valore.Length == 14 && valore.StartsWith("0039"))
        return true;
        if(valore.Length == 10 && valore.StartsWith("3"))
        return true;
        return false;
    }
}