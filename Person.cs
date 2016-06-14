using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OptimalScheduling
{
    /// <summary>
    /// A single individual and the skills he/she holds
    /// </summary>
    public class Person
    {
        public string Name { get; set; }
        public string ID { get; set; } // probably the personal code number

        private PersonSkills skills;


        public Person()
        {
        }

        public Person(string name, string id)
        {
            this.Name = name;
            this.ID = id;
            this.skills = new PersonSkills();
        }

        public Person(string name, string id, PersonSkills skills)
        {
            this.Name = name;
            this.ID = id;
            this.skills = skills;
        }


        public PersonSkills Skills
        {
            get { return skills; }
            set { skills = value; }
        }

        // TODO: Fixa!!!
        public bool AddSkill(int skillID)
        {
            return false;
        }
        
    }
}
