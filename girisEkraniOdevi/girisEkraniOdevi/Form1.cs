namespace girisEkraniOdevi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = textBox1.Text;
            string sifre = textBox2.Text;

            if (kullaniciAdi == "132130038")
            {
                if(sifre =="sumeyye123")
                {
                    Form2 x2 = new Form2();
                    x2.Show();

                }
            }
            else
            {
                Form3 x3 = new Form3();
                x3.Show();
            }


        }
    }
}