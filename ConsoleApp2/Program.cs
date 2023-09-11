using System;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Привет, создатель, как тебя зовут?");
            string answerUser = Console.ReadLine();

            Console.WriteLine("А как ты назовешь меня?");
            string nameBot = Console.ReadLine();
            Console.WriteLine($"Приятно познакомиться, {answerUser}. Меня зовут {nameBot}, это ты меня так назвал");
        }
    }
}
