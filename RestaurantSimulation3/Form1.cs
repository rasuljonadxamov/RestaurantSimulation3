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
        private int customerCount = 0;

        public Form1()
        {
            InitializeComponent();
            cook = new Cook();
            server = new Server(cook);

            cmbDrink.Items.Clear();
            cmbDrink.Items.AddRange(new[] { "Tea", "CocaCola", "Pepsi", "NoDrink" });
            cmbDrink.SelectedIndex = 0;
        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            int ch = (int)nudChicken.Value;
            int eg = (int)nudEgg.Value;

            string drinkName = cmbDrink.SelectedItem.ToString();

            server.ReceiveRequest(ch, eg, drinkName);

            customerCount++;
            MessageBox.Show($"Request received from customer {customerCount - 1}");

            nudChicken.Value = 0;
            nudEgg.Value = 0;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            server.SendToCook();
            MessageBox.Show("All requests sent to Cook and prepared via Order objects.");
        }

        private void btnServe_Click_1(object sender, EventArgs e)
        {
            txtResults.Text = server.ServeAndGetResults();
        }


    }
}
