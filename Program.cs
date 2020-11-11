using System;

namespace bankHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Plan your heist!");
            Console.WriteLine("What is the member's name?");
            string codeName = Console.ReadLine();
            Console.WriteLine($"What is {codeName}'s skill level?");
            int skill = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"How courageous is {codeName}?");
            double courage = Convert.ToDouble(Console.ReadLine());

            var memberOne = new HeistMember(codeName, skill, courage);
            memberOne.description();
        }
    }
}
