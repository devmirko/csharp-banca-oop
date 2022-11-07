// See https://aka.ms/new-console-template for more information
public class Prestito
{
    private int ammontarePrestito;

    //prestito in partenza dalla data specificata
    public Prestito( int iD, int ammontare, int valoreRata, DateOnly inizio, DateOnly fine, Cliente intestatario)
    {
        ID = iD;
        Ammontare = ammontare;
        ValoreRata = valoreRata;
        Inizio = inizio;
        Fine = fine;
        Intestatario = intestatario;
    }

    //un prestito in data di oggi
    public Prestito(int iD, int ammontare, int valoreRata, DateOnly fine, Cliente intestatario)
    {
        ID = iD;
        Ammontare = ammontare;
        ValoreRata = valoreRata;
        //data di oggi
        Inizio = new DateOnly();
        Fine = fine;
        Intestatario = intestatario;
    }

    public int ID { get; set; }
    public int Ammontare { get; set; }
    public int ValoreRata { get; set; }
    public DateOnly Inizio { get; set; }
    public DateOnly Fine { get; set; }
    public Cliente Intestatario { get; set; }


}