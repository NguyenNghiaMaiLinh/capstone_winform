using dental_sys.model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using dental_sys.Constants;
using dental_sys.service;
using dental_sys.view;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace dental_sys
{
    public partial class ImportData : Form
    {
        //ICollection<string> listLabel;
        private readonly List<ImageFileModel> _imageFiles;
        private readonly List<LabelFileModel> _labelFiles;
        private readonly Dictionary<string, string> _orderDictionary;
        private readonly DataSetService _dataSetService;
        private static ImportData _instance;
        private bool _isClearData = true;
        public static ImportData Instance => _instance ?? (_instance = new ImportData());
        private ImportData()
        {
            _dataSetService = new DataSetService();
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
            TrainBtn.Enabled = false;
            //PreviousBtn.Enabled = false;
            //NextBtn.Enabled = false;
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
                //ImportDataBtn.Text = $@"Data ({_imageFiles.Count})";
            }

        }

        private void BindingData(List<ImageFileModel> imageFile, List<LabelFileModel> labelFile)
        {
            PicturePanel.Image = null;
            FileDataGridView.DataSource = null;
            FileDataGridView.DataSource = imageFile;
            SetOrderColumn();
            FileDataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            FileDataGridView_CellClick(this, null);
            if (imageFile?.Count > 0)
            {
                if (imageFile.Any(_ => !_.IsLabel))
                {
                    ClearAllInValidFileBtn.Enabled = true;
                    SendBtn.Enabled = false;
                }
                else
                {
                    ClearAllInValidFileBtn.Enabled = false;
                    SendBtn.Enabled = true;
                }

            }
            else
            {
                ClearAllInValidFileBtn.Enabled = false;
                SendBtn.Enabled = false;
            }

            ImageNumber.Text = imageFile?.Count.ToString() ?? "0";
            LabelNumber.Text = labelFile?.Count.ToString() ?? "0";
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


                foreach (var imageFileModel in _imageFiles)
                {
                    imageFileModel.IsLabel = _labelFiles.Any(w =>
                        Path.GetFileNameWithoutExtension(w.Path) ==
                        Path.GetFileNameWithoutExtension(imageFileModel.Path));
                }

                BindingData(_imageFiles, _labelFiles);
                //ImportDataBtn.Text = $@"Data ({_imageFiles.Count})";

            }
        }

        private void FileDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (FileDataGridView.CurrentRow?.DataBoundItem is ImageFileModel currentFile)
            {
                ShowImage(currentFile);
            }
        }

        private void DrawBoundingBox(LabelFileModel label, Image currentImage)
        {
            if (label != null)
            {
                var widthImage = currentImage.Width;
                var heightImage = currentImage.Height;
                Graphics g = Graphics.FromImage(currentImage);
                Pen p = new Pen(Color.Green);

                var listBoundingBox = GetBoundingBoxes(label.Path, widthImage, heightImage);

                foreach (var boundingBox in listBoundingBox)
                {
                    SolidBrush sb = new SolidBrush(Color.Red);
                    g.DrawRectangle(p, boundingBox.X, boundingBox.Y, boundingBox.Width, boundingBox.Height);
                    //g.FillRectangle(sb, boundingBox.X, boundingBox.Y, boundingBox.Width, boundingBox.Height);
                }

            }
        }

        private ICollection<BoundingBox> GetBoundingBoxes(string labelPath, int widthImage, int heightImage)
        {
            string[] lines = File.ReadAllLines(labelPath);
            var listBoundingBox = new List<BoundingBox>();
            foreach (var line in lines)
            {
                var item = line.Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                var boundingBox = new BoundingBox()
                {
                    X = float.Parse(item[1]) * widthImage,
                    Y = float.Parse(item[2]) * heightImage,
                    Width = float.Parse(item[3]) * widthImage,
                    Height = float.Parse(item[4]) * heightImage,

                };
                boundingBox.X = boundingBox.X - boundingBox.Width / 2;
                boundingBox.Y = boundingBox.Y - boundingBox.Height / 2;
                listBoundingBox.Add(boundingBox);
            }

            return listBoundingBox;
        }


        private void FileDataGridView_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
            e.Column.DefaultCellStyle = new DataGridViewCellStyle()
            {
                Alignment = DataGridViewContentAlignment.MiddleCenter
            };
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

            _imageFiles.Clear();
            _imageFiles.AddRange(imageFiles);
            BindingData(_imageFiles, _labelFiles);
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            var currentRow = FileDataGridView.CurrentCell?.RowIndex ?? 0;
            if (currentRow >= 0)
            {
                if (currentRow + 1 < _imageFiles.Count)
                {
                    FileDataGridView.CurrentCell = FileDataGridView.Rows[currentRow + 1].Cells[0];

                    var currentFile = _imageFiles[currentRow + 1];

                    ShowImage(currentFile);
                }

            }
        }

        private void PreviousBtn_Click(object sender, EventArgs e)
        {
            var currentRow = FileDataGridView.CurrentCell?.RowIndex ?? 0;
            if (currentRow >= 1)
            {
                FileDataGridView.CurrentCell = FileDataGridView.Rows[currentRow - 1].Cells[0];

                var currentFile = _imageFiles[currentRow - 1];

                ShowImage(currentFile);
            }
        }

        private void ShowImage(ImageFileModel fileModel)
        {

            var currentImage = Image.FromFile(fileModel.Path);

            var fileName = Path.GetFileNameWithoutExtension(fileModel.Path);

            var label = _labelFiles.FirstOrDefault(w => Path.GetFileNameWithoutExtension(w.Path) == fileName);

            DrawBoundingBox(label, currentImage);

            PicturePanel.Image = currentImage;
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
            var no = 1;
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

            BindingData(_imageFiles, _labelFiles);
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

                    foreach (var imageFileModel in _imageFiles)
                    {
                        imageFileModel.IsLabel = _labelFiles.Any(w =>
                            Path.GetFileNameWithoutExtension(w.Path) ==
                            Path.GetFileNameWithoutExtension(imageFileModel.Path));
                    }

                    if (_imageFiles.Count > 0)
                    {
                        BindingData(_imageFiles, _labelFiles);
                    }


                }
            }
        }

        private void ImportData_KeyDown(object sender, KeyEventArgs e)
        {
            PicturePanel.CtrlKeyDown = e.Control;
            PicturePanel.Drag = PicturePanel.CtrlKeyDown;
        }

        private void ImportData_KeyUp(object sender, KeyEventArgs e)
        {
            PicturePanel.CtrlKeyDown = false;
            PicturePanel.Drag = PicturePanel.CtrlKeyDown;
        }

        private void ClearAllInValidFileBtn_Click(object sender, EventArgs e)
        {
            _imageFiles.RemoveAll(w => !w.IsLabel);
            BindingData(_imageFiles, _labelFiles);
        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (_dataSetService.IsTraining())
                {
                    MessageBox.Show(@"Server is training! Please try later.");
                }
                else
                {
                    if (_imageFiles.Any(w => !w.IsLabel))
                    {
                        MessageBox.Show(@"There is still an image without a label.");
                    }
                    else
                    {
                        var waitForm = new WaitFormFunc();
                        waitForm.Show();
                        var isSuccess = _dataSetService.TransferData(_imageFiles, _labelFiles, _isClearData);
                        _isClearData = false;
                        waitForm.Close();
                        if (isSuccess)
                        {
                            MessageBox.Show(@"Data has been sent successfully.", "Message",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                            _imageFiles.Clear();
                            _labelFiles.Clear();
                            BindingData(null, null);
                            TrainBtn.Enabled = true;
                        }
                        else
                        {
                            TrainBtn.Enabled = false;
                            MessageBox.Show(@"Failed to sent data. Please try again later", "Message",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                }
            }
            catch (Exception exception)
            {
                TrainBtn.Enabled = false;
                ExceptionLogging.SendErrorToText(exception, nameof(this.SendBtn_Click), nameof(ImportData));
                MessageBox.Show(@"Failed to sent data. Please try again later", "Message",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void TrainBtn_Click(object sender, EventArgs e)
        {
            var ofg = new OpenFileDialog
            {
                Filter = @"Configure Files (*.cfg)|*.cfg",
                Multiselect = false,
                //InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                Title = @"My Configure Browser",
                RestoreDirectory = true,
            };

            //  Allow the user to select multiple images.
            var dr = ofg.ShowDialog();
            if (dr == DialogResult.OK)
            {

                if (_dataSetService.IsTraining())
                {
                    MessageBox.Show(@"Server is training! Please try later");
                }
                else
                {
                    var waitForm = new WaitFormFunc();
                    waitForm.Show();
                    var isSuccess = _dataSetService.TrainData(ofg.FileName);
                    waitForm.Close();
                    if (isSuccess)
                    {
                        MessageBox.Show(@"The system is processing. Please wait for the notification.", "Message",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show(@"An error occurred while training. Please try again later", "Message",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }
    }

}

