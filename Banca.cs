// See https://aka.ms/new-console-template for more information
//Sviluppare un’applicazione orientata agli oggetti per gestire i prestiti che una banca concede ai propri clienti.
//La banca è caratterizzata da
//un nome
//un insieme di clienti (una lista)
//un insieme di prestiti concessi ai clienti (una lista)
//I clienti sono caratterizzati da
//nome,
//cognome,
//codice fiscale
//stipendio
//I prestiti sono caratterizzati da
//ID
//intestatario del prestito (il cliente),
//un ammontare,
//una rata,
//una data inizio,
//una data fine.
//Per la banca deve essere possibile:
//aggiungere, modificare e ricercare un cliente.
//aggiungere un prestito.
//effettuare delle ricerche sui prestiti concessi ad un cliente dato il codice fiscale
//sapere, dato il codice fiscale di un cliente, l’ammontare totale dei prestiti concessi.
//sapere, dato il codice fiscale di un cliente, quante rate rimangono da pagare alla data odierna.
//Per i clienti e per i prestiti si vuole stampare un prospetto riassuntivo con tutti i dati che li caratterizzano in un formato di tipo stringa a piacere.
//Bonus:
//visualizzare per ogni cliente, la situazione dei suoi prestiti in formato tabellare.


using System.Security.AccessControl;

public class Banca
{
    public string Nome { get; set; }

    List<Cliente> Clienti { get; set; }
    List<Prestito> Prestiti { get; set; }

    public Banca(string nome)
    {
        Nome = nome;
        Clienti = new List<Cliente>();
        Prestiti = new List<Prestito>();
    }

    //Aggiungi cliente

    public bool AggiungiCliente(string nome, string cognome, string codiceFiscale, int stipendio)
    {
        if (
           nome == null || nome == "" ||
           cognome == null || cognome == "" ||
           codiceFiscale == null || codiceFiscale == "" ||
           stipendio < 0
           )
        {
            return false;
        }

        Cliente cliente = new Cliente(nome, cognome, codiceFiscale, stipendio);
        Clienti.Add(cliente);

        return true;



    }

    //ricerca cliente
    public Cliente RicercaCliente(string codiceFiscale)
    {
        foreach (Cliente cliente in Clienti)
        {
            if (cliente.CodiceFiscale == codiceFiscale)
                return cliente;
        }
        return null;

    }

    //modifica cliente
    public bool ModificaCliente(Cliente clienteMod)
    {
        Cliente cliente = RicercaCliente(clienteMod.CodiceFiscale);
        if(cliente == null)
        {
            return false;
        }
        if(clienteMod.Nome != "")
        {
            cliente.Nome = clienteMod.Nome;
        }
        if (clienteMod.Cognome != "")
        {
            cliente.Cognome = clienteMod.Cognome;

        }
        if (clienteMod.Stipendio > 0)
        {
            cliente.Stipendio = clienteMod.Stipendio;

        }


        return true;

    }


    ////ricerca prestito
    public List<Prestito> RicercaPrestito(string codiceFiscale)
    {
        List<Prestito> trovati = new List<Prestito>();

        if(codiceFiscale == null || codiceFiscale == "") {

            return null;
        }







        return trovati;

    }
    //aggiungi prestito

    public bool AggiungiPrestito(Prestito nuovoPrestito)
    {
        Prestiti.Add(nuovoPrestito);

        return true;


    }






}



//ricerca prestito
//totale prestiti cliente
//rate mancanti clienti

