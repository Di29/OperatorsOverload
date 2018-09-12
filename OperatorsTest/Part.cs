using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsTest
{
    public  class Part
    {
        public string Name { get; set; }

        public static Complete operator +(Part firstPart, Part secondPart)
        {
            string completeName = firstPart.Name[0].ToString() + secondPart.Name[0].ToString();
            return new Complete
            {
                Name = completeName,
                Parts = new Part[]
                {
                    firstPart,
                    secondPart
                }

            };
        }
    }
}
