using Microsoft.VisualBasic.ApplicationServices;

namespace ShopingCart
{
    public partial class Shopingcart : Form
    {
        private Dictionary<string, string> data = new Dictionary<string, string>();
        public Shopingcart()
        {
            InitializeComponent();

            loginpanel.Visible = true;
            signupanel.Visible = false;
        }

        private void InitializeComponent()
        {
            label1 = new Label();
            Login = new Button();
            signup = new Button();
            loginpanel = new Panel();
            loginbutton = new Button();
            loginpasstext = new TextBox();
            logintextuser = new TextBox();
            labelpasslogin = new Label();
            loginlabeluser = new Label();
            signupanel = new Panel();
            signupbutton = new Button();
            confirmpasstext = new TextBox();
            confirmpasslabel = new Label();
            signuppasstext = new TextBox();
            signuptextuser = new TextBox();
            signuplabelpass = new Label();
            signuplabeluser = new Label();
            loginpanel.SuspendLayout();
            signupanel.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoEllipsis = true;
            label1.AutoSize = true;
            label1.Location = new Point(284, 9);
            label1.Name = "label1";
            label1.Size = new Size(118, 20);
            label1.TabIndex = 0;
            label1.Text = "Login or Sign up";
            // 
            // Login
            // 
            Login.Location = new Point(12, 9);
            Login.Name = "Login";
            Login.Size = new Size(94, 29);
            Login.TabIndex = 1;
            Login.Text = "Login";
            Login.UseVisualStyleBackColor = true;
            Login.Click += Login_Click;
            // 
            // signup
            // 
            signup.Location = new Point(670, 5);
            signup.Name = "signup";
            signup.Size = new Size(94, 29);
            signup.TabIndex = 2;
            signup.Text = "Sign up";
            signup.UseVisualStyleBackColor = true;
            signup.Click += signup_Click;
            // 
            // loginpanel
            // 
            loginpanel.Controls.Add(loginbutton);
            loginpanel.Controls.Add(loginpasstext);
            loginpanel.Controls.Add(logintextuser);
            loginpanel.Controls.Add(labelpasslogin);
            loginpanel.Controls.Add(loginlabeluser);
            loginpanel.Location = new Point(0, 44);
            loginpanel.Name = "loginpanel";
            loginpanel.Size = new Size(764, 408);
            loginpanel.TabIndex = 3;
            // 
            // loginbutton
            // 
            loginbutton.Location = new Point(284, 329);
            loginbutton.Name = "loginbutton";
            loginbutton.Size = new Size(94, 29);
            loginbutton.TabIndex = 7;
            loginbutton.Text = "Login";
            loginbutton.UseVisualStyleBackColor = true;
            loginbutton.Click += loginbutton_Click;
            // 
            // loginpasstext
            // 
            loginpasstext.Location = new Point(273, 239);
            loginpasstext.Name = "loginpasstext";
            loginpasstext.Size = new Size(221, 27);
            loginpasstext.TabIndex = 6;
            // 
            // logintextuser
            // 
            logintextuser.Location = new Point(273, 80);
            logintextuser.Name = "logintextuser";
            logintextuser.Size = new Size(221, 27);
            logintextuser.TabIndex = 5;
            // 
            // labelpasslogin
            // 
            labelpasslogin.AutoEllipsis = true;
            labelpasslogin.AutoSize = true;
            labelpasslogin.Location = new Point(149, 242);
            labelpasslogin.Name = "labelpasslogin";
            labelpasslogin.Size = new Size(117, 20);
            labelpasslogin.TabIndex = 4;
            labelpasslogin.Text = "Enter password: ";
            // 
            // loginlabeluser
            // 
            loginlabeluser.AutoEllipsis = true;
            loginlabeluser.AutoSize = true;
            loginlabeluser.Location = new Point(149, 82);
            loginlabeluser.Name = "loginlabeluser";
            loginlabeluser.Size = new Size(118, 20);
            loginlabeluser.TabIndex = 4;
            loginlabeluser.Text = "Enter username: ";
            // 
            // signupanel
            // 
            signupanel.Controls.Add(signupbutton);
            signupanel.Controls.Add(confirmpasstext);
            signupanel.Controls.Add(confirmpasslabel);
            signupanel.Controls.Add(signuppasstext);
            signupanel.Controls.Add(signuptextuser);
            signupanel.Controls.Add(signuplabelpass);
            signupanel.Controls.Add(signuplabeluser);
            signupanel.Location = new Point(0, 44);
            signupanel.Name = "signupanel";
            signupanel.Size = new Size(760, 408);
            signupanel.TabIndex = 7;
            // 
            // signupbutton
            // 
            signupbutton.Location = new Point(284, 307);
            signupbutton.Name = "signupbutton";
            signupbutton.Size = new Size(94, 29);
            signupbutton.TabIndex = 9;
            signupbutton.Text = "Sign up";
            signupbutton.UseVisualStyleBackColor = true;
            signupbutton.Click += signupbutton_Click;
            // 
            // confirmpasstext
            // 
            confirmpasstext.Location = new Point(272, 236);
            confirmpasstext.Name = "confirmpasstext";
            confirmpasstext.Size = new Size(221, 27);
            confirmpasstext.TabIndex = 8;
            // 
            // confirmpasslabel
            // 
            confirmpasslabel.AutoEllipsis = true;
            confirmpasslabel.AutoSize = true;
            confirmpasslabel.Location = new Point(136, 243);
            confirmpasslabel.Name = "confirmpasslabel";
            confirmpasslabel.Size = new Size(130, 20);
            confirmpasslabel.TabIndex = 7;
            confirmpasslabel.Text = "Confirm Password:";
            // 
            // signuppasstext
            // 
            signuppasstext.Location = new Point(272, 167);
            signuppasstext.Name = "signuppasstext";
            signuppasstext.Size = new Size(221, 27);
            signuppasstext.TabIndex = 6;
            // 
            // signuptextuser
            // 
            signuptextuser.Location = new Point(273, 80);
            signuptextuser.Name = "signuptextuser";
            signuptextuser.Size = new Size(221, 27);
            signuptextuser.TabIndex = 5;
            // 
            // signuplabelpass
            // 
            signuplabelpass.AutoEllipsis = true;
            signuplabelpass.AutoSize = true;
            signuplabelpass.Location = new Point(149, 167);
            signuplabelpass.Name = "signuplabelpass";
            signuplabelpass.Size = new Size(117, 20);
            signuplabelpass.TabIndex = 4;
            signuplabelpass.Text = "Enter password: ";
            // 
            // signuplabeluser
            // 
            signuplabeluser.AutoEllipsis = true;
            signuplabeluser.AutoSize = true;
            signuplabeluser.Location = new Point(149, 82);
            signuplabeluser.Name = "signuplabeluser";
            signuplabeluser.Size = new Size(118, 20);
            signuplabeluser.TabIndex = 4;
            signuplabeluser.Text = "Enter username: ";
            // 
            // Shopingcart
            // 
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(776, 464);
            Controls.Add(loginpanel);
            Controls.Add(signupanel);
            Controls.Add(signup);
            Controls.Add(Login);
            Controls.Add(label1);
            Name = "Shopingcart";
            Text = "Login and Signup";
            loginpanel.ResumeLayout(false);
            loginpanel.PerformLayout();
            signupanel.ResumeLayout(false);
            signupanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void signup_Click(object sender, EventArgs e)
        {
            signupanel.Visible = true;
            loginpanel.Visible = false;
        }

        private void Login_Click(object sender, EventArgs e)
        {
            loginpanel.Visible = true;
            signupanel.Visible = false;
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            //string user = logintextuser.Text;
            //string pass = loginpasstext.Text;
            //if (data.ContainsKey(user) && data[user] == pass)
            //{
            //    MessageBox.Show("Login successfull", "", MessageBoxButtons.OK);
                cart cart = new cart();
                listform ls = new listform(cart);
                ls.Show();
            //}
            //else
            //{
            //    MessageBox.Show("Invalid username or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void signupbutton_Click(object sender, EventArgs e)
        {
            string pass = signuppasstext.Text;
            string user = signuptextuser.Text;
            string conf = confirmpasstext.Text;
            if (data.ContainsKey(user))
            {
                MessageBox.Show("This username already existed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            if (pass != conf)
            {
                MessageBox.Show("Password does not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            data.Add(user, conf);
            MessageBox.Show("Your account has been created", "", MessageBoxButtons.OK);
            loginpanel.Visible = true;
            signupanel.Visible = false;
        }
    }
}
