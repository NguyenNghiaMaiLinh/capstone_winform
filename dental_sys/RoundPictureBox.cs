using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace dental_sys.view
{
    public  class RoundPictureBox :PictureBox
    {
        protected override void OnPaint(PaintEventArgs pr)
        {
            GraphicsPath graphics = new GraphicsPath();
            graphics.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(graphics);
            base.OnPaint(pr);
        } 
    }
}
