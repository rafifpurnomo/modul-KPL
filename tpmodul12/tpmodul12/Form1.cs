namespace tpmodul12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string CariTandaBilangan(int a)
        {
            if (a == 0)
            {
                return "NOL";
            }
            else if (a < 0)
            {
                return "NEGATIF";
            }
            else
            {
                return "POSITIF";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(inputText.Text, out int inputValue))
            {
                string result = CariTandaBilangan(inputValue);

                output.Text = result;
            }
            else
            {
                output.Text = "Input tidak valid";
            }
        }

        private void inputText_TextChanged(object sender, EventArgs e)
        {

        }

        private void output_Click(object sender, EventArgs e)
        {

        }
    }
}
