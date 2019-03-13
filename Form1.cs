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
    public partial class Form1 : Form
    {
        //timer
        public Form1()
        {
            //timer interval
            t.Interval = 1000; //in milliseconds
            t.Tick += new EventHandler(this.t_Tick);
            InitializeComponent();
            t.Start();

        }

        //przycisk zaloguj
        private void Zaloguj_Click(object sender, EventArgs e)
        {
         
                     if(polehaslo.Text == "1234" && ( poleID.Text == "1" || poleID.Text == "2" || poleID.Text == "3"))
                     {
                        this.label1.BackColor = Color.White;
                        this.Hide();
                        Proces page = new Proces();
                        page.Show();
            
                          
                     }
                        else
                        {
                            
                            this.label3.BackColor = Color.Red;
                            this.label1.BackColor = Color.Red;
                        }                
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
          Timer t = new Timer();  
        
      
        public int x = DateTime.Now.Second;
        ////timer evenhander
        private void t_Tick(object sender, EventArgs e)
        {
            //get current time 
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;

            //time
            string time = "";

            //padding leading zero

            if(hh<10)
            {
                time +="0" + hh;
            }
            else
            {
                time += hh;
            }

            time += ":";

            if (mm < 10)
            {
                time += "0" + mm;
            }
            else
            {
                time += mm;
            }

            time += ":";

            if (ss < 10)
            {
                time += "0" + ss;
            }
            else
            {
                time += ss;
            }

            int klik = ss;

        //    //Update label4
            label4.Text = time;

       }

        

    }
}
