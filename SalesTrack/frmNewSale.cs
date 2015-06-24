using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SalesTrack
{    //created by Trenton Thompson
    public partial class frmNewSale : Form
    {
        public frmNewSale()
        {
            InitializeComponent();
        }

        private Sale sale = null;
// below this method calls GetNewSale from the frmNewSaleManager and displays the NewSale as the dialog box.
        public Sale GetNewSale()
        {
            this.ShowDialog();
            return sale;
        }
        // below is the method that is used when user click the save button, the if loop calls the ISValidData method that calls the IsPresent method from the validator class
        // to check to see if data entered is valid and if valid new code, description and price are saved.
        private void btnSave_Click(object sender, System.EventArgs e)
        {
            if (IsValidData())
            {
                sale = new Sale(txtCode.Text,txtDescription.Text, Convert.ToDecimal(txtPrice.Text));
                this.Close();
            }
        }
        // This is the IsValidData method that calls methods used to validate data entered from the validator class.
        private bool IsValidData()
        {          
            return Validator.IsPresent(txtCode)  &&
                   Validator.IsPresent(txtDescription)  &&
                   Validator.IsPresent(txtPrice) &&
                   Validator.IsDecimal(txtPrice);
        }
        // This closes the dialog box when clicked
        private void btnCancel_Click(object sender, System. EventArgs e)
        {
            this.Close();
        }
        // these methods were created by accident when debug test mode.
        private void txtItem_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtItem_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void frmNewEntry_Load(object sender, EventArgs e)
        {

        }
         
        
        }
    }