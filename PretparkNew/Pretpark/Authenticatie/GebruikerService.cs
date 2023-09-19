namespace Pretpark;

public class GebruikerService
{
    private Gebruiker inlogger;
    EmailService emailer = new EmailService();
    GebruikerContext gebruiker = new GebruikerContext();
    public Gebruiker Registreer (string email, string wachtwoord){
        gebruiker.NieuweGebruiker(email, wachtwoord);
        emailer.Email("Welkom nieuwe gebruiker van het pretpark.", email);
        return gebruiker.GetGebruiker(gebruiker.AantalGebruikers() - 1);
    }

    public bool Login (string email, string wachtwoord){
        foreach (Gebruiker account in gebruiker.GetAlleGebruikers())
        {
            if (account.Email.Equals(email) && account.Wachtwoord.Equals(wachtwoord) && account.Geverifieerd() == true)
            {
                return true;
            }
        }
        return false;
    }

    public bool Verifieer (string email, string token){
        if (DateTime.Now < inlogger.Token.verloopDatum && token.Equals("token"))
        {
            inlogger.Token = null;
            return true;
        }
        return false;
    }
}