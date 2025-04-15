namespace DesignPattern.code.Iterator_Pattern.Components
{
    public class PlayAllIterator : IIterator<Music>
    {
        List<Music> _musics;
        int _pointer;
        public PlayAllIterator(List<Music>  musics)
        {
            _musics = musics;
        }

        public bool hasNext()
        {
            return _pointer < _musics.Count;
        }

        public Music Next()
        {
            return _pointer < _musics.Count ? _musics[_pointer++] : new Music(0,"");
        }
    }
}
