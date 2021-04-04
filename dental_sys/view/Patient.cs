using dental_sys.model;
using dental_sys.service;
using dental_sys.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using dental_sys.Constants;

namespace dental_sys
{
    public partial class Patient : Form
    {
        private readonly CustomerService _customerService;
        public PagingModel<CustomerModel> Customers { get; set; }

        private int _pageIndex = 1;
        private int _pageSize = 20;
        private int _total;
        private int _numberPage = 0;
        private static Patient _instance;

        public static Patient Instance => _instance ?? (_instance = new Patient());

        private Patient()
        {
            _customerService = new CustomerService();
            InitializeComponent();
        }

        public void ReLoadData()
        {
            LoadData(_pageIndex, _pageSize);
        }

        public void LoadData(int pageIndex, int pageSize, string searchValue = null, PagingModel<CustomerModel> pagingModel = null)
        {

            pagingModel = pagingModel ?? _customerService.GetAllCustomers(pageIndex, pageSize, searchValue);

            if (pagingModel.Data != null && pagingModel.Data.Count > 0)
            {
                BindingData(pagingModel.Data);
            }
            _total = pagingModel.Total;
            _numberPage = (int)Math.Ceiling(new decimal(_total / pageSize));
            var temp = _total % pageSize;
            if (temp > 0)
            {
                _numberPage++;
            }
            NumberCustomerText.Text = _total.ToString();
            PageNumber.Text = _numberPage > 0 ? $@"{ pageIndex} / {_numberPage}" : @"0 / 0";
        }

        private void BindingData(ICollection<CustomerModel> data)
        {
            CustomerGridView.DataSource = null;
            CustomerGridView.DataSource = data;
            SetOrderColumn();
            CustomerGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        private void SetOrderColumn()
        {
            if (CustomerGridView?.Columns[CustomerHeaderConstant.No] != null)
                CustomerGridView.Columns[CustomerHeaderConstant.No].DisplayIndex = 0;
            if (CustomerGridView?.Columns[CustomerHeaderConstant.Name] != null)
                CustomerGridView.Columns[CustomerHeaderConstant.Name].DisplayIndex = 1;
            if (CustomerGridView?.Columns[CustomerHeaderConstant.Phone] != null)
                CustomerGridView.Columns[CustomerHeaderConstant.Phone].DisplayIndex = 2;
            if (CustomerGridView?.Columns[CustomerHeaderConstant.Email] != null)
                CustomerGridView.Columns[CustomerHeaderConstant.Email].DisplayIndex = 3;
            if (CustomerGridView?.Columns[CustomerHeaderConstant.Status] != null)
                CustomerGridView.Columns[CustomerHeaderConstant.Status].DisplayIndex = 4;
        }
        private void SearchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            string searchValue = SearchTextBox.Text;
            if (e.KeyCode == Keys.Enter)
            {
                LoadData(_pageIndex, _pageSize, searchValue);
                PageNumber.Text = $@"{ _pageIndex} / {_numberPage}";
            }
        }


        private void PreviousPageBtn_Click(object sender, EventArgs e)
        {
            string searchValue = SearchTextBox.Text;
            if (_pageIndex > 1)
            {
                _pageIndex--;
                LoadData(_pageIndex, _pageSize, searchValue);
                PageNumber.Text = $@"{ _pageIndex} / {_numberPage}";
            }
        }

        private void NextPageBtn_Click(object sender, EventArgs e)
        {
            string searchValue = SearchTextBox.Text;
            if (_pageIndex < _numberPage)
            {
                _pageIndex++;
                LoadData(_pageIndex, _pageSize, searchValue);
                PageNumber.Text = $@"{ _pageIndex} / {_numberPage}";
            }
        }

        private void CustomerGridView_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {

            if (e.Column.HeaderText == CustomerHeaderConstant.No)
            {
                e.Column.DefaultCellStyle = new DataGridViewCellStyle()
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                };

            }
            else
            {
                e.Column.DefaultCellStyle = new DataGridViewCellStyle()
                {
                    Alignment = DataGridViewContentAlignment.MiddleLeft
                };
            }

        }

        private void CustomerGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (CustomerGridView.CurrentRow?.DataBoundItem is CustomerModel currentCustomer)
            {
                var profile = new Profile { Customer = currentCustomer };
                profile.ShowDialog();
            }
        }
    }
}

