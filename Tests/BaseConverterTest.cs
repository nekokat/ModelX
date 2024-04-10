using System;
using Converter;

namespace Tests
{
    public abstract class BaseConverterTest
    {
        public void Test<T>(decimal x, Enum typex, decimal y, Enum typey, decimal delta) where T: IMeasure
        {
            T expected = (T)Activator.CreateInstance(typeof(T), x, typex);
            T actual = (T)Activator.CreateInstance(typeof(T), y, typey);
            Assert.That(expected.Result(typey), Is.InRange(actual.Result(typey) - delta, actual.Result(typey) + delta));
        }

    }
}
