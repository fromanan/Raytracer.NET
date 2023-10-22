using System.ComponentModel;
using System.Drawing;
using System.Numerics;
using Raytracer.Rendering;

namespace Raytracer
{
    public class RenderWorker : BackgroundWorker
    {
        public Bitmap? CurrentRender { get; private set; }
        
        public void InitializeWorker()
        {
            WorkerReportsProgress = true;
            WorkerSupportsCancellation = true;
            DoWork += DoRenderWork;
        }

        private void DoRenderWork(object? sender, DoWorkEventArgs args)
        {
            args.Result = RenderFrame((RenderArgs) args.Argument!);
        }
        
        public Bitmap? RenderFrame(RenderArgs args)
        {
            int width = args.ViewingRect.Width;
            int height = args.ViewingRect.Height;
            int numPixels = width * height;
            
            Bitmap frame = new(width, height, RendererForm.UserSettings.PixelFormat);

            for (int i = 0; i < numPixels; ++i)
            {
                if (CancellationPending)
                    return null;
                
                int x = i % width;
                int y = i / width;

                Vector3 color = Renderer.Raycast(args.Camera, new Rectangle(x, y, width, height));
                
                frame.SetPixel(x, y, color.SystemColor());

                if (x == 0)
                {
                    CurrentRender = frame.Clone() as Bitmap;
                    ReportProgress((int)(i / (float) numPixels * 100));
                }
            }

            return frame;
        }
    }
}