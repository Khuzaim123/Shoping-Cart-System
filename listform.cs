using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Text.Json.Serialization.Metadata;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace ShopingCart
{
    public partial class listform : Form
    {



        public List<Item> items = new List<Item>();
        public cart Cart;
        public List<string> li = new List<string>();
        public listform(cart cart)
        {
            Shopingcart s = new Shopingcart();
            s.Hide();
            InitializeComponent();
            Cart = cart;
            loaditems();
            layoutpanel.Visible = true;
            itempanel.Visible = false;
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
                    $"Enter quantity for {item.Name} (Available: {item.quantity}):",
                    "Quantity",
                    "1");
                if (int.TryParse(input, out int quantity) && quantity > 0)
                {
                    if (quantity <= item.quantity)
                    {
                        item.quantity -= quantity;
                        Cart.AddItem(new Item(item.Id, item.Name, item.Price) { quantity = quantity });
                        MessageBox.Show($"{quantity} {item.Name}(s) added to cart!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        tptext.Text = Cart.CalculateTotal().ToString();
                        li.Add($"{item.Name}  {quantity}");
                        itemlist.DataSource = null;
                        itemlist.DataSource = li;
                    }
                    else
                    {
                        MessageBox.Show($"Insufficient quantity. Only {item.quantity} {item.Name}(s) available.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid quantity.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            layoutpanel.Visible = true;
            itempanel.Visible = false;
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
                itemquantity.Location = new Point(300, sety);
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

        private void viewcart_Click(object sender, EventArgs e)
        {
            layoutpanel.Visible = false;
            itempanel.Visible = true;
        }

        private void delete_Click(object sender, EventArgs e)
        {
            if (itemlist.SelectedIndex != -1) 
            {
                string selectedindex = li[itemlist.SelectedIndex];
                string name = selectedindex.Split(' ')[0];
                var IN = Cart.items.FirstOrDefault(x => x.Name == name);
                if (IN != null)
                {
                    var oi = items.FirstOrDefault(i => i.Id == IN.Id);
                    if (oi != null)
                    {
                        oi.quantity = 100;
                    }
                    Cart.items.Remove(IN);
                    li.RemoveAt(itemlist.SelectedIndex);
                    itemlist.DataSource = null;
                    itemlist.DataSource = li;
                    tptext.Text = Cart.CalculateTotal().ToString();
                    MessageBox.Show($"{name} has been removed sucessfully");
                }
            }
            else
            {
                MessageBox.Show($"Enter a valid index");
            }
        }
    }
}
