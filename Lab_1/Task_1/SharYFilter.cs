using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
  class SharYFilter : MatrixFilter
  {
    public SharYFilter()
    {
      kernel = new float[,] { { 3, 0, -3 }, { 10, 0, -10 }, { 3, 0, -3 } };
    }
  }
}
