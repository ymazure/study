using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snapshot
{
  public interface ISnapshotCreator<T>
  {
    ISnapshot<T> MakeSnapshot();

    void RestoreState(ISnapshot<T> snapshot);
  }
}
