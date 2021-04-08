using dental_sys.service;
using System;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using dental_sys.model;

namespace dental_sys.view
{
    public partial class ClassVersionDetail : Form
    {
        private readonly ClassVersionService _classVersionService;
        public ClassVersionModel ClassVersionModel { get; set; }

        public ClassVersionDetail()
        {
            _classVersionService = new ClassVersionService();
            InitializeComponent();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            var createdDate = ClassVersionModel.CreatedDate;
            CreatedDateTextBox.Text = createdDate.HasValue ? createdDate.Value.ToString("dd/MM/yyyy") : "";
            VersionTextBox.Text = ClassVersionModel.Version;
            IdTextBox.Text = ClassVersionModel.Id;
            CommitHashTextBox.Text = ClassVersionModel.CommitHash;
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

        private void Update_Click(object sender, EventArgs e)
        {
            var commitHash = CommitHashTextBox.Text;
            var classVersion = new ClassVersionEntity()
            {
                CommitHash = commitHash,
                Id = IdTextBox.Text
            };
            var check = _classVersionService.Update(classVersion);
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
    }
}
