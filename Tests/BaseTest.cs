using System;
using ModelX;
using NUnit.Framework;

namespace Tests
{
    public abstract class BaseTest
    {
        public void Test<T>(decimal x, Enum typex, decimal y, Enum typey, decimal delta) where T: IMeasure
        {
            T expected = (T)Activator.CreateInstance(typeof(T), x, typex);
            T actual = (T)Activator.CreateInstance(typeof(T), y, typey);
            Assert.That(expected.Result(typex), Is.EqualTo(actual.Result(typex)));
        }

    }
}
