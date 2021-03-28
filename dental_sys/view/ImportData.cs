using dental_sys.model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace dental_sys
{
    public partial class ImportData : Form
    {
        ICollection<string> listData;
        ICollection<string> listLabel;
        public ImportData()
        {
            listData = new List<string>();
            listLabel = new List<string>();
            InitializeComponent();
        }

        private void ImportDataBtn_Click(object sender, EventArgs e)
        {
            var ofg = new OpenFileDialog();
            ofg.Filter = @"Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

            //  Allow the user to select multiple images.
            ofg.Multiselect = true;
            ofg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            ofg.Title = @"My Data Browser";
            DialogResult dr = ofg.ShowDialog();
            var uploads = new List<string>();
            if (dr == DialogResult.OK)
            {

                ofg.FileNames.ToList().ForEach(file =>
                {
                    listData.Add(file);

                });
                ImportDataBtn.Text = $@"Import Data ({listData.Count})";
            }
            //if (listLabel.Count > 0)
            //{
            var col = new DataGridViewTextBoxColumn()
            {
                Visible = false
            };
            FileDataGridView.Columns.Add(col);
            FileDataGridView.Rows.Add(listData.Count);
            var fileDatas = GetNames(listData);
            var fileLabels = GetNames(listLabel);
            for (int i = 0; i < fileDatas.Count; i++)
            {
                bool check = Check(fileLabels, fileDatas[i].NameFile);
                int no = i;
                FileDataGridView.Rows[i].Cells[0].Value = (no++).ToString();
                FileDataGridView.Rows[i].Cells[1].Value = fileDatas[i].NameFile;
                FileDataGridView.Rows[i].Cells[2].Value = "01/02/2021";
                FileDataGridView.Rows[i].Cells[3].Value = check ? Properties.Resources._checked : Properties.Resources.uncheck;
                FileDataGridView.Rows[i].Cells[4].Value = fileDatas[i].Path;
            }
            //}
        }
        private bool Check(List<FileModel> labels, string data)
        {
            foreach (var item in labels)
            {
                if (data.Equals(item.NameFile))
                {
                    return true;
                }
            }
            return false;
        }
        private List<FileModel> GetNames(ICollection<string> listTemp)
        {
            List<FileModel> result = new List<FileModel>();
            for (int i = 0; i < listTemp.Count; i++)
            {
                string path = listTemp.ToList()[i];
                int start = path.LastIndexOf(@"\");
                string fileName = path.Substring((start + 1));
                int end = fileName.IndexOf(".");
                fileName = fileName.Substring(0, end);
                FileModel file = new FileModel();
                file.NameFile = fileName;
                file.Path = path;
                result.Add(file);
            }
            return result;
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
            ofg.Filter =
                "Text Files (*.txt)|*.txt";

            //  Allow the user to select multiple images.
            ofg.Multiselect = true;
            ofg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            ofg.Title = "My Label Browser";
            DialogResult dr = ofg.ShowDialog();
            var uploads = new List<string>();
            if (dr == DialogResult.OK)
            {

                ofg.FileNames.ToList().ForEach(file =>
                {
                    listLabel.Add(file);

                });
                ImportLabelBtn.Text = $"Import Label ({listLabel.Count})";

            }
        }

        private void FileDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string path = FileDataGridView.CurrentRow.Cells[4].Value.ToString();

            PicturePanel.BackgroundImage = Image.FromFile(path);
            //PictureBox.Image = Image.FromFile(path);
            //PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
        }
    }

}

