using System.Collections.Generic;

namespace PYB.Models
{
  public class Places
  {
    public string CityName { get; set; }
    public string Description { get; set; }
    public int Id { get; }
    private static List<Places> _places = new List<Places> {};

    public Places(string cityName, string description)
    {
      CityName = cityName;
      Description = description;
      _places.Add(this);
      Id = _places.Count;
    }

    public static void ClearAll()
    {
      _places.Clear();
    }

    public static List<Places> GetAll()
    {
      return _places;
    }

    public static Places Find(int searchId)
    {
      return _places[searchId - 1];
    }
  }
}