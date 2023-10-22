using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Raytracer
{
    public class RenderPanel : Panel
    {
        public float AspectRatio => (float)Width / Height;
        
        private Rectangle ViewingRect => ClientRectangle;

        public RenderPanel()
        {
            SetStyle(ControlStyles.UserPaint | ControlStyles.AllPaintingInWmPaint | ControlStyles.OptimizedDoubleBuffer, true);
        }

        protected override void OnPaint(PaintEventArgs args)
        {
            if (RendererForm.Instance.CurrentFrame is not { } frame)
                return;

            args.Graphics.InterpolationMode = InterpolationMode.High;
            args.Graphics.DrawImage(frame, ViewingRect, 0, 0, Width, Height, GraphicsUnit.Pixel);
        }
    }
}