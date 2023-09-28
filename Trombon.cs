using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_8_net
{
    internal class Trombon:MusicalInstrument
    {

        public Trombon(string instrumentName) : base(instrumentName) { }

        public override void Sound()
        {
            Console.WriteLine($"Sound Trombon {InstrumentName}");
        }
        public override void Show()
        {
            Console.WriteLine($"Name of musical instrument: {InstrumentName}");
        }
        public override void Desc()
        {
            Console.WriteLine("Trombone is a European wind instrument. {InstrumentName}");
            Console.WriteLine("Member of the orchestral group of brass ,");
            Console.WriteLine("musical instruments of the bass-tenor register.");
            
        }

        // Переопределение метода для истории создания тромбона
        public override void History()
        {
            Console.WriteLine("History of the trombon {InstrumentName}");
            Console.WriteLine("The appearance of the trombone dates back to the 15th century.,");
            Console.WriteLine("It is generally accepted that the immediate predecessors of this instrument were rocker pipes.");
            
        }

    }
}
