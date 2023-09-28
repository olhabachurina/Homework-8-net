using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_8_net
{
    internal class President:Worker

    {
        public override void Print()
        {
            Console.WriteLine("President company");
            Console.WriteLine("The president of the company has the following responsibilities: ");
            Console.WriteLine("Manage the activities of the enterprise in all areas in accordance with the Charter. ");
        }
    }
}
