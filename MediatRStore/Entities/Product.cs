namespace MediatRStore.Entities;

public class Product
{
    public Product(string name, int quantity)
    {
        this.Id = Guid.NewGuid();
        this.Name = name;
        this.Quantity = quantity;
    }
    public Guid Id { get; private set; }
    public string Name { get; private set; }
    public int Quantity { get; private set; }

    public void UpdateQuantity(int update)
    {
        this.Quantity += update;
    }
}