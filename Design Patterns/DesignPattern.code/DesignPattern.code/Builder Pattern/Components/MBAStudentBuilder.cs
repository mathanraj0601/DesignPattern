using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.code.Builder_Pattern.Components
{
    public class MBAStudentBuilder : StudentBuilder
    {
        public override StudentBuilder setSubjects()
        {
            this.Subjects = new List<string>();
            this.Subjects.Add("Business");
            this.Subjects.Add("commerce");
            return this;
        }
    }
}
