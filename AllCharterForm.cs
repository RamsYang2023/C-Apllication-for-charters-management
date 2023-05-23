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
using System.Text;
using System.Windows.Forms;

namespace GYangProgram16
{
    public partial class AllCharterForm : Form
    {
        public AllCharterForm()
        {
            InitializeComponent();
        }

        //Close button click event
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
