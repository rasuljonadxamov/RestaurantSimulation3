public class Server
{
    private TableRequests table = new TableRequests();
    private int customerIndex = 0;
    private Cook cook;

    public Server(Cook cook) => this.cook = cook;

    public void ReceiveRequest(int chQty, int egQty, string drinkName)
    {
        if (chQty > 0) table.Add(customerIndex, new Chicken(chQty));
        if (egQty > 0) table.Add(customerIndex, new Egg(egQty));
        if (drinkName != "NoDrink") table.Add(customerIndex, new Drink(drinkName));
        customerIndex++;
    }

    public void SendToCook() => cook.Process(table);

    public string Serve()
    {
        string result = "";
        for (int i = 0; i < customerIndex; i++)
        {
            int ch = 0, eg = 0;
            string dr = "No Drink";
            IMenuItem[] items = table[i];

            foreach (var item in items)
            {
                if (item is Chicken c) ch += c.Quantity;
                else if (item is Egg e) eg += e.Quantity;
                else if (item is Drink d) dr = d.ToString();
            }
            result += $"Customer {i}: {ch} chicken, {eg} egg, {dr}\r\n";
        }
        return result;
    }

    public string ServeAndGetResults()
    {
        SendToCook();
        return Serve();
    }
}