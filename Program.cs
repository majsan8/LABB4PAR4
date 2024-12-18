namespace LABB4PAR4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Person person1 = new(
                2001-10-30,
                "Green",
                Gender.Woman,
                new Hair { HairLength = 20, HairColor = "Blonde", HairStyle = "Long" });

            Person person2 = new(
                1997-11-03,
                "Brown",
                Gender.Man,
                new Hair { HairLength = 5, HairColor = "Brown", HairStyle = "Short" });
                
              
                Console.WriteLine(person1.ToString());
                Console.WriteLine(person2.ToString());^*/

            // Person person = new Person("1990", "Blå", Gender.Man, new Hair(10, "Brunt"));
            Person hajj = new Person("1111", "blue", Gender.Woman, new Hair(10, "brown"));

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
                            List<Person> people = new List<Person>();

                            hajj.AddPersonToList(people);
                            Console.WriteLine("Persons in list:");
                            foreach (var person in people)
                            {
                                Console.WriteLine(person); // Antag att du har överlagrat ToString() i Person-klassen
                            }
                            break;
                            
                        }
                            
                        
                    case 2:
                        {
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
