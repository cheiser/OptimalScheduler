using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace OptimalScheduling
{
    /// <summary>
    /// An instance of this class will hold a specific type of skill that the people should be able
    /// to have
    /// </summary>
    public class Skill
    {
        public Skill(string name)
        {
            this.name = name;
            this.designation = "";
            this.uniqueID = 0;
        }
        /// <summary>
        /// The unique ID for this specific instance of a Skill
        /// </summary>
        private int uniqueID;

        public int UniqueID
        {
            get { return uniqueID; }
            set { uniqueID = value; }
        }

        /// <summary>
        /// The name of the skill
        /// </summary>
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// The designation of the skill
        /// </summary>
        private string designation;

        public string Designation
        {
            get { return designation; }
            set { designation = value; }
        }
        
        
    }
}
