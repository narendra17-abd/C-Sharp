//Create a base class `Product` with properties `Name` and `Price`.
//Derive two classes `ElectronicProduct` and `ClothingProduct`. 
//Add a `GetDiscountedPrice()` method in the base class and override
//it in the derived classes to apply different discount rules.

public class Product
{
    public string Name { get; set; }
    public decimal Price { get; set; }

    public Product(string name, decimal price)
    {
        Name = name;
        Price = price;
    }

    public virtual decimal GetDiscountedPrice()
    {
        return Price * 0.9m;
    }
}

public class ElectronicProduct : Product
{
    public ElectronicProduct(string name, decimal price) : base(name, price) { }

    public override decimal GetDiscountedPrice()
    {
        return Price * 0.8m;
    }
}

public class ClothingProduct : Product
{
    public ClothingProduct(string name, decimal price) : base(name, price) { }

    public override decimal GetDiscountedPrice()
    {
        return Price * 0.6m;
    }
}

class Program
{
    static void Main()
    {
       
        Product electronicItem = new ElectronicProduct("Laptop", 50000m);
        Product clothingItem = new ClothingProduct("Jacket", 2000m);

        Console.WriteLine($"{electronicItem.Name} original price: {electronicItem.Price}, discounted price: {electronicItem.GetDiscountedPrice()}");
        Console.WriteLine($"{clothingItem.Name} original price: {clothingItem.Price}, discounted price: {clothingItem.GetDiscountedPrice()}");
    }
}
