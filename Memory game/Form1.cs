namespace Memory_game
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int k1, k2, k3, k4, k5, k6, k7, k8;
        int secimSayi = 0;
        int birinciReng = 0;
        int ikinciReng = 0;
        Button birinciKart = null!;
        Button ikinciKart = null!;
        int duzgunSay = 0;
        int sehvSay = 0;
        int acilanCut = 0;
        bool gozle = false;
        private void Form1_Load(object sender, EventArgs e)
        {
            RengleriPayla();
        }
        private void RengleriPayla()
        {
            Random r = new Random();
            int nov = r.Next(1, 5);
            if (nov == 1)
            {
                k1 = 1; k2 = 3; k3 = 2; k4 = 4;
                k5 = 2; k6 = 1; k7 = 4; k8 = 3;
            }
            else if (nov == 2)
            {
                k1 = 4; k2 = 2; k3 = 1; k4 = 3;
                k5 = 3; k6 = 4; k7 = 1; k8 = 2;
            }
            else if (nov == 3)
            {
                k1 = 2; k2 = 1; k3 = 4; k4 = 3;
                k5 = 1; k6 = 3; k7 = 2; k8 = 4;
            }
            else
            {
                k1 = 3; k2 = 4; k3 = 1; k4 = 2;
                k5 = 4; k6 = 2; k7 = 3; k8 = 1;
            }
        }
        private void RengVer(Button btn, int rengNomresi)
        {
            if (rengNomresi == 1)
                btn.BackColor = Color.Red;
            else if (rengNomresi == 2)
                btn.BackColor = Color.Blue;
            else if (rengNomresi == 3)
                btn.BackColor = Color.Yellow;
            else if (rengNomresi == 4)
                btn.BackColor = Color.Green;
        }
        private void KartYoxla(Button kliklenenBtn, int rengNomresi)
        {
            if (gozle == true || kliklenenBtn.BackColor != Color.LightGray)
                return;
            RengVer(kliklenenBtn, rengNomresi);
            secimSayi++;

            if (secimSayi == 1)
            {
                birinciKart = kliklenenBtn;
                birinciReng = rengNomresi;
            }
            else if (secimSayi == 2)
            {
                ikinciKart = kliklenenBtn;
                ikinciReng = rengNomresi;
                secimSayi = 0;
                if (birinciReng == ikinciReng)
                {
                    duzgunSay++;
                    acilanCut++;
                    label2.Text = duzgunSay.ToString();
                    label5.Text = "✅";
                    birinciKart.Enabled = false;
                    ikinciKart.Enabled = false;
                    if (acilanCut == 4)
                    {
                        MessageBox.Show("Oyun bitdi! Topladığınız xal: " + duzgunSay);
                    }
                }
                else
                {
                    sehvSay++;
                    label4.Text = sehvSay.ToString();
                    label5.Text = "❌";
                    gozle = true;
                    timer1.Start();
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            KartYoxla(button1, k1);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            KartYoxla(button2, k2);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            KartYoxla(button3, k3);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            KartYoxla(button4, k4);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            KartYoxla(button5, k5);
        }
        private void button6_Click(object sender, EventArgs e)
        {
            KartYoxla(button6, k6);
        }
        private void button7_Click(object sender, EventArgs e)
        {
            KartYoxla(button7, k7);
        }
        private void button8_Click(object sender, EventArgs e)
        {
            KartYoxla(button8, k8);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            birinciKart.BackColor = Color.LightGray;
            ikinciKart.BackColor = Color.LightGray;
            gozle = false;
        }
        private void button9_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            gozle = false;
            secimSayi = 0;
            duzgunSay = 0;
            sehvSay = 0;
            acilanCut = 0;
            label2.Text = "0";
            label4.Text = "0";
            label5.Text = "";
            button1.BackColor = Color.LightGray; button1.Enabled = true;
            button2.BackColor = Color.LightGray; button2.Enabled = true;
            button3.BackColor = Color.LightGray; button3.Enabled = true;
            button4.BackColor = Color.LightGray; button4.Enabled = true;
            button5.BackColor = Color.LightGray; button5.Enabled = true;
            button6.BackColor = Color.LightGray; button6.Enabled = true;
            button7.BackColor = Color.LightGray; button7.Enabled = true;
            button8.BackColor = Color.LightGray; button8.Enabled = true;
            RengleriPayla();
        }
        private void button10_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Oyundan çıxmaq istəyirsiniz?", "Çıxış", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (d == DialogResult.Yes)
            {
                Close();
            }
        }
    }
}