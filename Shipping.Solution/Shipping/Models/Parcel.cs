using System;
using System.Collections.Generic;

namespace Shipping.Models
{
  public class Parcel
  {
    public int Length {get; set;}
    public int Width {get; set;}
    public int Height {get; set;}
    public int Weight {get; set;}
    public string Destination{get; set;}
    public Dictionary <string, int> Cities = new Dictionary <string, int>()
    {
      {"Atlanta", 2675},
      {"Boston", 3065},
      {"Chicago", 2070},
      {"Clevelend", 2421},
      {"Dallas", 2195},
      {"Denver", 1321},
      {"Detroit", 2357},
      {"Houston", 2442},
      {"Las Vegas", 1122},
      {"Los Angeles", 1141},
      {"New York", 2890},
      {"Philadelphia ", 2840}
    };

    public Parcel(int length, int width, int height, int weight)
    {
      Length = length;
      Width = width;
      Height = height;
      Weight = weight;
    }

    public int Volume()
    {
      return Length * Width * Height;
    }

  }
}