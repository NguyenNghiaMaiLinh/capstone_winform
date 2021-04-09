using dental_sys.Constants;
using dental_sys.model;
using dental_sys.service;
using dental_sys.view;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace dental_sys
{
    public partial class Version : Form
    {
        private readonly WeightService _weightService;
        private readonly ClassVersionService _classVersionService;
        public PagingModel<WeightVersionModel> WeightVersions { get; set; }
        public PagingModel<ClassVersionModel> ClassVersions { get; set; }

        private int _weightVersionPageIndex = PagingConstant.PageIndex;
        private int _weightVersionPageSize = PagingConstant.PageSize;
        private int _classVersionPageIndex = PagingConstant.PageIndex;
        private int _classVersionPageSize = PagingConstant.PageSize;
        private int _weightVersionTotal;
        private int _weightVersionNumberPage;

        private int _classVersionTotal;
        private int _classVersionNumberPage;
        private static Version _instance;

        public static Version Instance => _instance ?? (_instance = new Version());

        private Version()
        {
            _weightService = new WeightService();
            _classVersionService = new ClassVersionService();
            InitializeComponent();
        }

        public void ReLoadData()
        {
            LoadClassVersionData(_classVersionPageIndex, _classVersionPageSize);
            var firstClassVersion = ClassVersions.Data?.FirstOrDefault();
            LoadWeightVersionData(firstClassVersion?.Id, _weightVersionPageIndex, _weightVersionPageSize);
        }

        public void LoadClassVersionData(int pageIndex, int pageSize, string searchValue = null, PagingModel<ClassVersionModel> pagingModel = null)
        {

            pagingModel = pagingModel ?? _classVersionService.GetAllClassVersion(pageIndex, pageSize, searchValue);
            ClassVersions = pagingModel;
            BindingData(pagingModel.Data);
            _classVersionTotal = pagingModel.Total;
            _classVersionNumberPage = (int)Math.Ceiling(new decimal(_classVersionNumberPage / pageSize));
            var temp = _classVersionTotal % pageSize;
            if (temp > 0)
            {
                _classVersionNumberPage++;
            }
            ClassVersionNumber.Text = _classVersionTotal.ToString();
            ClassVersionPageNumber.Text = _classVersionNumberPage > 0 ? $@"{ pageIndex} / {_classVersionNumberPage}" : @"0 / 0";

        }

        public void LoadWeightVersionData(string classVersionId, int pageIndex, int pageSize, string searchValue = null, PagingModel<WeightVersionModel> pagingModel = null)
        {
            pagingModel = pagingModel ?? _weightService.GetAllWeightByClassId(classVersionId, pageIndex, pageSize, searchValue);

            WeightVersions = pagingModel;
            BindingData(pagingModel.Data);

            _weightVersionTotal = pagingModel.Total;
            _weightVersionNumberPage = (int)Math.Ceiling(new decimal(_weightVersionTotal / pageSize));
            var temp = _weightVersionTotal % pageSize;
            if (temp > 0)
            {
                _weightVersionNumberPage++;
            }
            WeightNumber.Text = _weightVersionTotal.ToString();
            WeightVersionPageNumber.Text = _weightVersionNumberPage > 0 ? $@"{ pageIndex} / {_weightVersionNumberPage}" : @"0 / 0";
        }

        private void BindingData(dynamic data)
        {
            if (data is ICollection<WeightVersionModel>)
            {
                WeightGridView.DataSource = null;
                WeightGridView.DataSource = data;
                SetWeightOrderColumn();
                WeightGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            if (data is ICollection<ClassVersionModel>)
            {
                ClassVersionGridView.DataSource = null;
                ClassVersionGridView.DataSource = data;
                SetClassVersionOrderColumn();
                ClassVersionGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }


        }
        private void SetWeightOrderColumn()
        {
            if (WeightGridView?.Columns[WeightVersionHeaderConstant.No] != null)
                WeightGridView.Columns[WeightVersionHeaderConstant.No].DisplayIndex = 0;
            if (WeightGridView?.Columns[WeightVersionHeaderConstant.Id] != null)
                WeightGridView.Columns[WeightVersionHeaderConstant.Id].DisplayIndex = 1;
            if (WeightGridView?.Columns[WeightVersionHeaderConstant.Version] != null)
                WeightGridView.Columns[WeightVersionHeaderConstant.Version].DisplayIndex = 2;
            if (WeightGridView?.Columns[WeightVersionHeaderConstant.CreatedDate] != null)
                WeightGridView.Columns[WeightVersionHeaderConstant.CreatedDate].DisplayIndex = 3;
            if (WeightGridView?.Columns[WeightVersionHeaderConstant.Status] != null)
                WeightGridView.Columns[WeightVersionHeaderConstant.Status].DisplayIndex = 4;

        }

        private void SetClassVersionOrderColumn()
        {
            if (ClassVersionGridView?.Columns[ClassVersionHeaderConstant.No] != null)
                ClassVersionGridView.Columns[ClassVersionHeaderConstant.No].DisplayIndex = 0;
            if (ClassVersionGridView?.Columns[ClassVersionHeaderConstant.Id] != null)
                ClassVersionGridView.Columns[ClassVersionHeaderConstant.Id].DisplayIndex = 1;
            if (ClassVersionGridView?.Columns[ClassVersionHeaderConstant.Version] != null)
                ClassVersionGridView.Columns[ClassVersionHeaderConstant.Version].DisplayIndex = 2;
            if (ClassVersionGridView?.Columns[ClassVersionHeaderConstant.CommitHash] != null)
                ClassVersionGridView.Columns[ClassVersionHeaderConstant.CommitHash].DisplayIndex = 3;
            if (ClassVersionGridView?.Columns[ClassVersionHeaderConstant.CreatedDate] != null)
                ClassVersionGridView.Columns[ClassVersionHeaderConstant.CreatedDate].DisplayIndex = 4;

        }
        private void SearchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            //string searchValue = SearchTextBox.Text;
            //if (e.KeyCode == Keys.Enter)
            //{
            //    LoadWeightVersionData(_weightVersionPageIndex, _weightVersionPageSize, searchValue);
            //    WeightVersionNumber.Text = $@"{ _weightVersionPageIndex} / {_weightVersionNumberPage}";
            //}
        }


        private void WeightGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (WeightGridView.CurrentRow?.DataBoundItem is WeightVersionModel currentWeight)
            {
                var currentClassVersion = (ClassVersionModel)ClassVersionGridView.CurrentRow?.DataBoundItem;
                var weightDetail = new WeightDetail()
                {
                    WeightVersionModel = currentWeight,
                    ClassVersionModel = currentClassVersion
                };
                weightDetail.ShowDialog();
            }
        }

        private void WeightGridView_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            if (e.Column.HeaderText == WeightVersionHeaderConstant.No)
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

        private void NextWeightVersionBtn_Click(object sender, EventArgs e)
        {
            var searchValue = SearchWeightTextBox.Text;
            if (ClassVersionGridView.CurrentRow?.DataBoundItem is ClassVersionModel currentClassVersion)
            {
                if (_weightVersionPageIndex < _weightVersionNumberPage)
                {
                    _weightVersionPageIndex++;
                    LoadWeightVersionData(currentClassVersion.Id, _weightVersionPageIndex, _weightVersionPageSize, searchValue);
                    WeightVersionPageNumber.Text = $@"{ _weightVersionPageIndex} / {_weightVersionNumberPage}";
                }

            }

        }

        private void PreviousPageWeightVersionBtn_Click(object sender, EventArgs e)
        {
            var searchValue = SearchWeightTextBox.Text;
            if (ClassVersionGridView.CurrentRow?.DataBoundItem is ClassVersionModel currentClassVersion)
            {
                if (_weightVersionPageIndex > 1)
                {
                    _weightVersionPageIndex--;
                    LoadWeightVersionData(currentClassVersion.Id, _weightVersionPageIndex, _weightVersionPageSize, searchValue);
                    WeightVersionPageNumber.Text = $@"{_weightVersionPageIndex} / {_weightVersionNumberPage}";
                }
            }
        }

        private void Version_Load(object sender, EventArgs e)
        {
            LoadClassVersionData(PagingConstant.PageIndex, PagingConstant.PageSize, pagingModel: ClassVersions);
            //LoadData(PagingConstant.PageIndex, PagingConstant.PageSize, pagingModel: WeightVersions);
        }

        private void ClassVersionGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var waitForm = new WaitFormFunc();
            waitForm.Show();
            if (ClassVersionGridView.CurrentRow?.DataBoundItem is ClassVersionModel currentClassVersion)
            {
                LoadWeightVersionData(currentClassVersion.Id, _classVersionPageIndex, _classVersionPageSize);
            }
            waitForm.Close();
        }

        private void CreateClassBtn_Click(object sender, EventArgs e)
        {
            var createClassVersion = new CreateClassVersion();
            createClassVersion.ShowDialog();
        }

        private void ClassVersionGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (ClassVersionGridView.CurrentRow?.DataBoundItem is ClassVersionModel currentClassVersion)
            {
                var classVersionDetail = new ClassVersionDetail() { ClassVersionModel = currentClassVersion };
                classVersionDetail.ShowDialog();
            }

        }

        private void NextClassPageBtn_Click(object sender, EventArgs e)
        {
            var searchValue = SearchWeightTextBox.Text;

            if (_classVersionPageIndex < _classVersionNumberPage)
            {
                _classVersionPageIndex++;
                LoadClassVersionData(_classVersionPageIndex, _classVersionPageSize, searchValue);
                ClassVersionPageNumber.Text = $@"{ _classVersionPageIndex} / {_classVersionNumberPage}";
            }


        }

        private void PreviousClassPageBtn_Click(object sender, EventArgs e)
        {
            var searchValue = SearchWeightTextBox.Text;

            if (_classVersionPageIndex > 1)
            {
                _classVersionPageIndex--;
                LoadClassVersionData(_classVersionPageIndex, _classVersionPageSize, searchValue);
                ClassVersionPageNumber.Text = $@"{_classVersionPageIndex} / {_classVersionNumberPage}";
            }

        }

        private void CreateWeightBtn_Click(object sender, EventArgs e)
        {
            if (ClassVersionGridView.CurrentRow?.DataBoundItem is ClassVersionModel currentClassVersion)
            {
                var createWeightVersion = new CreateWeightVersion {  ClassVersionModel= currentClassVersion };
                createWeightVersion.ShowDialog();
            }
            else
            {
                MessageBox.Show(@"Please select class version");
            }
        }
    }
}

