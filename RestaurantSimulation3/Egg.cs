using System;

public class Egg : CookedFood, IDisposable
{
    private static readonly Random _rand = new Random();

    public int Quality { get; } = _rand.Next(50, 101);

    public Egg(int quantity) : base(quantity) { }

    public override void Obtain() { }
    public override void Serve() { }

    public override void Cook()
    {
        for (int i = 0; i < Quantity; i++)
            Crack();
    }

    public void Dispose() => DiscardShells();

    private void Crack()
    {
        if (Quality < 50)
            throw new InvalidOperationException("Rotten egg!");
    }

    private void DiscardShells() { }
}
