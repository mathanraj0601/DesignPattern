using DesignPattern.code.Iterator_Pattern.Components;

namespace DesignPattern.code.Iterator_Pattern
{
    public class IteratorPattern
    {
        public void Demo()
        {
            IAggregator aggregator = new PlaylistAggregator();

            IIterator<Music> iterator = aggregator.CreateIterator();
            Console.Write(iterator.Next());

            aggregator.AddMusic(new Music(1, "one"));
            aggregator.AddMusic(new Music(2, "two"));
            aggregator.AddMusic(new Music(3, "three"));
            aggregator.AddMusic(new Music(4, "four"));
            aggregator.AddMusic(new Music(5, "five"));
            aggregator.AddMusic(new Music(6, "six"));

            while (iterator.hasNext())
            {
                Console.Write(iterator.Next());
            }
        }
    }
}
