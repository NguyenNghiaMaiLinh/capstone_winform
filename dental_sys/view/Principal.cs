using System;
using System.Collections.Generic;
using System.Windows.Forms;
using dental_sys.Constants;
using dental_sys.model;
using dental_sys.service;

namespace dental_sys
{
    public partial class Principal : Form
    {
        public ICollection<CustomerModel> Customers { get; set; }
        private readonly CustomerService _customerService;
        public Principal()
        {
            _customerService = new CustomerService();
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            Patient.Instance.Customers = Customers;
            ShowContainer("Management customer", Patient.Instance);
        }

        private void ShowContainer(string containerName, Form form)
        {
            label_val.Text = containerName;
            guna2PictureBox_val.Image = Properties.Resources.outline_manage_accounts_black_36dp;

            if (guna2Panel_container.Controls.Count > 0) guna2Panel_container.Controls.Clear();
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;
            form.Dock = DockStyle.Fill;
            guna2Panel_container.Controls.Add(form);
            guna2Panel_container.Tag = form;
            form.Show();
        }

        private void guna2CircleButton7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ManageCustomerBtn_Click(object sender, EventArgs e)
        {
            var data = _customerService.GetAllCustomers(PagingConstant.PageIndex, PagingConstant.PageSize);
            Patient.Instance.Customers = data;
            Patient.Instance.LoadData(PagingConstant.PageIndex, PagingConstant.PageSize, data: data);
            ShowContainer("Management customer", Patient.Instance);
        }

        private void ImportDataBtn_Click(object sender, EventArgs e)
        {
            Patient.Instance.Customers = Customers;
            ShowContainer("Import Data", new ImportData());
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
