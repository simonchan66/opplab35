


using part2_interfaces;

class Program
{

    static void Main(string[] args)
    {
        Dog dog = new Dog();
        Console.Write("Enter a dog name: ");
        dog.Name = Console.ReadLine();


        Console.Write("Enter dog colour: ");
        dog.Colour = Console.ReadLine();

        Console.Write("Enter dog age: ");
        dog.Age = int.Parse(Console.ReadLine());

        Console.WriteLine($"Dog name: {dog.Name}");
        Console.WriteLine($"Dog color: {dog.Colour}");
        Console.WriteLine($"Dog age: {dog.Age}");
        dog.Eat();
        Console.WriteLine(dog.Cry());

        Cat cat = new Cat();
        Console.Write("Enter a cat name: ");
        cat.Name = Console.ReadLine();


        Console.Write("Enter cat colour: ");
        cat.Colour = Console.ReadLine();

        Console.Write("Enter cat age: ");
        cat.Age = int.Parse(Console.ReadLine());

        Console.WriteLine($"Cat name: {cat.Name}");
        Console.WriteLine($"Cat color: {cat.Colour}");
        Console.WriteLine($"Cat age: {cat.Age}");
        cat.Eat();
        Console.WriteLine(cat.Cry());

        List<IAnimal> animals = new List<IAnimal>();
        animals.Add(dog);
        animals.Add(cat);

        string choice;
        do
        {
            Console.Write("Add dog or cat? (d or c , press other key to exit)");
            choice = Console.ReadLine()!.ToLower();

            if (choice == "d")
            {

                Dog dog1 = new Dog();
                Console.Write("Enter a dog name: ");
                dog1.Name = Console.ReadLine();
                Console.Write("Enter dog colour: ");
                dog1.Colour = Console.ReadLine();

                Console.Write("Enter dog age: ");
                dog1.Age = int.Parse(Console.ReadLine());
                animals.Add(dog1);

            }
            else if (choice == "c")
            {

                Cat cat1 = new Cat();
                Console.Write("Enter a cat name: ");
                cat1.Name = Console.ReadLine();


                Console.Write("Enter cat colour: ");
                cat1.Colour = Console.ReadLine();

                Console.Write("Enter cat age: ");
                cat1.Age = int.Parse(Console.ReadLine());
                animals.Add(cat1);
            }

        } while (choice == "d" || choice == "c");

        // Finally print animal names
        Console.WriteLine("Animal Name List:");
        foreach (IAnimal animal in animals)
        {

            Console.WriteLine(animal.Name);
        }
    }
}