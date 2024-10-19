using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization.Metadata;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ShopingCart
{
    public partial class listform : Form
    {
        public List<Item> items;
        public cart Cart;
        public listform(cart cart)
        {
            InitializeComponent();
            Cart = cart;
            loaditems();
        }

        public void loaditems()
        {
            items = new List<Item>
            {
                new Item(1 , "Pencil" , 90),
                new Item(2 , "Rubber" , 100),
                new Item(3 , "Pen" , 150),
                new Item(4 , "Clip Board" , 800),
                new Item(5 , "Ink" , 200),
                new Item(6 , "Shapner" , 40),
                new Item(7 , "Remover" , 50),
                new Item(8 , "XYZ" , 90)
            };
        }
        private void addtocart_Click(object sender, EventArgs e)
        {
            if (sender is Button button && button.Tag is Item item)
            {
                string input = Microsoft.VisualBasic.Interaction.InputBox(
                    $"Enter quantity for {item.Name}:",
                    "Quantity",
                    "1");

                if (int.TryParse(input, out int quantity) && quantity > 0)
                {
                    item.quantity = quantity;
                    Cart.AddItem(item);
                    MessageBox.Show($"{quantity} {item.Name}(s) added to cart!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tptext.Text = Cart.CalculateTotal().ToString();
                    item.quantity -= quantity;
                }
                else
                {
                    MessageBox.Show("Please enter a valid quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void backbutton_Click(object sender, EventArgs e)
        {

        }

        private void listform_Shown(object sender, EventArgs e)
        {
            int sety = 40;
            for (int i = 0; i < items.Count; i++)
            {
                // Declaration
                itemquantity = new Label();
                itembutton = new Button();
                itemname = new Label();
                pricees = new Label();
                int quantity = items[i].quantity;
                // Item name
                itemname.Text = items[i].Name + ": ";
                itemname.Name = "Itemname" + i;
                itemname.Size = new Size(150, 30);
                itemname.Location = new Point(10, sety);
                // pricees
                pricees.Text = items[i].Price.ToString();
                pricees.Name = "Itemprice" + i;
                pricees.Size = new Size(150, 30);
                pricees.Location = new Point(155, sety);
                // item Quantity
                itemquantity.Name = "ItemQuantity" + i;
                itemquantity.Size = new Size(150, 30);
                itemquantity.Location = new Point(300 , sety);
                itemquantity.Text = items[i].quantity.ToString();
                // Item Button
                itembutton.Location = new Point(500, sety);
                itembutton.Name = "itembutton" + i;
                itembutton.Size = new Size(100, 30);
                itembutton.Text = "Add to cart";
                itembutton.UseVisualStyleBackColor = true;
                // Tag
                itembutton.Tag = items[i];
                itemname.Tag = items[i];
                pricees.Tag = items[i];
                itemquantity.Tag = items[i];
                itembutton.Click += addtocart_Click;
                // Control Layout
                layoutpanel.Controls.Add(itembutton);
                layoutpanel.Controls.Add(itemname);
                layoutpanel.Controls.Add(pricees);
                layoutpanel.Controls.Add(itemquantity);
                sety += 40;
            }
        }
    }
}
