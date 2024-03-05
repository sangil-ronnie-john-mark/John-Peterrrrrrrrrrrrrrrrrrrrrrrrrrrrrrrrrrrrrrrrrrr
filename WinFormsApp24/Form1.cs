namespace WinFormsApp24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private double total;
        private double cash;
        private void calculateTotal()
        {
            double dishPrice;
            double drinkPrice;
            try
            {
                dishPrice = double.Parse(lblDish.Text);
            }
            catch
            {
                dishPrice = 0;
            }
            try
            {
                drinkPrice = double.Parse(lblDrinks.Text);
            }
            catch { drinkPrice = 0; }

            total = dishPrice + drinkPrice;
            double tax = total * 0.12;
            lblTax.Text = tax.ToString();
            lblTotal.Text = total.ToString();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboDishes.Text)
            {
                case "CALDERETA":
                    lblDish.Text = "30";
                    break;
                case "SISIG":
                    lblDish.Text = "40";
                    break;
                case "ASADO":
                    lblDish.Text = "50";
                    break;
                case "MENUDO":
                    lblDish.Text = "60";
                    break;
                case "PANDESAL":
                    lblDish.Text = "20";
                    break;
                case "ANCHOVY":
                    lblDish.Text = "10";
                    break;
            }
            calculateTotal();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblDish.Text = "---";
            cboDishes.Text = null;
            lblDrinks.Text = "---";
            cboDrinks.Text = null;
            txtCash.Text = null;
            button2.Enabled = false;
            lblChange.Text = null;
        }

        private void cboDrinks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboDrinks.Text == "RED HORSE")
            {
                lblDrinks.Text = "65";
            }
            else if (cboDrinks.Text == "TANDUAY")
            {
                lblDrinks.Text = "40";
            }
            else if (cboDrinks.Text == "SOJU")
            {
                lblDrinks.Text = "60";
            }
            else if (cboDrinks.Text == "GIN")
            {
                lblDrinks.Text = "60";
            }
            calculateTotal();
        }

        private void txtCash_TextChanged(object sender, EventArgs e)
        {
         
            try
            {
                cash = double.Parse(txtCash.Text);
            }
            catch
            {
                cash = 0;
            }

            if (cash >= total)
            {
                button2.Enabled = true;
            }
            else
            {
                button2.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double change = cash - total;
            lblChange.Text = change.ToString();
        }
    }
}
