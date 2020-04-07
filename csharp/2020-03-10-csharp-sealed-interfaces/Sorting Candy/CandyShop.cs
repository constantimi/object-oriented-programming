using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sorting_Candy
{
    public partial class CandyShop : Form
    {
        private List<Candy> candies;
        public CandyShop()
        {
            // TODO: display the unsorted Candy.
            InitializeComponent();
            string[] candyNames = { "Mars", "Gummi bear", "Lollipop", "Jelly beans", "Toblerone", "Liquorice", "Peppermints", "Chewygum", "Snickers" };
            double[] prices = { 1, 0.5, 0.2, 1, 1.5, 0.8, 0.8, 1.2, 1 };
            candies = new List<Candy>();
            for (int i = 0; i < candyNames.Length; i++)
            {
                Candy candy = new Candy(candyNames[i], prices[i]);
                candies.Add(candy);
            }
            showInfo();
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            // TODO: Sort "candies", and display the sorted list in "lbCandy"
            candies.Sort();
            showInfo();

        }

        private void showInfo()
        {
            this.lbCandy.Items.Clear();

            foreach (Candy c in this.candies)
            {
                this.lbCandy.Items.Add(c.GetInfo());
            }
        }
    }
}
