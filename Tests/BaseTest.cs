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
#pragma warning disable NUnit2005 // Consider using Assert.That(actual, Is.EqualTo(expected)) instead of ClassicAssert.AreEqual(expected, actual)
            ClassicAssert.AreEqual((double)expected.Result(typey), (double)y, (double)delta);
            ClassicAssert.AreEqual((double)actual.Result(typex), (double)x, (double)delta);
#pragma warning restore NUnit2005 // Consider using Assert.That(actual, Is.EqualTo(expected)) instead of ClassicAssert.AreEqual(expected, actual)
        }

    }
}
