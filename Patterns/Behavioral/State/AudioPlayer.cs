using State.States;
using System;
using System.Collections.Generic;

namespace State
{
  internal class AudioPlayer
  {
    internal List<string> Songs;
    internal int CurrentSongIndex = 0;

    public AudioPlayer(List<string> songs)
    {
      Songs = songs;
      ChangeState(new StoppedState(this));
    }

    internal bool PlayButtonEnabled = true;
    internal bool PauseButtonEnabled = false;
    internal bool StopButtonEnabled = true;

    private IState _state;

    public void ShowState()
    {
      Console.WriteLine($"PlayButtonEnabled : {PlayButtonEnabled}");
      Console.WriteLine($"PauseButtonEnabled : {PauseButtonEnabled}");
      Console.WriteLine($"StopButtonEnabled : {StopButtonEnabled}");
      Console.WriteLine(_state.GetType().Name);
    }

    internal void ChangeState(IState state)
    {
      _state = state;
    }

    public void Play()
    {
      _state.Play();
    }

    public void Stop()
    {
      _state.Stop();
    }

    public void Next()
    {
      _state.Next();
    }

    public void Previous()
    {
      _state.Previous();
    }

    public void Pause()
    {
      _state.Pause();
    }
  }
}
