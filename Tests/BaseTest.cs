using ModelX;
using NUnit.Framework.Legacy;

namespace Tests
{
    public abstract class BaseTest
    {
        public void Test<T>(double x, Enum typex, double y, Enum typey, double delta) where T: IMeasure
        {
            T expected = (T)Activator.CreateInstance(typeof(T), x, typex);
            T actual = (T)Activator.CreateInstance(typeof(T), y, typey);
#pragma warning disable NUnit2005 // Consider using Assert.That(actual, Is.EqualTo(expected)) instead of ClassicAssert.AreEqual(expected, actual)
            ClassicAssert.AreEqual(expected.Result(typey), y, delta);
            ClassicAssert.AreEqual(actual.Result(typex), x, delta);
#pragma warning restore NUnit2005 // Consider using Assert.That(actual, Is.EqualTo(expected)) instead of ClassicAssert.AreEqual(expected, actual)
        }

    }
}
