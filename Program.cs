// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Banca banca = new Banca("unicredit");
Cliente Cliente_1 = new Cliente("pippo", "franco", "mdxrgfzht", 1000);
banca.AggiungiCliente(Cliente_1);

//ricerca cliente
Console.WriteLine("Inserisci il codice fiscale:");
string ricerca = Console.ReadLine();
Cliente esistente = banca.RicercaCliente(ricerca);

if (esistente == null)
{
    Console.WriteLine("errore: Cliente non trovato!");
}

//modifica cliente
Cliente Cliente_NEW = new Cliente("pippo", "franco", "mdxrgfzht", 1000);
banca.ModificaCliente(Cliente_NEW);

DateOnly inizio = DateOnly.FromDateTime(DateTime.Now);
DateOnly fine = inizio.AddMonths(24);

//aggiungi prestito
Prestito prestito_1 = new Prestito(123, 900, 100, inizio, fine, Cliente_NEW);
banca.AggiungiPrestito(prestito_1);

//ricerca prestiti
List<Prestito> prestiti = banca.RicercaPrestito("mdxrgfzht");
foreach (Prestito prestito in prestiti)
{
    Console.WriteLine(" Prestito: totale{0}", prestito.Ammontare);
    Console.WriteLine(" Prestito: rata da {0}", prestito.ValoreRata);
}






