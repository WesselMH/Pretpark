namespace Pretpark;

public abstract class KaartItem : Tekenbaar
{
    Coordinaat _locatie;
    Kaart kaart;

    public KaartItem(Kaart kaart, Coordinaat _locatie){
        this.kaart = kaart;
        this._locatie = _locatie;
    }
    
    public void TekenConsole(ConsoleTekener t){
        t.SchrijfOp(this._locatie, Karakter.ToString());
    }

    public Coordinaat Locatie{ get ; set; } 

    public abstract char Karakter { get; }

}