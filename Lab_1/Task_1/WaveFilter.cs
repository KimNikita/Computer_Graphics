using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Task_1
{
  class WaveFilter : Filters
  {
    internal override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
    {
      int newX = Clamp((int)(x + 20 * Math.Sin(2 * Math.PI * y / 60)), 0, sourceImage.Width - 1);
      int newY = y;

      return Color.FromArgb(sourceImage.GetPixel(newX, newY).R, sourceImage.GetPixel(newX, newY).G, sourceImage.GetPixel(newX, newY).B);
    }

  }
}
