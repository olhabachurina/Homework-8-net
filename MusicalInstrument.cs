using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_8_net
{
    public abstract class MusicalInstrument
    {
        protected string InstrumentName;//название иструмента
        public MusicalInstrument(string instrumentName)//конструктор для установки названия инструмета
        {
            InstrumentName = instrumentName;
        }
        public virtual void Sound()
        {
            Console.WriteLine("Sound {InstrumentName}");//звук музыкального инструмента
                }
        public virtual void Show()
        {
            Console.WriteLine("Name of musical instrument: {InstrumentName}");//название музыкаьного инструмента
        }
        public virtual void Desc()//описание мзыкального инструмент
        {
            Console.WriteLine("The  {InstrumentName}");
        }
        public virtual void History()//создание истории музыального инструмента
        {
            Console.WriteLine("The history of the creation of a musical instrument for {InstrumentName}");
        }
    }
}
