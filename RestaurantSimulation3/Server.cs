using System;
using System.Collections.Generic;

public class Server
{
    private TableRequests table = new TableRequests();
    private Cook cook;

    public event EventHandler Ready;

    public Server(Cook cook) => this.cook = cook;

    public void ReceiveRequest(string customerName, int chQty, int egQty, string drinkName)
    {
        if (chQty > 0) table.Add<Chicken>(customerName, new Chicken(chQty));
        if (egQty > 0) table.Add<Egg>(customerName, new Egg(egQty));
        if (drinkName != "NoDrink") table.Add<Drink>(customerName, new Drink(drinkName));
    }

    public void SendToCook()
    {
        Ready?.Invoke(this, EventArgs.Empty);
    }

    public TableRequests GetTableRequests()
    {
        return table;
    }

    public string Serve()
    {
        string result = "";

        foreach (var customerName in table.GetCustomerNames())
        {
            int ch = 0, eg = 0;
            string dr = "No Drink";
            int? eggQuality = null;

            var customerItems = table[customerName];
            foreach (var item in customerItems)
            {
                if (item is Chicken c) ch += c.Quantity;
                else if (item is Egg e)
                {
                    eg += e.Quantity;
                    if (e.Quality.HasValue)
                        eggQuality = e.Quality;
                }
                else if (item is Drink d) dr = d.ToString();
            }

            string eggQualityStr = eggQuality.HasValue ? $", Egg Quality: {eggQuality}" : "";
            result += $"Customer {customerName}: {ch} chicken, {eg} egg, {dr}{eggQualityStr}\r\n";
        }
        return result;
    }

    public void OnProcessed(object sender, EventArgs e)
    {
        // This is the named method subscriber to Cook's Processed event
    }
}