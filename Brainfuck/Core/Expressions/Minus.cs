using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Brainfuck.Core.Expressions
{
  public class Minus : Expression
  {
    public override void Evaluate()
    {
      Memory.Value--;
    }
  }
}
