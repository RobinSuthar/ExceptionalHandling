using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionalHandling
{
    public class InvalidRadiusException
    {
        /*Method that returns that radius is not valid without any arugment*/
        public string invalidradiusexpeection()
        {
            string a;
            a = "The radius is less than or equal to zero ";
            return a;
        }
        /*Method that returns that radius is not valid without any arugment*/
        public string SecondConstructor( double radius)
        {
            string message;
            message = $"{radius} is not valid";
            return message;
        }

    }
}
