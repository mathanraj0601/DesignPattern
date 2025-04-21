using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.code.Builder_Pattern.Components
{
    public class NullStudentBuilder : StudentBuilder
    {
        public override StudentBuilder setSubjects()
        {
            this.Subjects = new List<string>();
            return this;
        }
    }
}
