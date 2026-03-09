using System;
using System.Collections.Generic;

public class Cook
{
    public event EventHandler Processed;

    public void Process(TableRequests table)
    {
        List<Chicken> chickens = table.Get<Chicken>();
        foreach (Chicken c in chickens)
        {
            c.Obtain();
            c.Cook();
        }

        List<Egg> eggs = table.Get<Egg>();
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

        // Raise the Processed event as a lambda expression
        Processed?.Invoke(this, EventArgs.Empty);
    }
}