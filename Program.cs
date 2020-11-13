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

            int bankDiff = 100;
            int teamSkill = 0;

            bool quitting = false;
            while(quitting != true)
            {
              Console.Clear();
              foreach(var member in HeistTeam.MemberList)
              {
                teamSkill += member.SkillLevel;
              }
              Console.WriteLine($"1. Hire Member");
              Console.WriteLine($"2. Check team.");
              Console.WriteLine($"3. Run Heist Simulation");
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
              if(input == "3")
              {
                runSimulation(teamSkill, bankDiff);
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

          while (skill <= 0){
            skill = getSkill();
          }

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
        static int getSkill()
        {
          Console.WriteLine("What is the team member's skill level?");
          int skill = Convert.ToInt32(Console.ReadLine());
          if(skill <= 0)
          {
            Console.WriteLine("A team member cannot be negatively skilled!");
            Console.WriteLine("Press any key to continue!");
            Console.ReadKey();
            getSkill();
          }
          return skill;
        }

        static double getCourage()
        {
          Console.WriteLine("How courageous is the team member?");
          Console.WriteLine("(from 0.0 to 2.0)");
          double courage = Convert.ToDouble(Console.ReadLine());
          if(courage <= 0 || courage > 2.0)
          {
            Console.WriteLine("Courage must be greater than 0.0 and smaller than 2.0!");
            Console.WriteLine("Press any key to try again!");
            Console.ReadKey();
            getCourage();
          }
          return courage;
        }
        static void runSimulation(int teamSkill, int bankDiff)
        {
          var rand = new Random();
          int luck = rand.Next(-10, 10);
          int totalDiff = bankDiff + luck;
          Console.Clear();
          string dots = "............";
          Console.Write("Running simulation");
          foreach(var dot in dots)
          {
            Console.Write($"{dot}");
            System.Threading.Thread.Sleep(450);
          }
          Console.Write("\nResult: ");
          if(teamSkill > totalDiff)
          {
            Console.Write("Success");
          }
          else{
            Console.Write("Failure");
          }
          Console.WriteLine("\nPress any key to continue...");
          Console.ReadKey();
        }
    }
}
