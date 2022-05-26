using System;
using System.Collections.Generic;

namespace Command
{
  class Program
  {
    static void Main(string[] args)
    {
      var commandHistory = new Stack<CalculatorCommand>();

      var calculator = new Calculator();

      var commandList = new List<CalculatorCommand>() {
        new CalculatorCommand(calculator, 10, '+'),
        new CalculatorCommand(calculator, 4, '*'),
        new CalculatorCommand(calculator, 30, '-'),
        new CalculatorCommand(calculator, 4, '/'),
        new CalculatorCommand(calculator, 20, '-')
      };

      foreach (var command in commandList)
      {
        command.Execute();
        Console.WriteLine($"Current Value: {calculator.Current};");
        commandHistory.Push(command);
      }

      commandHistory.Pop().Undo();
      Console.WriteLine($"Undo the last operation: Value: {calculator.Current}");

      commandHistory.Pop().Undo();
      Console.WriteLine($"Undo one more: Value: {calculator.Current}");

      commandHistory.Pop().Undo();
      Console.WriteLine($"Undo and one more operation: Value: {calculator.Current}");

      Console.Read();
    }
  }
}
