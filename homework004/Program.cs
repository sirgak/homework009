using System;

namespace homework004
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("До перестановки");
            string name ;
            string surname;
            name = "Иванов";
            surname = "Иван";
            Console.WriteLine("Имя " + name);
            Console.WriteLine("Фамилия " + surname);
            Console.WriteLine("После перестановки");
            (name, surname) = (surname, name);
            Console.WriteLine("Имя " + name);
            Console.WriteLine("фамилия " + surname);
        }
    }
}
