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

        public CustomerModel Customer { get; set; }

        public CreateClassVersion()
        {
            _classVersionService = new ClassVersionService();
            InitializeComponent();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            var lastClassVersionModel = _classVersionService.GetLastClassVersion();
            var createdDate = DateTime.Now;
            CreatedDateTextBox.Text = createdDate.ToString("dd/MM/yyyy");
            VersionTextBox.Text = (int.Parse(lastClassVersionModel?.Version ?? "0") + 1).ToString();
        }

        private void CloseBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Profile_Deactivate(object sender, EventArgs e)
        {
            BringToFront();
            Activate();
            Focus();
        }

        private void Profile_Leave(object sender, EventArgs e)
        {
            BringToFront();
            Activate();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            var version = VersionTextBox.Text;
            var commitHash = CommitHashTextBox.Text;
            var description = DescriptionRichBox.Text;
            var createdDate = DateTime.Now;

            if (string.IsNullOrEmpty(commitHash) || string.IsNullOrEmpty(description))
            {
                MessageBox.Show(@"Please enter value to create.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
            {
                var classVersion = new ClassVersionEntity()
                {
                    Version = version,
                    CommitHash = commitHash,
                    CreatedDate = createdDate
                };
                var check = _classVersionService.Create(classVersion);
                if (check)
                {
                    MessageBox.Show(@"Create success!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Version.Instance.ReLoadData();
                    Close();
                }
                else
                {
                    MessageBox.Show(@"Create failed!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}