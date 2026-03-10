public class Chicken : CookedFood
{
    public Chicken(int quantity) : base(quantity) { }

    public override void Obtain() { }
    public override void Serve() { }

    public override void Cook()
    {
        for (int i = 0; i < Quantity; i++)
            CutUp();
    }

    private void CutUp() { }
}
