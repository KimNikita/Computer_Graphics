using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Drawing;

namespace Task_1
{
  class BlackHat : MathMorfology
  {
    Dilation dilation;

    public BlackHat(int[,] mask)
    {
      dilation = new Dilation(mask, 2, 0);
      this.mask = mask;
    }

    public override Bitmap processImage(Bitmap sourceImage, BackgroundWorker worker)
    {
      Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height), tempImage;
      tempImage = dilation.processImage(sourceImage, worker);

      for (int i = 0; i < sourceImage.Width; i++)
      {
        worker.ReportProgress((int)((float)i / resultImage.Width * 50) + 50);
        if (worker.CancellationPending)
          return null;

        for (int j = 0; j < sourceImage.Height; j++)
        {
          int r = Clamp(tempImage.GetPixel(i, j).R - sourceImage.GetPixel(i, j).R, 0, 255);
          int g = Clamp(tempImage.GetPixel(i, j).G - sourceImage.GetPixel(i, j).G, 0, 255);
          int b = Clamp(tempImage.GetPixel(i, j).B - sourceImage.GetPixel(i, j).B, 0, 255);

          resultImage.SetPixel(i, j, Color.FromArgb(r, g, b));
        }
      }

      return resultImage;
    }

  }
}
