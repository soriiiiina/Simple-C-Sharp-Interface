using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; 

namespace Tema1
{

    public partial class Form1 : Form
    {
        private string[] _fileLines;
        private string _pathFile = "riddles.txt";
        private static int _index = 0;
        public Form1()
        {
            InitializeComponent();

            //Creating & putting the riddles into the file 
            StreamWriter streamWriter = new StreamWriter("riddles.txt", true);
            streamWriter.WriteLine("Q: Numele meu"); 
            streamWriter.WriteLine("Sorina"); 
            streamWriter.WriteLine("Q: Prenumele meu"); 
            streamWriter.WriteLine("Suciu");
            streamWriter.WriteLine("Q: Presedinte"); 
            streamWriter.WriteLine("Klaus");
            streamWriter.Close();
            
            //making the progress bar visible 
            pBar1.Visible = true;

            //setting minimum, maximum & step  
            pBar1.Minimum = 1;
            pBar1.Maximum = 4;
            pBar1.Step = 1;

            textBox2.Text = "Press 'Start' to start the game";
            button2.Text = "Start";

            //Geeting all the lines in the file 
            _fileLines = File.ReadAllLines(_pathFile); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {   
        }

        //Verify button 
        private void Button1_Click(object sender, EventArgs e)
        {
            String correctanswer = _fileLines[_index+1];    
            string answer = textBox1.Text;
            if (answer == correctanswer)
            {
                pBar1.PerformStep();
                _index = _index + 2;
                textBox2.Text = _fileLines[_index];
                textBox1.Text = String.Empty; 

                if (_index == 6)
                {
                    MessageBox.Show("You Won. Close this window and press 'Next game'");
                    textBox1.Text = String.Empty; 
                }
            }
            else
                MessageBox.Show("Try another word");

        }

        
        //Start-Next button 
        private void Button2_Click(object sender, EventArgs e)
        {
            
            Console.WriteLine(_fileLines[_index] + " : " + _fileLines[_index+1]);
            textBox2.Text = _fileLines[_index];
        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Button3_Click(object sender, EventArgs e)
        {

            Form2 secondForm = new Form2();
            secondForm.Show();
            secondForm.Text = "Spelling contest";
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
