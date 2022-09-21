using FrontDeskApp.Context;
using FrontDeskApp.Data;
using FrontDeskApp.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrontDeskApp.WinApp
{
    public partial class frmAddCustomer : Form
    {
        protected CustomerRepository Customers { get; set; }
        protected FrontDeskAppDbModel context { get; set; }

        public frmAddCustomer()
        {
            InitializeComponent();
            context = new FrontDeskAppDbModel();
            Customers = new CustomerRepository(context);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var customer = new Customer();
            customer.FirstName = txtFirstName.Text;
            customer.LastName = txtLastName.Text;
            customer.PhoneNumber = txtPhoneNo.Text;
            Customers.Add(customer);
            context.SaveChanges();
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
