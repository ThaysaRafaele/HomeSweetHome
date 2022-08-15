using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using HomeSweetHome;

namespace HomeSweetHomeTests
{
    [TestClass]
    public class UnitTest1
    {
        FamilyConditions familyTest = new FamilyConditions();

        [TestMethod]
        public void TestInsert()
        {
            //    familyTest.Name = "Fulano";
            //    familyTest.Income = 900.50;
            //    familyTest.Dependents = 2;
            //    var result = familyTest.CreateFamily();

            //    Assert.AreEqual(result.Name, familyTest.Name);
        }

        [TestMethod]
        public void TestGetScore()
        {
            familyTest.Income = 900.99;
            familyTest.Dependents = 2;
            var result = familyTest.GetScore(familyTest.Income, familyTest.Dependents);

            Assert.AreEqual(result, 7);
        }
    }
}
