//Creazione Array cibi preferiti
string[] CibiPreferiti = { "Pizza", "Hamburger", "Mascarpone", "Cioccolato", "Sushi" };

//La lunghezza della classifica dei cibi
Console.WriteLine("la lunghezza della classifica dei miei cibi preferiti è di : " + CibiPreferiti.Length + " Alimenti");

//Riga vuota per spaziare
Console.WriteLine();

//La vostra classifica (dunque stampare l’intero array in ordine indicando la posizione in classifica)
Console.WriteLine("La mia personale classifica dei cibi:");
for (int i = 0; i < CibiPreferiti.Length; i++)
{
    Console.WriteLine(i + 1  + "." +  CibiPreferiti[i]);
}

//Riga vuota per spaziare
Console.WriteLine();

//Il vostro cibo top (prima posizione della classifica)
Console.WriteLine("il mio cibo preferito e' la " + CibiPreferiti[0]);


