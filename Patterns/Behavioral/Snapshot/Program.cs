using Snapshot;

Point p = new Point(10, 10);

var stateStorage = new StateStorage<Point>(p);

p.ChangeState();
stateStorage.Save();
ShowPoint(p);
Console.ReadKey();

p.ChangeState();
stateStorage.Save();
ShowPoint(p);
Console.ReadKey();

p.ChangeState();
stateStorage.Save();
ShowPoint(p);
Console.ReadKey();

p.ChangeState();
ShowPoint(p);
Console.WriteLine("Changed state without saving");
Console.ReadKey();

stateStorage.Undo();
ShowPoint(p);
Console.ReadKey();

stateStorage.Undo();
ShowPoint(p);
Console.ReadKey();

stateStorage.ReDo();
ShowPoint(p);
Console.ReadKey();

stateStorage.ReDo();
ShowPoint(p);
Console.ReadKey();

Console.ReadKey();

// Unfinished. Redo works invalid.

void ShowPoint(Point p)
{
  Console.WriteLine($"X: {p.X}, Y: {p.Y}");
}
