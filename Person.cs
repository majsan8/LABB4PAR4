using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace LABB4PAR4
{
    public class Person
    {
        public int Birthday { get; set; }
        public string EyeColor { get; set; }

        public Gender gender {  get; set; }
        public Hair hair {  get; set; }

        //Konstruktor
        public Person(int Birthday, string Eyecolor, Gender gender, Hair hair)
        {
           


        }

        public override string ToString()
        {
            return $"Birthday: {Birthday}\n," +
                $"Eye color: {EyeColor}\n," +
                $"Gender: {gender}\n," +
                $"Hair length: {hair}";
        }
    }
}
