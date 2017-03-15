using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PortionCalculator
{
    public partial class PortionCalculator : Form
    {
        #region Variables

        double inMeasurement;
        double inOldMultiplier;
        double inNewMultiplier;
        double outputNumber;
        String outputString;

        #endregion

        public PortionCalculator()
        {
            InitializeComponent();
        }

        #region Allow only numbers in the textboxes

        private void Measurement_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumWithDecimal(sender, e);
        }

        private void OldMultiplier_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumWithDecimal(sender, e);
        }

        private void NewMultiplier_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumWithDecimal(sender, e);
        }

        private void OutputBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            NumWithDecimal(sender, e);
        }

        public void NumWithDecimal(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '.'))
            {
                e.Handled = true;
            }
            TextBox txtDecimal = sender as TextBox;
            if (e.KeyChar == '.' && txtDecimal.Text.Contains("."))
            {
                e.Handled = true;
            }
        }

        #endregion

        private void GoButton_Click(object sender, EventArgs e) // Listen for when the GoButton is clicked
        {
            if (Measurement.Text != "" || OldMultiplier.Text != "" || NewMultiplier.Text != "") // Make sure the input boxes arent empty
            {
                inMeasurement = double.Parse(Measurement.Text); // Convert to a double
                inOldMultiplier = double.Parse(OldMultiplier.Text); // Convert to a double
                inNewMultiplier = double.Parse(NewMultiplier.Text); // Convert to double

                outputNumber = inMeasurement * inNewMultiplier / inOldMultiplier; // Times the first box by the second box, then divide by the third box
                
                outputNumber = Math.Round(outputNumber, 2); // Round the number to two decimal places
                outputString = Convert.ToString(outputNumber); // Convert the number back into a string
                OutputBox.Text = outputString; // Display the string
            }
        }
    }
}