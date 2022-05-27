using System;
using System.Collections.Generic;

namespace State
{
  internal class Program
  {
    static void Main(string[] args)
    {
      var songs = new List<string>() { "Radioactive", "Show Must go on", "Felicita" };

      var player = new AudioPlayer(songs);

      player.ShowState();
      Console.WriteLine("----------------------------");
      Console.ReadLine();


      player.Play();
      player.ShowState();
      Console.WriteLine("----------------------------");
      Console.ReadLine();

      player.Stop();
      player.ShowState();
      Console.WriteLine("----------------------------");
      Console.ReadLine();

      player.Pause();
      player.ShowState();
      Console.WriteLine("----------------------------");
      Console.ReadLine();

      player.Play();
      player.ShowState();
      Console.WriteLine("----------------------------");
      Console.ReadLine();

      player.Pause();
      player.ShowState();
      Console.WriteLine("----------------------------");
      Console.ReadLine();

      player.Play();
      player.ShowState();
      Console.WriteLine("----------------------------");
      Console.ReadLine();

      player.Play();
      player.ShowState();
      Console.WriteLine("----------------------------");
      Console.ReadLine();

    }
  }
}
