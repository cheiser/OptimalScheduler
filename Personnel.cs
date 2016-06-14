using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace OptimalScheduling
{
    /// <summary>
    /// Makes all the personnel accessible without knowing about the underlying storing method
    /// </summary>
    interface Personnel
    {
        /// <summary>
        /// Gets the person with the specified id.
        /// </summary>
        /// <param name="ID">The ID.</param>
        /// <returns></returns>
        Person GetPerson(string ID);

        /// <summary>
        /// Gets all personnels IDs.
        /// </summary>
        /// <returns></returns>
        string[] GetAllPersonnelIDs();

        /// <summary>
        /// Gets all personnel as an array.
        /// </summary>
        /// <returns></returns>
        Person[] GetAllPersonnelArray();

        /// <summary>
        /// Gets all personnel as an List.
        /// </summary>
        /// <returns></returns>
        List<Person> GetAllPersonnelList();

        /// <summary>
        /// Adds the person.
        /// </summary>
        /// <param name="person">The person.</param>
        /// <returns>Returns false if the adding would fail for some reason</returns>
        bool AddPerson(Person person);

        /// <summary>
        /// Adds the group of personnel.
        /// </summary>
        /// <param name="Personnel">The personnel.</param>
        /// <returns>Adds an whole group of persons </returns>
        bool AddGroupOfPersonnel(Person[] Personnel);

        /// <summary>
        /// Adds the group of personnel.
        /// </summary>
        /// <param name="Personnel">The personnel.</param>
        /// <returns>Adds an whole group of persons</returns>
        bool AddGroupOfPersonnel(List<Person> Personnel);


        /// <summary>
        /// Removes the person.
        /// </summary>
        /// <param name="personID">The person ID.</param>
        /// <returns></returns>
        bool RemovePerson(string personID);

        /// <summary>
        /// Clears all the personnel.
        /// </summary>
        /// <returns></returns>
        bool ClearPersonnel();
    }
}
