using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_8_net
{
    internal class Security:Worker
    {
        public override void Print()
        {
            Console.WriteLine("Security");
            Console.WriteLine("Protects the facility, property, material assets located within the checkpoint.");
        }
    }
}
