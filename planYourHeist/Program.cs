using System;
using System.Collections.Generic;
using System.Linq;

namespace PlanYourHeist {
    class Program {
        static void Main (string [] args) {
            Team myTeam = new Team ();

            Console.WriteLine ("So you want to rob a bank and get rich do you...");
            Console.WriteLine ("Well how rich do you want to be?");
            Console.WriteLine (" 1) Poor");
            Console.WriteLine (" 2) Middle class");
            Console.WriteLine (" 3) Boogey");
            Console.WriteLine (" 4) Starbucks every day type");
            Console.WriteLine ();
            Console.Write ("> ");
            string bank = Console.ReadLine ();
            int bankLevel = Int32.Parse (bank) * 10;

            while (true) {
                Console.WriteLine ("Menu");
                Console.WriteLine (" 1) Add a Team Member");
                Console.WriteLine (" 2) Print out Team Members");
                Console.WriteLine (" 3) Run Scenario");
                Console.WriteLine (" 4) Exit");
                Console.WriteLine ();
                Console.Write ("> ");
                string userChoice = Console.ReadLine ();

                switch (userChoice) {
                    case "1":
                        Console.WriteLine ("Plan Your Heist!");
                        // Console.WriteLine("Enter team name");
                        // string teamName = Console.ReadLine();
                        Console.WriteLine ("Enter team member's name");
                        string name = Console.ReadLine ();
                        if (name == "") {
                            myTeam.SumOfMembers ();
                            myTeam.ListTeamMembers ();

                            // return;

                        }
                        Console.WriteLine ("Enter team member's skill level");
                        string skillLevel = Console.ReadLine ();
                        Console.WriteLine ("Enter team member's courage factor");
                        string courageFactor = Console.ReadLine ();

                        TeamMember aNewTeamMember = new TeamMember (name, skillLevel, courageFactor);
                        myTeam.addTeamMember (aNewTeamMember);
                        break;
                    case "2":
                        myTeam.ListTeamMembers ();
                        break;
                    case "3":
                        Console.WriteLine ("How many times shall we run through this scenario?");
                        string numScenarioRuns = Console.ReadLine ();
                        int RunScenario = Int32.Parse (numScenarioRuns);
                        for (int i = 0; i < RunScenario; i++) {
                            int luckValue = new Random ().Next (-10, 11);
                            int difficultyLevel = bankLevel + luckValue;
                            // Console.WriteLine ("bang!");
                            //if skillLevelSum is greater than difficulty level will be successful, otherwise will fail;
                            int skillLevelSum = myTeam.SumSkillLevel ();
                            Console.WriteLine ($"Team's Skill Level: {skillLevelSum}");
                            Console.WriteLine ($"Bank's difficulty Level: {difficultyLevel}");
                            if (skillLevelSum >= difficultyLevel) {
                                Console.WriteLine ("You will succeed in your heist!");
                            }
                            else {
                                Console.WriteLine ("Sorry, you will fail");
                            }
                        }
                        break;
                    case "4":
                        return;
                    default:
                        // if the "choice" variable didn't match any "case" we inform the user that they
                        //  didn't choose a valid option
                        Console.WriteLine ("Invalid Menu Option. You should know better.");
                        break;
                }

            }
        }
    }
}