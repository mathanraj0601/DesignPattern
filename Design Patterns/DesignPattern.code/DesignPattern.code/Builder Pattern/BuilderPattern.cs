using DesignPattern.code.Builder_Pattern.Components;

namespace DesignPattern.code.Builder_Pattern
{
    public class BuilderPattern
    {
        public void Demo()
        {
            Director director = new Director();
            Console.WriteLine(director.createStudent());

            StudentBuilder Mba = new MBAStudentBuilder();
            director.setStudentBuilder(Mba);
            Console.WriteLine(director.createStudent());

            StudentBuilder engineer = new EngineerStudentBuilder();
            director.setStudentBuilder(engineer);
            Console.WriteLine(director.createStudent());
        }
    }
}
