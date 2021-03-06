using dental_sys.Constants;
using dental_sys.model;
using dental_sys.service;
using System;
using System.Linq;
using System.Windows.Forms;
using dental_sys.view;

namespace dental_sys
{
    public partial class Principal : Form
    {
        public PagingModel<CustomerModel> Customers { get; set; }
        public PagingModel<WeightVersionModel> Weights { get; set; }
        private readonly CustomerService _customerService;
        private readonly WeightService _weightService;
        private readonly ClassVersionService _classVersionService;
        private readonly NotificationService _notificationService;
        public Principal()
        {
            _customerService = new CustomerService();
            _classVersionService = new ClassVersionService();
            _weightService = new WeightService();
            _notificationService = new NotificationService();
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
            Patient.Instance.Customers = Customers;
            Patient.Instance.LoadData(PagingConstant.PageIndex, PagingConstant.PageSize, pagingModel: Customers);
            UpdatedUnreadNotification();
            ShowContainer("Customer Management", Patient.Instance);
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
            var waitForm = new WaitFormFunc();
            waitForm.Show(this);
            Patient.Instance.LoadData(PagingConstant.PageIndex, PagingConstant.PageSize);
            ShowContainer("Customer Management", Patient.Instance);
            waitForm.Close();
        }

        private void ImportDataBtn_Click(object sender, EventArgs e)
        {
            var waitForm = new WaitFormFunc();
            waitForm.Show(this);
            ShowContainer("Import Data && Train", ImportData.Instance);
            waitForm.Close();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void WeightBtn_Click(object sender, EventArgs e)
        {
            var waitForm = new WaitFormFunc();
            waitForm.Show(this);

            var classVersionData = _classVersionService.GetAllClassVersion(PagingConstant.PageIndex, PagingConstant.PageSize);
            var firstClass = classVersionData?.Data?.FirstOrDefault();
            PagingModel<WeightVersionModel> weightVersion = null;
            if (firstClass != null)
            {
                weightVersion = _weightService.GetAllWeightByClassId(firstClass.Id, PagingConstant.PageIndex, PagingConstant.PageSize);

            }
            Version.Instance.ClassVersions = classVersionData;
            Version.Instance.WeightVersions = weightVersion;
            Version.Instance.LoadClassVersionData(PagingConstant.PageIndex, PagingConstant.PageSize, pagingModel: classVersionData);
            Version.Instance.LoadWeightVersionData(firstClass?.Id, PagingConstant.PageIndex, PagingConstant.PageSize, pagingModel: weightVersion);
            ShowContainer("Model Management", Version.Instance);
            waitForm.Close();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void NotificationPicture_Click(object sender, EventArgs e)
        {
            Notification.Instance.LoadNotification(PagingConstant.PageIndex, 10);
            Notification.Instance.Principal = this;
            Notification.Instance.ShowDialog();

        }

        public void UpdatedUnreadNotification()
        {
            var notificationUnread = _notificationService.CountUnread();
            if (notificationUnread == 0)
            {
                NotificationNumber.Visible = false;
            }
            else
            {
                NotificationNumber.Visible = true;
                NotificationNumber.Text = notificationUnread.ToString();
            }

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            UpdatedUnreadNotification();
        }
    }
}
