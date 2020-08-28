using System;
using System.Collections.Generic;
using System.Linq;

namespace PlanYourHeist {
    class Program {
        static void Main (string [] args) {
            Console.WriteLine ("Plan Your Heist!");
            Console.WriteLine ("Enter team name");
            string teamName = Console.ReadLine ();
            Console.WriteLine ("Enter team member's names");
            string name = Console.ReadLine ();
            Console.WriteLine ("Enter team member's skill level");
            string skillLevel = Console.ReadLine ();
            Console.WriteLine ("Enter team member's courage factor");
            string courageFactor = Console.ReadLine ();

            Team Cheddar = new Team (teamName);
            TeamMember Faith = new TeamMember (name, skillLevel, courageFactor);
            Cheddar.addTeamMember (Faith);
            // calling them with cheddar.ListTeamMembers
            Cheddar.ListTeamMembers ();

        }
    }
}