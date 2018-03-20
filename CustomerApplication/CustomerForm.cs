using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CustomerApplication
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();
        }

        private void AllCustomersButton_Click(object sender, EventArgs e)
        {
            using (CustomerAddressEntities dbContext = new CustomerAddressEntities())
            {
                var allCustomers = from cust in dbContext.Customers
                                   join cuad in dbContext.CustomerAddresses on cust.CustomerID equals cuad.CustomerID
                                   join addr in dbContext.Addresses on cuad.AddressID equals addr.AddressID
                                   orderby cust.FirstName
                                   select new
                                   {
                                       cust.Title,
                                       cust.FirstName,
                                       cust.MiddleName,
                                       cust.LastName,
                                       cust.CompanyName,
                                       cust.SalesPerson,
                                       cust.EmailAddress,
                                       cust.Phone,
                                       cuad.AddressType,
                                       addr.AddressLine1,
                                       addr.AddressLine2,
                                       addr.City,
                                       addr.StateProvince,
                                       addr.CountryRegion,
                                       addr.PostalCode
                                   };
                CustomersGridView.DataSource = allCustomers.ToList();
                SetGridColumnHeaders();
            }
        }

        private void CanadianCustomersButton_Click(object sender, EventArgs e)
        {
            using (CustomerAddressEntities dbContext = new CustomerAddressEntities())
            {
                var allCustomers = from cust in dbContext.Customers
                                   join cuad in dbContext.CustomerAddresses on cust.CustomerID equals cuad.CustomerID
                                   join addr in dbContext.Addresses on cuad.AddressID equals addr.AddressID
                                   where addr.CountryRegion == "Canada"
                                   orderby cust.CompanyName
                                   select new
                                   {
                                       cust.Title,
                                       cust.FirstName,
                                       cust.MiddleName,
                                       cust.LastName,
                                       cust.CompanyName,
                                       cust.SalesPerson,
                                       cust.EmailAddress,
                                       cust.Phone,
                                       cuad.AddressType,
                                       addr.AddressLine1,
                                       addr.AddressLine2,
                                       addr.City,
                                       addr.StateProvince,
                                       addr.CountryRegion,
                                       addr.PostalCode
                                   };
                CustomersGridView.DataSource = allCustomers.ToList();
                SetGridColumnHeaders();
            }
        }

        private void SetGridColumnHeaders()
        {
            CustomersGridView.Columns["FirstName"].HeaderText = "First Name";
            CustomersGridView.Columns["MiddleName"].HeaderText = "Middle Name";
            CustomersGridView.Columns["LastName"].HeaderText = "Last Name";
            CustomersGridView.Columns["CompanyName"].HeaderText = "Company Name";
            CustomersGridView.Columns["SalesPerson"].HeaderText = "Sales Person";
            CustomersGridView.Columns["EmailAddress"].HeaderText = "Email";
            CustomersGridView.Columns["AddressType"].HeaderText = "Address Type";
            CustomersGridView.Columns["AddressLine1"].HeaderText = "Address Line 1";
            CustomersGridView.Columns["AddressLine1"].HeaderText = "Address Line 1";
            CustomersGridView.Columns["StateProvince"].HeaderText = "Province";
            CustomersGridView.Columns["CountryRegion"].HeaderText = "Country";
            CustomersGridView.Columns["PostalCode"].HeaderText = "Postal Code";
        }
    }
}