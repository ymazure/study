using Iterator.BodyParts;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
  internal class Human : IEnumerable<IBodyPart>
  {
    public string Name { get; set; };

    public Stomach Stomach { get; set; } = new Stomach();

    public Brain Brain { get; set; } = new Brain();

    public Heart Heart { get; set; } = new Heart();

    public Liver Liver { get; set; } = new Liver();

    public Spleen Spleen { get; set; } = new Spleen();

    public IEnumerator<IBodyPart> GetEnumerator()
    {
      yield return Brain;
      yield return Heart;
      yield return Stomach;
      yield return Liver;
      yield return Spleen;
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
      yield return Brain;
      yield return Heart;
      yield return Stomach;
      yield return Liver;
      yield return Spleen;
    }
  }
}
