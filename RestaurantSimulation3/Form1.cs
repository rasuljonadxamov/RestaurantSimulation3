using System;
using System.Windows.Forms;

namespace RestaurantSimulation3
{
    public partial class Form1 : Form
    {
        private readonly Cook _cook = new Cook();
        private readonly Server _server;

        public Form1()
        {
            InitializeComponent();
            _server = new Server(_cook);

            cmbDrink.Items.AddRange(new[] { "Tea", "CocaCola", "Pepsi", "NoDrink" });
            cmbDrink.SelectedIndex = 0;
            eggQuality.ReadOnly = true;
        }

        private void btnReceive_Click(object sender, EventArgs e)
        {
            var customerName = txtCustomerName.Text.Trim();
            int chicken = (int)nudChicken.Value;
            int eggs    = (int)nudEgg.Value;
            string drink = cmbDrink.SelectedItem.ToString();

            if (string.IsNullOrWhiteSpace(customerName))
            {
                ShowWarning("Please enter a customer name.");
                return;
            }

            if (chicken == 0 && eggs == 0)
            {
                ShowWarning("Please select at least one food item.");
                return;
            }

            int? quality = _server.ReceiveRequest(customerName, chicken, eggs, drink);
            eggQuality.Text = quality.HasValue ? quality.Value.ToString() : string.Empty;

            MessageBox.Show($"Order received from \"{customerName}\".",
                "Order Received", MessageBoxButtons.OK, MessageBoxIcon.Information);

            ResetInputs();
        }

        private async void btnSend_Click(object sender, EventArgs e)
        {
            btnSend.Enabled = false;
            txtResults.Text = "Preparing orders… please wait.";

            try
            {
                await _server.SendToCookAsync();
                txtResults.Text = _server.Serve();
            }
            catch (Exception ex)
            {
                ShowWarning($"An error occurred: {ex.Message}");
                txtResults.Text = string.Empty;
            }
            finally
            {
                btnSend.Enabled = true;
            }
        }

        private void ResetInputs()
        {
            nudChicken.Value = 0;
            nudEgg.Value = 0;
            txtCustomerName.Clear();
            cmbDrink.SelectedIndex = 0;
        }

        private void ShowWarning(string message) =>
            MessageBox.Show(message, "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
}
