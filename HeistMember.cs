using System;

namespace bankHeist
{
  public class HeistMember{
    public HeistMember(string name, int skill, double courage){
      Name = name;
      SkillLevel = skill;
      Courage = courage;
    }

    public void description(){
      Console.WriteLine($"Code Name: {Name}");
      Console.WriteLine("--------------------");
      Console.WriteLine($"---Skill Level: {SkillLevel}");
      Console.WriteLine($"---Courage Level: {Courage}");
    }
    public string Name {get; set; }
    public int SkillLevel {get; set; }
    public double Courage {get; set; }


  }
}