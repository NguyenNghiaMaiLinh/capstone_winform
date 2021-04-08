using dental_sys.model;
using dental_sys.service;
using System;
using System.Windows.Forms;

namespace dental_sys.view
{
    public partial class Profile : Form
    {
        private readonly CustomerService _customerService;
        public CustomerModel Customer { get; set; }

        public Profile()
        {
            _customerService = new CustomerService();
            InitializeComponent();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            try
            {
                
                if (!string.IsNullOrEmpty(Customer?.Url))
                {

                    //var request = WebRequest.Create(Customer.Url);

                    //using (var response = request.GetResponse())
                    //using (var stream = response.GetResponseStream())
                    //{
                    Avatar.LoadAsync(Customer.Url);

                    //Rectangle r = new Rectangle(0, 0, pictureBox1.Width, pictureBox1.Height);
                    //System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();

                    //gp.AddEllipse(0, 0, pictureBox1.Width - 3, pictureBox1.Height - 3);
                    //Region rg = new Region(gp);
                    //pictureBox1.Region = rg;
                    //}
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
            }


            CustomerNameTxt.Text = Customer?.Name;
            UidLabel.Text = Customer?.UId;
            EmailLabel.Text = Customer?.Email;
            PhoneLabel.Text = Customer?.Phone;
            StatusComboBox.SelectedIndex = StatusComboBox.FindStringExact(Customer?.Status);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            var active = StatusComboBox.SelectedItem != null && StatusComboBox?.SelectedItem.ToString() == "Active";
            var check = _customerService.Update(Customer.Id, active);
            if (check)
            {
                MessageBox.Show(@"Update success!");
                Patient.Instance.ReLoadData();
                this.Close();
            }
            else
            {
                MessageBox.Show(@"Update failed!");
            }
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Profile_Deactivate(object sender, EventArgs e)
        {
            this.BringToFront();
            this.Activate();
            this.Focus();
        }

        private void Profile_Leave(object sender, EventArgs e)
        {
            this.BringToFront();
            this.Activate();
        }
    }
}
