
namespace Pretpark;

public class VerificatieToken
{
    public string token {get; set;}
    public DateTime verloopDatum {get; set;}

    public VerificatieToken (){
        this.token = "token";
        this.verloopDatum = DateTime.Now.AddDays(3);
    }
}