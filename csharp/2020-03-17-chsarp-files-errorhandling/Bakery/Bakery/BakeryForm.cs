using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bakery
{
    public partial class BakeryForm : Form
    {
        // Properties
        private Bakery bakery;
        private Sandwich sandwich;

        public BakeryForm()
        {
            InitializeComponent();           
            LoadComponent(); // Load the comboboxes
            this.bakery = new Bakery(); // Initialization
        }
        
        // Helper methods
        private void LoadComponent()
        {
            // Ingredients
            foreach (var item in Enum.GetValues(typeof(IngredientType)))
            {
                this.cbIngredients.Items.Add(item);
            }

            // BreadTypes
            foreach (var item in Enum.GetValues(typeof(BreadType)))
            {
                this.cbBreadTypes.Items.Add(item);
            }
        }

        // Validation removeWhiteSpaces
        private string removeWhiteSpaces(string text)
        {
            return Regex.Replace(text, @"\s+|\t|\n|\r", String.Empty);
        }

        // Update information to the ListBox
        private void UpdateInformation()
        {
            this.lbSandwiches.Items.Clear();

            foreach (var item in this.bakery.Sandwiches)
            {
                this.lbSandwiches.Items.Add(item.NameAndPrice);
            }
        }

        ///
        /// This methods adds a new sandwich. The name of the sandwich must be unique. 
        /// When this is not the case, the method should return false and the sandwich
        /// will not be added. Otherwhises, the method return true and the sandwich is
        /// added to the list of sandwiches.
        /// 
        private void btAddBread_Click(object sender, EventArgs e)
        {
            try
            {
                string name;
                if (string.IsNullOrWhiteSpace(removeWhiteSpaces(name = this.tbName.Text.ToString())))
                {
                    MessageBox.Show("Change the Name field");
                }
                else
                {
                    if (this.cbBreadTypes.SelectedIndex > -1)
                    {
                        BreadType breadType = (BreadType)this.cbBreadTypes.SelectedItem;
                        Bread bread = new Bread("description", breadType, 2.00);

                        this.sandwich = new Sandwich(name, bread);
                        MessageBox.Show("You successfully added a sandwitch!");
                                            }
                    else
                    {
                        MessageBox.Show("Please, select from the combobox!");
                    }
                }
            }
            catch (Exception)
            {
                System.Console.WriteLine("Input sandwitch");
                throw;
            }
        }

        private void btAddIngredient_Click(object sender, EventArgs e)
        {
            try
            {
                if(this.cbIngredients.SelectedIndex > -1) { 
                    IngredientType ingredientType = (IngredientType)this.cbIngredients.SelectedItem;
                    Ingredient ingredient = new Ingredient("description", ingredientType, 1.00);

                    if (this.sandwich.AddIngredient(ingredient, true))
                    {
                        MessageBox.Show("You successfully added an ingredient!");
                    }
                    else
                    {
                        MessageBox.Show("Choose something that you haven't added!");
                    }

                }
                else
                {
                    MessageBox.Show("Please, select from the combobox!");
                }
            }
            catch (Exception)
            {
                System.Console.WriteLine("Input ingredient");
                throw;
            }
        }

        
        private void btSandwichFinished_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.bakery.AddSandwich(this.sandwich))
                {
                    UpdateInformation();
                }
                else
                {
                    MessageBox.Show("Sandwich already exists!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                System.Console.WriteLine("Input sandwich");
                throw;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if(this.lbSandwiches.SelectedIndex > -1)
            {
                this.lblSandwichNameAndPrice.Text = this.lbSandwiches.SelectedItem.ToString();
                string str = "";
                foreach( var item in this.bakery.Sandwiches[this.lbSandwiches.SelectedIndex].Ingredients)
                {
                    str += item.IngredientType + ", ";
                }

                if(this.bakery.Sandwiches[this.lbSandwiches.SelectedIndex].Ingredients.Count > 0)
                    this.lblIngredients.Text = str.Substring(0, str.Length - 2);
            }
        }

        ///
        /// The next method we are going to implement is “CreatePriceList”,
        /// in the Bakery class. All sandwiches from the bakery will be saved 
        /// into a textfile. Use the property “NameAndPrice” from the Sandwich class,
        /// make sure the name of the sandwich and the price are seperated with a “ – “.
        /// For example: “Sandwich Deluxe – 5,50”. 
        /// 
        private async void btCreatePriceList_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter="Text Documents|*txt", ValidateNames = true})
            {
                if(saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName))
                    {
                        string text = "";
                        foreach (var sandw in this.bakery.Sandwiches)
                        {
                            text += sandw.NameAndPrice + "@";

                            string str = "";
                            foreach (var ingr in sandw.Ingredients)
                            {
                                str += ingr.IngredientType + ", ";
                            }

                            if (sandw.Ingredients.Count > 0)
                                text += str.Substring(0, str.Length - 2) + "@@";
                        }

                        text = text.Replace("@", System.Environment.NewLine);

                        await streamWriter.WriteLineAsync(this.lbSandwiches.GetItemText(text));
                        MessageBox.Show("You have been successfully saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        /// 
        /// The method “SaveSandwiches” will save all sandwiches in
        /// a binary file named “sandwiches.bin”. Implement this method. 
        /// 

        const string fileName = "sandwiches.bin";

        private void btSaveSandwiches_Click(object sender, EventArgs e)
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.Create)))
            {
                foreach (var sandw in this.bakery.Sandwiches)
                {
                     writer.Write(sandw.NameAndPrice + System.Environment.NewLine);

                    string str = "";
                    foreach (var ingr in sandw.Ingredients)
                    {
                        str += ingr.IngredientType + ", ";
                    }

                    if (sandw.Ingredients.Count > 0)
                        writer.Write(str.Substring(0, str.Length - 2) + System.Environment.NewLine);
                }

                MessageBox.Show("You have been successfully saved.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// 
        /// The method “LoadSandwiches” will load all sandwiches from the binary file
        /// named “sandwiches.bin”, only if this file exists of course.  
        ///
        private void btLoadSandwiches_Click(object sender, EventArgs e)
        {
            if (File.Exists(fileName))
            {
                using (BinaryReader reader = new BinaryReader(File.Open(fileName, FileMode.Open)))
                {
                    string text = "";

                    while (reader.BaseStream.Position != reader.BaseStream.Length)
                    {
                        text += reader.ReadString();
                    }

                    MessageBox.Show(text);
                }
            }
        }
    }
}
