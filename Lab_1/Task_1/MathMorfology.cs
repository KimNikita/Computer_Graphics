using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.ComponentModel;

namespace Task_1
{
  abstract class MathMorfology : Filters
  {
    protected int[,] mask = null;
    protected int progressK = 1, progressM = 0;

    protected MathMorfology() { }

    public MathMorfology(int[,] mask)
    {
      this.mask = mask;
    }

    public int Average(Color sourceColor)
    {
      int av = (sourceColor.R + sourceColor.G + sourceColor.B) / 3;
      return av;
    }

    internal override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y) { return Color.FromArgb(0, 0, 0); }

  }
}
