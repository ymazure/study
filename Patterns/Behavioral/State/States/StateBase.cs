using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.States
{
  abstract class StateBase : IState
  {
    protected AudioPlayer Player;

    public StateBase(AudioPlayer player)
    {
      Player = player;
      ApplyState();
    }

    protected abstract void ApplyState();
    public abstract void Play();
    public abstract void Stop();
    public abstract void Pause();
    public abstract void Next();
    public abstract void Previous();
  }
}
