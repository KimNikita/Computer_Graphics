using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Drawing;

namespace Task_1
{
  class Closing : MathMorfology
  {
    Erosion erosion;
    Dilation dilation;

    public Closing(int[,] mask)
    {
      erosion = new Erosion(mask, 2, 50);
      dilation = new Dilation(mask, 2, 0);
      this.mask = mask;
    }

    public override Bitmap processImage(Bitmap sourceImage, BackgroundWorker worker)
    {
      return erosion.processImage(dilation.processImage(sourceImage, worker), worker);
    }

  }
}
