using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Brainfuck.Core.Expressions
{
  public class LeftBracket : Expression
  {
    public override void Evaluate()
    {
      MemoryZeroValue = (Memory.Value != 0);
    }
  }
}
