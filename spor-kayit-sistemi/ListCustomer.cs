using spor_kayit_sistemi.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace spor_kayit_sistemi
{
    public partial class ListCustomer : Form
    {
        public ListCustomer()
        {
            InitializeComponent();
        }

        private void ListCustomer_Load(object sender, EventArgs e)
        {
            List<Customer> customerList = new List<Customer>();
            customerList.Add(new Customer("doğukan", "karasansar", "13342342123", "sdadadad", "14.07.2002", "05340741203", "05.11.2021", "05.12.2021", 100, "kredi kartı", "34431234512", 4 ));
            customerList.Add(new Customer("damla", "sekmen", "13342342123", "sdadadad", "14.07.2002", "05340741203", "05.11.2021", "05.12.2021", 100, "kredi kartı", "34431234512", 4));
            customerList.Add(new Customer("esra", "aybar", "13342342123", "sdadadad", "14.07.2002", "05340741203", "05.11.2021", "05.12.2021", 100, "kredi kartı", "34431234512", 4));

            foreach (Customer customer in customerList)
            {
                Console.WriteLine(customer.Name + " " + customer.Surname);
            }
        }
    }
}
