public class Drink : MenuItem
{
    private readonly string _name;

    public Drink(string name) : base(1) => _name = name;

    public override void Obtain() { }
    public override void Serve() { }

    public override string ToString() => _name;
}
