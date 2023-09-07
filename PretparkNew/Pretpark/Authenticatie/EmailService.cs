namespace Pretpark;

public class EmailService
{
    public GebruikerService service = new GebruikerService();
    private Gebruiker gebruiker;
    public bool Email(string tekst, string naarAdres){
        Console.WriteLine(tekst + " "+ naarAdres);
        if (service.Verifieer(naarAdres, gebruiker.Token.token))
        {
            return true;
        }
        return false;
    }
}