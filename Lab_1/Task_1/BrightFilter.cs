using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Task_1
{
  class BrightFilter : Filters
  {
    internal override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
    {
      Color sourceColor = sourceImage.GetPixel(x, y);
      int k = 60;

      Color resultColor = Color.FromArgb(Clamp(sourceColor.R + k, 0, 255), Clamp(sourceColor.G + k, 0, 255), Clamp(sourceColor.B + k, 0, 255));

      return resultColor;
    }

  }
}
