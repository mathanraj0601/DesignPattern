namespace DesignPattern.code.Iterator_Pattern.Components
{
    public interface IAggregator
    {
        public IIterator<Music> CreateIterator();
        public void AddMusic(Music music);
    }
}
