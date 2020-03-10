using System;
using System.Collections.Generic;

namespace Shipping.Models
{
  public class Parcel
  {
    public int Length {get; set;}
    public int Width {get; set;}
    public int Height {get; set}
    public int Weight {get; set}

    public Parcel()
    {

    }

  }
}