using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;




namespace Glücksrad
{
    public partial class Form1 : Form
    {
        private bool hasStarted = true;
        public Form1()
        {
            InitializeComponent();
        }
         
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
       

        private void button1_Click(object sender, EventArgs e)
        {

            string[] Eingabe = textBox1.Text.Split('\n');
            int Obergrenze = Eingabe.Length;
            int intuntergrenze = 0;
            int randomzahl;
            
            
            if (!hasStarted)
            {
                hasStarted = true;
                button1.Text = "Stop";



                while (hasStarted == true)
            {
                Random objzufallszahl = new Random();

                randomzahl = objzufallszahl.Next(intuntergrenze, Obergrenze);

                textBox2.Text = Eingabe[randomzahl];
                Application.DoEvents();

            }
            }
            else
            {
                hasStarted = false;
                button1.Text = "Start";
            }

        }

    }
}
