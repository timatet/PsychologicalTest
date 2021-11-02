namespace psychologicaltestlib
{
    public class Pair<T1, T2>
    {
        public T1 _Key;
        public T2 _Value;

        /// <summary>
        /// Create and return a copy of this object.
        /// </summary>
        /// <returns></returns>
        public Pair<T1, T2> Copy()
        {
            Pair<T1, T2> pair = new Pair<T1, T2>(_Key, _Value);
            return pair;
        }

        public Pair(T1 Key, T2 Value)
        {
            _Key = Key;
            _Value = Value;
        }

    }
}
