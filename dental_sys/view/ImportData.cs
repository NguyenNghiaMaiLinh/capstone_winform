using dental_sys.model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace dental_sys
{
    public partial class ImportData : Form
    {
        //ICollection<string> listLabel;
        private ICollection<ImageFileModel> _imageFiles;
        private ICollection<LabelFileModel> _labelFiles;
        public ImportData()
        {
            _labelFiles = new List<LabelFileModel>();
            _imageFiles = new List<ImageFileModel>();
            InitializeComponent();
        }

        private void ImportDataBtn_Click(object sender, EventArgs e)
        {
            var ofg = new OpenFileDialog
            {
                Filter = @"Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png",
                Multiselect = true,
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                Title = @"My Data Browser"
            };

            //  Allow the user to select multiple images.
            var dr = ofg.ShowDialog();
            var uploads = new List<string>();
            if (dr == DialogResult.OK)
            {
                _imageFiles.Clear();
                var no = 0;
                ofg.FileNames.ToList().ForEach(file =>
                {
                    var fileModel = new ImageFileModel()
                    {

                        No = no++.ToString(),
                        NameFile = Path.GetFileName(file),
                        Path = file,
                        UpdatedDate = File.GetLastWriteTime(file).ToString("dd/MM/yyyy"),
                        Id = Guid.NewGuid().ToString("N"),
                        IsLabel = _labelFiles.Any(w => w.NameFile == Path.GetFileName(file))
                    };
                    _imageFiles.Add(fileModel);
                    //listData.Add(file);

                });
                ImportDataBtn.Text = $@"Import Data ({_imageFiles.Count})";
            }

            FileDataGridView.DataSource = null;
            FileDataGridView.DataSource = _imageFiles;
            FileDataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

        }

        private void ImportData_Load(object sender, EventArgs e)
        {
        }

        void UserControl_Click(object sender, EventArgs e)
        {
            Item item = (Item)sender;
            MessageBox.Show(item.Name);

        }

        private void ImportLabelBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofg = new OpenFileDialog();
            ofg.Filter = @"Text Files (*.txt)|*.txt";

            //  Allow the user to select multiple images.
            ofg.Multiselect = true;
            ofg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            ofg.Title = @"My Label Browser";
            DialogResult dr = ofg.ShowDialog();
            var uploads = new List<string>();
            if (dr == DialogResult.OK)
            {
                _labelFiles.Clear();
                ofg.FileNames.ToList().ForEach(file =>
                {
                    var fileModel = new LabelFileModel()
                    {
                        NameFile = Path.GetFileName(file),
                        Path = file,
                        UpdatedDate = File.GetLastWriteTime(file).ToString("dd/MM/yyyy"),
                        Id = Guid.NewGuid().ToString("N"),
                    };
                    //listData.Add(file);
                    _labelFiles.Add(fileModel);
                });
                ImportLabelBtn.Text = $@"Import Label ({_labelFiles.Count})";

            }
        }

        private void FileDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (FileDataGridView.CurrentRow?.DataBoundItem is ImageFileModel currentFile)
            {
                PicturePanel.BackgroundImage = Image.FromFile(currentFile.Path);
            }

            //PictureBox.Image = Image.FromFile(path);
            //PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
        }

        private void FileDataGridView_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            foreach (DataGridViewColumn column in FileDataGridView.Columns)
            {
                column.DefaultCellStyle = new DataGridViewCellStyle(e.Column.DefaultCellStyle)
                {
                    Alignment = DataGridViewContentAlignment.MiddleCenter
                };
            }

        }
    }

}

