using dental_sys.service;
using System;
using System.Drawing;
using System.Windows.Forms;
using dental_sys.model;

namespace dental_sys.view
{
    public partial class Profile : Form
    {
        private bool mouseIsDown = false;
        private readonly CustomerService _customerService;
        private Point firstPoint;
        public CustomerModel Customer { get; set; }

        public Profile()
        {
            _customerService = new CustomerService();
            InitializeComponent();
        }

        private void Profile_Load(object sender, EventArgs e)
        {

            if (Customer?.Url != null)
                roundPictureBox1.Load(Customer.Url);

            CustomerNameTxt.Text = Customer?.Name;
            guna2HtmlLabel28.Text = Customer?.UId;
            guna2HtmlLabel20.Text = Customer?.Email;
            guna2HtmlLabel41.Text = Customer?.Phone;
            StatusComboBox.SelectedIndex = StatusComboBox.FindStringExact(Customer?.Status);
        }


        private void Profile_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseIsDown)
            {
                // Get the difference between the two points
                int xDiff = firstPoint.X - e.Location.X;
                int yDiff = firstPoint.Y - e.Location.Y;

                // Set the new point
                int x = this.Location.X - xDiff;
                int y = this.Location.Y - yDiff;
                this.Location = new Point(x, y);
            }
        }

        private void Profile_MouseUp(object sender, MouseEventArgs e)
        {
            mouseIsDown = false;
        }

        private void Profile_MouseDown(object sender, MouseEventArgs e)
        {
            firstPoint = e.Location;
            mouseIsDown = true;
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
