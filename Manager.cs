using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_8_net
{
    internal class Manager:Worker
    {
        public override void Print()
        {
            Console.WriteLine("Manager");
            Console.WriteLine("Manages projects or departments of the company");
            Console.WriteLine("monitors the production and turnover of goods,");
            Console.WriteLine("controls the distribution of resources and the quality of service provision.");
        }
    }
}
