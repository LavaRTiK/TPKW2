namespace TPKW2
{
    public class Student
    {
        private static int idCounter = 0;
        
        public int Id { get;}

        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Student()
        {
            Id = ++idCounter;
        }
        public Student(string firstName, string lastName)
        {
            Id = ++idCounter;
            FirstName = firstName;
            LastName = lastName;
        }

        public int GetId()
        {
            return Id;
        }
    }
}