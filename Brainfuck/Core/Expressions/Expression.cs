using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Brainfuck.Core.Expressions
{
  public abstract class Expression
  {
    public event Action OnBeforeEvaluate;
    public event Action OnAfterEvaluate;

    static Dictionary<char, Expression> list = new Dictionary<char, Expression>();

    static Expression()
    {
      list.Add('+', new Plus());
      list.Add('-', new Minus());
      list.Add(',', new Comma());
      list.Add('.', new Dot());
      list.Add('<', new MovePrevious());
      list.Add('>', new MoveNext());
      list.Add('[', new LeftBracket());
      list.Add(']', new RightBracket());
    }

    public static Expression GetInstance(char chr)
    {
      if (list.ContainsKey(chr))
        return list[chr];

      return null;
    }

    protected Expression() { }

    public Expression Previous { get; set; }
    public Expression Next { get; set; }

    public static bool MemoryZeroValue { get; set; }

    public void Eval()
    {
      if (OnBeforeEvaluate != null)
        OnBeforeEvaluate();

      Evaluate();

      if (OnAfterEvaluate != null)
        OnAfterEvaluate();
    }

    protected abstract void Evaluate();

  }
}
