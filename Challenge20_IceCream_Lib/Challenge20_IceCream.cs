namespace Challenge20_IceCream_Lib;

public static class Challenge20_IceCream
{
  public static Dictionary<string, long> GetFlavourTubs(string filename)
  {
    using StreamReader reader = new StreamReader(filename);

    const int SCOOPS_IN_TUB = 9;
    const double SCOOPS_PER_ATTENDEE = 1.5;

    string line;
    var flavourTubsDictionary = new Dictionary<string, double>();
    while ((line = reader.ReadLine()) != null)
    {

      (string countAttendeesAsString, string flavour) = line.Split(':')
      switch
      {
        var array =>
      (array[1], array[2].Trim())
      };

      if (!flavourTubsDictionary.ContainsKey(flavour))
      {
        flavourTubsDictionary.Add(flavour, 0);
      }
      flavourTubsDictionary[flavour] += int.Parse(countAttendeesAsString) * SCOOPS_PER_ATTENDEE / SCOOPS_IN_TUB;
    }

    foreach (var flavour in flavourTubsDictionary.Keys)
    {
      flavourTubsDictionary[flavour] = Math.Ceiling(flavourTubsDictionary[flavour]);
    }

    return flavourTubsDictionary
    .Select(kvp => new KeyValuePair<string, long>(kvp.Key, (long)Math.Ceiling(kvp.Value)))
    .ToDictionary(grp => grp.Key, grp => grp.Value);
  }

}
