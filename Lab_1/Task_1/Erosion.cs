using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Drawing;

namespace Task_1
{
  class Erosion : MathMorfology
  {
    public Erosion(int[,] mask, int pk, int pm)
    {
      this.mask = mask;
      progressK = pk;
      progressM = pm;
    }

    public override Bitmap processImage(Bitmap sourceImage, BackgroundWorker worker)
    {
      Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);

      for (int y = 1; y < sourceImage.Height - 1; y++)
      {
        worker.ReportProgress((int)((float)y / resultImage.Height * 100 / progressK) + progressM);
        if (worker.CancellationPending)
          return null;

        for (int x = 1; x < sourceImage.Width - 1; x++)
        {
          int minR = 255;
          int minG = 255;
          int minB = 255;
          for (int j = -1; j <= 1; j++)
            for (int i = -1; i <= 1; i++)
              if (mask[1 + i, 1 + j] == 1)
              {
                if (sourceImage.GetPixel(x + i, y + j).R < minR)
                  minR = sourceImage.GetPixel(x + i, y + j).R;
                if (sourceImage.GetPixel(x + i, y + j).G < minG)
                  minG = sourceImage.GetPixel(x + i, y + j).G;
                if (sourceImage.GetPixel(x + i, y + j).B < minB)
                  minB = sourceImage.GetPixel(x + i, y + j).B;
              }
          resultImage.SetPixel(x, y, Color.FromArgb(minR, minG, minB));
        }
      }

      return resultImage;
    }

  }
}
