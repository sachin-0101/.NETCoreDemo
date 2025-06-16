using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomCollection
{
    // Custom collection class using ArrayList
    public class PersonCollection
    {
        private ArrayList persons = new ArrayList();

        public void Add(Person person)
        {
            if (person == null)
                throw new ArgumentNullException("person");

            persons.Add(person);
        }

        public void Remove(Person person)
        {
            persons.Remove(person);
        }

        public Person this[int index]
        {
            get { return (Person)persons[index]; }
        }

        public int Count
        {
            get { return persons.Count; }
        }

        public void DisplayAll()
        {
            foreach (Person person in persons)
            {
                Console.WriteLine(person);
            }
        }
    }

}
