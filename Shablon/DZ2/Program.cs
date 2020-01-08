using System;

class Program
{
    static void Main(string[] args)
    {
        AppleStore appleStore = new AppleStore();
        Samsung samsung = new Samsung();

        appleStore.Catalog();
        samsung.Catalog();

        Console.Read();
    }
}
abstract class Shop
{
    public void Catalog()
    {
        Phones();
        TV();
        Sales();
        Pad();
    }
    public abstract void Phones();
    public abstract void TV();
    public virtual void Sales()
    {
        Console.WriteLine("Акция!!! 2 по цене 1!!!");
        Console.WriteLine("\n");
    }
    public abstract void Pad();
}

class AppleStore : Shop
{
    public override void Pad()
    {
        Console.WriteLine("Catalog of iPad:\n");

        Console.WriteLine("iPad 1");
        Console.WriteLine("iPad 2");
        Console.WriteLine("iPad 3");
        Console.WriteLine("\n");
    }

    public override void Phones()
    {
        Console.WriteLine("Catalog of iPhone:\n");

        Console.WriteLine("iPhone X");
        Console.WriteLine("iPhone XR");
        Console.WriteLine("iPhone 11");
        Console.WriteLine("\n");
    }

    public override void TV()
    {
        Console.WriteLine("Catalog of TV:\n");

        Console.WriteLine("Apple TV");
        Console.WriteLine("Apple TV2");
        Console.WriteLine("\n");
    }

  
}

class Samsung : Shop
{
    public override void Phones()
    {
        Console.WriteLine("Catalog of Phone:\n");

        Console.WriteLine("Samsung galaxy S7");
        Console.WriteLine("Samsung galaxy S8");
        Console.WriteLine("Samsung galaxy S9");
        Console.WriteLine("\n");
    }

    public override void TV()
    {
        Console.WriteLine("Catalog of TV:\n");

        Console.WriteLine("Samsung TV");
        Console.WriteLine("Samsung TV 2");
        Console.WriteLine("Samsung TV 3");
        Console.WriteLine("\n");
    }

    public override void Pad()
    {
        Console.WriteLine("Catalog of Tab:\n");

        Console.WriteLine("Samsung galaxy Tab");
        Console.WriteLine("Samsung galaxy Tab 2");
        Console.WriteLine("Samsung galaxy Tab 3");
        Console.WriteLine("\n");
    }
}
