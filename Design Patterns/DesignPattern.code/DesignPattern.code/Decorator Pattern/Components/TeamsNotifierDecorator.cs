using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.code.Decorator_Pattern.Components
{
    public class TeamsNotifierDecorator : BaseNotifierDecorator
    {
        public TeamsNotifierDecorator(INotifier notifier) : base(notifier) { }
        public override string SendNotification()
        {
            return base.SendNotification() + " Via Teams ";
        }
    }

}