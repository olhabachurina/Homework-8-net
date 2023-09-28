using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_8_net
{
    public class Cello : MusicalInstrument
    {
        public Cello(string instrumentName) : base(instrumentName) { }

        
        public override void Sound()//переопределение метода звук виолончели
        {
            Console.WriteLine($"Sound Cello {InstrumentName}");
        }
        public override void Show()
        {
            Console.WriteLine($"Name of musical instrument: {InstrumentName}");
        }

        // Переопределение метода для описания виолончели
        public override void Desc()
        {
            Console.WriteLine($"This is a cello {InstrumentName}");
            Console.WriteLine($"The cello is a bowed string instrument of the bass and tenor register");
            Console.WriteLine($"known since the first half of the 16th century,");
            Console.WriteLine($"of the same structure as the violin, but much larger in size.");

        }

        // Переопределение метода для истории создания файлов виолончели
        public override void History()
        {
            Console.WriteLine($"History of the cello {InstrumentName}");
            Console.WriteLine($"The appearance of the cello dates back to the late 15th and early 16th centuries");
            Console.WriteLine($"as a result of the long development of folk bowed instruments.");

        }
    }
}
