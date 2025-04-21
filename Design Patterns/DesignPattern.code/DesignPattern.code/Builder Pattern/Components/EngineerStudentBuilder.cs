namespace DesignPattern.code.Builder_Pattern.Components
{
    public class EngineerStudentBuilder : StudentBuilder
    {
        public override StudentBuilder setSubjects()
        {
            this.Subjects = new List<string>();
            this.Subjects.Add("DSP");
            this.Subjects.Add("Computer Science");
            return this;
        }
    }
}
