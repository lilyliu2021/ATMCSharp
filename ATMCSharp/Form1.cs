
namespace ATMCSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //        Exercise 2:
        //•Make a Mini-ATM.
        //•Using a function and subroutine, use the function to return the amount withdrawn as a messagebox.Use the subroutine to print the balance in a message box.Print the balance when after you withdraw
        //•Output is on the next page, but feel free to use your own design
        private void initial()
        {
            Button3.BackColor = Color.White;
            Button1.BackColor = Color.White;
            Button2.BackColor = Color.White;
            Label4.Visible = false;
            Label2.Visible = false;
            TextBox1.Visible = false;
            Button4.Visible = false;
        }
        private void inputActive()
        {           
            Label4.Visible = true;
            Label2.Visible = true;
            TextBox1.Visible = true;
            Button4.Visible = true;
        }

        double Withdraw(double amount, double myBalance)
        {
            if (amount < myBalance)
            {
                MessageBox.Show($"Here is your ${amount}");
                return myBalance - amount;
            }
            MessageBox.Show("Your account does not have enough money");
            return myBalance;
        }
        double Deposit(double amount, double myBalance)
        {
            MessageBox.Show($"${amount} is deposit into your account");
            return myBalance + amount;
        }
        private void PostBalance(double newBalance)
        {
            TextBox2.Text = newBalance.ToString();
            MessageBox.Show($"You have ${newBalance} left");
        }
        private void SelectBalance()
        {
            initial();
            Button3.BackColor = Color.Green;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TextBox2.Text = "10000";
            SelectBalance();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            initial();
            Button1.BackColor = Color.Green;           
            inputActive ();
            Label4.Text = "Withdraw";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            initial();
            Button2.BackColor = Color.Green;
            inputActive();
            Label4.Text = "Deposit";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            SelectBalance();
            double myBalance = Convert.ToDouble(TextBox2.Text);
            PostBalance(myBalance);
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            double myAmount = Convert.ToDouble(TextBox1.Text);
            double myBalance = Convert.ToDouble(TextBox2.Text);
            if (Label4.Text == "Withdraw")
            {
                double newBalance = Withdraw(myAmount, myBalance);
                PostBalance(newBalance);
            }
            else if (Label4.Text == "Deposit")
            {
                double newBalance = Deposit(myAmount, myBalance);
                PostBalance(newBalance);
            }
        }       
    }
}
