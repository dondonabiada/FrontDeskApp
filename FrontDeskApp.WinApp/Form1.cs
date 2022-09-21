using FrontDeskApp.Entities;
using FrontDeskApp.Data;
using Microsoft.EntityFrameworkCore;
using FrontDeskApp.Context;
using FrontDeskApp.WinApp.Helpers;

namespace FrontDeskApp.WinApp
{

    public partial class Form1 : Form
    {
        protected List<AreaBox> AreaBoxes { get; set; }
        protected AreaBoxRepository AreaBoxesRepo { get; set; }

        protected CustomerRepository Customers { get; set; }
        protected FrontDeskAppDbModel Context { get; set; }

        protected TransactionRepository Transactions { get; set; }

        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            this.RefreshData();
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            frmAddCustomer frmAdd = new();
            frmAdd.ShowDialog();
        }

        public void RefreshCustomers()
        {
            dgCustomers.DataSource = Customers.GetAll().ToList();
        }

        public void RefreshData()
        {
            Context = new FrontDeskAppDbModel();
            AreaBoxes = new List<AreaBox>();
            AreaBoxesRepo = new AreaBoxRepository(Context);
            Customers = new CustomerRepository(Context);
            Transactions = new(Context);
            
            bindingSource1.DataSource = null;
            bindingSource1.DataSource = Transactions.GetAll().ToList().OrderByDescending(D => D.DateStored);
            dgStorageArea.DataSource = bindingSource1;
            dgStorageArea.Columns["DateStored"].SortMode = DataGridViewColumnSortMode.Automatic;
            dgStorageArea.Columns["DateRetrieved"].SortMode = DataGridViewColumnSortMode.Automatic;
            dgStorageArea.Columns["TransactionId"].Visible = false;
            dgStorageArea.Columns["CustomerId"].Visible = false;
            dgStorageArea.Columns["AreaBoxId"].Visible = false;
            dgStorageArea.Columns["Customer"].Visible = false;
            dgStorageArea.Columns["AreaBox"].Visible = false;


            dgCustomers.DataSource = Customers.GetAll().ToList();
            dgCustomers.Columns[dgCustomers.Columns.Count - 1].Visible = false;

            bindingSource2.DataSource = null;
            bindingSource2.DataSource = AreaBoxesRepo.GetAll().ToList();
            dgAreaBoxes.DataSource = bindingSource2;
            dgAreaBoxes.Columns[1].Visible = false;
            dgAreaBoxes.Columns[5].Visible = false;

            lblSmall.Text = AreaBoxesRepo.SmallCount();
            lblMedium.Text = AreaBoxesRepo.MediumCount();
            lblLarge.Text = AreaBoxesRepo.LargeCount();

        }
        private void Form1_Activated(object sender, EventArgs e)
        {
            if (Global.DataUpdated)
            {
                this.RefreshData();
                Global.DataUpdated = false;
            }

        }

        private void btnStoreBox_Click(object sender, EventArgs e)
        {
            frmStoreBox frmStore = new();
            frmStore.ShowDialog();
            Global.DataUpdated = true;
            this.RefreshData();
        }

        private void btnRetrieve_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Retrieve the box?", "Retrieve Box", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Transaction transaction = (Transaction)bindingSource1.Current;
                transaction.Status = "RETRIEVED";
                transaction.AreaBox = AreaBoxesRepo.GetByKey(transaction.AreaBoxId);
                if (transaction.AreaBox is not null)
                {
                    transaction.AreaBox.Status = "VACANT";
                }
                transaction.DateRetrieved = DateTime.Now;
                Context.SaveChanges();
                Global.DataUpdated = true;
                this.RefreshData();
            }
        }



        private void dgStorageArea_SelectionChanged(object sender, EventArgs e)
        {
            Transaction transaction = (Transaction)bindingSource1.Current;
            if (transaction is not null)
            {
                if (transaction.Status.Trim() == "STORED")
                    btnRetrieve.Enabled = true;
                else
                    btnRetrieve.Enabled = false;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.RefreshData();
        }

       

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}