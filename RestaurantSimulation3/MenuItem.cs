public abstract class MenuItem : IMenuItem
{
    public int Quantity { get; }

    protected MenuItem(int quantity) => Quantity = quantity;

    public abstract void Obtain();
    public abstract void Serve();
}

public abstract class CookedFood : MenuItem, ICookable
{
    protected CookedFood(int quantity) : base(quantity) { }

    public abstract void Cook();
}
