using dental_sys.service;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace dental_sys.view
{
    public partial class Profile : Form
    {
        private bool mouseIsDown = false;
        CustomerService customerService = new CustomerService();
        private Point firstPoint;

        public Profile()
        {
            InitializeComponent();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            int id = Patient.id;
            var customer = customerService.GetDetail(id);
            try
            {
                roundPictureBox1.Load(customer.Url);
            }
            catch (Exception)
            {
            }
            guna2HtmlLabel1.Text = customer.Name;
            guna2HtmlLabel28.Text = customer.UID;
            guna2HtmlLabel20.Text = customer.Email;
            guna2HtmlLabel41.Text = customer.Phone;
            var status = customer.IsActive ? "Active" : "Inactive";
            guna2ControlBox1.Name = status;
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
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
            bool active = guna2ComboBox1.SelectedItem == "Active" ? true : false;
            bool check = customerService.Update(Patient.id, active);
            if (check)
            {
                MessageBox.Show("Update success!");
                Patient patient = new Patient();
                patient.Refresh();
                this.Close();
            }
            else
            {
                MessageBox.Show("Update failed!");
            }
        }
    }
}
