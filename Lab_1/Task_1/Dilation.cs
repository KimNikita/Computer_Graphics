using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
  class Dilation : MathMorfology
  {
    public Dilation(int[,] mask, int pk, int pm)
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
          int maxR = 0;
          int maxG = 0;
          int maxB = 0;
          for (int j = -1; j <= 1; j++)
            for (int i = -1; i <= 1; i++)
              if (mask[1 + i, 1 + j] == 1)
              {
                if (sourceImage.GetPixel(x + i, y + j).R > maxR)
                  maxR = sourceImage.GetPixel(x + i, y + j).R;
                if (sourceImage.GetPixel(x + i, y + j).G > maxG)
                  maxG = sourceImage.GetPixel(x + i, y + j).G;
                if (sourceImage.GetPixel(x + i, y + j).B > maxB)
                  maxB = sourceImage.GetPixel(x + i, y + j).B;
              }
          resultImage.SetPixel(x, y, Color.FromArgb(maxR, maxG, maxB));
        }
      }

      return resultImage;
    }

  }
}
