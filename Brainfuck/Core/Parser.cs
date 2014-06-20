using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Brainfuck.Core.Expressions;
using System.Collections;

namespace Brainfuck.Core
{
  public class Parser
  {
    string input = "";
    int position = 0;
    Expression root = null;
    Stack<int> stack = new Stack<int>();

    public void Init(string input)
    {
      Regex re = new Regex(@"[^\+\-\[\]\,\.<>]+");
      this.input = re.Replace(input, "");
    }

    private char NextToken()
    {
      if (position == input.Length)
        return '\0';

      position++;
      return input[position];
    }

    public void Parse()
    {
      char token = '\0';
      do
      {
        token = NextToken();
        Evaluate(token);

      } while (token != '\0');
      
    }

    public void Evaluate(char token)
    {
      bool leftBracket = token == '[';
      bool rightBracket = token == ']';

      if (leftBracket)
        stack.Push(position);
      
      Expression expr = Expression.GetInstance(token);
      expr.Eval();

      if (rightBracket)
      {
        
      }


    }

  }
}
