namespace Exercício_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbNum1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2, num3;
            try
            {
                num1=Convert.ToInt16(lbNum1.Text);
                num2=Convert.ToInt16(lbNum2.Text);
                num3=Convert.ToInt16(lbNum3.Text);

                if((num1>num2) && (num1>num3))
                   txbNumMaior.Text = num1.ToString();
                if ((num2 > num1) && (num2 > num3))
                    txbNumMaior.Text = num2.ToString();
                if ((num3 > num1) && (num3 > num2))
                    txbNumMaior.Text = num3.ToString();
            }
            catch
            {
                MessageBox.Show("Há números iguais", "ATENÇÃO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}