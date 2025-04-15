using DesignPattern.code.Iterator_Pattern.Components;

namespace DesignPattern.code.Iterator_Pattern
{
    public class PlaylistAggregator : IAggregator
    {
        List<Music> _musics;
        public PlaylistAggregator()
        {
            _musics = new List<Music>();
        }
        public void AddMusic(Music music)
        {
            _musics.Add(music);
        }
        public IIterator<Music> CreateIterator()
        {
            return new PlayAllIterator(_musics);
        }
    }
}
