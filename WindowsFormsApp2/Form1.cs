using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            double[] numbers = new double[10]; // We create an array which can have maximum 10 numbers in it
            double total = 0;
            double average = 0;
            Random ramdomnumber = new Random();
            for (int i = 0; i < numbers.Length; i++) // We adding random numbers to our numbers array You can add these numbers by your hand to calculate variance
            {
               
                int myrandom = ramdomnumber.Next(0, 100);
                textBox1.Text += myrandom.ToString() + ",";
                numbers[i] = myrandom;
                //  We had Array which contains random numbers between 0-100 .
                // To calculate variance we need to find the average of these numbers.
              total += myrandom;


            }
            average = total / numbers.Length;
            // "average"  contains the average of these numbers by using total / N formula
            // we need to find the diffrence of each numbers from average.
            double totalfarks = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                // numbers array now contains the differances.
                double fark = average - numbers[i];
                numbers[i] = fark;
                double squreofnumber = Math.Pow(fark, 2);
                totalfarks += squreofnumber;

            }
            //  To calculate variance we calculated the square of these differances
            // Need to divide to N-1 to calculate variance
       

            double variance = totalfarks / (numbers.Length - 1); // toplam farkı elemansaysının bir eksiğine bldüm.
            Console.WriteLine(variance); // in variance variable we got the variance. if we calculate square root of variance we can find the standard deviation
            double standarddeviation = Math.Sqrt(variance);
            label2.Text = variance.ToString();
            label4.Text = standarddeviation.ToString();


        }
    }
}
