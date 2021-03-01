using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Task_1
{
  class SepiaFilter : Filters
  {
    internal override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
    {
      Color sourceColor = sourceImage.GetPixel(x, y);

      int intensity = (int)(0.299 * sourceColor.R + 0.587 * sourceColor.G + 0.114 * sourceColor.B);
      int k = 60;

      Color resultColor = Color.FromArgb(Clamp(intensity + 2 * k, 0, 255), Clamp(intensity + (int)0.5 * k, 0, 255), Clamp(intensity - 1 * k, 0, 255));

      return resultColor;
    }

  }
}
