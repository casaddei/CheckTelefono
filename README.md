# Check Telefono

Ricevuto come parametro un vettore di string, ritornare al chiamante la prima stringa che assomiglia molto ad un numero di telefono cellulare italiano ovvero:
- che inizia con +39 (esattamente lungo  13)
- oppure con 0039 (esattamente lungo 14)
- oppure con un 3 (esattamente lungo 10)

Se il numero non viene trovato, ritornare stringa vuota ""

Ad esempio.
Se arriva "05417373", "3367726712",  "778823"
Tornare "3367726712"

Se arriva "33677267", "33677232",  "778823"
Tornare ""

Se arriva "", "05417723",  "+391231231234"
Tornare "+391231231234"

Se arriva "3", "05417723",  "00391231231230"
Tornare ""

etc


Per prima bisogna controllare che la stringa che ci viene passata assomigli a un numero di telefono italiano. 
###
private static bool NumeroItaliano(string valore)
    {
        if(valore.Length== 13 && ( valore.StartsWith("+39") || valore.StartsWith("0039")))
        return true;
        if(valore.Length== 14 && valore.StartsWith("0039"))
        return true;
        if(valore.Length== 10 && valore.StartsWith("3"))
        return true;
        return false;
    }
###
Usiamo un metodo booleano che controlla che la lunghezza della stringa sia giusta e che i suoi primi caratteri siano giusti; se sono giusti ritorna true. 

