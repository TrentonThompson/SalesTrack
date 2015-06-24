using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SalesTrack
{              // Created by Trenton Thompson
    public partial class frmNewSaleManager : Form
    {
        public frmNewSaleManager()
        {
            InitializeComponent();
        }
        //Below a class variable Sale is assigned to a list type and encapsulated.
        private List<Sale> sales = null;
        //Below GetSales method of SaleDB is called to fill sales into the list box. frmNewSaleManager_load is a load event handler for this class.
		private void frmNewSaleManager_Load(object sender, System.EventArgs e)
		{
			sales = SaleDB.GetSales();
			FillSaleListBox();
		}
        //Below this method uses a foreach loop to add the string returned by each of the sales GetDisplayText method to the salelistbox.
        //Tab is used in the parameter to display each sale by line.
		private void FillSaleListBox()
		{
			lstSales.Items.Clear();
			foreach (Sale s in sales)
			{
				lstSales.Items.Add(s.GetDisplayText("\t"));
			}
		}
        // Below this method is used when user clicks add button creating an instance of the sale.
        // The if loop checks to see if the method is null and if not null the method adds the sale to the sale listbox.
		private void btnAdd_Click(object sender, System.EventArgs e)
		{
			frmNewSale newSaleForm = new frmNewSale();
			Sale sale = newSaleForm.GetNewSale();
			if (sale != null)
			{
				sales.Add(sale);
				SaleDB.SaveSales(sales);
				FillSaleListBox();
			}
		}
        //Below this method is used when user clicks delete button, a confirmation dialog is displayed.
        // If user confirms the sale is removed from the sale list. 2 if loops are used.
		private void btnDelete_Click(object sender, System.EventArgs e)
		{
			int i = lstSales.SelectedIndex;
			if (i != -1)
			{
				Sale sale = (Sale)sales[i];
				string message = "Are you sure you want to delete "
					+ sale.Description + "?";
				DialogResult button =
					MessageBox.Show(message, "Confirm Delete",
					MessageBoxButtons.YesNo);
				if (button == DialogResult.Yes)
				{
					sales.Remove(sale);
					SaleDB.SaveSales(sales);
					FillSaleListBox();
				}
			}
		}
        //this method closes the application.
		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
        //These methods were created by accident when I clicked the buttons and listsalebox during a test debug session. 
        // They are still here to remind me not to do that in the future. There is no function applied to these methods.
        private void lstSales_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {

        }

        private void frmNewSaleManager_Load_1(object sender, EventArgs e)
        {

        }
	}
}