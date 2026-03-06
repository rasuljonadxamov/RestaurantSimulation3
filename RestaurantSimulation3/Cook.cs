using System;

public class Cook
{
    public void Process(TableRequests table)
    {
        IMenuItem[] chickens = table[typeof(Chicken)];
        foreach (Chicken c in chickens)
        {
            c.Obtain();
            c.Cook();
        }

        IMenuItem[] eggs = table[typeof(Egg)];
        foreach (Egg e in eggs)
        {
            try
            {
                e.Obtain();
                e.Cook();
            }
            finally
            {
                e.Dispose();
            }
        }
    }
}

