

using System;
using System.Collections.Generic;
using System.Collections;

public class TableRequests : IEnumerable<IMenuItem>
{
    private Dictionary<string, List<IMenuItem>> requests = new Dictionary<string, List<IMenuItem>>();

    public void Add<T>(string customerName, T item) where T : IMenuItem
    {
        if (!requests.ContainsKey(customerName))
            requests[customerName] = new List<IMenuItem>();
        requests[customerName].Add(item);
    }

    public List<IMenuItem> this[string customerName]
    {
        get
        {
            if (requests.ContainsKey(customerName))
                return requests[customerName];
            return new List<IMenuItem>();
        }
    }

    public List<T> Get<T>() where T : IMenuItem
    {
        List<T> foundItems = new List<T>();
        foreach (var customerList in requests.Values)
        {
            foreach (var item in customerList)
            {
                if (item is T typedItem)
                    foundItems.Add(typedItem);
            }
        }
        return foundItems;
    }

    public IEnumerable<string> GetCustomerNames()
    {
        return requests.Keys;
    }

    public IEnumerator<IMenuItem> GetEnumerator()
    {
        // First yield all drinks in the order they were added
        foreach (var customerName in requests.Keys)
        {
            foreach (var item in requests[customerName])
            {
                if (item is Drink)
                    yield return item;
            }
        }

        // Then yield all other items in the order they were added
        foreach (var customerName in requests.Keys)
        {
            foreach (var item in requests[customerName])
            {
                if (!(item is Drink))
                    yield return item;
            }
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
