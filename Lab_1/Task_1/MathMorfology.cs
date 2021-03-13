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

    public int Bright(Color sourceColor)
    {
      int bright = (int)(sourceColor.R * 0.299 + sourceColor.G * 0.587 + sourceColor.B * 0.114);
      return bright;
    }

    internal override Color calculateNewPixelColor(Bitmap sourceImage, int x, int y) { return Color.FromArgb(0, 0, 0); }

  }
}
