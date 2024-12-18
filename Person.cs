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
        public string Birthday { get; set; }
        public string EyeColor { get; set; }

        public Gender Gender {  get; set; }
        public Hair Hair {  get; set; }

        //Konstruktor
        public Person(string birthday, string eyecolor, Gender gender, Hair hair)
        {
            Birthday = birthday;
            EyeColor = eyecolor;
            Gender = gender;
            Hair = hair;

            

        }

        public override string ToString()
        {
            return $"Birthday: {Birthday}\n," +
                $"Eye color: {EyeColor}\n," +
                $"Gender: {Gender}\n," +
                $"Hair length: {Hair}";
        }

        /*public override string AddPerson() { 
        
        
            Console.WriteLine("Skriv in personens födelsedag (åååå-mm-dd):");
            string userPersonBd = Console.ReadLine();

            Person newPerson = new Person(userPersonBd);

            (userPersonBd);


            Console.WriteLine(people);

        }*/


        public void AddPersonToList(List<Person> people)
        {
            Console.WriteLine("Välj kön (1 för kvinna, 0 för man):");
            int userChoiceGender = int.Parse(Console.ReadLine());

            int userPersonGender = 0; // Initiera med 0 som standard
            if (userChoiceGender == 1)
            {
                userPersonGender = (int)Gender.Woman;
            }

            Console.WriteLine("Skriv in personens födelsedag (åååå-mm-dd):");
            string userPersonBd = Console.ReadLine();

            Console.WriteLine("Skriv in personens ögonfärg:");
            string userPersonEC = Console.ReadLine();

            Console.WriteLine("Skriv in personens hårfärg:");
            string userPersonHair = Console.ReadLine();

            Console.WriteLine("Skriv in personens hårläng i siffror(cm)");
            int userPersonHairLength = int.Parse(Console.ReadLine());

            // Skapa en ny instans av Person och lägg till den i listan
            Person newPerson = new Person(userPersonBd, userPersonEC, Gender.Woman, new Hair(userPersonHairLength, userPersonHair));
            people.Add(newPerson);
        }
    }
}
