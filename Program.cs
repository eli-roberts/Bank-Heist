using System;

namespace bankHeist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            //Initializes heist member list
            var HeistTeam = new Team();

            //Introductory console stuff
            Console.WriteLine("Plan your heist!");
            Console.WriteLine("What is your heist team's name?");
            string teamName = Console.ReadLine();
            HeistTeam.teamName = teamName;

            bool quitting = false;
            while(quitting != true)
            {
              Console.Clear();
              Console.WriteLine($"1. Hire Member");
              Console.WriteLine($"2. Check team.");
              Console.WriteLine($"0. Quit Program");
              string input = Console.ReadLine();
              if(input == "1")
              {
                addMember(HeistTeam);
              }
              if(input == "2")
              {
                HeistTeam.checkTeam();
              }
              if(input == "0")
              {
                quitting = true;
              }
            }

        }
        static void addMember(Team team)
        { 

          //Init member attributes
          string codeName = "";
          int skill = 0;
          double courage = 0.0;
          
          Console.Clear();

          while (codeName == "")
          {
            codeName = getName();
          }

          Console.WriteLine($"What is {codeName}'s skill level?");
          skill = Convert.ToInt32(Console.ReadLine());

          Console.WriteLine($"How courageous is {codeName}?");
          courage = Convert.ToDouble(Console.ReadLine());

          var member = new HeistMember(codeName, skill, courage);


          team.addToTeam(member);
        }

        static string getName()
        {
          Console.WriteLine("What is the member's name?");
          string name = Console.ReadLine();
          return name;
        }
    }
}
