using DesignPattern.code.Momento_Pattern.Components;

namespace DesignPattern.code.Momento_Pattern
{
    public class MomentoPattern
    {
       public void Demo()
       {
            CareTaker careTaker = new();
            Originator originator = new Originator();

            originator.state.Value = 2;
            careTaker.AddMomento(originator.createMomento());
            Console.WriteLine(originator.state);

            originator.state.Value = 3;
            careTaker.AddMomento(originator.createMomento());
            Console.WriteLine(originator.state);

            originator.RestoreState(careTaker.UndoMomento()); // 3
            Console.WriteLine(originator.state);

            originator.RestoreState(careTaker.UndoMomento()); // 2
            Console.WriteLine(originator.state);

            originator.RestoreState(careTaker.UndoMomento()); //0 as there is not state default
            Console.WriteLine(originator.state);
        }
    }
}
