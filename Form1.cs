namespace mathematicalOperation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try{
                int num1 = Convert.ToInt32(txtNum1.Text);
                int num2 = Convert.ToInt32(txtNum2.Text);
                txtResult.Text = (num1 + num2).ToString();
            }catch(Exception){
            MessageBox.Show(
                  "Please enter valid numbers only.",
                    "Input Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
            );
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try{
                int num1 = Convert.ToInt32(txtNum1.Text);
                int num2 = Convert.ToInt32(txtNum2.Text);
                txtResult.Text = (num1 - num2).ToString();
            }catch(Exception){
            MessageBox.Show(
                  "Please enter valid numbers only.",
                    "Input Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
            );
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try{
                int num1 = Convert.ToInt32(txtNum1.Text);
                int num2 = Convert.ToInt32(txtNum2.Text);
                txtResult.Text = (num1 * num2).ToString();
            }catch(Exception){
            MessageBox.Show(
                  "Please enter valid numbers only.",
                    "Input Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
            );
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try{
                int num1 = Convert.ToInt32(txtNum1.Text);
                int num2 = Convert.ToInt32(txtNum2.Text);
                if (num2 == 0)
                        {
                            MessageBox.Show("Cannot divide by zero.");
                            return;
                        }
    
                txtResult.Text = (num1 / num2).ToString();
            }catch(Exception){
            MessageBox.Show(
                  "Please enter valid numbers only.",
                    "Input Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
            );
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
        try{
                int num1 = Convert.ToInt32(txtNum1.Text);
                int num2 = Convert.ToInt32(txtNum2.Text);
                txtResult.Text = (num1 % num2).ToString();
            }catch(Exception){
            MessageBox.Show(
                  "Please enter valid numbers only.",
                    "Input Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
            );
            }
        }
    }
}

