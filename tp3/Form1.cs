namespace tp3
{
    public partial class Form1 : Form
    {
        double total = 0;
        string input = string.Empty;
        string display = string.Empty;
        bool hasilBaruTampil = false;

        public Form1()
        {
            InitializeComponent();
        }

        // function to show text
        private void Tampil(string text)
        {
            label1.Text = text;
        }


        //fungsi event click biar gk repetitif, jadinya nanti tinggal passing aja ini button apa
        private void TambahAngka(string angka)
        {
            // Kalau sebelumnya baru tampil hasil, mulai input baru dari awal
            if (hasilBaruTampil)
            {
                input = "";
                total = 0;
                display = "";
                hasilBaruTampil = false;
            }

            input += angka;
            display += angka;
            Tampil(display);
        }

        //count total
        private void TambahKeTotal()
        {
            if (!string.IsNullOrEmpty(input))
            {
                total += Convert.ToDouble(input);
                input = "";
            }
        }


        //button event implementation
        private void button1_Click(object sender, EventArgs e) => TambahAngka("1");
        private void button2_Click(object sender, EventArgs e) => TambahAngka("2");
        private void button3_Click(object sender, EventArgs e) => TambahAngka("3");
        private void button4_Click(object sender, EventArgs e) => TambahAngka("4");
        private void button5_Click(object sender, EventArgs e) => TambahAngka("5");
        private void button6_Click(object sender, EventArgs e) => TambahAngka("6");
        private void button7_Click(object sender, EventArgs e) => TambahAngka("7");
        private void button8_Click(object sender, EventArgs e) => TambahAngka("8");
        private void button9_Click(object sender, EventArgs e) => TambahAngka("9");
        private void button11_Click(object sender, EventArgs e) => TambahAngka("0");

        private void button10_Click(object sender, EventArgs e) // tombol +
        {
            if (!string.IsNullOrEmpty(input))
            {
                TambahKeTotal();
                display += " + ";
                Tampil(display);
            }
        }


        // button total
        private void button12_Click(object sender, EventArgs e) // tombol =
        {
            if (!string.IsNullOrEmpty(input))
            {
                TambahKeTotal();
            }

            display = total.ToString();
            Tampil(display);

            hasilBaruTampil = true;
        }

        // label 
        private void Form1_Load(object sender, EventArgs e)
        {
            label1.AutoSize = false;
            label1.Width = panel1.Width;
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Text = "0";
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}