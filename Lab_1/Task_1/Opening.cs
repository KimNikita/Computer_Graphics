using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Drawing;

namespace Task_1
{
  class Opening : MathMorfology
  {
    Erosion erosion;
    Dilation dilation;

    public Opening(int[,] mask)
    {
      erosion = new Erosion(mask, 2, 0);
      dilation = new Dilation(mask, 2, 50);
      this.mask = mask;
    }

    public override Bitmap processImage(Bitmap sourceImage, BackgroundWorker worker)
    {
      return dilation.processImage(erosion.processImage(sourceImage, worker), worker);
    }

  }
}
