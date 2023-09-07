namespace Pretpark;

public readonly struct Coordinaat
{
    public readonly int x;
    public readonly int y;

    public Coordinaat(int x, int y){
        this.x = x;
        this.y = y;
    }

    public static Coordinaat operator +(Coordinaat a, Coordinaat b)
    {
        return new Coordinaat((a.x+b.x),(a.y+b.y));
    }
}