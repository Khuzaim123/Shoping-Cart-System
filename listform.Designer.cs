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
            labelquantity = new Label();
            itemprices = new Label();
            itemsnames = new Label();
            itempanel = new Panel();
            itemlist = new ListBox();
            backbutton = new Button();
            tptext = new TextBox();
            totalprice = new Label();
            viewcart = new Button();
            delete = new Button();
            layoutpanel.SuspendLayout();
            itempanel.SuspendLayout();
            SuspendLayout();
            // 
            // layoutpanel
            // 
            layoutpanel.AutoScroll = true;
            layoutpanel.BackColor = SystemColors.GradientActiveCaption;
            layoutpanel.Controls.Add(labelquantity);
            layoutpanel.Controls.Add(itemprices);
            layoutpanel.Controls.Add(itemsnames);
            layoutpanel.ForeColor = Color.Black;
            layoutpanel.Location = new Point(0, 58);
            layoutpanel.Name = "layoutpanel";
            layoutpanel.Size = new Size(800, 391);
            layoutpanel.TabIndex = 0;
            // 
            // labelquantity
            // 
            labelquantity.AutoSize = true;
            labelquantity.Location = new Point(300, 4);
            labelquantity.Name = "labelquantity";
            labelquantity.Size = new Size(65, 20);
            labelquantity.TabIndex = 2;
            labelquantity.Text = "Quantity";
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
            itempanel.Controls.Add(delete);
            itempanel.Controls.Add(itemlist);
            itempanel.Location = new Point(0, 58);
            itempanel.Name = "itempanel";
            itempanel.Size = new Size(800, 391);
            itempanel.TabIndex = 3;
            // 
            // itemlist
            // 
            itemlist.FormattingEnabled = true;
            itemlist.Location = new Point(12, 15);
            itemlist.Name = "itemlist";
            itemlist.Size = new Size(327, 364);
            itemlist.TabIndex = 0;
            itemlist.SelectedIndex = -1;
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
            viewcart.Location = new Point(311, 22);
            viewcart.Name = "viewcart";
            viewcart.Size = new Size(94, 29);
            viewcart.TabIndex = 4;
            viewcart.Text = "Display";
            viewcart.UseVisualStyleBackColor = true;
            viewcart.Click += viewcart_Click;
            // 
            // delete
            // 
            delete.Location = new Point(506, 38);
            delete.Name = "delete";
            delete.Size = new Size(160, 29);
            delete.TabIndex = 1;
            delete.Text = "Delete Item";
            delete.UseVisualStyleBackColor = true;
            delete.Click += delete_Click;
            // 
            // listform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(800, 450);
            Controls.Add(viewcart);
            Controls.Add(totalprice);
            Controls.Add(tptext);
            Controls.Add(backbutton);
            Controls.Add(itempanel);
            Controls.Add(layoutpanel);
            Name = "listform";
            Text = "listform";
            Shown += listform_Shown;
            layoutpanel.ResumeLayout(false);
            layoutpanel.PerformLayout();
            itempanel.ResumeLayout(false);
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
        private Label labelquantity;
        private Button viewcart;
        private Panel itempanel;
        private ListBox itemlist;
        private Button delete;
        //private Button addtocart;
    }
}