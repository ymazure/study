using Factory;
using Factory.Mac;
using Factory.Windows;

var factory = GetFactory();

IButton button = factory.CreateButton();

ITextBox textBox = factory.CreateTextBox();

IUIFactory GetFactory()
{
  bool useWindows = false;
  if (useWindows)
  {
    return new WindowsUIFactory();
  }
  else
  {
    return new MacUIFactory();
  }
}
