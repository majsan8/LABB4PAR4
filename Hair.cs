using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LABB4PAR4
{
    public struct Hair
    {
        public int HairLength;
        public string HairColor;


        public Hair(int hairlength, string haircolor)
        {
            HairLength = hairlength;
            HairColor = haircolor;
        }

        public override string ToString()
        {
            return $"{HairLength} cm, Hair color: {HairColor}";
        }
    }
}
