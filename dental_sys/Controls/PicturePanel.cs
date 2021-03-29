using System;
using System.Drawing;
using System.Windows.Forms;

namespace dental_sys.Controls
{
    public sealed class PicturePanel : Panel
    {
        private bool drag;
        private float ScaleFactor = 1;
        private Point basePoint;
        private int x, y;

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
                this.ZoomExtents();
                this.LimitBasePoint(basePoint.X, basePoint.Y);
                this.Invalidate();
            }
        }

        /// <summary>
        /// Mouse button down event
        /// </summary>
        protected override void OnMouseDown(MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    this.ZoomIn();
                    break;

                case MouseButtons.Middle:
                    this.drag = true;
                    x = e.X;
                    y = e.Y;
                    break;

                case MouseButtons.Right:
                    this.ZoomOut();
                    break;
            }

            base.OnMouseDown(e);
        }

        /// <summary>
        /// Mouse button up event
        /// </summary>
        protected override void OnMouseUp(MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Middle)
                drag = false;

            base.OnMouseUp(e);
        }

        /// <summary>
        /// Mouse move event
        /// </summary>
        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (drag)
            {
                LimitBasePoint(basePoint.X + e.X - x, basePoint.Y + e.Y - y);
                x = e.X;
                y = e.Y;
                this.Invalidate();
            }

            base.OnMouseMove(e);
        }

        /// <summary>
        /// Resize event
        /// </summary>
        protected override void OnResize(EventArgs e)
        {
            LimitBasePoint(basePoint.X, basePoint.Y);
            this.Invalidate();

            base.OnResize(e);
        }

        /// <summary>
        /// Paint event
        /// </summary>
        protected override void OnPaint(PaintEventArgs pe)
        {
            if (this.BackgroundImage != null)
            {
                Rectangle src = new Rectangle(0, 0, BackgroundImage.Width, BackgroundImage.Height);
                Rectangle dst = new Rectangle(basePoint.X, basePoint.Y, (int)(BackgroundImage.Width * ScaleFactor), (int)(BackgroundImage.Height * ScaleFactor));
                pe.Graphics.DrawImage(BackgroundImage, dst, src, GraphicsUnit.Pixel);
            }

            base.OnPaint(pe);
        }

        private void ZoomExtents()
        {
            if (this.BackgroundImage != null)
                this.ScaleFactor = (float)Math.Min((double)this.Width / this.BackgroundImage.Width, (double)this.Height / this.BackgroundImage.Height);
        }

        private void ZoomIn()
        {
            if (ScaleFactor < 10)
            {
                int x = (int)((this.Width / 2 - basePoint.X) / ScaleFactor);
                int y = (int)((this.Height / 2 - basePoint.Y) / ScaleFactor);
                ScaleFactor *= 2;
                LimitBasePoint((int)(this.Width / 2 - x * ScaleFactor), (int)(this.Height / 2 - y * ScaleFactor));
                this.Invalidate();
            }
        }

        private void ZoomOut()
        {
            if (ScaleFactor > .1)
            {
                int x = (int)((this.Width / 2 - basePoint.X) / ScaleFactor);
                int y = (int)((this.Height / 2 - basePoint.Y) / ScaleFactor);
                ScaleFactor /= 2;
                LimitBasePoint((int)(this.Width / 2 - x * ScaleFactor), (int)(this.Height / 2 - y * ScaleFactor));
                this.Invalidate();
            }
        }

        private void LimitBasePoint(int x, int y)
        {
            if (this.BackgroundImage == null)
                return;

            int width = this.Width - (int)(BackgroundImage.Width * ScaleFactor);
            int height = this.Height - (int)(BackgroundImage.Height * ScaleFactor);
            if (width < 0)
            {
                x = Math.Max(Math.Min(x, 0), width);
            }
            else
            {
                x = width / 2;
            }
            if (height < 0)
            {
                y = Math.Max(Math.Min(y, 0), height);
            }
            else
            {
                y = height / 2;
            }
            basePoint = new Point(x, y);
        }
    }
}
