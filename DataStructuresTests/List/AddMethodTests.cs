using DataStructures;

namespace DataStructuresTests;

[TestFixture]
public class AddMethodTests
{
    private DgList<int> dgList;
    [SetUp]
    public void Setup()
    {
        dgList = new DgList<int>();
    }
    [Test]
    public void AddingItem_ToEmptyList_AddsItemAtIndex0()
    {
        dgList.Add(2);
        
        Assert.AreEqual(2, dgList.At(0));
    }
    
    [Test]
    public void AddingItem_ToEmptyList_ResultsInListLengthBeing1()
    {
        dgList.Add(2);
        
        Assert.AreEqual(1, dgList.Length());
    }
    
    [Test]
    public void AddingItem_ToEmptyList_IncreasesCapacityTo4()
    {
        dgList.Add(2);
        
        Assert.AreEqual(4, dgList.Capacity);
    }
    
    [TestCase(5, 8)]
    [TestCase(9, 16)]
    [TestCase(17, 32)]
    [TestCase(33, 64)]
    [TestCase(65, 128)]
    [TestCase(129, 256)]
    public void AddingItems_ToEmptyList_IncreasesCapacityTo(int numberOfItems, int expectedCapacity)
    {
        ListTestsHelper.FillListWithRandomIntValues(dgList, numberOfItems);

        Assert.AreEqual(expectedCapacity, dgList.Capacity);
    }
    
    [Test]
    public void AddingItem_ToEmptyList_MakesItNotEmpty()
    {
        dgList.Add(2);
        
        Assert.AreEqual(false, dgList.IsEmpty());
    }
    
    [TestCase(-1, 0)]
    [TestCase(1, 0)]
    [TestCase(-1, 10)]
    [TestCase(11, 10)]
    public void InsertMethod_WithInvalidIndex_ThrowsIndexOutOfRangeException(int index, int numberOfItems)
    {
        ListTestsHelper.FillListWithRandomIntValues(dgList, numberOfItems);
        Assert.Throws<IndexOutOfRangeException>(() => dgList.Insert(2, index));
    }
    
    [Test]
    public void InsertMethod_WithIndex_InsertsValueCorrectly()
    {
        ListTestsHelper.FillListWithRandomIntValues(dgList, 33);
        var rand = new Random();
        for (var i = 0; i < 10; i++)
        {
            var valueToInsert = rand.Next(0, 100);
            var currentLength = dgList.Length();
            var index = rand.Next(0, currentLength + 1);
            dgList.Insert(valueToInsert, index);
            
            Assert.AreEqual(valueToInsert, dgList.At(index));
            Assert.AreEqual(currentLength + 1, dgList.Length());
        }
    }
}