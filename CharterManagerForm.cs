/*
 * Project:         Assignment Set 7 - Program 16
 * Date:            November 5 2022
 * Developed By:    Gsmh Yang
 * Class Name:      Charter manager
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace GYangProgram16
{
    public partial class CharterManagerForm : Form
    {
        public CharterManagerForm()
        {
            InitializeComponent();
        }

        #region "Add Charter button click"
        // declare a class/module level variable of type CharterManager
        private CharterManager aCharterManager;
        private void btnAddCharter_Click(object sender, EventArgs e)
        {
            // declare local (i.e., method-level) variables
            string customerName;
            string yachtType;
            int yachtSize, charterHours;

            //validates the input data
            if (txtName.Text == string.Empty)
            {
                MessageBox.Show("Customer Name is required", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return;
            }

            if (cboYachtType.SelectedIndex == -1)
            {
                MessageBox.Show("Yacht Type is required", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboYachtType.Focus();
                return;
            }

            if (cboYachtSize.SelectedIndex == -1)
            {
                MessageBox.Show("Yacht Size is required", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboYachtSize.Focus();
                return;
            }

            
            // assign input data to variables

            customerName = txtName.Text;
            yachtType = cboYachtType.Text;
            yachtSize = Convert.ToInt32(cboYachtSize.Text);
            charterHours = Convert.ToInt32(nudCharterhour.Value);

            // if it is not already instantiated, instantiate aCharterManager 

            if (aCharterManager is null)
            {
                aCharterManager = new CharterManager();
            }

            // instantiate charter object and add it to the CharterList collection
            aCharterManager.AddCharter(customerName, yachtType, yachtSize, charterHours);
            
            // display confirmation

            MessageBox.Show("Charter added", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // disable Add button

            btnAddCharter.Enabled = false;

            // enable the display menu items

            allChartersToolStripMenuItem.Enabled = true;
            numberOfChartersForaYachtSizeToolStripMenuItem.Enabled = true;
            chartersSummaryToolStripMenuItem.Enabled = true;

            btnAddCharter.Enabled = false;
        }
        #endregion

        #region "All Charter menu click"
        //Event handler to All Charter click in Menu.
        private void allChartersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AllCharterForm aForm = new AllCharterForm();
            aForm.CharterManagerbindingSource.DataSource = aCharterManager;
            aForm.ShowDialog();
        }
        #endregion

        #region "Number of Charters for a Yacht size"
        //Event click for Charter summary
        private void numberOfChartersForaYachtSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Test if select a size or not
            if (cboYachtType.SelectedIndex == -1)
            {
                MessageBox.Show("select Charter Size", "input error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Get the size info and calculate the counts.
            int aSize = Convert.ToInt32(cboYachtSize.Text);
            int result = aCharterManager.GetCharterCount(aSize);

            //Output the data
            string message = $"There is/are {result} Charter(s) for a size of {aSize} yacht";
            MessageBox.Show(message, "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion

        #region "Button click for Charter summary"
        //The event handler for button click for Charter summary
        private void chartersSummaryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChartersSummaryForm aForm = new ChartersSummaryForm();
            aForm.lblLowestFee.Text = aCharterManager.FindLowestCharterFee().ToString("c2");
            aForm.lblTotalFee.Text = aCharterManager.GetTotalCharterFees().ToString("c2");
            aForm.lblAverageFee.Text = aCharterManager.GetAverageCharterFee().ToString("c2");
            
            aForm.ShowDialog();
        }
        #endregion

        #region "Exit click"
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region "Reset button"
        //event handler for reset button click.
        private void resetForNextYachtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //resst input areas.
            txtName.Text = string.Empty;
            cboYachtType.SelectedIndex = -1;
            cboYachtSize.SelectedIndex = -1;
            nudCharterhour.Value = nudCharterhour.Minimum;

            txtName.Focus();

            //Disable the functions
            allChartersToolStripMenuItem.Enabled = false;
            numberOfChartersForaYachtSizeToolStripMenuItem.Enabled = false;
            chartersSummaryToolStripMenuItem.Enabled = false;

            //Enable the Add button.
            btnAddCharter.Enabled = true;
        }
        #endregion

        #region "Add Yacht Type"

        //Event handler to Add Yacht Type click
        private void addYachtTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Check if  there is a input for a new yacht type
            if (cboYachtType.Text == string.Empty)
            {
                MessageBox.Show("Enter a new yacht type", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboYachtType.Focus();
                return;
            }

            //assign the new Type to be added to a variable
            string newType = cboYachtType.Text;
            // duplication indicator 
            bool duplicate = false; 

            //a foreach loop to iterate through the items in the list and check for potential duplication

            foreach (string aType in cboYachtType.Items) 
            {
                if (string.Equals(newType, aType, StringComparison.OrdinalIgnoreCase)) //ignoring case, compare each member in the list to the member to be added
                {
                    duplicate = true; //if the type already exists in the list, set duplication indicator to true
                    break;
                }
            }

            if (duplicate)  //if duplicate is true, new Type is not added
            {
                MessageBox.Show("This Type is not added", "Duplicate member", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboYachtType.Text = string.Empty;
            }
            else  
            {
                TextInfo aTextInfo = new CultureInfo("en-US", false).TextInfo; //create a CultureInfo object and get its TextInfo property

                newType = aTextInfo.ToTitleCase(newType); //change the name of the new Type to be added to proper case

                cboYachtType.Items.Add(newType); //add the new Type to the list
                MessageBox.Show("New member added", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboYachtType.Text = string.Empty;
            }
        }

        #endregion

        #region "Add Yacht Type"
        //Event handler to remove a type"
        private void removeYachtTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Check if a type is selected for removing or not
            if (cboYachtType.Text == string.Empty)
            {
                MessageBox.Show("Select a yacht type to remove", "Missing Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboYachtType.Focus();
                return;
            }

            //assign the Type to be removed to a variable
            String removeType = cboYachtType.Text;

            // remove the Type
            cboYachtType.Items.Remove(removeType); 
            MessageBox.Show("Slected Type was removed", "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cboYachtType.Text = string.Empty;
        }
        #endregion
    }
}
