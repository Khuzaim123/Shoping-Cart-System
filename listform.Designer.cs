namespace ShopingCart
{
    partial class listform
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;


        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            layoutpanel = new Panel();
            label1 = new Label();
            recom = new ListBox();
            itemprices = new Label();
            itemsnames = new Label();
            itempanel = new Panel();
            remove = new Button();
            add = new Button();
            update = new Button();
            delete = new Button();
            itemlist = new ListBox();
            backbutton = new Button();
            tptext = new TextBox();
            totalprice = new Label();
            viewcart = new Button();
            checkout = new Button();
            checkpanel = new Panel();
            Out = new Button();
            Tax = new TextBox();
            sales = new Label();
            Discount = new TextBox();
            Dis = new Label();
            Dissal = new TextBox();
            tpad = new Label();
            card = new Button();
            cash = new Button();
            layoutpanel.SuspendLayout();
            itempanel.SuspendLayout();
            checkpanel.SuspendLayout();
            SuspendLayout();
            // 
            // layoutpanel
            // 
            layoutpanel.AutoScroll = true;
            layoutpanel.BackColor = SystemColors.GradientActiveCaption;
            layoutpanel.Controls.Add(label1);
            layoutpanel.Controls.Add(recom);
            layoutpanel.Controls.Add(itemprices);
            layoutpanel.Controls.Add(itemsnames);
            layoutpanel.ForeColor = Color.Black;
            layoutpanel.Location = new Point(0, 58);
            layoutpanel.Name = "layoutpanel";
            layoutpanel.Size = new Size(800, 391);
            layoutpanel.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(555, 3);
            label1.Name = "label1";
            label1.Size = new Size(145, 20);
            label1.TabIndex = 4;
            label1.Text = "Recoomeded Items: ";
            // 
            // recom
            // 
            recom.FormattingEnabled = true;
            recom.Location = new Point(506, 26);
            recom.Name = "recom";
            recom.Size = new Size(294, 364);
            recom.TabIndex = 3;
            recom.SelectedIndexChanged += recom_SelectedIndexChanged;
            // 
            // itemprices
            // 
            itemprices.AutoSize = true;
            itemprices.Location = new Point(150, 4);
            itemprices.Name = "itemprices";
            itemprices.Size = new Size(41, 20);
            itemprices.TabIndex = 1;
            itemprices.Text = "Price";
            // 
            // itemsnames
            // 
            itemsnames.AutoSize = true;
            itemsnames.Location = new Point(10, 4);
            itemsnames.Name = "itemsnames";
            itemsnames.Size = new Size(66, 20);
            itemsnames.TabIndex = 0;
            itemsnames.Text = "Products";
            // 
            // itempanel
            // 
            itempanel.BackColor = SystemColors.ActiveCaption;
            itempanel.Controls.Add(remove);
            itempanel.Controls.Add(add);
            itempanel.Controls.Add(update);
            itempanel.Controls.Add(delete);
            itempanel.Controls.Add(itemlist);
            itempanel.Location = new Point(0, 58);
            itempanel.Name = "itempanel";
            itempanel.Size = new Size(800, 391);
            itempanel.TabIndex = 3;
            // 
            // remove
            // 
            remove.Location = new Point(504, 206);
            remove.Name = "remove";
            remove.Size = new Size(160, 29);
            remove.TabIndex = 4;
            remove.Text = "Remove quantity";
            remove.UseVisualStyleBackColor = true;
            remove.Click += remove_Click;
            // 
            // add
            // 
            add.Location = new Point(506, 152);
            add.Name = "add";
            add.Size = new Size(160, 29);
            add.TabIndex = 3;
            add.Text = "Add quantity";
            add.UseVisualStyleBackColor = true;
            add.Click += add_Click;
            // 
            // update
            // 
            update.Location = new Point(506, 94);
            update.Name = "update";
            update.Size = new Size(160, 29);
            update.TabIndex = 2;
            update.Text = "Update Item";
            update.UseVisualStyleBackColor = true;
            update.Click += update_Click;
            // 
            // delete
            // 
            delete.Location = new Point(506, 38);
            delete.Name = "delete";
            delete.Size = new Size(160, 30);
            delete.TabIndex = 1;
            delete.Text = "Delete Item";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // itemlist
            // 
            itemlist.FormattingEnabled = true;
            itemlist.Location = new Point(12, 15);
            itemlist.Name = "itemlist";
            itemlist.Size = new Size(327, 364);
            itemlist.TabIndex = 0;
            // 
            // backbutton
            // 
            backbutton.Location = new Point(23, 23);
            backbutton.Name = "backbutton";
            backbutton.Size = new Size(191, 29);
            backbutton.TabIndex = 1;
            backbutton.Text = "back to main menu";
            backbutton.UseVisualStyleBackColor = true;
            backbutton.Click += backbutton_Click;
            // 
            // tptext
            // 
            tptext.Location = new Point(614, 25);
            tptext.Name = "tptext";
            tptext.ReadOnly = true;
            tptext.Size = new Size(125, 27);
            tptext.TabIndex = 2;
            // 
            // totalprice
            // 
            totalprice.AutoSize = true;
            totalprice.Location = new Point(504, 32);
            totalprice.Name = "totalprice";
            totalprice.Size = new Size(81, 20);
            totalprice.TabIndex = 3;
            totalprice.Text = "Total Price:";
            // 
            // viewcart
            // 
            viewcart.Location = new Point(252, 23);
            viewcart.Name = "viewcart";
            viewcart.Size = new Size(94, 29);
            viewcart.TabIndex = 4;
            viewcart.Text = "Display";
            viewcart.UseVisualStyleBackColor = true;
            viewcart.Click += viewcart_Click;
            // 
            // checkout
            // 
            checkout.Location = new Point(375, 23);
            checkout.Name = "checkout";
            checkout.Size = new Size(101, 29);
            checkout.TabIndex = 5;
            checkout.Text = "Check out";
            checkout.UseVisualStyleBackColor = true;
            checkout.Click += checkout_Click;
            // 
            // checkpanel
            // 
            checkpanel.BackColor = SystemColors.ActiveCaption;
            checkpanel.Controls.Add(Out);
            checkpanel.Controls.Add(Tax);
            checkpanel.Controls.Add(sales);
            checkpanel.Controls.Add(Discount);
            checkpanel.Controls.Add(Dis);
            checkpanel.Controls.Add(Dissal);
            checkpanel.Controls.Add(tpad);
            checkpanel.Controls.Add(card);
            checkpanel.Controls.Add(cash);
            checkpanel.Location = new Point(0, 58);
            checkpanel.Name = "checkpanel";
            checkpanel.Size = new Size(800, 394);
            checkpanel.TabIndex = 3;
            // 
            // Out
            // 
            Out.Location = new Point(575, 344);
            Out.Name = "Out";
            Out.Size = new Size(134, 29);
            Out.TabIndex = 8;
            Out.Text = "Check out";
            Out.UseVisualStyleBackColor = true;
            Out.Click += Out_Click;
            // 
            // Tax
            // 
            Tax.Location = new Point(292, 291);
            Tax.Name = "Tax";
            Tax.ReadOnly = true;
            Tax.Size = new Size(66, 27);
            Tax.TabIndex = 7;
            // 
            // sales
            // 
            sales.AutoSize = true;
            sales.Location = new Point(211, 294);
            sales.Name = "sales";
            sales.Size = new Size(75, 20);
            sales.TabIndex = 6;
            sales.Text = "Sales Tax: ";
            // 
            // Discount
            // 
            Discount.Location = new Point(103, 291);
            Discount.Name = "Discount";
            Discount.ReadOnly = true;
            Discount.Size = new Size(66, 27);
            Discount.TabIndex = 5;
            // 
            // Dis
            // 
            Dis.AutoSize = true;
            Dis.Location = new Point(23, 294);
            Dis.Name = "Dis";
            Dis.Size = new Size(74, 20);
            Dis.TabIndex = 4;
            Dis.Text = "Discount: ";
            // 
            // Dissal
            // 
            Dissal.Location = new Point(306, 346);
            Dissal.Name = "Dissal";
            Dissal.ReadOnly = true;
            Dissal.Size = new Size(188, 27);
            Dissal.TabIndex = 3;
            Dissal.TextChanged += textBox1_TextChanged;
            // 
            // tpad
            // 
            tpad.AutoSize = true;
            tpad.Location = new Point(23, 353);
            tpad.Name = "tpad";
            tpad.Size = new Size(277, 20);
            tpad.TabIndex = 2;
            tpad.Text = "Total price after discount and Sales Tax:  ";
            // 
            // card
            // 
            card.Location = new Point(12, 124);
            card.Name = "card";
            card.Size = new Size(134, 29);
            card.TabIndex = 1;
            card.Text = "Through Card";
            card.UseVisualStyleBackColor = true;
            card.Click += card_Click;
            // 
            // cash
            // 
            cash.Location = new Point(12, 28);
            cash.Name = "cash";
            cash.Size = new Size(134, 29);
            cash.TabIndex = 0;
            cash.Text = "Through Cash";
            cash.UseVisualStyleBackColor = true;
            cash.Click += cash_Click;
            // 
            // listform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(800, 449);
            Controls.Add(checkout);
            Controls.Add(viewcart);
            Controls.Add(totalprice);
            Controls.Add(tptext);
            Controls.Add(backbutton);
            Controls.Add(layoutpanel);
            Controls.Add(itempanel);
            Controls.Add(checkpanel);
            Name = "listform";
            Text = "listform";
            Shown += listform_Shown;
            layoutpanel.ResumeLayout(false);
            layoutpanel.PerformLayout();
            itempanel.ResumeLayout(false);
            checkpanel.ResumeLayout(false);
            checkpanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel layoutpanel;
        private Button backbutton;
        private Button itembutton;
        private Label itemname;
        private TextBox tptext;
        private Label totalprice;
        private Label pricees;
        private Label itemprices;
        private Label itemsnames;
        private Label itemquantity;
        private Button viewcart;
        private Panel itempanel;
        private ListBox itemlist;
        private Button delete;
        private Button update;
        private Button remove;
        private Button add;
        private Button checkout;
        private Panel checkpanel;
        private Button card;
        private Button cash;
        private TextBox Discount;
        private Label Dis;
        private TextBox Dissal;
        private Label tpad;
        private TextBox Tax;
        private Label sales;
        private Button Out;
        private ListBox recom;
        private Label label1;
    }
}