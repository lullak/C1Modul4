using OO5.Classes;

namespace OO5
{
        class Program
        {
            static void Main(string[] args)
            {
                List<Animal> animals = new List<Animal>();
                string input;
                do
                {
                    Console.WriteLine("1 - Cat");
                    Console.WriteLine("2 - Rabbit");
                    Console.WriteLine("3 - Cow");
                    Console.WriteLine("4 - Tiger");
                    Console.Write("Which animal do you want to add?");
                    input = Console.ReadLine();
                    Animal newAnimal = null;
                    switch (input)
                    {
                        case "1":
                            newAnimal = new Cat();
                            break;
                        case "2":
                            newAnimal = new Rabbit();
                            break;
                        case "3":
                            newAnimal = new Cow();
                            break;
                        case "4":
                            newAnimal = new Tiger();
                            break;
                    }
                    Console.WriteLine();
                    if (newAnimal != null)
                    {
                        var add = true;
                        foreach (var animal in animals)
                        {
                            if (animal is Carnivore && (animal.Size >= newAnimal.Size))
                            {
                                Console.WriteLine(animal.Speak());
                                Console.WriteLine(newAnimal + " was eaten by " + animal);
                                add = false;
                            }
                        }
                        if (add) animals.Add(newAnimal);
                    }
                } while (input.ToLower() != "y");
            }
        }

    }
