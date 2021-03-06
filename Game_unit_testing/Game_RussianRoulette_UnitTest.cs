using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Game_form;
namespace Game_unit_testing
{
    [TestClass]
    public class Game_RussianRoulette_UnitTest
    {
        logic_class obj_logic_class = new logic_class();

        [TestMethod]
        public void Fire()
        {
            obj_logic_class.load_position = 1;
            obj_logic_class.spin_position = 1;
            int ExpectedResult = obj_logic_class.shoot();
            Assert.AreEqual(1, ExpectedResult);
        }

        [TestMethod]
        public void NotFire()
        {
            obj_logic_class.load_position = 1;
            obj_logic_class.spin_position = 5;
            int ExpectedResult = obj_logic_class.shoot();
            Assert.AreEqual(0, ExpectedResult);
        }
    }
}
