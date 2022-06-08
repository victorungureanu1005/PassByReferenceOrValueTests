



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
Console.WriteLine(a.GetHashCode());
Console.WriteLine(b.GetHashCode());
Console.WriteLine(c.GetHashCode());
Console.WriteLine(d.GetHashCode());
Console.WriteLine();
Console.WriteLine(a.GetHashCode());
Console.WriteLine("After Ref");
RecreateRef(ref a);
Console.WriteLine(a.GetHashCode());
RecreateOut(out a);
Console.WriteLine("After Out");
Console.WriteLine(a.GetHashCode());


void Switch(Dog a, Dog b, out Dog c, out Dog d)
{
    Console.WriteLine($"Hash code of first Dog is {a.GetHashCode()} and second Dog is {b.GetHashCode()}");
    a = b;

    c = a;
    d = b;
    Console.WriteLine("After assignment of first to second dog");
    Console.WriteLine($"Hash code of first Dog is {a.GetHashCode()} and second Dog is {b.GetHashCode()}");
}


void RecreateRef(ref Dog a)
{
    a = new Dog();
}
void RecreateOut(out Dog a)
{
    a = new Dog();
}





















public class Dog
{
    public string Name { get; set; }
    public int? Age { get; set; }

    public bool? GoodOrBad { get; set; }
    public Dog? DogOfTheDog { get; set; }

}



