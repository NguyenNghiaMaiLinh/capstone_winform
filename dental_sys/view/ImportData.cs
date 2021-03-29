using dental_sys.model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using dental_sys.Constants;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace dental_sys
{
    public partial class ImportData : Form
    {
        //ICollection<string> listLabel;
        private readonly List<ImageFileModel> _imageFiles;
        private readonly List<LabelFileModel> _labelFiles;
        private readonly Dictionary<string, string> _orderDictionary;
        public ImportData()
        {
            _orderDictionary = new Dictionary<string, string>()
            {
                {FileHeaderConstant.No,Order.Asc },
                {FileHeaderConstant.Name,Order.Asc },
                {FileHeaderConstant.DateModified,Order.Asc },
                {FileHeaderConstant.Label,Order.Asc },
            };
            _labelFiles = new List<LabelFileModel>();
            _imageFiles = new List<ImageFileModel>();
            InitializeComponent();
            SetBorderAndGridlineStyles();
            ImageNumber.Text = "0";
            LabelNumber.Text = "0";
        }

        private void ImportDataBtn_Click(object sender, EventArgs e)
        {
            var ofg = new OpenFileDialog
            {
                Filter = @"Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png",
                Multiselect = true,
                //InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                Title = @"My Data Browser",
                RestoreDirectory = true,
            };

            //  Allow the user to select multiple images.
            var dr = ofg.ShowDialog();
            if (dr == DialogResult.OK)
            {
                _imageFiles.Clear();
                ImportImageFileData(ofg.FileNames.ToList());
                ImportDataBtn.Text = $@"Import Data ({_imageFiles.Count})";
            }

        }

        private void BindingData(List<ImageFileModel> imageFile)
        {
            FileDataGridView.DataSource = null;
            FileDataGridView.DataSource = imageFile;
            SetOrderColumn();
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
            OpenFileDialog ofg = new OpenFileDialog
            {
                Filter = @"Text Files (*.txt)|*.txt",
                Multiselect = true,
                //InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                Title = @"My Label Browser",
                RestoreDirectory = true,
            };

            //  Allow the user to select multiple images.
            var dr = ofg.ShowDialog();
            if (dr == DialogResult.OK)
            {
                _labelFiles.Clear();

                ImportLabelFileData(ofg.FileNames.ToList());

                if (_imageFiles.Count != 0)
                {
                    foreach (var imageFileModel in _imageFiles)
                    {
                        imageFileModel.IsLabel = _labelFiles.Any(w =>
                            Path.GetFileNameWithoutExtension(w.Path) ==
                            Path.GetFileNameWithoutExtension(imageFileModel.Path));
                    }

                    BindingData(_imageFiles);
                }
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

        private void SetOrderColumn()
        {
            if (FileDataGridView?.Columns[FileHeaderConstant.No] != null)
                FileDataGridView.Columns[FileHeaderConstant.No].DisplayIndex = 0;
            if (FileDataGridView?.Columns[FileHeaderConstant.Name] != null)
                FileDataGridView.Columns[FileHeaderConstant.Name].DisplayIndex = 1;
            if (FileDataGridView?.Columns[FileHeaderConstant.DateModified] != null)
                FileDataGridView.Columns[FileHeaderConstant.DateModified].DisplayIndex = 2;
            if (FileDataGridView?.Columns[FileHeaderConstant.Label] != null)
                FileDataGridView.Columns[FileHeaderConstant.Label].DisplayIndex = 3;
        }

        private void FileDataGridView_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex < 0) return;
            ICollection<ImageFileModel> imageFiles = null;
            if (FileDataGridView.Columns[e.ColumnIndex].HeaderText == FileHeaderConstant.Name)
            {
                if (_orderDictionary[FileHeaderConstant.Name] == Order.Desc)
                {
                    imageFiles = _imageFiles.OrderBy(o => o.NameFile).ToList();
                    _orderDictionary[FileHeaderConstant.Name] = Order.Asc;
                }
                else
                {
                    imageFiles = _imageFiles.OrderByDescending(o => o.NameFile).ToList();
                    _orderDictionary[FileHeaderConstant.Name] = Order.Desc;
                }
            }

            if (FileDataGridView.Columns[e.ColumnIndex].HeaderText == FileHeaderConstant.No)
            {
                if (_orderDictionary[FileHeaderConstant.No] == Order.Desc)
                {
                    imageFiles = _imageFiles.OrderBy(o => int.Parse(o.No)).ToList();
                    _orderDictionary[FileHeaderConstant.No] = Order.Asc;
                }
                else
                {
                    imageFiles = _imageFiles.OrderByDescending(o => int.Parse(o.No)).ToList();
                    _orderDictionary[FileHeaderConstant.No] = Order.Desc;
                }
            }

            if (FileDataGridView.Columns[e.ColumnIndex].HeaderText == FileHeaderConstant.DateModified)
            {
                if (_orderDictionary[FileHeaderConstant.DateModified] == Order.Desc)
                {
                    imageFiles = _imageFiles.OrderBy(o => DateTime.ParseExact(o.UpdatedDate, "dd/MM/yyyy", CultureInfo.InvariantCulture)).ToList();
                    _orderDictionary[FileHeaderConstant.DateModified] = Order.Asc;
                }
                else
                {
                    imageFiles = _imageFiles.OrderByDescending(o => DateTime.ParseExact(o.UpdatedDate, "dd/MM/yyyy", CultureInfo.InvariantCulture)).ToList();
                    _orderDictionary[FileHeaderConstant.DateModified] = Order.Desc;
                }
            }

            if (FileDataGridView.Columns[e.ColumnIndex].HeaderText == FileHeaderConstant.Label)
            {
                if (_orderDictionary[FileHeaderConstant.Label] == Order.Desc)
                {
                    imageFiles = _imageFiles.OrderBy(o => o.IsLabel).ToList();
                    _orderDictionary[FileHeaderConstant.Label] = Order.Asc;
                }
                else
                {
                    imageFiles = _imageFiles.OrderByDescending(o => o.IsLabel).ToList();
                    _orderDictionary[FileHeaderConstant.Label] = Order.Desc;
                }

            }

            if (imageFiles != null)
            {
                _imageFiles.Clear();
                _imageFiles.AddRange(imageFiles);
                BindingData(_imageFiles);
            }

        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            var currentRow = FileDataGridView.CurrentCell.RowIndex;
            if (currentRow >= 0)
            {
                FileDataGridView.CurrentCell = FileDataGridView.Rows[currentRow + 1].Cells[0];
                PicturePanel.BackgroundImage = Image.FromFile(_imageFiles[currentRow + 1].Path);
            }
        }

        private void PreviousBtn_Click(object sender, EventArgs e)
        {
            var currentRow = FileDataGridView.CurrentCell.RowIndex;
            if (currentRow >= 1)
            {
                FileDataGridView.CurrentCell = FileDataGridView.Rows[currentRow - 1].Cells[0];
                PicturePanel.BackgroundImage = Image.FromFile(_imageFiles[currentRow - 1].Path);
            }
        }
        private void SetBorderAndGridlineStyles()
        {
            this.FileDataGridView.GridColor = Color.Black;
            this.FileDataGridView.BorderStyle = BorderStyle.Fixed3D;
            this.FileDataGridView.CellBorderStyle = DataGridViewCellBorderStyle.None;
            this.FileDataGridView.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            this.FileDataGridView.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
        }

        private void ImportDirBtn_Click(object sender, EventArgs e)
        {
            using (var fbd = new CommonOpenFileDialog())
            {

                fbd.RestoreDirectory = true;
                fbd.IsFolderPicker = true;
                fbd.Title = @"My Data Browser";
                var result = fbd.ShowDialog();
                if (result == CommonFileDialogResult.Ok && !string.IsNullOrWhiteSpace(fbd.FileName))
                {
                    var supportedExtensions = "*.jpg, *.jpeg, *.jpe, *.jfif, *.png";
                    var files = Directory.EnumerateFiles(fbd.FileName, "*.*", SearchOption.AllDirectories)
                        .Where(s => supportedExtensions.Contains(Path.GetExtension(s).ToLower())).ToList();

                    _imageFiles.Clear();

                    ImportImageFileData(files);
                }
            }
        }

        private void ImportImageFileData(List<string> files)
        {
            var no = 0;
            files.ForEach(file =>
            {
                var fileModel = new ImageFileModel()
                {

                    No = no++.ToString(),
                    NameFile = Path.GetFileName(file),
                    Path = file,
                    UpdatedDate = File.GetLastWriteTime(file).ToString("dd/MM/yyyy"),
                    Id = Guid.NewGuid().ToString("N"),
                    IsLabel = _labelFiles.Any(w => Path.GetFileNameWithoutExtension(w.Path) == Path.GetFileNameWithoutExtension(file))
                };
                _imageFiles.Add(fileModel);
                //listData.Add(file);
            });
            ImageNumber.Text = _imageFiles.Count.ToString();
            //ImportDataBtn.Text = $@"Import Data ({_imageFiles.Count})";

            BindingData(_imageFiles);
        }

        private void ImportLabelFileData(List<string> files)
        {
            files.ForEach(file =>
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
            LabelNumber.Text = _labelFiles.Count.ToString();
            //ImportLabelBtn.Text = $@"Import Label ({_labelFiles.Count})";
        }

        private void ImportLabelDirBtn_Click(object sender, EventArgs e)
        {
            using (var fbd = new CommonOpenFileDialog())
            {
                fbd.RestoreDirectory = true;
                fbd.IsFolderPicker = true;
                fbd.Title = @"My Label Browser";
                var result = fbd.ShowDialog();
                if (result == CommonFileDialogResult.Ok && !string.IsNullOrWhiteSpace(fbd.FileName))
                {
                    var supportedExtensions = "*.txt";
                    var files = Directory.EnumerateFiles(fbd.FileName, "*.*", SearchOption.AllDirectories)
                        .Where(s => supportedExtensions.Contains(Path.GetExtension(s).ToLower())).ToList();

                    _labelFiles.Clear();

                    ImportLabelFileData(files);
                }
            }
        }
    }

}

