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


using System.Collections.Generic;
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

    public bool AggiungiCliente(Cliente cliente)
    {
        if (
           cliente.Nome == null || cliente.Nome == "" ||
           cliente.Cognome == null || cliente.Cognome == "" ||
           cliente.CodiceFiscale == null || cliente.CodiceFiscale == "" ||
           cliente.Stipendio < 0
           )
        {
            return false;
        }
        Cliente Cliente_esistente = RicercaCliente(cliente.CodiceFiscale);
        if (Cliente_esistente != null)
        {
            return false;
        }
            

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
        //creamo una nuova lista dove inseire i prestiti trovati
        List<Prestito> trovati = new List<Prestito>();

        //facciamo un controllo che i dati inseriti siano corretti
        if(codiceFiscale == null || codiceFiscale == "") {

            return null;
        }

        Cliente cliente = RicercaCliente(codiceFiscale);
       foreach (Prestito prestito in Prestiti)
        {
            if(prestito.Intestatario.CodiceFiscale == cliente.CodiceFiscale)
            {
                trovati.Add(prestito);
            }
        }









        return trovati;

    }
    //aggiungi prestito

    public bool AggiungiPrestito(Prestito nuovoPrestito)
    {
        Prestiti.Add(nuovoPrestito);

        return true;


    }

    //totale prestiti cliente
    public int AmmontareTotalePrestitiCliente(string codiceFiscale)
    {
        int ammontare = 0;
        //creamo una nuova lista dove inseire i prestiti trovati per un cliente
        List<Prestito> PrestitiCliente = RicercaPrestito(codiceFiscale);

        //andiamo a prendere gli elementi nella lista creata
        foreach (Prestito prestito in PrestitiCliente)
        {
            //andiamo a sommarli tra di loro
            ammontare += prestito.Ammontare;
        }

        return ammontare;



    }






}




//rate mancanti clienti

