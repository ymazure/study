using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator.BodyParts
{
  internal interface IBodyPart
  {
  }

  internal class Liver : IBodyPart
  {
  }

  public class Heart : IBodyPart { }
  public class Brain : IBodyPart { }
  public class Spleen : IBodyPart { }
  public class Stomach : IBodyPart { }
}
