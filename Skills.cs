using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OptimalScheduling
{
    /// <summary>
    /// Will make all the skills in the system available for choosing no matter how they are internally stored
    /// </summary>
    interface Skills
    {
        /// <summary>
        /// Adds the skill.
        /// </summary>
        /// <param name="skill">The skill.</param>
        /// <returns>True if the skill got successfully added, false otherwise</returns>
        bool AddSkill(Skill skill);

        /// <summary>
        /// Gets the skill.
        /// </summary>
        /// <param name="uniqueSkillID">The unique skill ID.</param>
        /// <returns>The skill, null if not found perhaps</returns>
        Skill GetSkill(int uniqueSkillID);

        /// <summary>
        /// Gets the unique skill ID's.
        /// </summary>
        /// <returns>All the skills unique id's</returns>
        int[] GetUniqueSkillIDs(); // TODO: may need to redo this, returns all the uniqueID's for the skills

        /// <summary>
        /// Gets all the available skills as an array.
        /// </summary>
        /// <returns></returns>
        Skill[] GetAllSkillsArray();

        /// <summary>
        /// Gets all the available skills as an list.
        /// </summary>
        /// <returns></returns>
        List<Skill> GetAllSkillsList(); // TODO: maybe change to dictionary

        /// <summary>
        /// Removes the skill.
        /// </summary>
        /// <param name="uniqueSkillID">The unique skill's ID.</param>
        /// <returns>True if removal succeeded, false otherwise</returns>
        bool RemoveSkill(int uniqueSkillID);

        /// <summary>
        /// Removes the skill.
        /// </summary>
        /// <param name="skill">The skill.</param>
        /// <returns>True if removal succeeded, false otherwise</returns>
        bool RemoveSkill(Skill skill);

        /// <summary>
        /// Clears all skills.
        /// </summary>
        /// <returns></returns>
        bool ClearAllSkills();
        
    }
}
