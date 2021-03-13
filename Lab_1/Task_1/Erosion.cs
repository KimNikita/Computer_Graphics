﻿using System;
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
          int bright = 255;
          int im = 0, jm = 0;
          for (int j = -1; j <= 1; j++)
            for (int i = -1; i <= 1; i++)
              if (mask[1 + i, 1 + j] == 1 && Bright(sourceImage.GetPixel(x + i, y + j)) < bright)
              {
                bright = Bright(sourceImage.GetPixel(x + i, y + j));
                im = i;
                jm = j;
              }
          resultImage.SetPixel(x, y, sourceImage.GetPixel(x + im, y + jm));
        }
      }

      return resultImage;
    }

  }
}
