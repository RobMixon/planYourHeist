using System;
using System.Collections.Generic;
using System.Linq;

namespace PlanYourHeist {
    public class Team {
        public string name { get; set; }
        public List<TeamMember> Group = new List<TeamMember> ();

        //  method
        // adding a team member into the dictionary of the group
        public void addTeamMember (TeamMember newTeamMember) {
            Group.Add (newTeamMember);
        }

        // looping through our list and calling the function print on each method
        public void ListTeamMembers () {
            foreach (TeamMember member in Group) {
                member.print ();
            }
        }

        public void SumOfMembers () {
            Console.WriteLine ($"The Number of Team Members In your group: {Group.Count}");
        }

        //getting sum of list for property of SkillLevel

        public int SumSkillLevel () {
            return Group.Sum (member => member.SkillLevel);
        }

    }

}