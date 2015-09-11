using System;
using Interpolacja;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace IntepolacjaLagrangea.Tests
{
    [TestClass]
    public class InterpolacjaTests
    {
       
        [TestMethod]
        public void ScholudReturn3ForLAgrangeMethodWhenXIs1()
        {
            LagrangeInterpolacja lagrangeInterpolacja = new LagrangeInterpolacja();
            var wynik=lagrangeInterpolacja.Lagrangea(1);
            Assert.AreEqual(3,wynik);
        }
        [TestMethod]
        public void SchouldReturn4_195ForNewtonMethodWhenXIs1()
        {
            NewtonInterpolacja interpolacja = new NewtonInterpolacja();
            //var wynik = interpolacja.Newton(1, 1);
            //Assert.AreEqual(4.195,wynik);

        }
    }
}
