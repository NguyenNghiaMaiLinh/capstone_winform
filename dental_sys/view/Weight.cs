using dental_sys.Constants;
using dental_sys.model;
using dental_sys.service;
using dental_sys.view;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace dental_sys
{
    public partial class Weight : Form
    {
        private readonly WeightService _weightService;
        public PagingModel<WeightModel> Weights { get; set; }

        private int _pageIndex = PagingConstant.PageIndex;
        private int _pageSize = PagingConstant.PageSize;
        private int _total;
        private int _numberPage = 0;
        private static Weight _instance;

        public static Weight Instance => _instance ?? (_instance = new Weight());

        private Weight()
        {
            _weightService = new WeightService();
            InitializeComponent();
        }

        public void ReLoadData()
        {
            LoadData(_pageIndex, _pageSize);
        }

        public void LoadData(int pageIndex, int pageSize, string searchValue = null, PagingModel<WeightModel> pagingModel = null)
        {

            pagingModel = pagingModel ?? _weightService.GetAllWeight(pageIndex, pageSize, searchValue);

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
            WeightNumber.Text = _total.ToString();
            PageNumber.Text = _numberPage > 0 ? $@"{ pageIndex} / {_numberPage}" : @"0 / 0";

        }

        private void Patient_Load(object sender, EventArgs e)
        {
            LoadData(PagingConstant.PageIndex, PagingConstant.PageSize, pagingModel: Weights);
        }


        private void BindingData(ICollection<WeightModel> data)
        {
            WeightGridView.DataSource = null;
            WeightGridView.DataSource = data;
            SetOrderColumn();
            WeightGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        private void SetOrderColumn()
        {
            if (WeightGridView?.Columns[WeightHeaderConstant.No] != null)
                WeightGridView.Columns[WeightHeaderConstant.No].DisplayIndex = 0;
            if (WeightGridView?.Columns[WeightHeaderConstant.Id] != null)
                WeightGridView.Columns[WeightHeaderConstant.Id].DisplayIndex = 1;
            if (WeightGridView?.Columns[WeightHeaderConstant.Version] != null)
                WeightGridView.Columns[WeightHeaderConstant.Version].DisplayIndex = 2;
            if (WeightGridView?.Columns[WeightHeaderConstant.Url] != null)
                WeightGridView.Columns[WeightHeaderConstant.Url].DisplayIndex = 3;
            if (WeightGridView?.Columns[WeightHeaderConstant.CreatedDate] != null)
                WeightGridView.Columns[WeightHeaderConstant.CreatedDate].DisplayIndex = 4;
            if (WeightGridView?.Columns[WeightHeaderConstant.Status] != null)
                WeightGridView.Columns[WeightHeaderConstant.Status].DisplayIndex = 5;  

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

        private void WeightGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (WeightGridView.CurrentRow?.DataBoundItem is WeightModel currentWeight)
            {
                var weightDetail = new WeightDetail() { WeightModel = currentWeight };
                weightDetail.ShowDialog();
            }
        }

        private void WeightGridView_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            if (e.Column.HeaderText == WeightHeaderConstant.No)
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
    }
}

