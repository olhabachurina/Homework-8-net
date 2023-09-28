using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_8_net
{
    public class Violin : MusicalInstrument

    {
        public Violin(string instrumentName) : base(instrumentName) { }

        public override void Sound()
        {
            Console.WriteLine($"Sound Violin {InstrumentName}") ;
        }
        public override void Show()
        {
            Console.WriteLine($"Name of musical instrument: {InstrumentName}");
        }
        public override void Desc()
        {
            Console.WriteLine("This is a violin with a title {InstrumentName}");
            Console.WriteLine("The violin is one of the most refined and sophisticated musical instruments,");
            Console.WriteLine("with a charming melodious timbre very similar to the human voice,");
            Console.WriteLine("but at the same time very expressive and virtuosic. ");
        }

        // Переопределение метода для истории создания  скрипки
        public override void History()
        {
            Console.WriteLine("History of the violin {InstrumentName}");
            Console.WriteLine("The violin is of folk origin. The ancestors of the violin were the Arab rebab,");
            Console.WriteLine("the Spanish fidel, and the German rota, the merger of which formed the viol.");
            Console.WriteLine("The shapes of the violin were established by the 16th century.");
            Console.WriteLine("Famous violin makers, the Amati family, date back to this century and the beginning of the 17th century.");
        }





    }
    }




