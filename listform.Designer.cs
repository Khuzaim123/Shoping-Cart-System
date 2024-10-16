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
            backbutton = new Button();
            tptext = new TextBox();
            totalprice = new Label();
            itemsnames = new Label();
            itemprices = new Label();
            layoutpanel.SuspendLayout();
            SuspendLayout();
            // 
            // layoutpanel
            // 
            layoutpanel.AutoScroll = true;
            layoutpanel.Controls.Add(itemprices);
            layoutpanel.Controls.Add(itemsnames);
            layoutpanel.Location = new Point(0, 70);
            layoutpanel.Name = "layoutpanel";
            layoutpanel.Size = new Size(800, 380);
            layoutpanel.TabIndex = 0;
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
            // itemsnames
            // 
            itemsnames.AutoSize = true;
            itemsnames.Location = new Point(10, 4);
            itemsnames.Name = "itemsnames";
            itemsnames.Size = new Size(66, 20);
            itemsnames.TabIndex = 0;
            itemsnames.Text = "Products";
            // 
            // itemprices
            // 
            itemprices.AutoSize = true;
            itemprices.Location = new Point(200, 4);
            itemprices.Name = "itemprices";
            itemprices.Size = new Size(41, 20);
            itemprices.TabIndex = 1;
            itemprices.Text = "Price";
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
        //private Button addtocart;
    }
}