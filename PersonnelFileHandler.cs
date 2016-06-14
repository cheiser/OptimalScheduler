using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace OptimalScheduling
{
    /// <summary>
    /// A concrete handler for the personnel
    /// </summary>
    public class PersonnelFileHandler : Personnel
    {
        private List<Person> personnel; // perhaps use a dictionary instead....

        public PersonnelFileHandler()
        {
            // Load the file containing the personnel
            personnel = new List<Person>();

            // TODO: Add support for skills
            using (XmlReader reader = XmlReader.Create("personnel.xml"))
            {
                while (reader.Read())
                {
                    // Only detect start elements.
                    if (reader.IsStartElement())
                    {
                        // Get element name and switch on it.
                        switch (reader.Name)
                        {
                            case "Personnel":
                                // The beginning tag nothing special to do...
                                break;
                            case "Person":
                                // One employee found read all the information and save to the personnel array
                                reader.ReadToFollowing("ID");
                                string id = reader.ReadElementString("ID");
                                string name = reader.ReadElementString("Name");
                                personnel.Add(new Person(name, id));
                                break;
                        }
                    }
                }
            }

        }

        // Destructor
        ~PersonnelFileHandler()
        {
            // Save the Personnel list
            using (XmlWriter writer = XmlWriter.Create("personnel.xml")) // using "using" to make sure the resources get cleaned up
            {
                writer.WriteStartDocument();
                writer.WriteStartElement("Personnel");

                foreach (Person person in personnel)
                {
                    writer.WriteStartElement("Person");

                    writer.WriteElementString("ID", person.ID);
                    writer.WriteElementString("Name", person.Name);
                    // TODO: Add skills
                    //writer.WriteElementString("Skill", person.Skill);

                    writer.WriteEndElement();
                }

                writer.WriteEndElement();
                writer.WriteEndDocument();
            }
            Console.WriteLine("file created");
        }

        /// <summary>
        /// Gets the person with the specified id.
        /// </summary>
        /// <param name="ID">The ID.</param>
        /// <returns>The person, null if there does not exist such a person among the personnel</returns>
        public Person GetPerson(string ID)
        {
            foreach (Person person in personnel)
            {
                if (person.ID.Equals(ID))
                    return person;
            }
            return null;
        }

        /// <summary>
        /// Gets all personnels IDs.
        /// </summary>
        /// <returns>All the personnel id's as an array</returns>
        public string[] GetAllPersonnelIDs()
        {
            List<string> allPersonnel = new List<string>();
            foreach (Person person in personnel)
            {
                allPersonnel.Add(person.ID);
            }
            return allPersonnel.ToArray();
        }

        /// <summary>
        /// Gets all personnel as an array.
        /// </summary>
        /// <returns>All the personnel as an array</returns>
        public Person[] GetAllPersonnelArray()
        {
            return personnel.ToArray();
        }

        /// <summary>
        /// Gets all personnel as an List.
        /// </summary>
        /// <returns>All the personnel as an array</returns>
        public List<Person> GetAllPersonnelList()
        {
            return personnel;
        }

        // TODO: Update this so it's up to date
        public bool AddPerson(Person person)
        {
            // add person to personnel list and update the saved file with the updated list/new person
            personnel.Add(person);
            return true;
        }

        /// <summary>
        /// Adds the group of personnel.
        /// </summary>
        /// <param name="personnel">The personnel.</param>
        /// <returns>true if success, false otherwise (may need to be redone so it does not add some people and then fails)</returns>
        public bool AddGroupOfPersonnel(Person[] personnel)
        {
            //foreach (Person person in personnel)
            //{
            //    if (!AddPerson(person))
            //    {
            //        return false;
            //    }
            //}
            //return true;
            return AddGroupOfPersonnel(personnel.ToList());
        }

        /// <summary>
        /// Adds the group of personnel.
        /// </summary>
        /// <param name="personnel">The personnel.</param>
        /// <returns>true if success, false otherwise (may need to be redone to check so only one person is added one time)</returns>
        public bool AddGroupOfPersonnel(List<Person> personnel)
        {
            this.personnel.AddRange(personnel);
            return true;
        }


        /// <summary>
        /// Removes all the persons with the specified id.
        /// </summary>
        /// <param name="personID">The person's ID.</param>
        /// <returns>true on success, false othewise</returns>
        public bool RemovePerson(string personID)
        {
            bool found = false;
            foreach (Person person in personnel)
            {
                if (person.ID.Equals(personID))
                {
                    personnel.Remove(person);
                    found = true;
                }
            }
            return found;
        }

        /// <summary>
        /// Clears all the personnel
        /// </summary>
        /// <returns></returns>
        public bool ClearPersonnel()
        {
            // Clear the personnel list and the file containing the personnel information
            personnel = new List<Person>();
            return true;
        }
    }
}