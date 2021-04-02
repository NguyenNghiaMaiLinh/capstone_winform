using dental_sys.model;
using dental_sys.service;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using dental_sys.Constants;

namespace dental_sys
{
    public partial class Loading : Form
    {
        public PagingModel<CustomerModel> Customers { get; set; }

        //public ICollection<Customer> data { get; set; }
        public Loading()
        {
            var customerRepository = new CustomerService();
            Task.Run(() => Customers = customerRepository.GetAllCustomers(PagingConstant.PageIndex, PagingConstant.PageSize));
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (guna2CircleProgressBar1.Value == 100)
            {
                if (Customers != null)
                {
                    timer1.Stop();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    guna2CircleProgressBar1.Value = 0;
                    label_val.Text = "0";
                }

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
