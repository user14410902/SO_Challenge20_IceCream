using StreamReader reader = new StreamReader(args[0]);

const int SCOOPS_IN_TUB = 9;
const double SCOOPS_PER_ATTENDEE = 1.5;

string line;
var flavourTubsDictionary = new Dictionary<string, double>();
while ((line = reader.ReadLine()) != null)
{
  Console.WriteLine(line);

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

foreach (var flavourTub in flavourTubsDictionary)
{
  Console.WriteLine($"{flavourTub.Key}: {Math.Ceiling(flavourTub.Value)} tubs");
}