/*
File Name: Program.cs

*Name: Zulqarnayan Hossain, Liya T Slassie
*email:  hossaizn@mail.uc.edu, tslassll@mail.uc.edu
*Assignment Number: In Class Assignment March 27, 2025
*Due Date: March 27, 2025
*Course #/Section:   IS 3050 Sectiion 001
* Semester / Year:   Spring 2025
*Brief Description of the assignment:  We create a repository and perform pull requests to it as a collaborative effort.

*Brief Description of what this module does.  We work on our understanding of using github as a collaborative coding tool.
*Citations: N/A
*Anything else that's relevant: N/A
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClassIS3050March27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            iphone myiphone = new iphone();
            myiphone.Price = 1000;
            Console.WriteLine("Price of iphone is " + myiphone.Price);

            Console.WriteLine("Liya T Slassie");
        }
    }
}
