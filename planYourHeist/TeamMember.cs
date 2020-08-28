using System;

namespace PlanYourHeist {
    public class TeamMember {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public double CourageFactor { get; set; }

        // this is creating the team member 
        public TeamMember (string name, string skillLevel, string courageFactor) {
            Name = name;
            SkillLevel = Int32.Parse (skillLevel);
            CourageFactor = Double.Parse (courageFactor);
        }

        // created a method to print team members info
        public void print () {
            Console.WriteLine (Name);
            Console.WriteLine (SkillLevel);
            Console.WriteLine (CourageFactor);
        }
    }

}