using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class TableRequests : IEnumerable<IMenuItem>
{
    private readonly Dictionary<string, List<IMenuItem>> _requests =
        new Dictionary<string, List<IMenuItem>>();

    public void Add<T>(string customerName, T item) where T : IMenuItem
    {
        if (!_requests.TryGetValue(customerName, out var list))
        {
            list = new List<IMenuItem>();
            _requests[customerName] = list;
        }

        list.Add(item);
    }

    public IReadOnlyList<IMenuItem> this[string customerName] =>
        _requests.TryGetValue(customerName, out var list)
            ? list
            : (IReadOnlyList<IMenuItem>)new List<IMenuItem>();

    public IEnumerable<T> Get<T>() where T : IMenuItem =>
        _requests.Values
                 .SelectMany(items => items)
                 .OfType<T>();

    public IEnumerable<string> GetCustomerNames() => _requests.Keys;

    public IEnumerator<IMenuItem> GetEnumerator()
    {
        var all = _requests.Values.SelectMany(items => items);
        foreach (var item in all.OfType<Drink>())    yield return item;
        foreach (var item in all.Where(i => !(i is Drink))) yield return item;
    }

    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
}
