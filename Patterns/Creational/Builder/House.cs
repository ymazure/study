namespace Builder
{
  public partial class House
  {
    public Garage Garage { get; private set; }
    public Door[] Dors { get; private set; }
    public Window[] Windows { get; private set; }
    public Pool Pool { get; private set; }
    public Сhimney Tube { get; private set; }
    public Playground Playground { get; private set; }
    public Kitchen Kitchen { get; private set; }
    public Bathroom Bathroom { get; private set; }
    public Bedroom Bedroom { get; private set; }
    public Livingroom Livingroom { get; private set; }
    public Roof Roof { get; private set; }
  }

  public class Garage  {  }
  public class Door { }
  public class Window { }
  public class Pool { }
  public class Сhimney { }
  public class Playground { }
  public class Kitchen { }
  public class Bathroom { }
  public class Bedroom { }
  public class Livingroom { }
  public class Roof { }
}
