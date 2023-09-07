namespace Pretpark;

public class GebruikerContext
{
    public List<Gebruiker> gebruikers = new List<Gebruiker>();
    public int AantalGebruikers(){
        return gebruikers.Count;
    }

    public Gebruiker GetGebruiker(int i){
        return gebruikers.ElementAt(i);
    }

    public void NieuweGebruiker(string email, string wachtwoord){
        gebruikers.Add(new Gebruiker(email, wachtwoord));
    }
    public List<Gebruiker> GetAlleGebruikers(){
        return gebruikers;
    }
}