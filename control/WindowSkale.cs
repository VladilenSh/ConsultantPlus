using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace ConsultantPlus.control
{
    internal class WindowSkale
    {
        private static MainWindow w;

        public static void Skale1_25(MainWindow W)
        {
            w = W;
            var scaler = w.mainPanel.LayoutTransform as ScaleTransform;

            if (scaler == null)
            {
                w.mainPanel.LayoutTransform = new ScaleTransform(1.25, 1.25);
                w.Height = 560;
                w.Width = 1000;
            }
            else
            {
                double curZoomFactor = scaler.ScaleX;

                if (scaler.HasAnimatedProperties)
                {
                    scaler.BeginAnimation(ScaleTransform.ScaleXProperty, null);
                    scaler.BeginAnimation(ScaleTransform.ScaleYProperty, null);
                }

                if (curZoomFactor == 1.0)
                {
                    scaler.ScaleX = 1.25;
                    scaler.ScaleY = 1.25;
                    w.Height = 560;
                    w.Width = 1000;
                }
                else
                {
                    scaler.ScaleX = 1.0;
                    scaler.ScaleY = 1.0;
                    w.Height = 448;
                    w.Width = 800;
                }
            }
        }
    }
}
