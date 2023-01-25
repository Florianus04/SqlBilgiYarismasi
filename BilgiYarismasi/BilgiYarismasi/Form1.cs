using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BilgiYarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=DESKTOP-K6R87ON; Initial Catalog=BilgiYarismasi; Integrated Security=True");
        int sayac = 0,puan = 0, süre = 10;
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            süre = 10;
            button1.Enabled = false;
            Sayac();
            button1.Text = "Sonraki";
            if (sayac == 1)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select *From soru1 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    btnA.Text = oku["a"].ToString();
                    btnB.Text = oku["b"].ToString();
                    btnC.Text = oku["c"].ToString();
                    btnD.Text = oku["d"].ToString();
                    textBox1.Text = oku["soru"].ToString();
                    label2.Text = oku["dogru"].ToString();
                }
                baglan.Close();
            }
            if (sayac == 2)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select *From soru2 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    btnA.Text = oku["a"].ToString();
                    btnB.Text = oku["b"].ToString();
                    btnC.Text = oku["c"].ToString();
                    btnD.Text = oku["d"].ToString();
                    textBox1.Text = oku["soru"].ToString();
                    label2.Text = oku["dogru"].ToString();
                }
                baglan.Close();
            }
            if (sayac == 3)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select *From soru3 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    btnA.Text = oku["a"].ToString();
                    btnB.Text = oku["b"].ToString();
                    btnC.Text = oku["c"].ToString();
                    btnD.Text = oku["d"].ToString();
                    textBox1.Text = oku["soru"].ToString();
                    label2.Text = oku["dogru"].ToString();
                }
                baglan.Close();
            }
            if (sayac == 4)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select *From soru4 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    btnA.Text = oku["a"].ToString();
                    btnB.Text = oku["b"].ToString();
                    btnC.Text = oku["c"].ToString();
                    btnD.Text = oku["d"].ToString();
                    textBox1.Text = oku["soru"].ToString();
                    label2.Text = oku["dogru"].ToString();
                }
                baglan.Close();
            }
            if (sayac == 5)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select *From soru5 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    btnA.Text = oku["a"].ToString();
                    btnB.Text = oku["b"].ToString();
                    btnC.Text = oku["c"].ToString();
                    btnD.Text = oku["d"].ToString();
                    textBox1.Text = oku["soru"].ToString();
                    label2.Text = oku["dogru"].ToString();
                }
                baglan.Close();
            }
            if (sayac > 5)
            {
                Bitti();
                label5.Text = "5";
            }
        }
        void Bitti()
        {
            timer1.Enabled = false;
            button1.Text = "Yarışma Bitti";
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
        }
        void Sayac()
        {
            sayac += 1;
            label5.Text = sayac.ToString();
        }
        void Puan(int x)
        {
            puan += x;
            label3.Text = puan.ToString();
        }
        private void btnA_Click(object sender, EventArgs e)
        {
            if (btnA.Text == label2.Text)
            {
                Puan(10);
                button1_Click(sender, e);
            }
            else
            {
                Puan(-10);
                button1_Click(sender,e);
            }
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            if (btnB.Text == label2.Text)
            {
                Puan(10);
                button1_Click(sender, e);
            }
            else
            {
                Puan(-10);
                button1_Click(sender, e);
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            if (btnC.Text == label2.Text)
            {
                Puan(10);
                button1_Click(sender, e);
            }
            else
            {
                Puan(-10);
                button1_Click(sender, e);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            süre -= 1;
            label7.Text = süre.ToString();
            if (süre < 0)
            {
                Bitti();
            }
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            if (btnD.Text == label2.Text)
            {
                Puan(10);
                button1_Click(sender, e);
            }
            else
            {
                Puan(-10);
                button1_Click(sender, e);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label5.Text = sayac.ToString();
        }
    }
}
