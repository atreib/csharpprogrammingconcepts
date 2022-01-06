using System;
using System.Collections.Generic;

namespace Association
{
    /**
     * In our "Class" class, we're creating an aggregation
     *   between our Student and Teacher classes.
     * They both exist by their own, and are aggregated in out Class class.
     *   A Class has students and a teacher, but the otherwise is false.
     */
    public class Class
    {
        private String name;
        private Teacher teacher;
        private List<Student> students;

        public Class(String name, Teacher teacher)
        {
            this.name = name;
            this.teacher = teacher;
            this.students = new List<Student>();
        }

        public void AddStudent(Student student)
        {
            this.students.Add(student);
        }

        public String GetName()
        {
            return this.name;
        }

        public String GetTeacher()
        {
            return this.teacher.GetName();
        }

        public String GetStudents()
        {
            return String.Join(", ", this.students.ConvertAll(s => s.GetName()));
        }
    }
}
