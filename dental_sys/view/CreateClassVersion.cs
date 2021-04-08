using dental_sys.service;
using System;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using dental_sys.model;

namespace dental_sys.view
{
    public partial class CreateClassVersion : Form
    {
        private readonly ClassVersionService _classVersionService;
        private ClassVersionModel _lastClassVersionModel;
        public CustomerModel Customer { get; set; }

        public CreateClassVersion()
        {
            _classVersionService = new ClassVersionService();
            InitializeComponent();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            _lastClassVersionModel = _classVersionService.GetLastClassVersion();
            var createdDate = DateTime.Now;
            CreatedDateTextBox.Text = createdDate.ToString("dd/MM/yyyy");
            VersionTextBox.Text = (int.Parse(_lastClassVersionModel.Version) + 1).ToString();
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

        private void Create_Click(object sender, EventArgs e)
        {
            var version = VersionTextBox.Text;
            var commitHash = CommitHashTextBox.Text;
            var createdDate = DateTime.Now;
            var classVersion = new ClassVersionEntity()
            {
                Version = version,
                CommitHash = commitHash,
                CreatedDate = createdDate
            };
            var check = _classVersionService.Create(classVersion);
            if (check)
            {
                MessageBox.Show(@"Create success!");
                Version.Instance.ReLoadData();
                this.Close();
            }
            else
            {
                MessageBox.Show(@"Create failed!");
            }
        }
    }
}
