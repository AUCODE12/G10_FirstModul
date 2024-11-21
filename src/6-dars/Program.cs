namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var students = new List<Student>();

            var firstStudent = new Student()
            {
                FirstName = "Ahmadjon",
                LastName = "Qudratov",
                Age = 17,
                BirthdayYear = "2007",
                Gender = "Male",
                StudyGroup = "G10"
            };

            var secondStudent = new Student()
            {
                FirstName = "Sherzod",
                LastName = "Karimov",
                Age = 18,
                BirthdayYear = "2006",
                Gender = "Male",
                StudyGroup = "G11"
            };

            var thirdStudent = new Student()
            {
                FirstName = "Malika",
                LastName = "Nazarova",
                Age = 16,
                BirthdayYear = "2008",
                Gender = "Female",
                StudyGroup = "G9"
            };

            var fourthStudent = new Student()
            {
                FirstName = "Javohir",
                LastName = "Shokirov",
                Age = 19,
                BirthdayYear = "2005",
                Gender = "Male",
                StudyGroup = "G12"
            };

            var fifthStudent = new Student()
            {
                FirstName = "Nodira",
                LastName = "Tursunova",
                Age = 17,
                BirthdayYear = "2007",
                Gender = "Female",
                StudyGroup = "G10"
            };

            var sixthStudent = new Student();
            sixthStudent.FirstName = "Dilshod";
            sixthStudent.LastName = "Karimov";
            sixthStudent.Age = 33;
            sixthStudent.BirthdayYear = "1991";
            sixthStudent.Gender = "Male";
            sixthStudent.StudyGroup = "F134";

            var seventhStudent = new Student();
            seventhStudent.FirstName = "Zilola";
            seventhStudent.LastName = "Tursunova";
            seventhStudent.Age = 35;
            seventhStudent.BirthdayYear = "1989";
            seventhStudent.Gender = "Female";
            seventhStudent.StudyGroup = "F132";

            students.Add(firstStudent);
            students.Add(secondStudent);
            students.Add(thirdStudent);
            students.Add(fourthStudent);
            students.Add(fifthStudent);
            students.Add(sixthStudent);
            students.Add(seventhStudent);

            foreach (var student in students)
            {
                student.DisplayInfo();
            }
        }
    }
}
