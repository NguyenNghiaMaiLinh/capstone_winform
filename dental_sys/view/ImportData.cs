using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace dental_sys
{
    public partial class ImportData : Form
    {
        public ImportData()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofg = new OpenFileDialog();
            ofg.Filter =
                "Text Files (*.txt)|*.txt|All files (*.*)|*.*";

            //  Allow the user to select multiple images.
            ofg.Multiselect = true;
            //                   ^  ^  ^  ^  ^  ^  ^
            ofg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            ofg.Title = "My Label Browser";
            DialogResult dr = ofg.ShowDialog();
            var uploads = new List<string>();
            if (dr == DialogResult.OK)
            {
                // Read the files
                foreach (string file in ofg.FileNames)
                {
                    listBox1.Items.Add(file);
                }
                ofg.FileNames.ToList().ForEach(file =>
                {
                    uploads.Add(file);

                });
                var message = string.Format("Files Uploaded: {0} files", uploads.Count);
                MessageBox.Show(message);
            }
        }
    }
}