using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Brainfuck.Core.Expressions
{
  public class Comma : Expression
  {
    public override void Evaluate()
    {
      Console.Write((char)Memory.Value);
    }
  }
}
