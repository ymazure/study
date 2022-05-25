using Factory.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Mac
{
  internal class MacUIFactory : IUIFactory
  {
    public IButton CreateButton()
    {
      return new MacButton();
    }

    public ITextBox CreateTextBox()
    {
      return new MacTextBox();
    }

    public IWindow CreateWindow()
    {
      return new MacWindow();
    }
  }
}
