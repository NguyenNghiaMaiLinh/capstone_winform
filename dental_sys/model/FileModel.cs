using System;
using System.ComponentModel;
using System.Drawing;

namespace dental_sys.model
{
    public class FileModel
    {

        [DisplayName("Name")]
        public string NameFile { get; set; }
        [Browsable(false)]
        public string Path { get; set; }
        [Browsable(false)]
        public string Id { get; set; }
        [DisplayName("Date modified")]
        public string UpdatedDate { get; set; }

    }
    public class LabelFileModel : FileModel
    {

    }

    public class ImageFileModel : FileModel
    {
        [DisplayName("No")]
        public string No { get; set; }
        [Browsable(false)]
        public bool IsLabel { get; set; }
        [DisplayName("Label")]
        public Bitmap Label => IsLabel ? Properties.Resources._checked : Properties.Resources.uncheck;
    }

    public class DisplayIndexAttribute : Attribute
    {
        public int Order { get; }

        public DisplayIndexAttribute(int order)
        {
            if (order < 0)
            {
                throw new ArgumentException($"{nameof(order)}  not be negative");
            }

            Order = order;
        }
    }
}
