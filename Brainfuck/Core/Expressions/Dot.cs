using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Brainfuck.Core.Expressions
{
  public class Dot : Expression
  {
    private string prevConsoleTitle = "";

    public Dot()
    {
      OnBeforeEvaluate += new Action(Dot_OnBeforeEvaluate);
      OnAfterEvaluate += new Action(Dot_OnAfterEvaluate);
    }

    void Dot_OnAfterEvaluate()
    {
      Console.Title = prevConsoleTitle;
    }

    void Dot_OnBeforeEvaluate()
    {
      string prevConsoleTitle = Console.Title;
      Console.Title = "Enter a key... ";
    }

    public override void Evaluate()
    {
      ConsoleKeyInfo cki = Console.ReadKey(true);
      Memory.Value = (int)cki.KeyChar;
    }
  }
}
