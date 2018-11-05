using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week7pjt
{
    public partial class TempConverter : Form
    {
        public TempConverter()
        {
            InitializeComponent();
        }

        private void btnCalculator_Click(object sender, EventArgs e)
        {
            //Input in Celsius
            double temperature = Convert.ToDouble(txtInput.Text);

            //Convert to Fahrenheit(temperature Celsius  *1.8) +32
            double convertedTemperature = Convert.ToDouble(temperature * 1.8) + 32;
            string outputTemp = Convert.ToString(convertedTemperature);





            //Decision about weather

            if (convertedTemperature >= 70)
            {
                lbloutput.Text = "it is " + convertedTemperature + " its warm ";
                btnCalculator.BackColor = Color.Red;
                btnCalculator.ForeColor = Color.Yellow;
            }

            if (convertedTemperature < 70)

            {
                lbloutput.Text = "It is " + convertedTemperature + " its Cool ";
                btnCalculator.BackColor = Color.LightBlue;
                btnCalculator.ForeColor = Color.White;
            }

            if (convertedTemperature <= 32)

            {
                lbloutput.Text = "it is " + convertedTemperature + " its cold ";
                btnCalculator.BackColor = Color.DarkBlue;


            }
        }
    }

}



            //Output

            //lbloutput.Text = "Your Tempture is " + convertedTemperature; 

         

     
   
