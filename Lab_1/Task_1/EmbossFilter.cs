using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;

namespace Task_1
{
  class EmbossFilter : MatrixFilter
  {
    GrayScaleFilter filter;

    public EmbossFilter()
    {
      kernel = new float[,] { { 0, 1, 0 }, { 1, 0, -1 }, { 0, -1, 0 } };
      filter = new GrayScaleFilter();
    }

    public override Bitmap processImage(Bitmap sourceImage, BackgroundWorker worker)
    {
      Bitmap tempImage = new Bitmap(sourceImage.Width, sourceImage.Height);
      Bitmap resultImage = new Bitmap(sourceImage.Width, sourceImage.Height);

      for (int i = 0; i < sourceImage.Width; i++)
      {
        worker.ReportProgress((int)((float)i / tempImage.Width * 50));
        if (worker.CancellationPending)
          return null;

        for (int j = 0; j < sourceImage.Height; j++)
        {
          tempImage.SetPixel(i, j, filter.calculateNewPixelColor(sourceImage, i, j));
        }
      }

      for (int i = 0; i < sourceImage.Width; i++)
      {
        worker.ReportProgress((int)((float)i / resultImage.Width * 50) + 50);
        if (worker.CancellationPending)
          return null;

        for (int j = 0; j < sourceImage.Height; j++)
        {
          resultImage.SetPixel(i, j, calculateNewPixelColor(tempImage, i, j));
        }
      }

      return resultImage;
    }

    internal override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y)
    {
      int radiusX = kernel.GetLength(0) / 2;
      int radiusY = kernel.GetLength(1) / 2;

      float resultR = 0;
      float resultG = 0;
      float resultB = 0;

      for (int l = -radiusY; l <= radiusY; l++)
        for (int k = -radiusX; k <= radiusX; k++)
        {
          int idX = Clamp(x + k, 0, sourceImage.Width - 1);
          int idY = Clamp(y + l, 0, sourceImage.Height - 1);
          Color neighborColor = sourceImage.GetPixel(idX, idY);
          resultR += neighborColor.R * kernel[k + radiusX, l + radiusY];
          resultG += neighborColor.G * kernel[k + radiusX, l + radiusY];
          resultB += neighborColor.B * kernel[k + radiusX, l + radiusY];
        }

      return Color.FromArgb(Clamp((int)(resultR + 255) / 2, 0, 255), Clamp((int)(resultG + 255) / 2, 0, 255), Clamp((int)(resultB + 255) / 2, 0, 255));
    }

  }
}
