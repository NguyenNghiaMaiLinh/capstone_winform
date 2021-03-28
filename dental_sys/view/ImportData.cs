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

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofg = new OpenFileDialog();
            ofg.Filter =
                "Image Files (*.PNG)|*.PNG";

            //  Allow the user to select multiple images.
            ofg.Multiselect = true;
            ofg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            ofg.Title = "My Data Browser";
            DialogResult dr = ofg.ShowDialog();
            var uploads = new List<string>();
            if (dr == DialogResult.OK)
            {

                ofg.FileNames.ToList().ForEach(file =>
                {
                    listData.Add(file);

                });
                guna2Button1.Text = $"Import Data ({listData.Count})";
            }
            if (listLabel.Count > 0)
            {
                guna2DataGridView2.Rows.Add(listData.Count);
                var fileDatas = GetNames(listData);
                var fileLabels = GetNames(listLabel);
                for (int i = 0; i < fileDatas.Count; i++)
                {
                    bool check = Check(fileLabels, fileDatas[i].NameFile);
                    int no = i;
                    guna2DataGridView2.Rows[i].Cells[1].Value = (no++).ToString();
                    guna2DataGridView2.Rows[i].Cells[2].Value = fileDatas[i].NameFile;
                    guna2DataGridView2.Rows[i].Cells[3].Value = "01/02/2021";
                    guna2DataGridView2.Rows[i].Cells[4].Value = check ? Properties.Resources._checked : Properties.Resources.uncheck;
                    guna2DataGridView2.Rows[i].Cells[5].Value = fileDatas[i].Path;
                }
            }
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

        private void guna2Button5_Click(object sender, EventArgs e)
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
                guna2Button5.Text = $"Import Label ({listLabel.Count})";

            }
        }

        private void guna2DataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string path = guna2DataGridView2.CurrentRow.Cells[5].Value.ToString();
            pictureBox1.Image = Image.FromFile(path);
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {

        }
    }
}