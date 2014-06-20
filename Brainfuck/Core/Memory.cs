using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Brainfuck.Core
{
  public static class Memory
  {
    const int MEM_SIZE = 2048;
    static int[] mem = new int[MEM_SIZE];
    static int pos = 0;

    public static int Position
    {
      get
      {
        return pos;
      }
      set
      {
        if (value < 0)
          pos = 0;
        else if (value >= MEM_SIZE)
          pos = MEM_SIZE - 1;
        else
          pos = value;
      }
    }

    public static int Value
    {
      get
      {
        return mem[Position];
      }
      set
      {
        mem[Position] = value;
      }
    }


  }
}
