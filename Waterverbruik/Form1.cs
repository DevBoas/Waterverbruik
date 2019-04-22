using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace Waterverbruik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Decimal Tarief1Verbruik = 0.25m;
        Decimal Tarief1 = 100;
        Decimal Tarief2Verbruik = 0.38m;
        Decimal Tarief2 = 75;
        private Decimal tarief(int tarief, int waterVerbruik)
        {
            Decimal price = 0;
            if (tarief == 1)
                price = Tarief1 + (waterVerbruik * Tarief1Verbruik);
            else if (tarief == 2)
                price = Tarief2 + (waterVerbruik * Tarief2Verbruik);
            return price;
        }

        private void Bereken_Click(object sender, EventArgs e)
        {
            int waterVerbruik = 0;
            Decimal price = 0;

            if (Int32.TryParse(TextBoxWaterverbruik.Text, out waterVerbruik))
            {
                if (Radio1.Checked)
                    price = tarief(1, waterVerbruik);
                else if (Radio2.Checked)
                    price = tarief(2, waterVerbruik);
                else if (Radio0.Checked)
                    price = tarief(1, waterVerbruik) < tarief(2, waterVerbruik) ? tarief(1, waterVerbruik) : tarief(2, waterVerbruik);
            }
            Output.Text = "Jouw kosten zijn €" + price.ToString("0.##");
        }
    }
}
