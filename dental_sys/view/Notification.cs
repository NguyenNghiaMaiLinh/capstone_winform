using dental_sys.model;
using dental_sys.service;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using dental_sys.Constants;

namespace dental_sys.view
{
    public partial class Notification : Form
    {
        private readonly NotificationService _notificationService;
        public Principal Principal { get; set; }
        public PagingModel<NotificationModel> Notifications { get; set; }
        private static Notification _instance;
        private int _pageIndex = PagingConstant.PageIndex;
        private int _pageSize = 10;
        private int _total;
        private int _numberPage = 0;
        public static Notification Instance => _instance ?? (_instance = new Notification());

        private Notification()
        {
            _notificationService = new NotificationService();
            InitializeComponent();
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

        public void LoadNotification(int pageIndex, int pageSize, string searchValue = null, PagingModel<NotificationModel> pagingModel = null)
        {
            pagingModel = pagingModel ?? _notificationService.GetAllNotification(pageIndex, pageSize);

            if (pagingModel.Data != null && pagingModel.Data.Count > 0)
            {
                Notifications = pagingModel;
                BindingData(pagingModel.Data);
            }
            _total = pagingModel.Total;
            _numberPage = (int)Math.Ceiling(new decimal(_total / pageSize));
            var temp = _total % pageSize;
            if (temp > 0)
            {
                _numberPage++;
            }
            NotificationNumber.Text = _total.ToString();
            NotificationPageNumber.Text = _numberPage > 0 ? $@"{ pageIndex} / {_numberPage}" : @"0 / 0";

        }

        private void BindingData(ICollection<NotificationModel> data)
        {
            NotificationGridView.DataSource = null;
            NotificationGridView.DataSource = data;
            SetOrderColumn();
            NotificationGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        private void SetOrderColumn()
        {
            if (NotificationGridView?.Columns[NotificationHeaderConstant.No] != null)
                NotificationGridView.Columns[NotificationHeaderConstant.No].DisplayIndex = 0;
            if (NotificationGridView?.Columns[NotificationHeaderConstant.Message] != null)
                NotificationGridView.Columns[NotificationHeaderConstant.Message].DisplayIndex = 1;
            if (NotificationGridView?.Columns[NotificationHeaderConstant.CreatedDate] != null)
                NotificationGridView.Columns[NotificationHeaderConstant.CreatedDate].DisplayIndex = 2;
            if (NotificationGridView?.Columns[NotificationHeaderConstant.Read] != null)
                NotificationGridView.Columns[NotificationHeaderConstant.Read].DisplayIndex = 3;
        }

        private void NextPageBtn_Click(object sender, EventArgs e)
        {
            if (_pageIndex < _numberPage)
            {
                _pageIndex++;
                LoadNotification(_pageIndex, _pageSize);
                NotificationPageNumber.Text = $@"{ _pageIndex} / {_numberPage}";
            }
        }

        private void PreviousPageBtn_Click(object sender, EventArgs e)
        {
            if (_pageIndex > 1)
            {
                _pageIndex--;
                LoadNotification(_pageIndex, _pageSize);
                NotificationPageNumber.Text = $@"{ _pageIndex} / {_numberPage}";
            }
        }

        private async void NotificationGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (NotificationGridView.CurrentRow?.DataBoundItem is NotificationModel currentNumber)
            {
                if (!currentNumber.IsRead)
                {
                    await Task.Run(() =>
                    {
                        currentNumber.IsRead = _notificationService.UpdateReadNotification(currentNumber.Id);
                        Principal?.UpdatedUnreadNotification();

                    });
                    NotificationGridView.Refresh();

                }
            }
        }

        private async void NotificationGridView_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (NotificationGridView.CurrentRow?.DataBoundItem is NotificationModel currentNumber)
            {
                if (!currentNumber.IsRead)
                {
                    await Task.Run(() =>
                    {
                        currentNumber.IsRead = _notificationService.UpdateReadNotification(currentNumber.Id);
                        Principal?.UpdatedUnreadNotification();
                    });
                    NotificationGridView.Refresh();
                }
            }
        }


        private void UpdateButton_Click(object sender, EventArgs e)
        {
            var waitForm = new WaitFormFunc();
            waitForm.Show(this);

            _notificationService.DeleteAllRead();
            Principal?.UpdatedUnreadNotification();
            LoadNotification(_pageIndex,_pageSize);

            waitForm.Close();
        }
    }
}
