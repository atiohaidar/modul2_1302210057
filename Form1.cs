namespace modul3_1302210057
{
    public partial class Form1 : Form
    {
        int value = -1;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "0";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text+ "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "2";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "3";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "4";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "5";

        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "6";

        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "7";

        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "8";

        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "9";

        }

        private void button11_Click(object sender, EventArgs e)
        {
            label1.Text = "";

            if (this.value != -1)
            {
               try
                {

            int hasil = this.value + int.Parse(textBox1.Text);
            textBox1.Text = hasil.ToString();
                    label2.Text = "";
                }
                catch(Exception ex)
                {
                    label1.Text = "Harap masukan bialngan bulat saja !!";

                }
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            label1.Text = "";

            if (textBox1.Text != "")
            {

                try
                {
                    this.value = int.Parse(textBox1.Text);
                    label2.Text = value.ToString() + "+";
                    textBox1.Text = "";

                }catch(Exception ex)
                {
                    label1.Text = "Harap masukan bialngan bulat saja !!";
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}