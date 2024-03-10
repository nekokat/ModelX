using System;
using ModelX;
using NUnit.Framework.Legacy;

namespace Tests
{
    public abstract class BaseTest
    {
        public void Test<T>(decimal x, Enum typex, decimal y, Enum typey, decimal delta) where T: IMeasure
        {
            T expected = (T)Activator.CreateInstance(typeof(T), x, typex);
            T actual = (T)Activator.CreateInstance(typeof(T), y, typey);
            Assert.That(Math.Abs(expected.Result(typey) - y), delta);
            Assert.That(Math.Abs(actual.Result(typex)- x), delta);
        }

    }
}
