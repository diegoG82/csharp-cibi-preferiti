//Creazione Array cibi preferiti
string[] CibiPreferiti = { "Pizza", "Hamburger", "Mascarpone", "Patatine", "Cioccolato", "Sushi" };

//La lunghezza della classifica dei cibi
Console.WriteLine($"la lunghezza della classifica dei miei cibi preferiti è di: { CibiPreferiti.Length} Alimenti");

//Riga vuota per spaziare
Console.WriteLine();

//La vostra classifica (dunque stampare l’intero array in ordine indicando la posizione in classifica)
Console.WriteLine("La mia personale classifica dei cibi:");
for (int i = 0; i < CibiPreferiti.Length; i++)
{
    Console.WriteLine($"{i + 1} {CibiPreferiti[i]}");
}

//Riga vuota per spaziare
Console.WriteLine();


//Il vostro cibo top (prima posizione della classifica)
Console.WriteLine($"Il mio cibo preferito e' la {CibiPreferiti[0]}" );

//Riga vuota per spaziare
Console.WriteLine();

//Il vostro cibo preferito ma non troppo (ultima posizione della classifica)
Console.WriteLine($"il mio cibo preferito ma non troppo è il {CibiPreferiti[CibiPreferiti.Length - 1]} "  );

//Riga vuota per spaziare
Console.WriteLine();

//BONUS

//Stampate a video anche il cibo di mezza classifica, cioè che si trova nella posizione mediana.
//Attenzione: gestire anche il caso se aveste una classifica con un numero di elementi pari. 
//In questo caso vanno stampati i 2 elementi in centro alla vostra classifica.


if (CibiPreferiti.Length % 2 == 0)

    {
    //Casistica array lungo pari   
    var cibo1 = (CibiPreferiti.Length / 2 - 1);
    var cibo2 = cibo1 + 1;
    Console.WriteLine($"i miei cibi di meta classifica sono: {CibiPreferiti[cibo1]} e {CibiPreferiti[cibo2]}  ");
}
else
{
    //Casistica array lungo dispari
    var cibo = CibiPreferiti.Length / 2;
    Console.WriteLine($"il mio cibo di meta classifica è il: {CibiPreferiti[cibo]}" );
}

