namespace bılet_satıs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        int kasaTutar = 0;
        private void button1_Click_1(object sender, EventArgs e)
        {

            int misir, soda, su, bilet, toplam;
            misir = Convert.ToInt32(txtMısır.Text);
            soda = Convert.ToInt32(txtSoda.Text);
            su = Convert.ToInt32(txtSu.Text);
            bilet = Convert.ToInt32(txtBilet.Text);

            toplam = misir * 30 + soda * 15 + su * 10 + bilet * 60;
            lblToplam.Text = toplam.ToString() + " TL";

            kasaTutar = kasaTutar + toplam;
            lblKasa.Text = kasaTutar.ToString();

           
           

            MessageBox.Show("ödemeniz gereken toplam tutar :" + lblToplam.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtBilet.Text = " ";
            txtMısır.Text = " ";
            txtSoda.Text = " ";
            txtSu.Text = " ";

            txtMısır.Focus();

           
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 fr = new Form2();
            fr.Show();

        }
    }
}