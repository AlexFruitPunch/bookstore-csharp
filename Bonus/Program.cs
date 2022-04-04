/*___Bonus___
  Per chi di voi che se la sente può poi modificare questo programma, creando una nuova soluzione
  e copiando il codice precedentemente scritto dentro un’apposita cartella denominata BONUS
  dove può cimentarsi nel rendere le variabili non più “hardcoded” nel codice e provare invece a chiedere le informazioni del libro direttamente all’utente
  tramite l’input della console.  Oppure ancora meglio creare un nuovo progetto, facendo destra mouse sopra la soluzione e facendo add project.
  Potete chiamare questo progetto bonus. Ricordatevi poi di cambiare il progetto principale con l'opzione set as startup projectr 
  facendo destra mouse sul progetto che volete eseguire. */

//dichiarazioni delle variabili

Console.Write("Inserisci il titolo del libro: ");
string Titolo = Console.ReadLine();
Console.Write("Inserisci l'autore del libro: ");
string Autore = Console.ReadLine();
Console.Write("Inserisci il codice ISBN: ");
int ISBN = int.Parse(Console.ReadLine());
Console.Write("Inserisci il numero delle pagine ");
int numeroDiPagine = int.Parse(Console.ReadLine());
Console.Write("Inserisci il peso dell'articolo in grammi: ");
int pesoLibro = int.Parse(Console.ReadLine());

//Misure del libro
Console.Write("Inserisci la larghezza del libro in cm");
double largezza = double.Parse(Console.ReadLine());
Console.Write("Inserisci la profondità del libro in cm");
double profondità = double.Parse(Console.ReadLine());
Console.Write("Inserisci l'altezza del libro in cm");
double altezza = double.Parse(Console.ReadLine());

Console.Write("Inserisci la valutazione media: ");
double valutazioneMedia = double.Parse(Console.ReadLine());
Console.Write("Inserisci il numero di recensioni: ");
int NumeroRecensioni = int.Parse(Console.ReadLine());

//variabili Flag
bool Kindle = true;
string sceltaKindle;
bool copertinaFlessibile = true;
string sceltaCopertinaFlessibile;

Console.Write("Il libro ha il Kindle ? [si/no]");
sceltaKindle = Console.ReadLine();
do {
    if (sceltaKindle == "si")
    {
        Kindle = true;
    } else if (sceltaKindle == "no")
    {
        Kindle = false;
    }
} while (sceltaKindle == "si" || sceltaKindle == "no");

Console.Write("Il libro ha la copertina flessibile ? [si/no]");
sceltaCopertinaFlessibile = Console.ReadLine();
do
{
    if (sceltaCopertinaFlessibile == "si")
    {
        copertinaFlessibile = true;
    }
    else if (sceltaCopertinaFlessibile == "no")
    {
        copertinaFlessibile = false;
    }
} while (sceltaCopertinaFlessibile == "si" || sceltaCopertinaFlessibile == "no");


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