using DataStructures;

namespace DataStructuresTests;

[TestFixture]
public class AtMethodTests
{
    private DgList<int> dgList;
    private const int numberOfValues = 20;
    [SetUp]
    public void Setup()
    {
        dgList = new DgList<int>();
        ListTestsHelper.FillListWithRandomIntValues(dgList, numberOfValues);
    }

    [TestCase(-1)]
    [TestCase(numberOfValues + 1)]
    public void AtMethod_WhenCalledWithInvalidIndex_ThrowsIndexOutOfRangeException(int index)
    {
        Assert.Throws<IndexOutOfRangeException>(() => dgList.At(index));
    }
    
}