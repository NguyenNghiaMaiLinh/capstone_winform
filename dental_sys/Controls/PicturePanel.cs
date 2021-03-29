using System.Drawing;
using System.Windows.Forms;

namespace dental_sys.Controls
{
    public sealed class PicturePanel : Panel
    {
        public PicturePanel()
        {
            this.DoubleBuffered = true;
            this.AutoScroll = true;
            this.BackgroundImageLayout = ImageLayout.Center;
        }
        public override Image BackgroundImage
        {
            get => base.BackgroundImage;
            set
            {
                base.BackgroundImage = value;
                if (value != null) this.AutoScrollMinSize = value.Size;
            }
        }
    }
}
