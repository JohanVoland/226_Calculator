using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Maths
{
    [TestClass]
    public class TestCalculator
    {
        #region private attributes
        private int testop1;
        private int testop2;
        private int testExpectedResult;
        private int testActualResult;
        private Calculator testCalculator = null;
        #endregion private attributes

        [TestInitialize]
        public void Init()
        {
            testCalculator = new Calculator();
            testActualResult = 0;
        }

        [TestMethod]
        public void Test_Add_Success()
        {
            // given
            testop1 = 2;
            testop2 = 4;
            testExpectedResult = 6;

            // when
            testActualResult = testCalculator.add(testop1, testop2);

            // then
            Assert.AreEqual(testExpectedResult, testActualResult);
        }

        [TestMethod]
        public void Test_Sub_Success()
        {
            // given
            testop1 = 2;
            testop2 = 4;
            testExpectedResult = -2;

            // when
            testActualResult = testCalculator.sub(testop1, testop2);

            // then
            Assert.AreEqual(testExpectedResult, testActualResult);
        }

        [TestMethod]
        public void Test_Mul_Success()
        {
            // given
            testop1 = 2;
            testop2 = 4;
            testExpectedResult = 8;

            // when
            testActualResult = testCalculator.mul(testop1, testop2);

            // then
            Assert.AreEqual(testExpectedResult, testActualResult);
        }

        [TestMethod]
        public void Test_Div_Success()
        {
            // given
            testop1 = 4;
            testop2 = 2;
            testExpectedResult = 2;

            // when
            testActualResult = testCalculator.div(testop1, testop2);

            // then
            Assert.AreEqual(testExpectedResult, testActualResult);
        }

        [TestCleanup]
        public void CleanUp()
        {
            testActualResult = 0;
        }
    }
}
