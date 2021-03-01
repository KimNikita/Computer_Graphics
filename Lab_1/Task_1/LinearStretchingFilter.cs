using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;

namespace Task_1
{
  class LinearStretchingFilter : Filters
  {
    Form1 image;

    public LinearStretchingFilter(Form1 image)
    {
      this.image = image;
    }

    internal override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
    {
      Color sourceColor = sourceImage.GetPixel(x, y);
      Color resultColor;

      float newBrightness = (sourceColor.GetBrightness() - image.minBright)*255 / (image.maxBright - image.minBright);

      resultColor = Color.FromArgb(Clamp(sourceColor.R + (int)newBrightness,0,255), Clamp(sourceColor.G + (int)newBrightness,0,255), Clamp(sourceColor.B + (int)newBrightness,0,255));

      return resultColor;
    }
  }
}
