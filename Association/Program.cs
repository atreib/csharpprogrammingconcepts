using System;

namespace Association
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher teacherAndre = new Teacher("André");
            Student studentJoe = new Student("Joe");
            Student studentRalph = new Student("Ralph");

            Class devClass = new Class("Software Development", teacherAndre);
            devClass.AddStudent(studentJoe);
            devClass.AddStudent(studentRalph);

            Console.WriteLine(String.Format(@"
                Our {0} class is given by {1}.
                Right now, {2} are in the class.
            ", devClass.GetName(), devClass.GetTeacher(), devClass.GetStudents()));

            Console.WriteLine(String.Format(@"
                Anyhow, our teacher object exists by itself, having its own behavior,
                like, ie, we can get its name: {0}
            ", teacherAndre.GetName()));

            Console.WriteLine(String.Format(@"
                The same works for our students {0} and {1}
            ", studentRalph.GetName(), studentJoe.GetName()));

            Console.WriteLine("We can remove an student, create a new one and our class will still up and running!");
            Console.WriteLine("Our class has students and a teacher, but our Student/Teacher can't have an own Class.");
        }
    }
}
