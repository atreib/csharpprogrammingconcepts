using System;
namespace Association
{
    public class Person
    {
        private string name;
        private Person marriedTo = null;

        public Person(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return this.name;
        }

        public void Marry (Person person)
        {
            this.marriedTo = person;
        }

        public string IsMarriedTo()
        {
            if (this.marriedTo == null) return "";
            return this.marriedTo.GetName();
        }
    }
}
