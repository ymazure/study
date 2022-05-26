
using Singleton;

var tasks = new List<Task>();
var suns = new List<Sun>();

for (var i = 0; i < 100; i++)
{
  tasks.Add(new Task(() =>
  {

    suns.Add(Sun.Instance);
  }));
}

Parallel.ForEach(tasks, s => s.Start());

foreach(var sun in suns)
{
  if(sun != Sun.Instance)
  {
    Console.WriteLine("Alarm! We have more than one Sun!");
    return;
  }
}

Console.WriteLine("No extra Suns. =)");
Console.ReadLine();


