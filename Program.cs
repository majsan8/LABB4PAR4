namespace LABB4PAR4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Person properties = new Person(new DateTime(2024,12,18), "blue", Gender.Woman, "10", "brown", "Maja");
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
                            
                            break;
                            
                        }
                            
                        
                    case 2:
                        {
                            foreach (var person in people)
                            {
                                Console.WriteLine("Persons in list:\n");
                                Console.WriteLine(person); 
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
