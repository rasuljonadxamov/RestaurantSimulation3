
using System;

public class Egg : CookedFood, IDisposable
{
    private int? quality;
    private static Random rand = new Random();
    private static int instanceCount = 0;

    public Egg(int quantity) : base(quantity)
    {
        instanceCount++;
        if (instanceCount % 2 == 0) quality = null;
        else quality = rand.Next(1, 101);
    }

    public int? Quality => quality;

    public override void Obtain() { }

    public void Crack()
    {
        if (quality.HasValue && quality < 25)
            throw new Exception("Rotten egg!");
    }

    public override void Cook()
    {
        for (int i = 0; i < Quantity; i++) Crack();
    }

    public override void Serve() { }

    public void Dispose()
    {
        DiscardShells();
    }

    private void DiscardShells() { }
}