namespace MyCalculator
{
    public partial class Form1 : Form
    {
        double a = 0;
        string s = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (Hisob.Text == "0") Hisob.Clear();
            Button q = (Button)sender;
            Hisob.Text += q.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hisob.Text = "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            a = double.Parse(Hisob.Text);
            Hisob.Text = "0";
            s = "/";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            a = double.Parse(Hisob.Text);
            Hisob.Text = "0";
            s = "*";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            a = double.Parse(Hisob.Text);
            Hisob.Text = "0";
            s = "-";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            a = double.Parse(Hisob.Text);
            Hisob.Text = "0";
            s = "+";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            switch (s)
            {
                case "/":
                    Hisob.Text = (a / double.Parse(Hisob.Text)).ToString();
                    break;
                case "*":
                    Hisob.Text = (a * double.Parse(Hisob.Text)).ToString();
                    break;
                case "-":
                    Hisob.Text = (a - double.Parse(Hisob.Text)).ToString();
                    break;
                case "+":
                    Hisob.Text = (a + double.Parse(Hisob.Text)).ToString();
                    break;
                default: break;
            }
        }
    }
}