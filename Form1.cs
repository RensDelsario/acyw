namespace activiti2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rbItalian_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnTotal_Click(object sender, EventArgs e)
        {

            int total = 0;


            if (rbHawaiian.Checked)
            {
                total = 200;

            }
            if (rbItalian.Checked)
            {
                total += 250;
            }
            if (rbOverload.Checked)
            {
                total += 300;
            }

            if (rbSmall.Checked)
            {
                total += 50;
            }
            if (rbMedium.Checked)
            {
                total += 100;
            }
            if (rbLarge.Checked)
            {
                total += 150;
            }

            if (chCheese.Checked)
            {
                total += 50;
            }
            if (chPepperoni.Checked)
            {
                total += 50;
            }
            if (chBellpepper.Checked)
            {
                total += 50;
            }
            if (chBacon.Checked)
            {
                total += 75;
            }

            txtTotal.Text = total.ToString();

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = true;
            panel3.Visible = true;
            panel4.Visible = true;
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtTotal.Clear();
            txtAmount.Clear();
            txtChange.Clear();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
           

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            int total = int.Parse(txtTotal.Text);
            int paid = int.Parse(txtAmount.Text);
            if (paid < total)
            {
                txtChange.Text = "Insufficient Amount Paid";
            }
            else
            {
                int change = paid - total;
                txtChange.Text = change.ToString();
            }
        }
    }
}
