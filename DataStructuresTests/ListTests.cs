using DataStructures;

namespace DataStructuresTests;

[TestFixture]
public class ListTests
{
    [Test]
    public void EmptyList_WhenCreated_ShouldHaveLength0()
    {
        //Arrange
        var newList = new DgList<string>();
        
        // Act
        var newListLength = newList.Length();
        
        Assert.AreEqual(0, newListLength);
    }
    
    [Test]
    public void EmptyList_WhenCreated_ShouldBeEmpty()
    {
        //Arrange
        var newList = new DgList<string>();
        
        // Act
        var isEmpty = newList.IsEmpty();
        
        Assert.AreEqual(true, isEmpty);
    }
    
    [Test]
    public void EmptyList_WhenCreated_HasInitialCapacity0()
    {
        //Arrange
        var newList = new DgList<string>();
        
        // Act
        var capacity = newList.Capacity();
        
        Assert.AreEqual(0, capacity);
    }
}