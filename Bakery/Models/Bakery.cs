using System;

namespace Bakery
{
  public class Bread
  {
    public int BreadCount { get; set; }
    public Bread(int breadCount)
    {
      BreadCount = breadCount;
    }

    public int Discount()
    {
      int breadDeal = 5 * (BreadCount / 3);
      int breadTotal  = (5 * BreadCount) - breadDeal;
      return breadTotal;
    }
  }

  public class Pastry
  {
    public int PastryCount { get; set; }
    public Pastry(int pastryCount)
    {
      PastryCount = pastryCount;
    }

     public int Discount()
    {
      int pastryDeal = 1 * (PastryCount / 3);
      int pastryTotal  = (2 * PastryCount) - pastryDeal;
      return pastryTotal;
    }
  }
}

