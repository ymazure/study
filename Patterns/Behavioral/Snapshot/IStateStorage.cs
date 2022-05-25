using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snapshot
{
  public interface IStateStorage<T> where T : class, ISnapshotCreator<T>
  {
    void Undo();

    void Save();

    void ReDo();
  }

  public class StateStorage<T> : IStateStorage<T> where T : class, ISnapshotCreator<T>
  {
    private readonly T _t;
    private readonly List<ISnapshot<T>> _backStates;
    private readonly List<ISnapshot<T>> _forwardStates;

    private ISnapshot<T> _current;

    public StateStorage(T t)
    {
      _t = t;
      //_current = t.MakeSnapshot();
      _backStates = new List<ISnapshot<T>>();
      _forwardStates = new List<ISnapshot<T>>();
    }

    public void ReDo()
    {
      Console.WriteLine("ReDo done.");

      if (!_forwardStates.Any())
        return;

      var snapshot = _forwardStates.First();

      _backStates.Add(snapshot);

      //_current = snapshot;

      _forwardStates.Remove(snapshot);
      _t.RestoreState(snapshot);
    }

    public void Save()
    {
      _backStates.Add(_t.MakeSnapshot());

      Console.WriteLine("Saved snapshot.");

      //_current = _t.MakeSnapshot();

      _forwardStates.Clear();
    }

    public void Undo()
    {
      Console.WriteLine("Undo done.");

      if (!_backStates.Any())
        return;

      var snapshot = _backStates.Last();

      _forwardStates.Insert(0, snapshot);

      //_current = snapshot;

      _backStates.Remove(snapshot);
      _t.RestoreState(snapshot);
    }
  }
}
