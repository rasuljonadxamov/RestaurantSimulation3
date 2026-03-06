public class Drink : MenuItem
{
    private string name;
    public Drink(string name) : base(1) { this.name = name; }
    public override string ToString() => name;
    public override void Obtain() { }
    public override void Serve() { }
}
