using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSimulation3
{
     public partial class Form1 : Form
    {
        private Cook cook;
        private Server server;

        public Form1()
        {
            InitializeComponent();
            cook = new Cook();
            server = new Server(cook);

            cook.Processed += server.OnProcessed;

            server.Ready += ((object sender, EventArgs e) => { cook.Process(server.GetTableRequests()); });

            cmbDrink.Items.Clear();
            cmbDrink.Items.AddRange(new[] { "Tea", "CocaCola", "Pepsi", "NoDrink" });
            cmbDrink.SelectedIndex = 0;
            eggQuality.ReadOnly = true;
            eggQuality.Text = "as";
        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            int ch = (int)nudChicken.Value;
            int eg = (int)nudEgg.Value;

            string drinkName = cmbDrink.SelectedItem.ToString();
            string customerName = txtCustomerName.Text;

            if (string.IsNullOrWhiteSpace(customerName))
            {
                MessageBox.Show("Please enter a customer name.");
                return;
            }

            if (ch == 0 & eg == 0)
            {
                MessageBox.Show("Please select at least one item for the order.");
                return;
            }

            server.ReceiveRequest(customerName, ch, eg, drinkName);

            MessageBox.Show($"Request received from customer {customerName}");

            nudChicken.Value = 0;
            nudEgg.Value = 0;
            txtCustomerName.Clear();
            cmbDrink.SelectedIndex = 0;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            server.SendToCook();
            MessageBox.Show("All requests sent to Cook and prepared. Enjoy with your food😊😊😊");
        }

        private void btnServe_Click_1(object sender, EventArgs e)
        {
            txtResults.Text = server.Serve();
        }


    }
}
