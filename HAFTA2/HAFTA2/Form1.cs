namespace HAFTA2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            comboBox1.Items.Add("Ýþçi");
            comboBox1.Items.Add("muhendis");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            personel pers = new personel
(textBox1.Text, textBox2.Text, Convert.ToInt32(textBox3.Text), comboBox1.Text, Convert.ToInt32(textBox4.Text));

            if (comboBox1.Text == "Ýþçi")

            {
                MessageBox.Show(pers.ucretHesapla().ToString());

            }
            else
            {
                pers.ucretHesapla(1000);
            }

        }
    }
}