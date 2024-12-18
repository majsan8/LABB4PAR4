using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LABB4PAR4
{
    public class Person
    {
        public DateTime Birthday { get; set; }

        
        public string EyeColor { get; set; }

        public Gender Gender {  get; set; }
        public Hair Hair {  get; set; }
        public string Name { get; set; }


        //Konstruktor
        public Person(DateTime birthday, string eyecolor, Gender gender, string hairlength, string haircolor, string name)
        {
            Birthday = birthday;
            EyeColor = eyecolor;
            Gender = gender;
            Hair = new Hair {HairLength = hairlength, HairColor = haircolor};
            Name = name;
            

        }

        public override string ToString()
        {
            return $"Name: {Name}\n" +
                $"Birthday: {Birthday:yyyy/MM/dd}\n" +
                $"Eye color: {EyeColor}\n" +
                $"Gender: {Gender}\n" +
                $"Hair length: {Hair.HairLength}\n" +
                $"Hair Color: {Hair.HairColor}\n";
            
        }

        

        public void AddPersonToList(List<Person> people)
        {
        

            string name = "";
            Console.WriteLine("\nWhat is the name of the person?");
            name = Console.ReadLine();
            DateTime birthday;

            while (true)
            {

                
                Console.WriteLine("\nEnter the person's birthday (yyyy-mm-dd):");
                string input = Console.ReadLine();
                if (DateTime.TryParse(input, out birthday))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("\nInvalid input, please follow the instructions.");
                    
                }
            }

            string eyecolor = "";

            while (true)
            {
                Console.WriteLine("\nWhat´s their eyecolor:\n1. Brown\n2. Gray\n3. Blue\n4. Green\n5. Black");
                int userPersonEC = int.Parse(Console.ReadLine());
                if (userPersonEC == 1)
                {
                    eyecolor = "Brown";
                    break;
                }
                else if (userPersonEC == 2)
                {
                    eyecolor = "Gray";
                    break;
                }
                else if (userPersonEC == 3)
                {
                    eyecolor = "Blue";
                    break;
                }
                else if (userPersonEC == 4)
                {
                    eyecolor = "Green";
                    break;
                }
                else if (userPersonEC == 5)
                {
                    eyecolor = "Black";
                    break;
                }
                else
                {
                    Console.WriteLine("\nInvalid input, please follow the instructions.");
                }
            }
            
            Gender gender;

            while (true) { 
                Console.WriteLine("\nWhat gender is the person?\n1. Woman\n2. Man\n3. Other");
                int userGInput = int.Parse(Console.ReadLine());

                if (userGInput == 1)
                {
                    gender = Gender.Woman;
                    break;
                }
                else if (userGInput == 2)
                {
                    gender = Gender.Man;
                    break;
                }
                else if (userGInput == 3)
                {
                    gender = Gender.Other;
                    break;

                }
                else 
                {
                    Console.WriteLine("\nInvalid input, please follow the instructions.");
                }
                
            }

            string hairlength = "";

            while (true)
            {
                Console.WriteLine("\nWhat´s their hair length? Pick one of the following:\n1. Bald\n2. Short\n3. Medium\n4. Long\n5. Other");
                int userHLinput = int.Parse(Console.ReadLine());

                if (userHLinput == 1)
                {
                    hairlength = "Bald";
                    break;
                }
                else if (userHLinput == 2)
                {
                    hairlength = "Short";
                    break;
                }
                else if (userHLinput == 3)
                {
                    hairlength = "Medium";
                    break;
                }
                else if (userHLinput == 4)
                {
                    hairlength = "Long";
                    break;
                }
                else if (userHLinput == 5)
                {
                    hairlength = "Other";
                    break;
                }
                else
                {
                    Console.WriteLine("\nYou entered the wrong data, please try again and follow the instructions");
                    
                }

            }



            Console.WriteLine("\nWhat´s their hair color?\n1. Brown\n2. Blonde\n3. Gray\n4. Crazycolor\n5. Other");
            int userHCInput = int.Parse(Console.ReadLine());

            string haircolor = "";

            while (true)
            {
                if (userHCInput == 1)
                {
                    haircolor = "Brown";
                    break;
                }
                else if (userHCInput == 2)
                {
                    haircolor = "Blonde";
                    break;
                }
                else if (userHCInput == 3)
                {
                    haircolor = "Gray";
                    break;
                }
                else if (userHCInput == 4)
                {
                    haircolor = "Crazycolor";
                    break;
                }
                else if (userHCInput == 5)
                {
                    haircolor = "Other";
                    break;
                }
                else
                {
                    Console.WriteLine("\nYou entered the wrong data, please try again and follow the instructions");
                    
                }
            }
            // Skapa en ny instans av Person och lägg till den i listan
            Person newPerson = new Person(birthday, eyecolor, gender, hairlength, haircolor, name);
            people.Add(newPerson);
        }

        public void ListPersons(List<Person> people)
        {
            Console.WriteLine("\nPersons in list:\n");
            foreach (var person in people)
            {

                Console.WriteLine(person);
            }
        }
    }
}
