using dental_sys.model;
using dental_sys.service;
using System;
using System.Windows.Forms;

namespace dental_sys.view
{
    public partial class CreateWeightVersion : Form
    {
        private readonly WeightService _weightService;
        private WeightVersionEntity _weightVersionEntity;
        public ClassVersionModel ClassVersionModel { get; set; }
        private string _weightPath;
        public CreateWeightVersion()
        {
            _weightService = new WeightService();
            InitializeComponent();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
            var createdDate = DateTime.Now;
            var lastWeightVersion = _weightService.GetWeightVersion(ClassVersionModel.Id);
            _weightVersionEntity = new WeightVersionEntity()
            {
                CreatedDate = createdDate,
                ClassVersionId = ClassVersionModel.Id,
                Version = (int.Parse(lastWeightVersion?.Version ?? "0") + 1).ToString()
            };
            CreatedDateTextBox.Text = createdDate.ToString("dd/MM/yyyy");
            VersionTextBox.Text = ClassVersionModel.Version;
            WeightVersionTextBox.Text = _weightVersionEntity.Version;
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
            var waitForm = new WaitFormFunc();
            waitForm.Show(this);
            var check = _weightService.Create(ClassVersionModel.Id, _weightPath);
            waitForm.Close();
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

        private void ChooseWeightBtn_Click(object sender, EventArgs e)
        {
            var ofg = new OpenFileDialog
            {
                Filter = @"Weight files (*.weights) | *.weights",
                Multiselect = false,
                //InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                Title = @"My Weight Browser",
                RestoreDirectory = true,
            };

            //  Allow the user to select multiple images.
            var dr = ofg.ShowDialog();
            if (dr == DialogResult.OK)
            {
                WeightTextBox.Text = ofg.FileName;
                _weightPath = ofg.FileName;
                //ImportDataBtn.Text = $@"Data ({_imageFiles.Count})";
            }
        }
    }
}
