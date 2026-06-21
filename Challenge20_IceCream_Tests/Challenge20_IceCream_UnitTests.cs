using Challenge20_IceCream_Lib;

namespace Challenge20_IceCream_Tests;

public class Challenge20_IceCream_UnitTests
{
    [SetUp]
    public void Setup()
    {
    }


    [TestCase("challenge_20_basic1.txt", "Chocolate:3,Vanilla:3,Strawberry:2")]
    [TestCase("challenge_20_basic2.txt", "Chocolate:3,Vanilla:3,Strawberry:2")]
    [TestCase("challenge_20_s1.txt", "Chocolate:23,Vanilla:16,Strawberry:8")]
    [TestCase("challenge_20_s2.txt", "Chocolate:17,Vanilla:18,Strawberry:13")]
    [TestCase("challenge_20_s3.txt", "Chocolate:24,Vanilla:21,Strawberry:10")]
    public void Test(string filename, string result)
    {
        var actual = Challenge20_IceCream.GetFlavourTubs(filename);
        var expected = ConvertDictionaryFromString(result);
        AssertDictionariesEqual(actual, expected);
    }

    private void AssertDictionariesEqual(Dictionary<string, long> actual, Dictionary<string, long> expected)
    {
        Assert.That(actual.Count, Is.EqualTo(expected.Count), "Dictionaries have different lengths.");
        Assert.That(actual.Keys, Is.EquivalentTo(expected.Keys), "Dictionaries contain different keys.");

        foreach (var key in expected.Keys)
        {
            Assert.That(actual[key], Is.EqualTo(expected[key]), $"Value mismatch for key '{key}'.");
        }
    }

    private Dictionary<string, long> ConvertDictionaryFromString(string result)
    {
        return result.Split(',').Select(a =>
{
    (var flavour, var count) = a.Split(':') switch { var arr => (arr[0], long.Parse(arr[1])) };
    return KeyValuePair.Create(flavour, count);
}).ToDictionary();
    }
}
