namespace Pretpark;

public class Kaart
{
    public List<KaartItem> kaartItems = new List<KaartItem>();
    public List<Pad> paden = new List<Pad>();
    public readonly int Breedte;
    public readonly int Hoogte;

    public Kaart(int breedte, int hoogte){
        this.Breedte = breedte;
        this.Hoogte = hoogte;
    }

    public void Teken(Tekener t){
        foreach (var items in kaartItems)
        {
            t.Teken(items);
        }
        foreach (var pad in paden)
        {
            t.Teken(pad);
        }
    }

    public void VoegItemToe (KaartItem item){
        kaartItems.Add(item);
    }

    public void VoegPadToe (Pad pad){
        paden.Add(pad);
    }
}