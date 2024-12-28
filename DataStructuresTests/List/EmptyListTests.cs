using DataStructures;

namespace DataStructuresTests;

[TestFixture]
public class EmptyListTests
{
    private DgList<string> newList;
    
    [SetUp]
    public void Setup()
    {
        newList = new DgList<string>();
    }
    
    [Test]
    public void EmptyList_WhenCreated_ShouldHaveLength0()
    {
        var newListLength = newList.Length();
        
        Assert.AreEqual(0, newListLength);
    }
    
    [Test]
    public void EmptyList_WhenCreated_ShouldBeEmpty()
    {
        var isEmpty = newList.IsEmpty();
        
        Assert.AreEqual(true, isEmpty);
    }
    
    [Test]
    public void EmptyList_WhenCreated_HasInitialCapacity0()
    {
        var capacity = newList.Capacity;
        
        Assert.AreEqual(0, capacity);
    }
}