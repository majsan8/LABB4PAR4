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
            
            Console.WriteLine("Välkommen!");
            int userChoice;

            while (true)
            {
                Console.WriteLine("\n Du kommer nu att få tre val. Skriv valet med siffra");
                Console.WriteLine("\n 1. Lägg till person" +
                                "\n 2. Skriv ut lista med personlig information" +
                                "\n 3. Avsluta programmet");
                
                userChoice = int.Parse(Console.ReadLine());

                switch (userChoice)
                {
                    case 1:
                        {
                            break;
                        }
                    case 2:
                        {
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Nu avslutas programmet");
                            Environment.ExitCode = 0;
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
