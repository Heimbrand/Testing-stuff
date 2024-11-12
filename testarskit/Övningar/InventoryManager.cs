namespace testarskit.Övningar;

public class InventoryManager
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Quantity { get; set; }

    public InventoryManager(int id, string name, int quantity)
    {
        Id = id;
        Name = name;
        Quantity = quantity;
    }
    public void AddToInventory(int amount)
    {
        Quantity = Quantity + amount;
    }
    public void RemoveFromInventory(int amount)
    {
        Quantity = Quantity - amount;
    }
    public void UpdateItem(string name, int quantity)
    {
        Name = name;
        Quantity = quantity;
    }
    public void PrintInventory()
    {
        Console.WriteLine($"Id: {Id}, Name: {Name}, Quantity: {Quantity}");
    }

}