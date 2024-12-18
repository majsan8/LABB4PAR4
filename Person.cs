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



        public void AddPersonToList(List<Person> people)
        {
            Console.WriteLine("Choose (1 for woman, 0 for man):");
            int userChoiceGender = int.Parse(Console.ReadLine());

            int userPersonGender = 0; // Initiera med 0 som standard
            if (userChoiceGender == 1)
            {
                userPersonGender = (int)Gender.Woman;
            }

            Console.WriteLine("What is the person´s birthday? Write it like this (yyyy-mm-dd):");
            string userPersonBd = Console.ReadLine();

            Console.WriteLine("What´s their eyecolor:");
            string userPersonEC = Console.ReadLine();

            Console.WriteLine("What´s their hair color:");
            string userPersonHair = Console.ReadLine();

            Console.WriteLine("What´s their hair length in cm:");
            int userPersonHairLength = int.Parse(Console.ReadLine());

            // Skapa en ny instans av Person och lägg till den i listan
            Person newPerson = new Person(userPersonBd, userPersonEC, Gender.Woman, new Hair(userPersonHairLength, userPersonHair));
            people.Add(newPerson);
        }
    }
}
