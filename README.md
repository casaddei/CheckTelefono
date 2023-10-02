# Check Telefono

###
     public static string Check(string[] input)
    {
       foreach(var valore in input)   // ciclo foreach che scorre il vettore passato in input cotrollando tutte le sue variabili 
       {
        if(Numerovero(valore))       // qui si va a richiamare il metodo Numerovero che abbiamo definito sotto 
        return valore;               // se la condizione è soddisfatta si ritorna il valore (cioè l'elemento del vettore)
       }
       return"";                    // nel caso in cui la condizione non è soddisfatta ritorna "" 
    }
###


Per prima cosa bisogna controllare che la stringa che ci viene passata assomigli a un numero di telefono italiano. 
Per farlo usiamo il metodo Numerovero che abbiamo definito nel pezzo di codice sotto. 

###
    private static bool Numerovero(string valore)
    {
        if(valore.Length == 13 && ( valore.StartsWith("+39") || valore.StartsWith("0039")))    // se la stringa valore è lunga 13 ed inzia per 0039 o +39 il metodo ritorna true
        return true;
        if(valore.Length == 14 && valore.StartsWith("0039"))  // se la stringa valore è lunga 14 ed inzia per 0039 ritorna true
        return true;
        if(valore.Length == 10 && valore.StartsWith("3"))  // se la stinga valore è lunga 10 ed inizia per 3 ritorna true 
        return true;
        return false; // nel caso in cui nessuna delle condizioni sopra si verifichi il metodo ritorna false
    }
###
In questo pezzo di codice abbiamo definito un metodo booleano privato chiamato Numerovero che si occupa di controllare la stringa che gli viene passata in input.
In particolare controlla se si verificano alcune condizioni e in quel caso ritorna true, in caso contrario false.
