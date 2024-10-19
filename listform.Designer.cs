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
            itemprices = new Label();
            itemsnames = new Label();
            backbutton = new Button();
            tptext = new TextBox();
            totalprice = new Label();
            labelquantity = new Label();
            layoutpanel.SuspendLayout();
            SuspendLayout();
            // 
            // layoutpanel
            // 
            layoutpanel.AutoScroll = true;
            layoutpanel.Controls.Add(labelquantity);
            layoutpanel.Controls.Add(itemprices);
            layoutpanel.Controls.Add(itemsnames);
            layoutpanel.Location = new Point(0, 70);
            layoutpanel.Name = "layoutpanel";
            layoutpanel.Size = new Size(800, 380);
            layoutpanel.TabIndex = 0;
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
            // labelquantity
            // 
            labelquantity.AutoSize = true;
            labelquantity.Location = new Point(300, 4);
            labelquantity.Name = "labelquantity";
            labelquantity.Size = new Size(65, 20);
            labelquantity.TabIndex = 2;
            labelquantity.Text = "Quantity";
            // 
            // listform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(totalprice);
            Controls.Add(tptext);
            Controls.Add(backbutton);
            Controls.Add(layoutpanel);
            Name = "listform";
            Text = "listform";
            Shown += listform_Shown;
            layoutpanel.ResumeLayout(false);
            layoutpanel.PerformLayout();
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
        //private Button addtocart;
    }
}