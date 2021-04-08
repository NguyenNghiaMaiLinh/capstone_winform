using dental_sys.service;
using System;
using System.Drawing;
using System.Windows.Forms;
using dental_sys.model;

namespace dental_sys.view
{
    public partial class WeightDetail : Form
    {
        private bool _mouseIsDown = false;
        private readonly WeightService _weightService;
        private Point _firstPoint;
        public WeightVersionModel WeightVersionModel { get; set; }
        public ClassVersionModel ClassVersionModel { get; set; }

        public WeightDetail()
        {
            _weightService = new WeightService();
            InitializeComponent();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            WeightVersionTxt.Text = WeightVersionModel?.Version;
            IdTextBox.Text = WeightVersionModel?.Id;
            UrlTextBox.Text = WeightVersionModel?.Url;
            CreatedDateTextBox.Text = WeightVersionModel?.CreatedDateText;
            ClassVersionTextBox.Text = ClassVersionModel?.Version;
            CommitHashTextBox.Text = ClassVersionModel?.CommitHash;
            ClassCreatedDateTextBox.Text = ClassVersionModel?.CreatedDateText;
            StatusComboBox.SelectedIndex = StatusComboBox.FindStringExact(WeightVersionModel?.Status);
        }


        private void Profile_MouseMove(object sender, MouseEventArgs e)
        {
            if (_mouseIsDown)
            {
                // Get the difference between the two points
                int xDiff = _firstPoint.X - e.Location.X;
                int yDiff = _firstPoint.Y - e.Location.Y;

                // Set the new point
                int x = this.Location.X - xDiff;
                int y = this.Location.Y - yDiff;
                this.Location = new Point(x, y);
            }
        }

        private void Profile_MouseUp(object sender, MouseEventArgs e)
        {
            _mouseIsDown = false;
        }

        private void Profile_MouseDown(object sender, MouseEventArgs e)
        {
            _firstPoint = e.Location;
            _mouseIsDown = true;
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            var active = StatusComboBox.SelectedItem != null && StatusComboBox?.SelectedItem.ToString() == "Active";
            var url = UrlTextBox.Text;
            var entity = new WeightVersionEntity()
            {
                Id = WeightVersionModel.Id,
                Url = url,
                IsActive = active,
                ClassVersionId = WeightVersionModel.ClassVersionId
            };
            var check = _weightService.Update(entity);
            if (check)
            {
                MessageBox.Show(@"Update success!");
                Version.Instance.ReLoadData();
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
