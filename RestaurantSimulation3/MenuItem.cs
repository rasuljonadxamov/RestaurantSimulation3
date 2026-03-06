// --- 2. Menu Item Class Hierarchy ---

public abstract class MenuItem : IMenuItem
{
    public int Quantity { get; protected set; }

    public MenuItem(int quantity) => Quantity = quantity;

    public abstract void Obtain();
    public abstract void Serve();
}

public abstract class CookedFood : MenuItem, ICookable
{
    public CookedFood(int quantity) : base(quantity) { }
    public abstract void Cook();
}