using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt6
{
    public partial class Proces : Form
    {
        Timer t = new Timer();

        public Proces()
        {
            InitializeComponent();
            timer_alarm1.Start();
            timer_wentylatory.Start();
            wentylator(wentylatory);
        }

        private void Proces_Load(object sender, EventArgs e)
        {
            timer.Start();
        }

        public float dane;
        public int wentylatory = 1;
        private void timer_Tick(object sender, EventArgs e)
        {
            //CPU
            float fcpu = pCPU.NextValue();
            progressBarCPU.Value = (int)fcpu;
            IblCPU.Text = string.Format("{0:0.00}%", fcpu);
            //RAM
            float fram = pRAM.NextValue();
            progressBarRAM.Value = (int)fram;
            IblRAM.Text = string.Format("{0:0.00}%", fram);

            //Wykres CPU i RAM
            chart1.Series["CPU"].Points.Add(fcpu);
            chart1.Series["RAM"].Points.Add(fram);

            //Obsługa komunikatu przeciążenia
            if(fcpu > 80 && fram > 80)
            {
                przeciazenie.BackColor = Color.Red;
                przeciazenie.Text = "Przeciążenie !!!";
                komunikatprzeciazenie.BackColor = Color.Red;
                komunikatprzeciazenie.Text = "Spróbuj rozwiązać problem \t\n ograniczjąc ilość aktywnych \t\n aplikacji. ";
                wentylator(5);
                    }else
            {
                przeciazenie.BackColor = Color.Transparent;
                komunikatprzeciazenie.BackColor = Color.Transparent;
                komunikatprzeciazenie.Text = "";
            }


            //System.Random x = new Random();
            //x.Next(1, 100);
            //komunikatprzeciazenie.Text = x.ToString();



            //Wentylatory przedziały ile powinno byc włączonych
            dane = fcpu;

            if (dane >= 0 && dane < 20)
            {
                wentylatory = 1;
            }
            else
            if (dane >= 20 && dane < 40)
            {
                wentylatory = 2;
            }
            else
            if (dane >= 40 && dane < 60)
            {
                wentylatory = 3;
            }
            else
            if (dane >= 60 && dane < 80)
            {
                wentylatory = 4;
            }
            else
            if (dane >= 80 && dane < 100)
            {
                wentylatory = 5;
            }
        }

        //Wyswietla wentylatory (1-5)
        public void wentylator(int wentylatory)
        {
            switch (wentylatory)
            {
                case 1:
                    {
                        wentylator1.BackColor = Color.Red;
                        wentylator2.BackColor = Color.Transparent;
                        wentylator3.BackColor = Color.Transparent;
                        wentylator4.BackColor = Color.Transparent;
                        wentylator5.BackColor = Color.Transparent;
                    }
                    break;

                case 2:
                    {
                        wentylator1.BackColor = Color.Red;
                        wentylator2.BackColor = Color.Red;
                        wentylator3.BackColor = Color.Transparent;
                        wentylator4.BackColor = Color.Transparent;
                        wentylator5.BackColor = Color.Transparent;
                    }
                    break;

                case 3:
                    {
                        wentylator1.BackColor = Color.Red;
                        wentylator2.BackColor = Color.Red;
                        wentylator3.BackColor = Color.Red;
                        wentylator4.BackColor = Color.Transparent;
                        wentylator5.BackColor = Color.Transparent;
                    }
                    break;
                case 4:
                    {
                        wentylator1.BackColor = Color.Red;
                        wentylator2.BackColor = Color.Red;
                        wentylator3.BackColor = Color.Red;
                        wentylator4.BackColor = Color.Red;
                        wentylator5.BackColor = Color.Transparent;
                    }
                    break;
                case 5:
                    {
                        wentylator1.BackColor = Color.Red;
                        wentylator2.BackColor = Color.Red;
                        wentylator3.BackColor = Color.Red;
                        wentylator4.BackColor = Color.Red;
                        wentylator5.BackColor = Color.Red;
                    }
                    break;
            }
        }



        //wroc do menu po 30 bez klikniecia
        private void Zaloguj_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

       public int co30 = 0, do30 = 0, timerwentylatory = 0;

        public string y;
        //odmierzanie 30s na alarm
        private void timer_alarm1_Tick(object sender, EventArgs e)
        {
            ++co30;
            if (co30 < 10)
            {
                y = "0" + co30.ToString();
            }else
            {
                y = co30.ToString();
            }

            label3.Text = "00:" + y.ToString();
            if (co30 == 30)
            {
                button1.BackColor = Color.Red;
                timer_alarm2.Start();
            }
 
        }

        // odmierz 30s na klikniecie 
        public string x;
            private void timer_alarm2_Tick(object sender, EventArgs e)
            {
                ++do30;
            
                if(do30 < 10)
                {
                     x="0"+ do30.ToString();
            }else
            {
                x = do30.ToString();
            }

                    label3.Text = "00:" + x;
                    timer_alarm1.Stop();

                 if (do30 == 30)
                {
                    this.Hide();
                    this.Close();
                    Form1 form1 = new Form1();
                    form1.Show();
                }
        }
        //ALARM
        private void button1_Click(object sender, EventArgs e)
        {
            co30 = 0;
            do30 = 0;
            label3.Text = "00:00";
            timer_alarm2.Stop();
            button1.BackColor = Color.White;
            timer_alarm1.Start();
        }

        //Aktywuje (akceptuje) ilosc wentylatorow usuwa komunikat
        int dokomunikatu = 1;
        private void button2_Click(object sender, EventArgs e)
        {
            dokomunikatu = 1;
            wentylator(wentylatory);
            komunikat.Text = "";


        }
        //zwraca komunikat kiedy sugerowana ilosc wentylatorow nie ulegla zmianie lub jest rzadanie komunikatu
        int back;
        private void timer_wentylatory_Tick(object sender, EventArgs e)
        {
            if(dokomunikatu == 1 || wentylatory != back)
            {
                komunikat.Text = "Komunikat:\t\n Przegrzanie. Dostosuj ilość wentylatorów. \t\n Naciśnij: 'Akceptuj' ";
                dokomunikatu = 0;
                back = wentylatory;
            }else
            {
                komunikat.Text = "";
            }
        
        }
        

    }
}
