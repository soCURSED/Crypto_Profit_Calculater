namespace calculate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void textEnter_TextChanged(object sender, EventArgs e)
        {

        }

        private void textPrice_TextChanged(object sender, EventArgs e)
        {

        }

        private void textOut_TextChanged(object sender, EventArgs e)
        {

        }

        private void textProfit_TextChanged(object sender, EventArgs e)
        {

        }

        private void textTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textEnter.Clear();
            textOut.Clear();
            textPrice.Clear();
            textProfit.Clear();
            textTotal.Clear();
            textFinal.Clear();

        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
      



            
             if ((String.IsNullOrEmpty(textOut.Text)) && (String.IsNullOrEmpty(textEnter.Text)) && (String.IsNullOrEmpty(textPrice.Text)))
            {
                string message = "دخل ارقام فقط";
                MessageBox.Show(message);
            }
            else
            {
                float Calcolating = Convert.ToSingle(textOut.Text) - Convert.ToSingle(textEnter.Text);
                float CalcolatingTwo = Calcolating / Convert.ToSingle(textEnter.Text);
                float percintage = CalcolatingTwo;
                float price = Convert.ToSingle(textPrice.Text);
                var total = percintage * price;
                float JustPrice = Convert.ToSingle(textPrice.Text);
                

                textProfit.Text = "%" + Convert.ToString(percintage);
                textTotal.Text = "$" + Convert.ToString(total);
                textFinal.Text = "$" + Convert.ToString(total + JustPrice);
            }    


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textVeryTotal_TextChanged(object sender, EventArgs e)
        {

        }

        private void textVeryTotal_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textTotalAllres_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1asf_TextChanged(object sender, EventArgs e)
        {

        }

        private void textFinal_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("By Faisal Github:" +
                "\n https://github.com/soCURSED");
        }
    }
}