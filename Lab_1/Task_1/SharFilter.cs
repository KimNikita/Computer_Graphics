using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
  class SharFilter : Filters
  {
    SharXFilter filter1;
    SharYFilter filter2;

    public SharFilter()
    {
      filter1 = new SharXFilter();
      filter2 = new SharYFilter();
    }

    internal override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
    {
      Color color1 = filter1.calculateNewPixelColor(sourceImage, x, y);
      Color color2 = filter2.calculateNewPixelColor(sourceImage, x, y);
      return Color.FromArgb(Clamp(Math.Abs(color1.R) + Math.Abs(color2.R), 0, 255), Clamp(Math.Abs(color1.G) + Math.Abs(color2.G), 0, 255), Clamp(Math.Abs(color1.B) + Math.Abs(color2.B), 0, 255));
    }
  }
}
