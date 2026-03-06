using RestaurantSimulation3;
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Reflection.Emit;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSimulation3
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}


//7.Form1.cs(main form – replace default code)
//Designer controls:

//nudChicken(NumericUpDown) – label "How many chicken?"
//nudEgg (NumericUpDown) – label "How many egg?"
//cmbDrink (ComboBox) – items: Tea, Coca Cola, Pepsi, No drink
//btnReceive – "Receive this request from a Customer"
//btnSend – "Send all Customer requests to the Cook"
//btnServe – "Serve prepared food to the Customers"
//txtResults (TextBox) – Multiline=true, ReadOnly = true, ScrollBars = Vertical