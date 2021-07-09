using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab1_A
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //creats a method that sets the output
        private void setOutput(decimal input)
        {
            output.Text = input.ToString("f");
        }
        //creates a method to clear text boxes
        private void clear()
        {
            input.Text = "";
            output.Text = "";
        }
        //convert to F button
        private void button1_Click(object sender, EventArgs e)
        {
            decimal tempF;
            decimal tempC;
            try{
                if (decimal.TryParse(input.Text, out tempC))
                {
                    //math to convert to Celsuis
                    tempF = (tempC * 9 / 5  ) + 32;
                    //calls the set output method
                    setOutput(tempF);

                }
                //notifies user if data is invalid
                else
                {   //notifies user if input is invalid and clears text boxes
                    MessageBox.Show("please enter a valid decimal temp", "ERROR");
                    clear();
                }
            }
            catch(Exception ex)
            {
                //notifies user if another error occures and clears text boxes
                MessageBox.Show("An error has occurd :c please try again");
                MessageBox.Show(ex.Message);
                clear();
            }
        }
        //exit button
        private void button3_Click(object sender, EventArgs e)
        {
            clear();
            this.Close();
        }
        //convert to C button
        private void cnvrtC_Click(object sender, EventArgs e)
        {
            decimal tempF;
            decimal tempC;
            try
            {
                if (decimal.TryParse(input.Text, out tempF))
                {
                    //math to convert to Celsuis
                    tempC = (tempF - 32) * 5 / 9 ;
                    //calls the set output method
                    setOutput(tempC);

                }
                //notifies user if data is invalid
                else
                {
                    MessageBox.Show("please enter a valid decimal temp", "ERROR");
                    clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error has occurd :c please try again");
                MessageBox.Show(ex.Message);
                clear();
            }
        }
    }
}
