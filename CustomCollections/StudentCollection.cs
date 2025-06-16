using System.Collections;


namespace CustomCollections
{

    public class StudentCollection : IEnumerable<Student>
    {
        private readonly List<Student> students = new List<Student>();
        private readonly HashSet<int> studentIds = new HashSet<int>(); // for duplicate checking

        // Add student if ID is not a duplicate
        public bool Add(Student student)
        {
            if (student == null || studentIds.Contains(student.Id))
            {
                return false; // Duplicate or null
            }

            students.Add(student);
            studentIds.Add(student.Id);
            return true;
        }

        // Remove student by ID
        public bool Remove(int studentId)
        {
            var student = students.Find(s => s.Id == studentId);
            if (student != null)
            {
                students.Remove(student);
                studentIds.Remove(studentId);
                return true;
            }

            return false;
        }

        // Search student by ID
        public Student GetById(int studentId)
        {
            return students.Find(s => s.Id == studentId);
        }

        // Enumerator support
        public IEnumerator<Student> GetEnumerator()
        {
            return students.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

}
