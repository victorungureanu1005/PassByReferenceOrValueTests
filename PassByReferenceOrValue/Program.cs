



// PLAYING WITH NULLABLES


//Console.WriteLine();
//Console.WriteLine();
//Console.WriteLine();
//Console.WriteLine("Playing with nullables!");
//Dog a = new Dog();
//a.Name = "Hey jimmy";
//Dog b = new Dog();
//Console.WriteLine(a.Age);
//if (a.Age is null) Console.WriteLine("AGE IS NuLL!");
//Console.WriteLine(a.Name);
//Console.WriteLine(a.DogOfTheDog is null);
//Console.WriteLine(a.GoodOrBad);
//a.GoodOrBad = true;
//Console.WriteLine(a.GoodOrBad);
//Console.WriteLine("Assigning nullable");
//a.GoodOrBad = null;
//if (a.GoodOrBad is null) Console.WriteLine("IS nuLL!");


// PLAYING WITH Passing references
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Playing with Passing references!");

Dog a = new Dog();
Dog b = new Dog();
Dog c;
Dog d;

Console.WriteLine(a.GetHashCode());
Console.WriteLine(b.GetHashCode());
Switch(a, b, out c, out d);
Console.WriteLine($"After Switch func");
Console.WriteLine(c.GetHashCode());
Console.WriteLine(d.GetHashCode());

void Switch(Dog x, Dog y, out Dog a, out Dog b)
{
    Console.WriteLine($"Hash code of first Dog is {x.GetHashCode()} and second Dog is {y.GetHashCode()}");
    x = y;

    a = x;
    b = y;
    Console.WriteLine("After assignment of first to second dog");
    Console.WriteLine($"Hash code of first Dog is {x.GetHashCode()} and second Dog is {y.GetHashCode()}");
}





















public class Dog
{
    public string Name { get; set; }
    public int? Age { get; set; }

    public bool? GoodOrBad { get; set; }
    public Dog? DogOfTheDog { get; set; }

}



