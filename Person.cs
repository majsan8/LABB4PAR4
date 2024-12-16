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
        public int Birthday { get; set; }
        public string EyeColor { get; set; }

        public Gender Gender {  get; set; }
        public Hair Hair {  get; set; }

        //Konstruktor
        public Person(int birthday, string eyecolor, Gender gender, Hair hair)
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
        
        public Person AddPerson()
        {
            Console.WriteLine($"Skriv in personens födelsedag (åååå-mm-dd): {Birthday}");
            return new Person { Birthday = Birthday, EyeColor = EyeColor, Gender = Gender, Hair = Hair };
        }
    }
}
