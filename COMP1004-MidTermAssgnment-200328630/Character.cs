using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP1004_MidTermAssgnment_200328630
{

    /// <summary>
    /// Program: Midterm DND Character Creator
    /// Name: Justin Schieck
    /// StudentID: 200328630
    /// App Creation Date: Feb 20, 2013
    /// App Desc: Creates a character used for RPG adventures
    /// </summary>
    /// 
    public class Character
    {

        //Storage for Information gathered from forms.

        public string Strength { get; set; }

        public string Dexterity { get; set; }

        public string Endurance { get; set; }

        public string Intelligence { get; set; }

        public string Perception { get; set; }

        public string Charisma { get; set; }

        public string Race { get; set; }

        public string Health { get; set; }

        public string Job { get; set; }


        //Unused but available for future editing
        //public string Name { get; set; }
        //public string Age { get; set; }
        //public string Height { get; set; }
        //public string Weight { get; set; }

    }
}