using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace dental_sys
{
    public partial class Item : UserControl
    {
        public Item()
        {
            InitializeComponent();
        }

        private void guna2Panel12_MouseEnter(object sender, EventArgs e)
        {
            this.guna2Panel12.FillColor = Color.FromArgb(217, 229, 242);
        }

        private void guna2Panel12_MouseLeave(object sender, EventArgs e)
        {
            this.guna2Panel12.FillColor = SystemColors.Control;
        }
        //private int _i;
        private string _name;
        private string _datetime;
        //private bool _check;

        //[Category("Custom Props")]
        //public bool Icon
        //{
        //    get { return _check; }
        //    set { _check = value;guna2CircleButton1.Image = _check ? Properties.Resources.chat__1_ : Properties.Resources.import__2_; }
        //}
        [Category("Custom Props")]
        public string Name
        {
            get { return _name; }
            set { _name = value; guna2HtmlLabel13.Text = value; }
        }
        //[Category("Custom Props")]
        //public int No
        //{
        //    get { return _i; }
        //    set { _i = value; guna2HtmlLabel2.Text = value.ToString(); }
        //}
        [Category("Custom Props")]
        public string Datetime
        {
            get { return _datetime; }
            set { _datetime = value; guna2HtmlLabel1.Text = value; }
        }

    }
}
