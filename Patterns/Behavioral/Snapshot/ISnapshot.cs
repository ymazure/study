﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snapshot
{
  public interface ISnapshot<T>
  {
    void Restore(T p);
  }
}
