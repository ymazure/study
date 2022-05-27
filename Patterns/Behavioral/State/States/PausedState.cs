using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.States
{
  internal class PausedState : StateBase
  {
    public PausedState(AudioPlayer player) : base(player) { }

    protected override void ApplyState()
    {
      Player.PauseButtonEnabled = true;
      Player.PlayButtonEnabled = false;
      Player.StopButtonEnabled = true;
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
      Player.ChangeState(new StoppedState(Player));
    }
  }
}
