namespace DesignPattern.code.Iterator_Pattern.Components
{
    public interface IIterator<T>
    {
        public T Next();
        public bool hasNext();
    }

}
