namespace OOP
{
    public class NullableStruct<T> where T : struct
    {
        private object _value;
        public bool HasValue => _value != null;

        public NullableStruct()
        {
            
        }

        public NullableStruct(T value)
        {
            _value = value;
        }

        public T GetValueOrDefault()
        {
            if (HasValue)
                return (T) _value;

            return default(T);
        }
    }
}
