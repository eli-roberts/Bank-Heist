using System;
using System.Collections.Generic;

namespace bankHeist
{
  public class Team
  {
    public List<HeistMember> MemberList = new List<HeistMember> {};
    public string teamName {get; set; }
    


    public void addToTeam(HeistMember member)
    {
      MemberList.Add(member);
      Console.WriteLine("Team Member Added Successfully!");
    }
    public void checkTeam()
    {
      Console.Clear();
      Console.WriteLine($"{teamName} Members");
      Console.WriteLine("~~~~~~~~~~~~~~~~~~~~");
      foreach(var member in MemberList){
        Console.WriteLine($"-{member.Name}");
        Console.WriteLine($"  -Skill: {member.SkillLevel}");
        Console.WriteLine($"  -Courage: {member.Courage}");
      }
      Console.WriteLine("~~~~~~~~~~~~~~~~~~~~");
      Console.WriteLine("Press any key to continue...");
      Console.ReadKey();
    }
  }
}