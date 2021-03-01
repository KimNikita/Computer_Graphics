using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Task_1
{
  class GlassFilter : Filters
  {
    Form1 image;

    public GlassFilter(Form1 image)
    {
      this.image = image;
    }

    internal override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
    {
      int newX = Clamp((int)(x + (image.rand.NextDouble() - 0.5) * 10), 0, sourceImage.Width - 1);
      int newY = Clamp((int)(y + (image.rand.NextDouble() - 0.5) * 10), 0, sourceImage.Height - 1);

      return Color.FromArgb(sourceImage.GetPixel(newX, newY).R, sourceImage.GetPixel(newX, newY).G, sourceImage.GetPixel(newX, newY).B);
    }

  }
}
