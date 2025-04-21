namespace DesignPattern.code.Builder_Pattern.Components
{
    public class Student
    {
        public int RollNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string SchoolName { get; set; }
        public List<string> Subjects { get; set; }

        public Student(StudentBuilder studentBuilder)
        {
            RollNumber = studentBuilder.RollNumber;
            FirstName = studentBuilder.FirstName;
            LastName = studentBuilder.LastName;
            MiddleName = studentBuilder.MiddleName;
            FatherName = studentBuilder.FatherName;
            MotherName = studentBuilder.MotherName;
            SchoolName = studentBuilder.SchoolName;
            Subjects = studentBuilder.Subjects;

        }

        public override string ToString()
        {
            return @$"StudentName : {this.FirstName} {this.MiddleName} {this.LastName} , 
                      ParentsName {FatherName} {MotherName}, 
                      RollNubmer {RollNumber}, 
                      subjects : {string.Join(" " , Subjects)}";
        }
    }
}
