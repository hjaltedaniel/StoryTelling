using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoryTelling.Objects
{
    class Person
    {
        public string Name;
        public int YearOfBirth;
        public string CityOfBirth;
        public string MothersName;
        public string FathersName;

        public string LifeStory()
        {
            string storyTime = "Well. Let me tell you your life story " + Name + ". You were born way back in " + YearOfBirth + " in the city of " + CityOfBirth + " your father, the great man was " + FathersName + " and his lovely and caring wife, your mother, " + MothersName + ". Now you know a little more about yourself, don't you?";
            return storyTime;
        }
    }
}
