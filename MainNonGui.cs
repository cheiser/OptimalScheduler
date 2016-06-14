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
    public class MainNonGui
    {
        static int Main(string[] args)
        {
            Console.WriteLine("TESTSETSETSET");
            PersonnelFileHandler ph = new PersonnelFileHandler();

            ph.AddPerson(new Person("Testgubbe4", "0115156401"));
            return 0;
        }
    }
}