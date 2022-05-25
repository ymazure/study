using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory.Windows
{
  internal class WindowsUIFactory : IUIFactory
  {
    public IButton CreateButton()
    {
      return new WindowsButton();
    }

    public ITextBox CreateTextBox()
    {
      return new WindowsTextBox();
    }

    public IWindow CreateWindow()
    {
      return new WindowsWindow();
    }
  }
}
