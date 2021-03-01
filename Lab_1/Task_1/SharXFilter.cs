using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
  class SharXFilter : MatrixFilter
  {
    public SharXFilter()
    {
      kernel = new float[,] { { 3, 10, 3 }, { 0, 0, 0 }, { -3, -10, -3 } };
    }
  }
}
