using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OptimalScheduling
{
    /// <summary>
    /// Collects all of one persons IndividualSkill into a single class
    /// </summary>
    public class PersonSkills
    {
        /// <summary>
        /// The skills, the integer is the ID of the skill
        /// </summary>
        private Dictionary<int, IndividualSkill> skills;

        public PersonSkills()
        {
            skills = new Dictionary<int, IndividualSkill>();
        }

        public PersonSkills(Dictionary<int, IndividualSkill> skills)
        {
            this.skills = skills;
        }

        public Dictionary<int, IndividualSkill> Skills
        {
            get { return skills; }
            set { skills = value; }
        }


        /// <summary>
        /// Gets the persons skill level for skill.
        /// </summary>
        /// <param name="skillID">The skill ID.</param>
        /// <param name="skillLevel">The skill level.</param>
        /// <exception cref="System.ArgumentNullException">
        /// Throws exception if it couldn't get the persons skill level for the skill</exception>
        public void GetSkillLevelForSkill(int skillID, out SkillLevel skillLevel)
        {
            IndividualSkill temp;
            if (!skills.TryGetValue(skillID, out temp))
            {
                throw new System.ArgumentNullException();
            }
            skillLevel = temp.skillLevel;
        }
    }
}
