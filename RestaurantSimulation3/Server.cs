using System.Linq;
using System.Threading;
using System.Threading.Tasks;

public class Server
{
    private readonly object _lock = new object();
    private readonly TableRequests _table = new TableRequests();
    private readonly Cook _cook;

    public Server(Cook cook) => _cook = cook;

    public int? ReceiveRequest(string customerName, int chickenQty, int eggQty, string drinkName)
    {
        int? eggQuality = null;

        lock (_lock)
        {
            if (chickenQty > 0)
                _table.Add<Chicken>(customerName, new Chicken(chickenQty));

            if (eggQty > 0)
            {
                var egg = new Egg(eggQty);
                eggQuality = egg.Quality;
                _table.Add<Egg>(customerName, egg);
            }

            if (drinkName != "NoDrink")
                _table.Add<Drink>(customerName, new Drink(drinkName));
        }

        return eggQuality;
    }

    public Task SendToCookAsync()
    {
        TableRequests snapshot;
        lock (_lock) { snapshot = _table; }

        return _cook.PrepareAsync(snapshot).ContinueWith(_ =>
        {
            lock (_lock) { Thread.Sleep(300); }
        });
    }

    public string Serve()
    {
        lock (_lock)
        {
            return string.Join("\r\n",
                _table.GetCustomerNames()
                      .OrderBy(name => name)
                      .Select(BuildSummary));
        }
    }

    private string BuildSummary(string customerName)
    {
        int chicken = 0, eggs = 0, drinks = 0;

        foreach (var item in _table[customerName])
        {
            if      (item is Chicken c) chicken += c.Quantity;
            else if (item is Egg e)     eggs    += e.Quantity;
            else if (item is Drink)     drinks++;
        }

        return $"{customerName} ordered {drinks} drink, {eggs} egg and {chicken} chicken";
    }
}
