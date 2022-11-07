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
else
{

    Console.WriteLine("Ammontare del prestito: ");
    int ammontarePrestito = Convert.ToInt32(Console.ReadLine());
    Prestito nuovoPrestito = new Prestito(0, ammontarePrestito, 0, new DateOnly(), esistente);

    banca.AggiungiPrestito(nuovoPrestito);
}

