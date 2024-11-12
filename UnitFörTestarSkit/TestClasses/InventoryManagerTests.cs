using testarskit.Övningar;

namespace UnitFörTestarSkit.TestClasses;

public class InventoryManagerTests
{
    [Fact]
    public void AddToInventory_ShouldAddToQuantity()
    {
        // Arrange
        var inventoryManager = new InventoryManager(1, "Test", 0);

        // Act
        inventoryManager.AddToInventory(5);

        // Assert
        Assert.Equal(5, inventoryManager.Quantity);
    }
    [Fact]
    public void RemoveFromInventory_ShouldRemoveFromQuantity()
    {
        // Arrange
        var inventoryManager = new InventoryManager(1, "Test", 0);

        // Act
        inventoryManager.AddToInventory(5);
        inventoryManager.RemoveFromInventory(5);

        // Assert
        Assert.Equal(0, inventoryManager.Quantity);
    }
    [Fact]
    public void UpdateItem_ShouldUpdateNameAndQuantity()
    {
        // Arrange
        var inventoryManager = new InventoryManager(1, "Test", 0);

        // Act
        inventoryManager.UpdateItem("Kalles Kaviar", 67);

        // Assert 
        Assert.Equal("Kalles Kaviar", inventoryManager.Name);
        Assert.Equal(67, inventoryManager.Quantity);
    }
}