using System;
using System.ComponentModel;
using System.Drawing;
using dental_sys.Constants;

namespace dental_sys.model
{
    public class FileModel
    {

        [DisplayName(FileHeaderConstant.Name)]
        public string NameFile { get; set; }
        [Browsable(false)]
        public string Path { get; set; }
        [Browsable(false)]
        public string Id { get; set; }
        [DisplayName(FileHeaderConstant.DateModified)]
        public string UpdatedDate { get; set; }

    }
    public class LabelFileModel : FileModel
    {

    }

    public class ImageFileModel : FileModel
    {
        [DisplayName(FileHeaderConstant.No)]
        public string No { get; set; }
        [Browsable(false)]
        public bool IsLabel { get; set; }
        [DisplayName(FileHeaderConstant.Label)]
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

    public class BoundingBox
    {
        public float X { get; set; }
        public float Y { get; set; }
        public float Width { get; set; }
        public float Height { get; set; }
    }
}
