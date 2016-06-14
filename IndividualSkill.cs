using System;

namespace OptimalScheduling
{
    /// <summary>
    /// Holds the level of the skill a person has
    /// </summary>
    public struct IndividualSkill
    {
        /// <summary>
        /// The skill's ID
        /// </summary>
        public int skillID;
        /// <summary>
        /// The level of the skill
        /// </summary>
        public SkillLevel skillLevel;
    }


    /// <summary>
    /// The different levels
    /// </summary>
    public enum SkillLevel { Poor, Decent, Good, VeryGood, Excellent };
}