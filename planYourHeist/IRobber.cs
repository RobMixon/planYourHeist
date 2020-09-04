using System;
using System.Collections.Generic;
using System.Linq;

namespace PlanYourHeist {
    public interface IRobber {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }
        public void PerformSkill (string Bank);
    }
}