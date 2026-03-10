using System.Threading;
using System.Threading.Tasks;

public class Cook
{
    private static readonly SemaphoreSlim _semaphore = new SemaphoreSlim(2, 2);

    public async Task PrepareAsync(TableRequests table)
    {
        await _semaphore.WaitAsync();
        try
        {
            await Task.Run(() =>
            {
                Thread.Sleep(1000);
                PrepareItems(table);
            });
        }
        finally
        {
            _semaphore.Release();
        }
    }

    private static void PrepareItems(TableRequests table)
    {
        foreach (var chicken in table.Get<Chicken>())
        {
            chicken.Obtain();
            chicken.Cook();
        }

        foreach (var egg in table.Get<Egg>())
        {
            using (egg)
            {
                egg.Obtain();
                egg.Cook();
            }
        }
    }
}
