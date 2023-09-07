namespace Pretpark;

public class Attractie : KaartItem
{
    private int? _minimaleLengte;
    private int _angsteLevel;
    private string _naam = "";

    public Attractie(Kaart k, Coordinaat c) : base(k, c) { }
    public override char Karakter {get;} = 'A';
    public int? MinimaleLengte {get; set;}
    public int AngsteLevel {get; set;}
    public string Naam {get; set;} = "";

}
