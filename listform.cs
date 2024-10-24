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
using System.Drawing;
using Microsoft.VisualBasic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using System.Security.Cryptography;

namespace ShopingCart
{
    public partial class listform : Form
    {


        public System.Windows.Forms.Timer cartex;
        public int limit = 15;
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
            checkpanel.Visible = false;
            add.Visible = false;
            Dissal.Visible = false;
            tpad.Visible = false;
            Tax.Visible = false;
            sales.Visible = false;
            Dis.Visible = false;
            Discount.Visible = false;
            remove.Visible = false;
            Out.Visible = false;
            recommended();
            //this.Shown += listshown();

            cartex = new System.Windows.Forms.Timer();
            cartex.Interval = 1000;
            cartex.Tick += cartex_Tick;
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
            checkpanel.Visible = false;
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
                //itembutton.Image = Image.FromFile("D:\\Programing\\C sharp\\Repos\\ShopingCart\\Shoping-Cart-System\\pictures\\cart.jpg");
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
            checkpanel.Visible = false;
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

        private void update_Click(object sender, EventArgs e)
        {
            add.Visible = true;
            remove.Visible = true;
        }

        private void add_Click(object sender, EventArgs e)
        {
            if (itemlist.SelectedIndex != -1)
            {
                string selectedindex = li[itemlist.SelectedIndex];
                string name = selectedindex.Split(' ')[0];
                string input = null;
                var IN = Cart.items.FirstOrDefault(x => x.Name == name);
                if (IN != null)
                {
                    var oi = items.FirstOrDefault(i => i.Id == IN.Id);
                    if (oi != null)
                    {
                        input = Microsoft.VisualBasic.Interaction.InputBox($"How much quantity that you want to add for {IN.Name}. Avalaible Quantity {oi.quantity}:", "", "1");
                    }
                    if (int.TryParse(input, out int quantity) && quantity <= oi.quantity)
                    {
                        if (quantity <= oi.quantity)
                        {
                            IN.quantity += quantity;
                            oi.quantity -= quantity;
                            tptext.Text = Cart.CalculateTotal().ToString();
                            li.Add($"{oi.Name}  {IN.quantity}");
                            li.RemoveAt(itemlist.SelectedIndex);
                            itemlist.DataSource = null;
                            itemlist.DataSource = li;

                        }
                        else
                        {
                            MessageBox.Show("Enter valid quantity");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Enter the valid input");
                    }
                }
                else
                {
                    MessageBox.Show($"Enter a valid index");
                }
                add.Visible = false;
                remove.Visible = false;
            }

        }
        private void remove_Click(object sender, EventArgs e)
        {
            if (itemlist.SelectedIndex != -1)
            {
                string selectedindex = li[itemlist.SelectedIndex];
                string name = selectedindex.Split(' ')[0];
                string input = null;
                var IN = Cart.items.FirstOrDefault(x => x.Name == name);
                if (IN != null)
                {
                    var oi = items.FirstOrDefault(i => i.Id == IN.Id);
                    if (oi != null)
                    {
                        input = Microsoft.VisualBasic.Interaction.InputBox($"How much quantity that you want to remove for {IN.Name}. Avalaible Quantity {oi.quantity}:", "", "1");
                    }
                    if (int.TryParse(input, out int quantity) && quantity <= IN.quantity)
                    {
                        if (quantity <= oi.quantity)
                        {
                            IN.quantity -= quantity;
                            oi.quantity += quantity;
                            tptext.Text = Cart.CalculateTotal().ToString();
                            li.Add($"{oi.Name}  {IN.quantity}");
                            li.RemoveAt(itemlist.SelectedIndex);
                            itemlist.DataSource = null;
                            itemlist.DataSource = li;

                        }
                        else
                        {
                            MessageBox.Show("Enter valid quantity");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Enter the valid input");
                    }
                }
                else
                {
                    MessageBox.Show($"Enter a valid index");
                }
                add.Visible = false;
                remove.Visible = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cash_Click(object sender, EventArgs e)
        {
            Dissal.Visible = true;
            tpad.Visible = true;
            Tax.Visible = true;
            sales.Visible = true;
            Dis.Visible = true;
            Discount.Visible = true;
            Out.Visible = true;
            decimal st = 7.5m;
            decimal d = 0;
            decimal total = Cart.CalculateTotal() + ((st / 100) * Cart.CalculateTotal());
            if (Cart.CalculateTotal() <= 1000)
            {
                if (Cart.CalculateTotal() >= 800)
                {
                    d = 10;
                }
                total = total - ((d / 100) * total);
            }
            else if (Cart.CalculateTotal() > 1000 && Cart.CalculateTotal() <= 5000)
            {
                d = 25;
                total = total - ((d / 100) * total);
            }
            else if (Cart.CalculateTotal() > 5000 && Cart.CalculateTotal() <= 15000)
            {
                d = 35;
                total = total - ((d / 100) * total);
            }
            else
            {
                d = 50;
                total = total - ((d / 100) * total);
            }
            Discount.Text = d.ToString();
            Tax.Text = st.ToString();
            Dissal.Text = total.ToString();
        }

        private void checkout_Click(object sender, EventArgs e)
        {
            if (Cart.CalculateTotal() > 0)
            {
                layoutpanel.Visible = false;
                itempanel.Visible = false;
                checkpanel.Visible = true;
                cartex.Start();
            }
            else
            {
                MessageBox.Show("First buy some Items");
            }
        }

        private void card_Click(object sender, EventArgs e)
        {
            Dissal.Visible = true;
            tpad.Visible = true;
            Tax.Visible = true;
            sales.Visible = true;
            Dis.Visible = true;
            Discount.Visible = true;
            Out.Visible = true;
            decimal st = 5m;
            decimal d = 0;
            decimal total = Cart.CalculateTotal() + ((st / 100) * Cart.CalculateTotal());
            if (Cart.CalculateTotal() <= 1000)
            {
                if (Cart.CalculateTotal() >= 800)
                {
                    d = 15;
                }
                total = total - ((d / 100) * total);
            }
            else if (Cart.CalculateTotal() > 1000 && Cart.CalculateTotal() <= 5000)
            {
                d = 30;
                total = total - ((d / 100) * total);
            }
            else if (Cart.CalculateTotal() > 5000 && Cart.CalculateTotal() <= 15000)
            {
                d = 40;
                total = total - ((d / 100) * total);
            }
            else
            {
                d = 50;
                total = total - ((d / 100) * total);
            }
            Discount.Text = d.ToString();
            Tax.Text = st.ToString();
            Dissal.Text = total.ToString();
        }

        private void Out_Click(object sender, EventArgs e)
        {
            Discount.Text = null;
            Tax.Text = null;
            Dissal.Text = null;
            li = null;
            itemlist.DataSource = null;
            Cart.items = null;
            tptext.Text = null;
            CompleteCheckout();
        }
        private void cartex_Tick(object sender, EventArgs e)
        {
            limit--;
            if (limit <= 0)
            {
                cartex.Stop();
                MessageBox.Show("Cart has expired!", "Expired", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ClearCart();
            }
        }
        private void ClearCart()
        {
            Cart.items.Clear();
            li.Clear();
            itemlist.DataSource = null;
            tptext.Text = "0";
            limit = 30;
        }

        private void CompleteCheckout()
        {
            cartex.Stop();
            MessageBox.Show("Checkout completed successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void recom_SelectedIndexChanged(object sender, EventArgs e)
        {
               
        }

        private void recommended()
        {
            Random random = new Random();
            List<Item> recommendedItems = new List<Item>();
            int numberOfRecommendations = Math.Min(3, items.Count);

            while (recommendedItems.Count < numberOfRecommendations)
            {
                int randomIndex = random.Next(items.Count);
                Item randomItem = items[randomIndex];
                if (!recommendedItems.Contains(randomItem))
                {
                    recommendedItems.Add(randomItem);
                }
            }

            recom.Items.Clear();
            foreach (var item in recommendedItems)
            {
                recom.Items.Add($"{item.Name} - Price: {item.Price}");
            }
            return;
        }
    }
}