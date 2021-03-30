using System;
using System.Drawing;
using System.Windows.Forms;

namespace dental_sys.Controls
{
    public sealed class PicturePanel : Panel
    {
        public bool Drag { get; set; }
        private float _scaleFactor = 1;
        private Point _basePoint;
        private int x, y;
        public bool CtrlKeyDown { get; set; }
        private bool _leftClick;
        private Image image;
        public PicturePanel()
        {
            CtrlKeyDown = false;
            _leftClick = false;
            DoubleBuffered = true;
            AutoScroll = true;
            //imageLayout = ImageLayout.Center;
        }

        public Image Image
        {
            get => this.image;
            set
            {
                this.image = value;
                this.ZoomExtents();
                this.LimitBasePoint(_basePoint.X, _basePoint.Y);
                this.Invalidate();
            }
        }

        protected override void OnMouseWheel(MouseEventArgs e)
        {
            bool IsGoUp = e.Delta > 0 ? true : false;

            if (CtrlKeyDown)

            {
                if (IsGoUp)

                {

                    this.ZoomIn();
                }
                else
                {
                    this.ZoomOut();
                }

            }

            base.OnMouseDown(e);
        }

        /// <summary>
        /// Mouse button down event
        /// </summary>
        protected override void OnMouseDown(MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    _leftClick = true;
                    if (Drag)
                    {
                        x = e.X;
                        y = e.Y;
                    }

                    break;
            }

            base.OnMouseDown(e);
        }

        /// <summary>
        /// Mouse button up event
        /// </summary>
        protected override void OnMouseUp(MouseEventArgs e)
        {
            switch (e.Button)
            {
                case MouseButtons.Left:
                    _leftClick = false;
                    if (Drag)
                    {
                        x = e.X;
                        y = e.Y;
                    }

                    break;
            }

            base.OnMouseUp(e);
        }

        /// <summary>
        /// Mouse move event
        /// </summary>
        protected override void OnMouseMove(MouseEventArgs e)
        {
            if (Drag && _leftClick)
            {
                LimitBasePoint(_basePoint.X + e.X - x, _basePoint.Y + e.Y - y);
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
            LimitBasePoint(_basePoint.X, _basePoint.Y);
            this.Invalidate();

            base.OnResize(e);
        }

        /// <summary>
        /// Paint event
        /// </summary>
        protected override void OnPaint(PaintEventArgs pe)
        {
            if (this.image != null)
            {
                Rectangle src = new Rectangle(0, 0, image.Width, image.Height);
                Rectangle dst = new Rectangle(_basePoint.X, _basePoint.Y, (int)(image.Width * _scaleFactor), (int)(image.Height * _scaleFactor));
                pe.Graphics.DrawImage(image, dst, src, GraphicsUnit.Pixel);
            }

            base.OnPaint(pe);
        }

        private void ZoomExtents()
        {
            if (this.image != null)
                this._scaleFactor = (float)Math.Min((double)this.Width / this.image.Width, (double)this.Height / this.image.Height);
        }

        private void ZoomIn()
        {
            if (_scaleFactor < 10)
            {
                int x = (int)((this.Width / 2 - _basePoint.X) / _scaleFactor);
                int y = (int)((this.Height / 2 - _basePoint.Y) / _scaleFactor);
                _scaleFactor *= 2;
                LimitBasePoint((int)(this.Width / 2 - x * _scaleFactor), (int)(this.Height / 2 - y * _scaleFactor));
                this.Invalidate();
            }
        }

        private void ZoomOut()
        {
            if (_scaleFactor > .1)
            {
                int x = (int)((this.Width / 2 - _basePoint.X) / _scaleFactor);
                int y = (int)((this.Height / 2 - _basePoint.Y) / _scaleFactor);
                _scaleFactor /= 2;
                LimitBasePoint((int)(this.Width / 2 - x * _scaleFactor), (int)(this.Height / 2 - y * _scaleFactor));
                this.Invalidate();
            }
        }

        private void LimitBasePoint(int x, int y)
        {
            if (this.image == null)
                return;

            int width = this.Width - (int)(image.Width * _scaleFactor);
            int height = this.Height - (int)(image.Height * _scaleFactor);
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
            _basePoint = new Point(x, y);
        }
    }
}
