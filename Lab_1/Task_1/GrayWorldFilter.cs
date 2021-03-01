using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Task_1
{
  class GrayWorldFilter : Filters
  {
    Form1 image;

    public GrayWorldFilter(Form1 image)
    {
      this.image = image;
    }

    internal override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
    {
    
      return Color.FromArgb(Clamp((int)(sourceImage.GetPixel(x, y).R * image.Avg / image.Rav), 0, 255),
        Clamp((int)(sourceImage.GetPixel(x, y).G * image.Avg / image.Gav), 0, 255),
        Clamp((int)(sourceImage.GetPixel(x, y).B * image.Avg / image.Bav), 0, 255));
    }

  }
}
