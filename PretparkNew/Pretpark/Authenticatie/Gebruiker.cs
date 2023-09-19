namespace Pretpark;

public class Gebruiker
{
    public int ID = 0;
    public string Wachtwoord {get; set;}
    public string Email {get; set;}

    public VerificatieToken? Token {get; set;}

    public Gebruiker (string wachtwoord, string email){
        this.Token = new VerificatieToken();
        // this.ID = GenerateID();
        this.Wachtwoord = wachtwoord;
        this.Email = email;
    }

    public bool Geverifieerd (){
        this.Token = null;
        return true;
        // if(Token == null){
        //     return true;
        // }
        // return false;
    }

    public int GenerateID(){
        return ID++;
    }
}