using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Brainfuck.Core.Expressions
{
  public class MovePrevious : Expression
  {
    public override void Evaluate()
    {
      Memory.Position--;
    }
  }
}
