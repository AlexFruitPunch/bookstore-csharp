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
long ISBN = long.Parse(Console.ReadLine());
Console.Write("Inserisci il numero delle pagine ");
int numeroDiPagine = int.Parse(Console.ReadLine());
Console.Write("Inserisci il peso dell'articolo in grammi: ");
int pesoLibro = int.Parse(Console.ReadLine());

//Misure del libro
Console.Write("Inserisci la larghezza del libro in cm: ");
double largezza = double.Parse(Console.ReadLine());
Console.Write("Inserisci la profondità del libro in cm: ");
double profondità = double.Parse(Console.ReadLine());
Console.Write("Inserisci l'altezza del libro in cm: ");
double altezza = double.Parse(Console.ReadLine());

//controllo sulla valutazione media
double valutazioneMedia;
do
{
    Console.Write("Inserisci la valutazione media [da 1 a 5]: ");
    valutazioneMedia = double.Parse(Console.ReadLine());
} while(valutazioneMedia > 5 || valutazioneMedia < 1);


Console.Write("Inserisci il numero di recensioni: ");
int NumeroRecensioni = int.Parse(Console.ReadLine());

//variabili Flag
bool Kindle = true;
string sceltaKindle;
bool copertinaFlessibile = true;
string sceltaCopertinaFlessibile;

//controllo sull'imput di Kindle e copertina flessibile 
do {
    Console.Write("Il libro ha il Kindle ? [si/no] ");
    sceltaKindle = Console.ReadLine();

    if (sceltaKindle == "si")
    {
        Kindle = true;
    } else if (sceltaKindle == "no")
    {
        Kindle = false;
    }
    else
    {
        Console.WriteLine("imput errato, inserire per piacere solo si o no");
    }
} while (sceltaKindle != "si" && sceltaKindle != "no");

do
{
    Console.Write("Il libro ha la copertina flessibile ? [si/no] ");
    sceltaCopertinaFlessibile = Console.ReadLine();
    if (sceltaCopertinaFlessibile == "si")
    {
        copertinaFlessibile = true;
    }
    else if (sceltaCopertinaFlessibile == "no")
    {
        copertinaFlessibile = false;
    }
    else
    {
        Console.WriteLine("imput errato, inserire per piacere solo si o no");
    }
} while (sceltaCopertinaFlessibile != "si" && sceltaCopertinaFlessibile != "no");
//fine Controllo su kindle e copertina flessibile
Console.WriteLine("\n");

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
    Console.WriteLine("Copertina Flessibile disponibile: Si\n");
}
else
{
    Console.WriteLine("Copertina Flessibile disponibile: No\n");
}

Console.WriteLine("\n---------------------------------------------------------");