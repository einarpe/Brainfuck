using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Brainfuck.Core;

namespace Brainfuck
{
  class Program
  {
    static void Main(string[] args)
    {
      if (args.Length == 0)
      {
        Console.WriteLine("brainfuck.exe expr1expr2...exprn");
        Console.WriteLine("Written by kubar3k 2014");
      }
      else
      {
        Parser parser = new Parser();
        parser.Init(args[0]);
        parser.Parse();
      }
    }
  }
}
