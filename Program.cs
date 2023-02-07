namespace Class03_20024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // get value from user
            // read data from file
            // check value
            // write data

            IRepository repository = new DatabaseRepository();
            // 1. read the data
            string allData = repository.Read();
            // 2. write the data
            repository.Write("");


            IAnimal animal = new Pig();
            animal.Name = "Fred";
            animal.Age = 14;

            //animal = new Cow();
            //animal.Name = "Clara";
            //animal.Age = 8;

            //animal = new Dog();
            //animal.Name = "Fido";
            //animal.Age = 4;

            //animal.MakeSound();  


            //Player.TakeDamage();
            //Building.TakeDamage();
            //Crate.TakeDamage();

            //Console.WriteLine("Please select your animal");
            //string animalSelection = Console.ReadLine();

            //switch (animalSelection)
            //{
            //    case "Pig":
            //        Console.WriteLine("Oink");
            //        break;
            //    case "Cow":
            //        Console.WriteLine("Moo");
            //        break;
            //    case "Dog":
            //        Console.WriteLine("Bark");
            //        break;
            //    case "Cat":
            //        Console.WriteLine("Meow");
            //        break;
            //    case "Chicken":
            //        Console.WriteLine("Cluck");
            //        break;
            //    default:
            //        Console.WriteLine("Silence");
            //        break;
            //}


        }
    }
}
