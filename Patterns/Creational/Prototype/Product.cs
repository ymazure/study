using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Prototype
{
  internal class Product : ICloneable<Product>
  {
    public int Price { get; private set; }
    public string Name { get; private set; }
    public double Weight { get; private set; }

    public Product(int price, string name, double weight)
    {
      this.Price = price;
      this.Name = name;
      this.Weight = weight;
}

    public Product(Product p)
{
      this.Price = p.Price;
      this.Name = p.Name;
      this.Weight = p.Weight;
    }

    public Product Clone()
    {
      return new Product(this);
    }
  }
}
