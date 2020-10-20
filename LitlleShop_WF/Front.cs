using LilleShopOOP;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LittleShop_CL;

namespace LitlleShop_WF
{
    public partial class Front : Form
    {
        List<Customer> customers = new List<Customer>();
        MakeOrder order = new MakeOrder();
        public Front()
        {
            InitializeComponent();
            
        }
        private void Front_Load(object sender, EventArgs e)
        {
            //listViewCustomer.Columns.Add("Kundenavn", 100);
            

        }

        private void SubmitCustomerBtn_Click(object sender, EventArgs e)
        {
            
            
            try
            {
                Customer newCustomer = new Customer(FirstNameTXT.Text, LastNameTXT.Text, EmailTXT.Text);
                MessageLabel.Text = newCustomer.ToString();
                customers.Add(newCustomer);
                LastNameTXT.Text = "";
                FirstNameTXT.Text = "";
                EmailTXT.Text = "";

            }
            catch (Exception ex)
            {

                ErrorLabel.Text = ex.Message;
            }
            
        }

        private void DeleteCustomerBtn_Click(object sender, EventArgs e)
        {
            int indexOfCustomer = customers.FindIndex(x => x.LastName == DeleteTXT.Text);
            MessageLabel.Text = customers[indexOfCustomer].DeletedCustomer();
            
            customers.RemoveAt(indexOfCustomer);
        }

        private void ShowCustomersBtn_Click(object sender, EventArgs e)
        {
            FluidItem fluidItem = new FluidItem("kande", "Description", 5.00, 1);
            //M

        }
        public void LoadList()
        {

        }

    }
}
