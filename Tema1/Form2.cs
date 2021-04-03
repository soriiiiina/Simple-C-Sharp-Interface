using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tema1
{
    public partial class Form2 : Form
    { public static int strt = 7; 

        private void timer1_Tick(object sender, System.EventArgs e)
        {
            strt = strt - 1;
            textBox3.Text = strt.ToString();

            if(strt == 0)
            {
                textBox3.Text = strt.ToString();
                timer1.Enabled = false;
                textBox1.ReadOnly = true;
                MessageBox.Show("You Lost!");
            }
           
        }

        public Form2()
        {   
            InitializeComponent();
            textBox2.Text = "This is a boring game!";
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            timer1.Tick += new EventHandler(timer1_Tick);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        //Start button 
        private void Button1_Click(object sender, EventArgs e)
        {
            strt = 7; 
            textBox3.Text = strt.ToString();
            timer1.Enabled = true;

        }

        //Stop Button 
        private void Button2_Click(object sender, EventArgs e)
        {   Console.WriteLine(timer1.Interval);
            String correctanswer = textBox1.Text;

            if (correctanswer == textBox2.Text)
            {
                timer1.Enabled = false;
                MessageBox.Show("You won!" + "\n" + "Your time: " + strt + " seconds");
            }

            else
            {
                MessageBox.Show("Incorrect text!");
            } 
        }

        //Exit button 
        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
