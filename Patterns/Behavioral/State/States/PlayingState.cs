using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State.States
{
  internal class PlayingState : StateBase
  {
    public PlayingState(AudioPlayer player) : base(player) { }

    protected override void ApplyState()
    {
      Player.PauseButtonEnabled = true;
      Player.PlayButtonEnabled = false;
      Player.StopButtonEnabled = true;
    }

    public override void Next()
    {
      Player.CurrentSongIndex++;
    }

    public override void Pause()
    {
      Player.ChangeState(new PausedState(Player));
    }

    public override void Play()
    {
    }

    public override void Previous()
    {
      Player.CurrentSongIndex--;
    }

    public override void Stop()
    {
      Player.ChangeState(new StoppedState(Player));
    }
  }
}
