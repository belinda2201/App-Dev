internal class Program
{
    public class Animal
    {
        private string Name;
        private int Age;
        private string Gender;
        private string Type;

        public void SetName(string name)
        {
            this.Name = name;
        }
        public void SetAge(int age)
        {
            this.Age = age;
        }
        public void SetGender(string gender)
        {
            this.Gender = gender;
        }
        public void SetType(string type)
        {
            this.Type = type;
        }
        public string GetName()
        {
            return Name;
        }
        public int GetAge()
        {
            return Age;
        }
        public string GetGender()
        {
            return Gender;
        }
        public string GetType()
        {
            return Type;
        }
    }


    public class Mammal : Animal
    {
        public string FurColor;
        public void SetFurColor(string furcolor)
        {
            this.FurColor = furcolor;
        }
        public string GetFurColor()
        {
            return FurColor;
        }

        public Mammal()
        {
            SetType("Mammal");
        }
    }


    public class Reptile : Animal
    {
        private string ScaleColor;

        public void SetScaleColor(string scalecolor)
        {
            this.ScaleColor = scalecolor;
        }
        public string GetScaleColor()
        {
            return ScaleColor;
        }
        public Reptile()
        {
            SetType("Reptile");
        }
    }
    public class Zoo
    {
        private string Name;
        private string Location;
        private List<Animal> animals = new List<Animal>();

        public void AddAnimal(Animal animal)
        {
            animals.Add(animal);
        }
        public void RemoveAnimal(string animalName)
        {
            Animal yangdihapus = new Animal();
            foreach (Animal animal in animals)
            {
                if (animal.GetName() == animalName)
                    yangdihapus = animal;
            }
            animals.Remove(yangdihapus);

        }
        public void PrintAnimals()
        {
            foreach (Animal animal in animals)
            {
                Console.WriteLine("Animal Name: " + animal.GetName());
                Console.WriteLine("Animal Age: " + animal.GetAge());
                Console.WriteLine("Animal Gender: " + animal.GetGender());
                Console.WriteLine("Animal Type: " + animal.GetType());
                Console.WriteLine();
            }
        }
        public void SetName(string name)
        {
            this.Name = name;
        }
        public void SetLocation(string location)
        {
            this.Location = location;
        }

    }

    
        static void Main(string[] args)
        {
            Zoo zoo = new Zoo();
            Console.Write("Add Zoo Name: ");
            zoo.SetName(Console.ReadLine());
            Console.Write("Add Zoo Location: ");
            zoo.SetLocation(Console.ReadLine());



            while (true)
            {
                Console.WriteLine("1. Add Animal");
                Console.WriteLine("2. Remove Animal");
                Console.WriteLine("3. Show Animal List");
                Console.WriteLine("4. Exit");

                int inputuser = Convert.ToInt32(Console.ReadLine());

                if (inputuser == 1)
                {
                    Console.WriteLine("1. Mammal");
                    Console.WriteLine("2. Reptile");
                    int inputpertama = Convert.ToInt32(Console.ReadLine());

                    if (inputpertama == 1)
                    {
                        Mammal mammal = new Mammal();

                        Console.Write("Add Name: ");
                        string namee = Console.ReadLine();
                        Console.Write("Add Age: ");
                        int age = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Add Gender: ");
                        string gender = Console.ReadLine();
                        Console.WriteLine("Add Fur Color: ");
                        string Colour = Console.ReadLine();
                        mammal.SetName(namee);
                        mammal.SetAge(age);
                        mammal.SetGender(gender);
                        mammal.SetFurColor(Colour);

                        zoo.AddAnimal(mammal);
                    }
                    else if (inputpertama == 2)
                    {
                        Reptile reptile = new Reptile();

                        Console.Write("Add Name: ");
                        string namee = Console.ReadLine();
                        Console.Write("Add Age: ");
                        int age = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Add Gender: ");
                        string gender = Console.ReadLine();
                        Console.WriteLine("Add Scale Color: ");
                        string Colour = Console.ReadLine();

                        reptile.SetName(namee);
                        reptile.SetAge(age);
                        reptile.SetGender(gender);
                        reptile.SetScaleColor(Colour);
                        zoo.AddAnimal(reptile);
                    }
                }

                else if (inputuser == 2)
                {
                    Console.WriteLine("Animal Name: ");
                    string animalname = Console.ReadLine();
                    zoo.RemoveAnimal(animalname);

                    zoo.PrintAnimals();
                }
                else if (inputuser == 3)
                {
                    zoo.PrintAnimals();
                }
                else
                    break;

            }
        }

    }

