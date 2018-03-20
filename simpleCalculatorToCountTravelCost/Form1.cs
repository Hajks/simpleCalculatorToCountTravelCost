using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simpleCalculatorToCountTravelCost
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int startingMileage;
        int endingMileage;
        double milesTraveled;
        double mileCost = 0.39;
        double totalAmount;
        private void button1_Click(object sender, EventArgs e)
        {
            startingMileage = (int) startNumber.Value;
            endingMileage = (int) endNumber.Value;
            if (endingMileage > startingMileage)
            { 
            milesTraveled = endingMileage - startingMileage;
            totalAmount = mileCost * milesTraveled;
            amountToReturn.Text = totalAmount + " zł.";
            }
            else
            {
                MessageBox.Show("Początkowy stan licznika musi być mniejszy od końcowego.");
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = milesTraveled.ToString() + " km" ;
        }
    }
}
