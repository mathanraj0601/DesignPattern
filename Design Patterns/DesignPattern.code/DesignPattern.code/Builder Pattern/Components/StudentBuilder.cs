namespace DesignPattern.code.Builder_Pattern.Components
{
    public abstract class StudentBuilder
    {
        public int RollNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string SchoolName { get; set; }
        public List<string> Subjects { get; set; }

        public StudentBuilder SetRollNumber(int rollNumber)
        {
            this.RollNumber = rollNumber;
            return this;
        }

        public StudentBuilder SetFirstName(string firstName)
        {
            this.FirstName = firstName;
            return this;
        }

        public StudentBuilder SetLastName(string lastName)
        {
            this.LastName = lastName;
            return this;
        }

        public StudentBuilder setMiddleName(string middleName)
        {
            this.MiddleName = middleName;
            return this;
        }


        public StudentBuilder SetFatherName(string fatherName)
        {
            this.FatherName = fatherName;
            return this;
        }


        public StudentBuilder SetMotherName(string motherName)
        {
            this.MotherName = motherName;
            return this;
        }


        public StudentBuilder SetSchoolName(string schoolName)
        {
            this.SchoolName = schoolName;
            return this;
        }

        public abstract StudentBuilder setSubjects();

        public Student build()
        {
            return new Student(this);
        }

    }
}
