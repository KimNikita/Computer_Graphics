using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Task_1
{
  class MedianFilter : Filters
  {

    internal override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
    {
      Color sourceColor = sourceImage.GetPixel(x, y);

      int radMin = -2;
      int radMax = 2;

      List<int> RValues = new List<int>();
      List<int> GValues = new List<int>();
      List<int> BValues = new List<int>();

      for (int i = radMin; i < radMax; i++)
      {
        int x2 = x + i;
        if (x2 >= 0 && x2 < sourceImage.Width)
        {
          for (int j = radMin; j < radMax; j++)
          {
            int y2 = y + j;
            if (y2 >= 0 && y2 < sourceImage.Height)
            {
              RValues.Add(sourceImage.GetPixel(x2, y2).R);
              GValues.Add(sourceImage.GetPixel(x2, y2).G);
              BValues.Add(sourceImage.GetPixel(x2, y2).B);
            }
          }
        }
      }

      RValues.Sort();
      GValues.Sort();
      BValues.Sort();

      Color medianColor = Color.FromArgb(RValues[RValues.Count / 2], GValues[GValues.Count / 2], BValues[BValues.Count / 2]);
      return medianColor;
    }

  }
}
