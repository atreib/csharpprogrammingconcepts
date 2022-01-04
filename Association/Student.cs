using System;
namespace Association
{
    /**
     * Our class Student exists by itself
     */
    public class Student
    {
        private String name;

        public Student(String name)
        {
            this.name = name;
        }

        public String GetName()
        {
            return this.name;
        }
    }
}
