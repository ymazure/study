using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.States
{
  internal class StoppedState : StateBase
  {
    public StoppedState(AudioPlayer player) : base(player)
    {
    }

    protected override void ApplyState()
    {
      Player.PauseButtonEnabled = false;
      Player.PlayButtonEnabled = true;
      Player.StopButtonEnabled = false;
    }

    public override void Next()
    {
    }

    public override void Pause()
    {
    }

    public override void Play()
    {
      Player.ChangeState(new PlayingState(Player));
    }

    public override void Previous()
    {
    }

    public override void Stop()
    {
    }
  }
}
