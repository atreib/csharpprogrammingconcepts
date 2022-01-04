using System;
namespace Association
{
    /**
     * Our class Teacher exists by itself
     */
    public class Teacher
    {
        private String name;

        public Teacher(String name)
        {
            this.name = name;
        }

        public String GetName()
        {
            return this.name;
        }
    }
}
