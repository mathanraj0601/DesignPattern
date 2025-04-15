using DesignPattern.code.Facade_Pattern.Components;

namespace DesignPattern.code.Facade_Pattern
{
    public class FacadePattern
    {
        public void Demo()
        {
            HomeTheatreFacade homeTheatreFacade = new HomeTheatreFacade();
            homeTheatreFacade.WatchMovie("GIFTED");
        }
    }
}
