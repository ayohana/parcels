using System.Collections.Generic;

namespace Shipping.Models
{
  public class Parcel
  {
    public int Length {get; set;}
    public int Width {get; set;}
    public int Height {get; set;}
    public int Weight {get; set;}
    public int Volume {get; set;}
    public int ParcelCost {get; set;}
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

    private static List <Parcel> _parcels = new List <Parcel> {};

    public Parcel(int length, int width, int height, int weight, string destination)
    {
      Length = length;
      Width = width;
      Height = height;
      Weight = weight;
      Volume = Length * Width * Height;
      Destination = destination;
      ParcelCost = CostToShip();
      _parcels.Add(this);
    }

    public int CostToShip()
    {
      int parcelCost = 1;
      foreach (KeyValuePair<string, int> city in Cities)
      {
        if (city.Key == Destination)
        {
          parcelCost *= city.Value;
        }
      }
      return parcelCost * Weight * Volume / 10;
    }

    public static List <Parcel> GetAll()
    {
      return _parcels;
    }

    public static int CalculateFinalCost()
    {
      int finalCost = 0;
      foreach (Parcel item in _parcels)
      {
        finalCost += item.ParcelCost;
      }
      return finalCost;
    }

  }
}