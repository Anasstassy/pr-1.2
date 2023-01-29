using System.Text.RegularExpressions;

namespace pr_1._2
{
    public partial class Form1 : Form
    {
        public int result;
       
        public Form1()
        {
            InitializeComponent();
            //comment
            textBox3.BackColor = textBox1.BackColor;  
     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string xstring = string.Join(string.Empty, Regex.Matches(textBox1.Text, @"\d+").OfType<Match>().Select(m => m.Value));
            string bstring = string.Join(string.Empty, Regex.Matches(textBox2.Text, @"\d+").OfType<Match>().Select(m => m.Value));
            double x = 0;
            double b = 0;
            double.TryParse(xstring, out x);
            double.TryParse(bstring, out b);
            double p = x * b;
            double s = 1;
            double f = 0;
            if (checkBox1.Checked)
            {
                f = 2 * x;
            }
            if (checkBox2.Checked)
            {
                f = x + 4;
            }
            if (checkBox3.Checked)
            {
                f = x * x;
            }
            if (1 < p && p < 10)
            {
                s = Math.Pow(Math.Exp(x), f);
            }
            if (12 < p && p < 40) {
                s = Math.Sqrt(Math.Abs(f) + 4 * b);
            }
            else
            {
                s = b * f * f;
            }
            textBox3.Text = $" при x = {x} \r\n при b = {b} \r\n s = {s} ";
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}