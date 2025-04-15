namespace DesignPattern.code.Facade_Pattern.Components
{
    public class HomeTheatreFacade
    {
        TV tV = new TV();
        Speaker speaker = new Speaker();
        DVDPlayer dvdPLayer = new DVDPlayer();

        public void WatchMovie(string movie)
        {
            tV.On();
            speaker.On();
            dvdPLayer.Play(movie);
        }
    }
}
