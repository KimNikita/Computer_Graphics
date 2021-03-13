using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;

namespace Task_1
{
  class ShinyFilter : Filters
  {
    MedianFilter filter1;
    SobelFilter filter2;
    protected int rad;

    public ShinyFilter(int rad)
    {
      this.rad = rad;
      filter1 = new MedianFilter(2);
      filter2 = new SobelFilter();
    }

    public override Bitmap processImage(Bitmap sourceImage, BackgroundWorker worker)
    {
      Bitmap temp1Image = new Bitmap(sourceImage.Width, sourceImage.Height);
      Bitmap temp2Image = new Bitmap(sourceImage.Width, sourceImage.Height);
      Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);

      for (int i = 0; i < sourceImage.Width; i++)
      {
        worker.ReportProgress((int)((float)i / temp1Image.Width * 33));
        if (worker.CancellationPending)
          return null;

        for (int j = 0; j < sourceImage.Height; j++)
        {
          temp1Image.SetPixel(i, j, filter1.calculateNewPixelColor(sourceImage, i, j));
        }
      }

      for (int i = 0; i < sourceImage.Width; i++)
      {
        worker.ReportProgress((int)((float)i / temp2Image.Width * 33) + 33);
        if (worker.CancellationPending)
          return null;

        for (int j = 0; j < sourceImage.Height; j++)
        {
          temp2Image.SetPixel(i, j, filter2.calculateNewPixelColor(temp1Image, i, j));
        }
      }

      for (int i = 0; i < sourceImage.Width; i++)
      {
        worker.ReportProgress((int)((float)i / resultImage.Width * 33) + 66);
        if (worker.CancellationPending)
          return null;

        for (int j = 0; j < sourceImage.Height; j++)
        {
          resultImage.SetPixel(i, j, calculateNewPixelColor(temp2Image, i, j));
        }
      }

      return resultImage;
    }

    internal override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
    {
      Color sourceColor = sourceImage.GetPixel(x, y);

      int radMin = -rad;
      int radMax = rad;

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

      Color hierColor = Color.FromArgb(RValues.Max(), GValues.Max(), BValues.Max());
      return hierColor;
    }

  }
}
