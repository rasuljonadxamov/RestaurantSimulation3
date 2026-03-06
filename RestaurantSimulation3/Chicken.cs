public class Chicken : CookedFood
{
    public Chicken(int quantity) : base(quantity) { }

    public override void Obtain() { }

    public void CutUp() { }

    public override void Cook()
    {
        for (int i = 0; i < Quantity; i++) CutUp();
    }

    public override void Serve() { }
}