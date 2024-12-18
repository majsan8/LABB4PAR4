namespace LABB4PAR4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Person properties = new Person("1111", "blue", Gender.Woman, new Hair(10, "brown"));
            List<Person> people = new List<Person>();

            Console.WriteLine("Welcome!");
            int userChoice;

            while (true)
            {
                Console.WriteLine("\n Here are three choices, answer with a number");
                Console.WriteLine("\n 1. Add person" +
                                "\n 2. Print list with personal information" +
                                "\n 3. Exit program");
                
                userChoice = int.Parse(Console.ReadLine());

                switch (userChoice)
                {
                    case 1:
                        {
                            

                            properties.AddPersonToList(people);
                            Console.WriteLine("Persons in list:");
                            
                            break;
                            
                        }
                            
                        
                    case 2:
                        {
                            foreach (var person in people)
                            {
                                Console.WriteLine(person); // Antag att du har överlagrat ToString() i Person-klassen
                            }
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Exiting program");
                            Environment.Exit(0);
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            }
        }
    }
}
