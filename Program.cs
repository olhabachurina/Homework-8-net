// See https://aka.ms/new-console-template for more information

using Homework_8_net;

class Program
{
    static void Main()
    {
        Console.WriteLine("Eercise 3");
        //Создать базовый класс «Музыкальный инструмент» и производные классы: «Скрипка», «Тромбон», «Укулеле», «Виолончель». 
        //С помощью конструктора установите название каждого музыкального инструмента и его свойства. 
        //Реализуйте для каждого из классов методы: ■ Sound — звук музыкального инструмента (пишем текстом в консоли); 
        //Show – отображает название музыкального инструмента; ■ Desc — описание музыкального инструмента;
        //History —  истории создания 
        Violin violin = new Violin("String violin");
        Console.WriteLine("**********************");
        violin.Show();
        violin.Sound();
        violin.Desc();
        violin.History();
        Cello cello = new Cello("String cello  ");
        Console.WriteLine("**********************");
        cello.Show();
        cello.Sound();
        cello.Desc();
        cello.History();
        Trombon trombon = new Trombon("Brass trombone ");
        Console.WriteLine("**********************");
        trombon.Show();
        trombon.Sound();
        trombon.Desc();
        trombon.History();
        Ukulele ukulele = new Ukulele("String ukulele ");
        Console.WriteLine("**********************");
        ukulele.Show();
        ukulele.Sound();
        ukulele.Desc();
        ukulele.History();
        Console.WriteLine("*/*/*/*/*/*/*/*/*/");
        Console.WriteLine("Exercise 4");
        //Создайте абстрактный базовый класс Worker (работник) с помощью метода Print(). 
        //создать четыре производных класса: Президент, Охранник, Менеджер, Инженер. 
        //Переопределите метод. Print() для получения информации, соответствующей каждому типу работника.
        Worker president = new President();
        Worker security = new Security();
        Worker manager = new Manager();
        Worker engineer = new Engineer();
        president.Print();
        Console.WriteLine("**********************");
        security.Print();
        Console.WriteLine("**********************");
        manager.Print();
        Console.WriteLine("**********************");
        engineer.Print();
    }
}




