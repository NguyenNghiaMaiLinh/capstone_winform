using dental_sys.model;
using dental_sys.service;
using dental_sys.view;
using System;
using System.Linq;
using System.Windows.Forms;

namespace dental_sys
{
    public partial class Patient : Form
    {
        CustomerService customerService = new CustomerService();
        public static int id = 0;
        private int pageIndex = 1;
        private int pageSize = 20;
        private int total;
        private int numberPage = 0;
        public Patient()
        {

            InitializeComponent();
        }
        private void loadData(int pageIndex, int pageSize, string searchValue)
        {
            guna2DataGridView1.MultiSelect = false;
            guna2DataGridView1.Rows.Clear();
            guna2DataGridView1.Refresh();
            var data = customerService.getAllCustomers(pageIndex, pageSize, searchValue);
            if (data != null && data.Count > 0)
            {
                guna2DataGridView1.Rows.Add(data.Count);

                for (int i = 0; i < data.Count; i++)
                {
                    Customer customer = data.ToList()[i];
                    var status = customer.IsActive ? "Active" : "Inactive";
                    int no = i;
                    guna2DataGridView1.Rows[i].Cells[1].Value = (no+1).ToString();
                    guna2DataGridView1.Rows[i].Cells[2].Value = customer.UID;
                    guna2DataGridView1.Rows[i].Cells[3].Value = customer.Name;
                    guna2DataGridView1.Rows[i].Cells[4].Value = customer.Phone;
                    guna2DataGridView1.Rows[i].Cells[5].Value = customer.Email;
                    guna2DataGridView1.Rows[i].Cells[6].Value = status;
                    guna2DataGridView1.Rows[i].Cells[7].Value = customer.Id;
                }

            }
            total = data?.Count ?? 0;
            label1.Text = total.ToString();
        }
        private void Patient_Load(object sender, EventArgs e)
        {
            var data = Loading.data;
            if (data != null && data.Count > 0)
            {
                guna2DataGridView1.Rows.Add(data.Count);

                for (int i = 0; i < data.Count; i++)
                {
                    Customer customer = data.ToList()[i];
                    var status = customer.IsActive ? "Active" : "Inactive";
                    int no = i;
                    guna2DataGridView1.Rows[i].Cells[1].Value = (no+1).ToString();
                    guna2DataGridView1.Rows[i].Cells[2].Value = customer.UID;
                    guna2DataGridView1.Rows[i].Cells[3].Value = customer.Name;
                    guna2DataGridView1.Rows[i].Cells[4].Value = customer.Phone;
                    guna2DataGridView1.Rows[i].Cells[5].Value = customer.Email;
                    guna2DataGridView1.Rows[i].Cells[6].Value = status;
                    guna2DataGridView1.Rows[i].Cells[7].Value = customer.Id;
                }
                total = data?.Count ?? 0;
                numberPage = total / pageSize;
            }
            else
            {
                loadData(pageIndex, pageSize, null);
            }
            int temp = total % pageSize;
            if (temp > 0)
            {
                numberPage++;
            }
            label1.Text = total.ToString();
            label3.Text = $"{ pageIndex} / {numberPage}";
        }

        private void guna2TextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            string searchValue = guna2TextBox1.Text;
            if (e.KeyCode == Keys.Enter)
            {
                loadData(pageIndex, pageSize, searchValue);
                label3.Text = $"{ pageIndex} / {numberPage}";
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string searchValue = guna2TextBox1.Text;
            if (pageIndex < numberPage)
            {
                pageIndex++;
                loadData(pageIndex, pageSize, searchValue);
                label3.Text = $"{ pageIndex} / {numberPage}";
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            string searchValue = guna2TextBox1.Text;
            if (pageIndex > 1)
            {
                pageIndex--;
                loadData(pageIndex, pageSize, searchValue);
                label3.Text = $"{ pageIndex} / {numberPage}";
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            //var result = customerService.UpdateCustomer();
        }

        //private void guna2Button4_Click(object sender, EventArgs e)
        //{
        //    string id = guna2DataGridView1.CurrentRow.Cells[7].Value.ToString();

        //    string searchValue = guna2TextBox1.Text;
        //    var result = customerService.Delete(id);
        //    if (result)
        //    {
        //        loadData(pageIndex, pageSize, searchValue);
        //    }
        //}

        private void guna2DataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int.TryParse( guna2DataGridView1.CurrentRow.Cells[7].Value.ToString(), out id);
            Profile profile = new Profile();
            profile.Show();
        }
    }
}
