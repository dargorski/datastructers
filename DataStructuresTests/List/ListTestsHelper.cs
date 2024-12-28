using DataStructures;

namespace DataStructuresTests;

public static class ListTestsHelper
{
    public static void FillListWithRandomIntValues(DgList<int> list, int numberOfValues)
    {
        var rand = new Random();
        for (var i = 0; i < numberOfValues; i++)
        {
            list.Add(rand.Next(1, 10));
        }
    }
}