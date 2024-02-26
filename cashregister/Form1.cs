using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace cashregister
{
    public partial class Storefront : Form
    {
        double stickPrice = 3.20;
        double shutterPrice = 6.75;
        double drinkPrice = 14.50;
        double taxRate = 0.13;
        int stickAmount;
        int shutterAmount;
        int drinkAmount;
        double subtotal;
        double taxAmount;
        double total;
        double given;
        double change;
        public Storefront()
        {
            InitializeComponent();
        }

        private void totalButton_Click(object sender, EventArgs e)
        {
            try
            {
                stickAmount = Convert.ToInt32(stickInput.Text);
                shutterAmount = Convert.ToInt32(shutterInput.Text);
                drinkAmount = Convert.ToInt32(drinkInput.Text);

                if (stickAmount == 9)
                {
                    if (shutterAmount == 1)
                    {
                        if (drinkAmount == 1)
                        {
                            this.BackColor = Color.Indigo;
                            nameLabel.Text = "Sorry we're closed";
                        }
                    }
                }
                else
                {

                    subtotal = stickAmount * stickPrice + shutterAmount * shutterPrice + drinkAmount * drinkPrice;
                    taxAmount = subtotal * taxRate;
                    total = subtotal + taxAmount;

                    subtotalLabel.Text = $"sub total: {subtotal.ToString("C")}";
                    taxLabel.Text = $"taxes: {taxAmount.ToString("C")}";
                    totalLabel.Text = $"total: {total.ToString("C")}";
                }
            }
            catch
            {
                subtotalLabel.Text = "sub total:";
                taxLabel.Text = "taxes:";
                totalLabel.Text = "total:";
                receiptLabel.Text = "Hang on, try that again";
            }

        }

        private void changeButton_Click(object sender, EventArgs e)
        {
          

                given = Convert.ToInt32(givenInput.Text);

                change = given - total;

                if (change < 0)
                {
                    receiptLabel.Text = "woah now, that's not enough";

                }
                else
                {
                    changeLabel.Text += $"\n{change.ToString("C")}";
                    Refresh();
                    Thread.Sleep(300);
                    printButton.Visible = true;
                    printButton.Enabled = true;
                }
                

        }

        private void printButton_Click(object sender, EventArgs e)
        {
            SoundPlayer receiptPlayer = new SoundPlayer(Properties.Resources.receiptSound);
            receiptPlayer.Play();
            receiptLabel.Text = "SPH";
            Refresh();
            Thread.Sleep(800);
            receiptLabel.Text += $"\n\n{stickAmount} glowsticks â {stickPrice.ToString("C")}";
            Refresh();
            Thread.Sleep(800);
            receiptLabel.Text += $"\n{shutterAmount} pairs of glasses â {shutterPrice.ToString("C")}";
            Refresh();
            Thread.Sleep(800);
            receiptLabel.Text += $"\n{drinkAmount} cups of drink â {drinkPrice.ToString("C")}";
            Refresh();
            Thread.Sleep(1200);
            receiptLabel.Text += $"\n\nSubtotal: {subtotal.ToString("C")}";
            Refresh();
            Thread.Sleep(800);
            receiptLabel.Text += $"\nTax: {taxAmount.ToString("C")} â {taxRate}";
            Refresh();
            Thread.Sleep(800);
            receiptLabel.Text += $"\nTotal: {total.ToString("C")}";
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            receiptLabel.Text = "";
            givenInput.Text = "";
            taxLabel.Text = "taxes:";
            subtotalLabel.Text = "sub total:";
            totalLabel.Text = "total:";
            stickInput.Text = "0";
            shutterInput.Text = "0";
            drinkInput.Text = "0";
            changeLabel.Text = "";

        }
    }
}
