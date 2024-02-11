using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelX;
using NUnit.Framework.Legacy;

namespace Tests
{
    public abstract class BaseTest
    {
        public void Test<T>(double x, Enum typex, double y, Enum typey, double delta) where T: IMeasure
        {
            var expected = (T)Activator.CreateInstance(typeof(T), x, typex);
            var actual = (T)Activator.CreateInstance(typeof(T), y, typey);
            ClassicAssert.AreEqual(expected.Result(typey), y, delta);
            ClassicAssert.AreEqual(actual.Result(typex), x, delta);
        }

    }
}
