

using System;

public class TableRequests
{
    private IMenuItem[,] requests = new IMenuItem[8, 10];
    private int[] counts = new int[8];

    public void Add(int customer, IMenuItem item)
    {
        if (customer < 8 && counts[customer] < 10)
        {
            requests[customer, counts[customer]++] = item;
        }
    }

    public IMenuItem[] this[int customer]
    {
        get
        {
            IMenuItem[] customerItems = new IMenuItem[counts[customer]];
            for (int i = 0; i < counts[customer]; i++)
                customerItems[i] = requests[customer, i];
            return customerItems;
        }
    }

    public IMenuItem[] this[Type type]
    {
        get
        {
            int total = 0;
            for (int i = 0; i < 8; i++)
                for (int j = 0; j < counts[i]; j++)
                    if (requests[i, j].GetType() == type) total++;

            IMenuItem[] foundItems = new IMenuItem[total];
            int p = 0;
            for (int i = 0; i < 8; i++)
                for (int j = 0; j < counts[i]; j++)
                    if (requests[i, j].GetType() == type) foundItems[p++] = requests[i, j];
            return foundItems;
        }
    }
}
