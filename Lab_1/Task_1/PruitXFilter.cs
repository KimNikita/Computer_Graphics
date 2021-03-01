using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
  class PruitXFilter : MatrixFilter
  {
    public PruitXFilter()
    {
      kernel = new float[,] { { -1, 0, 1 }, { -1, 0, 1 }, { -1, 0, 1 } };
    }
  }
}
