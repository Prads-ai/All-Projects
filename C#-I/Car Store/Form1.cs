using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_Store
{
    public partial class presentationForm : Form
    {
        Store s = new Store();
        BindingSource carInventoryBindingSource = new BindingSource();
        BindingSource carShoppingBindingSource = new BindingSource();
        public presentationForm()
        {
            InitializeComponent();
        }

        private void carClassBtn_Click(object sender, EventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // take the value of all the textbox
            string make, model = "";
            double price = 0.0;

            make = txt_make.Text;
            model = txt_model.Text;
            price = int.Parse(txt_price.Text);

            // Create a car object
            Car c = new Car(make,model,price);
            s.store.Add(c);
            carInventoryBindingSource.ResetBindings(false);
            // Add it to the lisbox components
            carInventoryBindingSource.DataSource = s.store;
            lb_cars.DataSource = carInventoryBindingSource;
            lb_cars.DisplayMember = ToString();

            carShoppingBindingSource.DataSource = s.shopping;
            ls_cart.DataSource = carShoppingBindingSource;
            ls_cart.DisplayMember = ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Car selected = (Car)lb_cars.SelectedItem;
            s.shopping.Add(selected);
            carShoppingBindingSource.ResetBindings(false);
        }

        private void btn_checkout_Click(object sender, EventArgs e)
        {
            double total = s.Checkout();
            lblPrice.Text = total.ToString();
        }
    }
}
