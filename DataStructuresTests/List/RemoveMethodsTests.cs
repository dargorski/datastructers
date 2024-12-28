using DataStructures;

namespace DataStructuresTests;

[TestFixture]
public class RemoveMethodsTests
{
    private DgList<int> _dgList;
    [SetUp]
    public void Setup()
    {
        _dgList = new DgList<int>();
    }

    [Test]
    public void PopMethod_WhenCalledOnEmptyList_ThrowsIndexOutOfRangeException()
    {
        Assert.Throws<IndexOutOfRangeException>(() => _dgList.Pop());
    }

    [Test]
    public void PopMethod_WhenCalled_ReturnsAndDeletesLastItem()
    {
        ListTestsHelper.FillListWithRandomIntValues(_dgList, 10);

        for (var i = 9; i >= 0; i--)
        {
            var itemToRemove = _dgList.At(i);
            var removedItem = _dgList.Pop();
            Assert.AreEqual(itemToRemove, removedItem);
        
        }
    }

    [TestCase(0,0)]
    [TestCase(5,5)]
    [TestCase(-1,5)]
    public void DeleteAt_WhenCalledWithInvalidIndex_ThrowsIndexOutOfRangeException(int index, int numberOfItems)
    {
        ListTestsHelper.FillListWithRandomIntValues(_dgList, numberOfItems);
        Assert.Throws<IndexOutOfRangeException>(() => _dgList.DeleteAt(index));
    }

    [Test]
    public void DeleteAt_WhenCalledWithValidIndex_DeletesValueAtGivenIndex()
    {
        ListTestsHelper.FillListWithRandomIntValues(_dgList, 10);
        var rand = new Random();

        for (var i = 0; i < 10; i++)
        {
            var index = rand.Next(0, _dgList.Length() - 1);

            var valueToRemove = _dgList.At(index);
            var removedValue = _dgList.DeleteAt(index);
            
            Assert.AreEqual(valueToRemove, removedValue);
        }
    }
}