using dental_sys.model;
using dental_sys.service;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dental_sys
{
    public partial class Loading : Form
    {
        public static ICollection<Customer> data = null;
        //public ICollection<Customer> data { get; set; }
        CustomerService customerRepository = new CustomerService();
        public Loading()
        {
            _ = Task.Run(() => { data = customerRepository.getAllCustomers(1, 20, null); });
            InitializeComponent();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (guna2CircleProgressBar1.Value == 100)
            {
                timer1.Stop();
                Principal p = new Principal();
                p.Show();
                this.Hide();

            }
            else
            {
                guna2CircleProgressBar1.Value += 1;
                label_val.Text = (Convert.ToInt32(label_val.Text) + 1).ToString();
            }
        }

        private void Loading_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            timer1.Start();
        }
    }
}
