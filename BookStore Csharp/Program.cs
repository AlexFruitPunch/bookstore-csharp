/*In questo esercizio vogliamo inserire in maniera “hardcoded” (ossia scritte nel codice senza dover chiedere all’utente nessun input) tutte le informazioni che troviamo su Amazon di un libro (per esempio "Clean Code") per poi stamparne una piccola sintesi fatta bene.
Le informazioni sul libro che dobbiamo chiedere all’utente sono le seguenti:
-Titolo
- Autore
- ISBN
- Numero pagine
- Peso del libro
- Larghezza, Altezza e Profondità del libro
- Valutazione media
- Numero di recensioni
- se è disponibile in versione Kindle
- se la copertina flessibile è disponibile
Per ognuna delle seguente informazioni è importante individuare bene il tipo corretto.
A questo punto stampiamo bene le informazioni acquisite sulla console, dove per <<nomeVariabile>> indica di stampare l’informazione contenuta nella variabile.*/

//dichiarazioni delle variabili

string Titolo = " The Witcher - Il guardiano degli innocenti.";
string Autore = "Andrzej Sapkowski";
string ISBN = "8842916595";
int numeroDiPagine = 372;
int pesoLibro = 500;

//Misure del libro
double largezza = 14.8;
double profondità = 4.1;
double altezza = 21.3;

double valutazioneMedia = 4.5;
int NumeroRecensioni = 2381;

//variabili Flag
bool Kindle = true;
bool copertinaFlessibile = true;

//Stampa a video delle informazioni raccolte

Console.WriteLine("---IL LIBRO DI OGGI: " + Titolo + " di " + Autore + " -----\n");
Console.WriteLine("Informazioni generiche:");
Console.WriteLine("ISBN: " + ISBN);
Console.WriteLine("Numero delle pagine: " + numeroDiPagine + " pagine");
Console.WriteLine("Peso del libro: " + pesoLibro + " g");
Console.WriteLine("Dimensione del libro: " + largezza + " cm x " + altezza + " cm x " + profondità + " cm\n");
Console.WriteLine("Informazioni Amazon:");
Console.WriteLine("Numero di Recensioni: " + NumeroRecensioni + " recensioni");
Console.WriteLine("Valutazione Media: " + valutazioneMedia + " stelline");

if (Kindle)
{
    Console.WriteLine("Kindle disponibile: Si");
}
else
{
    Console.WriteLine("Kindle disponibile: No");
}

if (copertinaFlessibile)
{
    Console.WriteLine("Copertina Flessibile disponibile: Si");
}
else
{
    Console.WriteLine("Copertina Flessibile disponibile: No");
}


