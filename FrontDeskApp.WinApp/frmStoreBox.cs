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
using FrontDeskApp.WinApp.Helpers;

namespace FrontDeskApp.WinApp
{
    public partial class frmStoreBox : Form
    {
        protected FrontDeskAppDbModel context { get; set; }

        protected CustomerRepository customers { get; set; }

        protected AreaBoxRepository areas { get; set; }

        protected List<AreaBox> areaBoxes { get; set; }

        protected TransactionRepository transactions { get; set; }  

        public frmStoreBox()
        {
            InitializeComponent();
            context = new FrontDeskAppDbModel();
            customers = new CustomerRepository(context);
            areas = new(context);
            transactions = new(context);    
        }

        private void frmStoreBox_Load(object sender, EventArgs e)
        {
            LoadCustomers();
            //areaBoxes = areas.All().ToList();
        }

        private void btnStore_Click(object sender, EventArgs e)
        {
            Transaction transaction = new Transaction();
            transaction.CustomerId = (int)Customers.SelectedValue;
            transaction.AreaBoxId = (int)StorageBoxes.SelectedValue;
            transaction.DateStored = DateTime.Now;
            transaction.Status = "STORED";
            transaction.AreaBox = areaBoxes.FirstOrDefault(e => e.AreaBoxId == (int)StorageBoxes.SelectedValue);
            if(transaction.AreaBox is not null)
            {
                transaction.AreaBox.Status = "OCCUPIED";
            }
            transactions.Add(transaction);
            context.SaveChanges();
            Global.DataUpdated = true;
            this.Close();
        }

        private void LoadCustomers()
        {
            Customers.DataSource = customers.GetAll().ToList();
            Customers.ValueMember = "CustomerId";
            Customers.DisplayMember = "FirstName";
        }

        private void BoxTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedArea = (string)BoxTypes.SelectedItem;
            areaBoxes = areas.GetVacantBySize(selectedArea).ToList<AreaBox>();
            if(areaBoxes.Count == 0)
            {
                MessageBox.Show("No available boxes to store your package.");
                btnStore.Enabled = false;
                return;        
            }
            else
            {
                StorageBoxes.DataSource = areaBoxes;
                StorageBoxes.ValueMember = "AreaBoxId";
                StorageBoxes.DisplayMember = "Name";
                btnStore.Enabled = true;
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
