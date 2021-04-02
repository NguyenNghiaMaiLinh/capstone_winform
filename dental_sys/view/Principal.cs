using dental_sys.Constants;
using dental_sys.model;
using dental_sys.service;
using System;
using System.Windows.Forms;

namespace dental_sys
{
    public partial class Principal : Form
    {
        public PagingModel<CustomerModel> Customers { get; set; }
        public PagingModel<WeightModel> Weights { get; set; }
        private readonly CustomerService _customerService;
        private readonly WeightService _weightService;
        public Principal()
        {
            _customerService = new CustomerService();
            _weightService = new WeightService();
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

        private void ManageCustomerBtn_Click(object sender, EventArgs e)
        {
            var data = _customerService.GetAllCustomers(PagingConstant.PageIndex, PagingConstant.PageSize);
            Patient.Instance.Customers = data;
            Patient.Instance.LoadData(PagingConstant.PageIndex, PagingConstant.PageSize, pagingModel: data);
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

        private void WeightBtn_Click(object sender, EventArgs e)
        {
            var data = _weightService.GetAllWeight(PagingConstant.PageIndex, PagingConstant.PageSize);
            Weight.Instance.Weights = data;
            Weight.Instance.LoadData(PagingConstant.PageIndex, PagingConstant.PageSize, pagingModel: data);
            ShowContainer("Management weight", Weight.Instance);
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
