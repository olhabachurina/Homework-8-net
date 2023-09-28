using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_8_net
{
    internal class Engineer :Worker
    {
        public override void Print()
        {
            Console.WriteLine("Engineer");
            Console.WriteLine("Provides methodological and practical assistance");
            Console.WriteLine("in the implementation of projects and programs, plans and contracts");
        }
    }
}
