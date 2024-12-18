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
                $"Birthday: {Birthday}\n" +
                $"Eye color: {EyeColor}\n" +
                $"Gender: {Gender}\n" +
                $"Hair length: {Hair.HairLength}\n" +
                $"Hair Color: {Hair.HairColor}\n";
            
        }

        

        public void AddPersonToList(List<Person> people)
        {
        

            string name = "";
            Console.WriteLine("What is the name of the person");
            name = Console.ReadLine();




            DateTime birthday;
            Console.WriteLine("Ange din födelsedag (åååå-mm-dd):");
            string input = Console.ReadLine();
            if (DateTime.TryParse(input, out birthday))
            {
            }
            else
            {
                Console.WriteLine("Ogiltig inmatning. Ange födelsedagen i formatet åååå-mm-dd.");
                Environment.Exit(0);
            }


            Console.WriteLine("What´s their eyecolor:\n1. Brown\n2. Gray\n3. Blue\n4. Green\n5. Black");
            string eyecolor = "";
            int userPersonEC = int.Parse(Console.ReadLine());
            if (userPersonEC == 1)
            {
                eyecolor = "Brown";
            }
            else if (userPersonEC == 2)
            {
                eyecolor = "Gray";
            }
            else if (userPersonEC == 3)
            {
                eyecolor = "Blue";
            }
            else if (userPersonEC == 4)
            {
                eyecolor = "Green";
            }
            else if (userPersonEC == 5)
            {
                eyecolor = "Black";
            } 
            else {
                Console.WriteLine("You entered the wrong data, please try again and follow the instructions");
                Environment.Exit(0);
            }



            string hairlength = "";

            Console.WriteLine("What´s their hair length, pick one of the following:\n1. Bald\n2. Short\n3. Medium\n4. Long\n5. Other");
            int userHLinput = int.Parse(Console.ReadLine());

            if (userHLinput == 1)
            {
                hairlength = "Bald";
            }
            else if (userHLinput == 2)
            {
                hairlength = "Short";
            }
            else if (userHLinput == 3)
            {
                hairlength = "Medium";
            }
            else if (userHLinput == 4)
            {
                hairlength = "Long";
            }
            else if (userHLinput == 5)
            {
                hairlength = "Other";
            }
            else
            {
                Console.WriteLine("You entered the wrong data, please try again and follow the instructions");
                Environment.Exit(0);
            }





            Console.WriteLine("What´s their hair color:\n1. Brown\n2. Blonde\n3. Gray\n4. Crazycolor\n5. Other");
            int userHCInput = int.Parse(Console.ReadLine());

            string haircolor = "";

            if (userHCInput == 1)
            {
                haircolor = "Brown";
            }
            else if (userHCInput == 2)
            {
                haircolor = "Blonde";
            }
            else if (userHCInput == 3)
            {
                haircolor = "Gray";
            }
            else if (userHCInput == 4)
            {
                haircolor = "Crazycolor";
            }
            else if (userHCInput == 5)
            {
                haircolor = "Other";
            }
            else
            {
                Console.WriteLine("You entered the wrong data, please try again and follow the instructions");
                Environment.Exit(0);
            }

            // Skapa en ny instans av Person och lägg till den i listan
            Person newPerson = new Person(birthday, eyecolor, Gender, hairlength, haircolor, name);
            people.Add(newPerson);
        }
    }
}
