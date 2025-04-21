using DesignPattern.code.Builder_Pattern.Components;

namespace DesignPattern.code.Builder_Pattern
{
    public class Director
    {
        private StudentBuilder _studentBuilder = new NullStudentBuilder();

        public Director(){ }

        public void setStudentBuilder(StudentBuilder studentBuilder)
        {
            _studentBuilder = studentBuilder;
        }
        public Student createStudent()
        {
            if (_studentBuilder is MBAStudentBuilder)
                return CreateEngineerStudent();
            else if (_studentBuilder is EngineerStudentBuilder)
                return CreateEngineerStudent();
            else
                return CreateNullStudent();
        }


        private Student CreateMBAStudent()
        {
            return _studentBuilder.SetFirstName("James")
                           .setMiddleName("")
                           .SetLastName("smith")
                           .SetFatherName("Jack")
                           .SetMotherName("Will")
                           .SetRollNumber(1)
                           .setSubjects()
                           .build();
        }

        private Student CreateEngineerStudent()
        {
            return _studentBuilder.SetFirstName("James")
                           .setMiddleName("")
                           .SetLastName("smith")
                           .SetFatherName("Jack")
                           .SetMotherName("Will")
                           .SetRollNumber(2)
                           .setSubjects()
                           .build();
        }

        private Student CreateNullStudent()
        {
            return _studentBuilder.SetFirstName("")
                           .setMiddleName("")
                           .SetLastName("")
                           .SetFatherName("")
                           .SetMotherName("")
                           .SetRollNumber(0)
                           .setSubjects()
                           .build();
        }
    }
}
