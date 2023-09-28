using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_8_net
{
    internal class Ukulele:MusicalInstrument
    {
        
        public Ukulele(string instrumentName) : base(instrumentName) { }

        public override void Sound()
        {
            Console.WriteLine($"Sound Ukulele {InstrumentName}");
        }
        public override void Show()
        {
            Console.WriteLine($"Name of musical instrument: {InstrumentName}");
        }
        public override void Desc()
        {
            Console.WriteLine("This is a ukulele with a title {InstrumentName}");
            Console.WriteLine("An Hawaiian four-string type of guitar used for chord ");
            Console.WriteLine("accompaniment of songs and playing solos.");
           
        }

        // Переопределение метода для истории создания укулеле
        public override void History()
        {
            Console.WriteLine("History of the ukulele {InstrumentName}");
            Console.WriteLine("The ukulele appeared on the Hawaiian Islands in the second half of the ");
            Console.WriteLine("19th century, where it was brought by the Portuguese from the island of Madeira.");
            
        }


    }
}
