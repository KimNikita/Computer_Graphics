using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Task_1
{
  class SobelXFilter : MatrixFilter
  {
    public SobelXFilter()
    {
      kernel = new float[,] { { -1, 0, 1 }, { -2, 0, 2 }, { -1, 0, 1 } };
    }
  }
}
